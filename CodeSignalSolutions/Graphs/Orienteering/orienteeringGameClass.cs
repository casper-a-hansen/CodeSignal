/*
    Status:   Solved
    Imported: 2020-06-11 23:33
    By:       Casper
    Url:      https://app.codesignal.com/arcade/graphs-arcade/orienteering/gDRv9hSBGutrsawEt

    Description:
        Not long ago you saw an orienteering competition on TV and immediately wanted to
        try it yourself. You've joined an orienteering club and started preparing for
        the upcoming competitions.
        You've just came home from one particularly exhausting competition and decided
        to relax by playing a board game which all qualified participants (including
        you, of course) got as a reward. In this game your objective is to navigate your
        way on the board from the start located in the upper-left corner to the finish
        located in the bottom-right corner in as little time as possible.
        The game board is a rectangle divided into equal cells. Each cell contains a
        number denoting the time you should wait in this cell before advancing to the
        next one. From each cell you can move only to the neighboring one, i.e. the one
        directly below, above, to the left or to the right of your current position.
        Given the game board find the minimum time required to reach the finish from the
        start.
        Example
        For
        board = [[42, 51, 22, 10,  0 ],
        [2,  50, 7,  6,   15],
        [4,  36, 8,  30,  20],
        [0,  40, 10, 100, 1 ]]
        the output should be
        orienteeringGame(board) = 140.
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] array.array.integer board
        The game board of size n × m. The start is located at board[0][0] and the finish
        is at board[n - 1][m - 1].
        Guaranteed constraints:
        1 ≤ board.length ≤ 250,
        1 ≤ board[i].length ≤ 250,
        0 ≤ board[i][j] ≤ 100.
        [output] integer
        The minimum time required to reach the finish from the start.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Graphs.Orienteering
{
    class orienteeringGameClass
    {
        int orienteeringGame(int[][] board)
        {
            var height = board.Length;
            var width = board[0].Length;
            var weight = board.Select(a => a.Select(_ => int.MaxValue).ToArray()).ToArray();
            weight[0][0] = board[0][0];
            var stack = new SortedSet<(int x, int y, int weight)>(new Comparer());
            stack.Add((0, 0, 0));
            while(stack.Count > 0)
            {
                var p = stack.First();
                stack.Remove(p);
                foreach(var direction in directions)
                {
                    var x = p.x + direction.x;
                    if (x < 0 || x >= width) continue;
                    var y = p.y + direction.y;
                    if (y < 0 || y >= height) continue;
                    if (weight[y][x] > weight[p.y][p.x] + board[y][x])
                    {
                        if (weight[y][x] != int.MaxValue)
                        {
                            stack.Remove((x, y, weight[y][x]));
                        }
                        weight[y][x] = weight[p.y][p.x] + board[y][x];
                        stack.Add((x, y, weight[y][x]));
                    }
                }
            }
            return weight[height - 1][width - 1] - board[height - 1][width - 1];
        }
        static (int x, int y)[] directions = new (int x, int y)[] { (0, 1), (0, -1), (1, 0), (-1, 0) };
        class Comparer : IComparer<(int x, int y, int weight)>
        {
            public int Compare((int x, int y, int weight) a, (int x, int y, int weight) b)
            {
                if (a.weight != b.weight) return a.weight - b.weight;
                if (a.x != b.x) return a.x - b.x;
                return a.y - b.y;
            }
        }
    }
}
