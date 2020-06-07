/*
    Status:   Solved
    Imported: 2020-06-01 20:14
    By:       Casper
    Url:      https://app.codesignal.com/arcade/graphs-arcade/neverending-grids/7NJiCELH4yxhc8hpJ

    Description:
        Little Ratiorg was tired of being bullied by other bots and mighty CodeFighters,
        so he joined the Ninja Bots Training camp. Any bot that manages to solve all the
        challenges becomes an ultimate master of algorithms, and that is exactly what
        Ratiorg wants.
        It's been several weeks, and Ratiorg already feels how much stronger he has
        become. However, Ratiorg is about to face his first really exciting challenge:
        the Electric Field. It works like this: the bot stays in the top left corner of
        a rectangular grid. In one move he can walk to one of the nearest cells
        (directly above, below, to the left or to the right of his current position).
        Ratiorg's goal is to get to the bottom right corner in the least possible number
        of moves. However, it's not as simple as it seems: there are electric wires
        running through the grid. If Ratiorg steps on a wire, his microchips will be
        burnt to a crisp, so Ratiorg, prudent bot that he is, wants to do his best to
        avoid them.
        You want to give Ratiorg a hint by telling him the least possible number of
        moves required to get to the destination. Given the grid and the wires, return
        the minimum number of moves required to get to the bottom right corner from the
        top left corner. If it's not possible to get there, return -1 instead.
        Example
        For grid = [4, 8] and
        wires = [[1, 0, 1, 3], [3, 1, 3, 2], [4, 1, 4, 3], [4, 2, 4, 4],
        [1, 3, 3, 3], [2, 1, 7, 1], [2, 2, 7, 2], [5, 3, 8, 3]]
        the output should be
        electricField(grid, wires) = 26.
        Check out the image below for better understanding. The wires are colored red,
        and the path Ratiorg should take is colored green.
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] array.integer grid
        Array of two elements, where the first element is the height and the second
        element is the width of the field.
        Guaranteed constraints:
        grid.length = 2,
        1 ≤ grid[i] ≤ 100.
        [input] array.array.integer wires
        Array of electric wires located on the grid. Each wire is given in the format
        [x1, y1, x2, y2], where (x1, y1) is position of the first endpoint and (x2, y2)
        is position of the second endpoint. x represents the x coordinate on the axis
        that runs along the width of the grid, and y represents the y coordinate on the
        axis that runs along the height of the grid.
        It is guaranteed that for each i either wires[i][0] = wires[i][2] or wires[i][1]
        = wires[i][3], but not simultaneously.
        The wires can intersect and overlap.
        Guaranteed constraints:
        0 ≤ wires.length ≤ 100,
        wires[i].length = 4,
        0 ≤ wires[0], wires[2] ≤ grid[1].length,
        0 ≤ wires[1], wires[3] ≤ grid[0].length.
        [output] integer
        The minimum number of moves required to get from the top left to the bottom
        right corner of the grid without stepping on the wires, or -1 if it's impossible
        to get there.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Graphs.NeverendingGrids
{
    class electricFieldClass
    {
        enum Direction { None = 0, Left = 1, RemoveLeft = 14, Right = 2, RemoveRight = 13,
                         Top = 4, RemoveTop = 11, Bottom = 8, RemoveBottom = 7, All = 15};
        int electricField(int[] grid, int[][] wires)
        {
            // Note: That Direction.Left means that there are no wires to the left meaning you can walk to the left.
            var field = Enumerable.Range(0, grid[0]).Select(_ => Enumerable.Range(0, grid[1]).Select(_ => Direction.All).ToArray()).ToArray();
            // Frame field
            for (var i = 0; i < grid[0]; i++)
            {
                field[i][0] &= Direction.RemoveLeft;
                field[i][grid[1] - 1] &= Direction.RemoveRight;
            }
            for (var i = 0; i < grid[1]; i++)
            {
                field[0][i] &= Direction.RemoveTop;
                field[grid[0] - 1][i] &= Direction.RemoveBottom;
            }
            // Add wires.
            foreach (var wire in wires)
            {
                if (wire[1] == wire[3])
                {
                    (int from, int to) = wire[0] < wire[2] ? (wire[0], wire[2]) : (wire[2], wire[0]);
                    for (var i = from; i < to; i++)
                    {
                        if (wire[1] > 0) field[wire[1] - 1][i] &= Direction.RemoveBottom;
                        if (wire[1] < grid[0]) field[wire[1]][i] &= Direction.RemoveTop;
                    }
                }
                else if (wire[0] == wire[2])
                {
                    (int from, int to) = wire[1] < wire[3] ? (wire[1], wire[3]) : (wire[3], wire[1]);
                    for (var i = from; i < to; i++)
                    {
                        if (wire[0] > 0) field[i][wire[0] - 1] &= Direction.RemoveRight;
                        if (wire[0] < grid[1]) field[i][wire[0]] &= Direction.RemoveLeft;
                    }
                }
            }
            CheckField(field);
            ShowField(field);
            var moves = Enumerable.Range(0, field.Length)
                .Select(_ => Enumerable.Range(0, field[0].Length).Select(_ => -1).ToArray())
                .ToArray();
            var queue = new Queue<(int x, int y, int move)>();
            queue.Enqueue((0, 0, 0));
            while(queue.Count > 0)
            {
                (int x, int y, int move) = queue.Dequeue();
                if (moves[y][x] != -1) continue;
                moves[y][x] = move++;
                if (y == moves.Length && x == moves[0].Length) break;
                var direction = field[y][x];
                if ((direction & Direction.Top) == Direction.Top)
                    queue.Enqueue((x, y - 1, move));
                if ((direction & Direction.Bottom) == Direction.Bottom)
                    queue.Enqueue((x, y + 1, move));
                if ((direction & Direction.Left) == Direction.Left)
                    queue.Enqueue((x - 1, y, move));
                if ((direction & Direction.Right) == Direction.Right)
                    queue.Enqueue((x + 1, y, move));
            }
            return moves[moves.Length - 1][moves[0].Length - 1];
        }
        void CheckField(Direction[][] field)
        {
            for (var y = 0; y < field.Length; y++)
            {
                Direction next = Direction.Left; // You cannot walk to the left
                for (var x = 0; x < field[0].Length; x++)
                {
                    var direction = field[y][x];
                    if ((next == Direction.None) && (direction & Direction.Left) != Direction.Left) throw new Exception();
                    if ((next != Direction.None) && (direction & next) == next) throw new Exception();
                    next = (direction & Direction.Right) == 0 ? Direction.Left : Direction.None;
                }
                if ((field[y][field[0].Length - 1] & Direction.Right) != 0) throw new Exception();
            }
            for (var x = 0; x < field[0].Length; x++)
            {
                Direction next = Direction.Top; // You cannot walk to the Top
                for (var y = 0; y < field.Length; y++)
                {
                    var direction = field[y][x];
                    if ((next == Direction.None) && (direction & Direction.Top) != Direction.Top) throw new Exception();
                    if ((next != Direction.None) && (direction & next) == next) throw new Exception();
                    next = (direction & Direction.Bottom) == 0 ? Direction.Top : Direction.None;
                }
                if ((field[field.Length - 1][x] & Direction.Bottom) != 0) throw new Exception();
            }
        }
        void ShowField(Direction[][] field)
        {
            var text = Enumerable.Range(0, field.Length * 2 + 1).Select(_ => new char[field[0].Length * 2 + 1]).ToArray();
            void Set(int x, int y)
            {
                var d = field[y][x];
                var xt = x * 2 + 1;
                var yt = y * 2 + 1;
                var top = (d & Direction.Top) == 0;
                var bottom = (d & Direction.Bottom) == 0;
                var left = (d & Direction.Left) == 0;
                var right = (d & Direction.Right) == 0;
                text[yt][xt] = '.';
                text[yt - 1][xt] = top ? '-' : ' ';
                text[yt + 1][xt] = bottom ? '-' : ' ';
                text[yt][xt - 1] = left ? '|' : ' ';
                text[yt][xt + 1] = right ? '|' : ' ';
                text[yt - 1][xt - 1] = top && left ? '+' : (left ? '|' : (top ? '-' : ' '));
                text[yt - 1][xt + 1] = top || right ? '+' : (right ? '|' : (top ? '-' : ' '));
                text[yt + 1][xt - 1] = bottom || left ? '+' : (left ? '|' : (bottom ? '-' : ' '));
                text[yt + 1][xt + 1] = bottom || right ? '+' : (right ? '|' : (bottom ? '-' : ' '));
            }
            for (var y = 0; y < field.Length; y++)
                for(var x = 0; x < field[0].Length; x++)
                    Set(x, y);
            foreach (var r in text)
                Console.WriteLine(string.Join("", r));
        }
    }
}
