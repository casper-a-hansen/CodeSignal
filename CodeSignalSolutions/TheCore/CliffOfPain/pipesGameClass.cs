using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeSignalSolutions.TheCore.CliffOfPain
{
    class pipesGameClass
    {
        enum PipeEnd { Left, Right, Top, Bottom, Leak, Success };
        static PipeEnd[] connection = new PipeEnd[] { PipeEnd.Right, PipeEnd.Left, PipeEnd.Bottom, PipeEnd.Top };
        static (int dx, int dy)[] nextPipe = new (int dx, int dy)[] { (-1, 0), (1, 0), (0, -1), (0, 1) };

        static PipeEnd[][] pipes = new PipeEnd[][] {
            new PipeEnd[] { PipeEnd.Leak, PipeEnd.Leak, PipeEnd.Leak, PipeEnd.Leak },   // No pipe
            new PipeEnd[] { PipeEnd.Leak, PipeEnd.Leak, PipeEnd.Bottom, PipeEnd.Top },  // Vertical pipe
            new PipeEnd[] { PipeEnd.Right, PipeEnd.Left, PipeEnd.Leak, PipeEnd.Leak },  // Horizontal pipe
            new PipeEnd[] { PipeEnd.Leak, PipeEnd.Bottom, PipeEnd.Leak, PipeEnd.Right },  // bottom right pipe
            new PipeEnd[] { PipeEnd.Bottom, PipeEnd.Leak, PipeEnd.Leak, PipeEnd.Left },  // bottom left pipe
            new PipeEnd[] { PipeEnd.Top, PipeEnd.Leak, PipeEnd.Left, PipeEnd.Leak },  // left top pipe
            new PipeEnd[] { PipeEnd.Leak, PipeEnd.Top, PipeEnd.Right, PipeEnd.Leak },  // right top pipe
            new PipeEnd[] { PipeEnd.Right, PipeEnd.Left, PipeEnd.Bottom, PipeEnd.Top },  // cross pipe
        };
        class Status
        {
            public Status(string[] state, PipeEnd pipeEnd, int x, int y, char source)
            {
                this.state = state;
                this.pipeEnd = pipeEnd;
                this.x = x;
                this.y = y;
                this.source = source;
                sink = source.ToString().ToUpper()[0];
                wired = new List<string>();
            }
            public string[] state;
            public List<string> wired;
            public PipeEnd pipeEnd;
            public int x;
            public int y;
            public char source;
            public char sink;

            public override string ToString()
            {
                return $"{source} -> {sink} ({x},{y}) {pipeEnd}";
            }
            public void Move()
            {
                if (pipeEnd == PipeEnd.Success) return;
                var next = nextPipe[(int)pipeEnd];
                y += next.dy;
                if (y < 0 || y >= state.Length) { pipeEnd = PipeEnd.Leak; return; }   // Attached to top/bottom
                x += next.dx;
                if (x < 0 || x >= state[y].Length) { pipeEnd = PipeEnd.Leak; return; }   // Attached to left/right edge.
                var p = state[y][x];
                if (p == sink) { pipeEnd = PipeEnd.Success; return; }
                var startPipe = connection[(int)pipeEnd];
                if ('1' <= p && p <= '7')
                {
                    pipeEnd = pipes[p - '0'][(int)startPipe];
                    if (pipeEnd <= PipeEnd.Bottom) wired.Add($"{x},{y}");
                    return;
                }
                pipeEnd = PipeEnd.Leak; // No pipe attached
                return;
            }
            public bool IsValid()
            {
                Move();
                return pipeEnd != PipeEnd.Leak;
            }
        }
        int pipesGame(string[] state)
        {
            var statuses = state
                .SelectMany((s, y) => s
                    .Select((c, x) => (c, x))
                    .Where(i => 'a' <= i.c && i.c <= 'z')
                    .Select(i => (X: i.x, Y: y, Source: i.c)))
                .SelectMany(i => Enumerable.Range(0, 4).Select(e => new Status(state, (PipeEnd)e, i.X, i.Y, i.Source)))
                .Where(s => s.IsValid()).ToArray();
            if (statuses.Length == 0) return 0;
            bool leaked = false;
            while (true)
            {
                bool finished = true;
                foreach (var status in statuses)
                {
                    if (!status.IsValid()) leaked = true;
                    if (status.pipeEnd != PipeEnd.Success) finished = false;
                }
                Console.WriteLine(string.Join<Status>(" - ", statuses));
                if (leaked) break;
                if (finished) break;
            }
            if (leaked)
            {
                foreach (var status in statuses.Where(s => s.pipeEnd <= PipeEnd.Bottom))
                    status.wired.RemoveAt(status.wired.Count - 1);
            }
            var count = statuses.SelectMany(s => s.wired).Distinct().Count();
            return leaked ? -count : count;
        }
    }
}
