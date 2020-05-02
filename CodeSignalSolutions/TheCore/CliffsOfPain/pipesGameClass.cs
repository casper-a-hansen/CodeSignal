/*
    Status:   Solved
    Imported: 2020-05-02 13:14
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/cliffs-of-pain/ipS8j77AWFDEZoQ7H

    Description:
        Carlos always loved playing video games, especially the well-known computer game
        "Pipes". Today he finally decided to write his own version of the legendary game
        from scratch.
        In this game the player has to place the pipes on a rectangular field to make
        water pour from each source to a respective sink. He has already come up with
        the entire program, but one question still bugs him: how can he best check that
        the arrangement of pipes is correct?
        It's your job to help him figure out exactly that.
        Carlos has 7 types of pipes in his game, with numbers corresponding to each
        type:
        1 - vertical pipe
        2 - horizontal pipe
        3-6 - corner pipes
        7 - two pipes crossed in the same cell (note that these pipes are not connected)
        Here they are, pipes 1 to 7, respectively:
        Water pours from each source in each direction that has a pipe connected to it
        (thus it can even pour in all four directions). The puzzle is solved correctly
        only if all water poured from each source eventually reaches a corresponding
        sink.
        Help Carlos check whether the arrangement of pipes is correct. If it is correct,
        return the number of cells with pipes that will be full of water at the end of
        the game. If not, return -X, where X is the number of cells with water before
        the first leakage point is reached, or if the first drop of water reaches an
        incorrect destination (whichever comes first). Assume that water moves from one
        cell to another at the same speed.
        Example
        For
        state = ["a224C22300000",
        "0001643722B00",
        "0b27275100000",
        "00c7256500000",
        "0006A45000000"]
        the output should be pipesGame(state) = 19.
        Here is how the game will end:
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] array.string state
        Array of strings of an equal length representing some state of the game. The
        pipes are represented by the numbers '1' to '7', the sources are given as
        lowercase English letters, and the corresponding sinks are marked by uppercase
        letters. Empty cells are marked with '0'.
        It is guaranteed that each letter from the English alphabet either is not
        present in state, or appears there twice (in uppercase and lowercase).
        Guaranteed constraints:
        1 ≤ state.length ≤ 100,
        1 ≤ state[i].length ≤ 100,
        state[i][j] ∈ {0-7, a-z, A-Z}.
        [output] integer
        If the pipe arrangement is correct, return the number of cells with pipes that
        will be filled with water at the end of the game. If not, return -X, where X is
        the number of cells with water before the first leakage point is reached, or if
        the first drop of water reaches an incorrect destination.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.CliffsOfPain
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
                    while(true)
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
                    if (leaked) {
                        foreach(var status in statuses.Where(s => s.pipeEnd <= PipeEnd.Bottom))
                            status.wired.RemoveAt(status.wired.Count - 1);
                    }
                    var count = statuses.SelectMany(s => s.wired).Distinct().Count();
                    return leaked ? -count : count;
                }
    }
}
