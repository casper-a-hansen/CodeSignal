/*
    Status:   Solved
    Imported: 2020-05-30 09:44
    By:       Casper
    Url:      https://app.codesignal.com/arcade/graphs-arcade/neverending-grids/ASAZNscPBXpRNrvkL

    Description:
        Little Ratiorg was tired of being bullied by other bots and mighty CodeFighters,
        so he joined the Ninja Bots Training camp. Any bot that manages to solve all the
        challenges becomes an ultimate master of algorithms, and that is exactly what
        Ratiorg wants.
        The little bot has already successfully completed several challenges. Now he is
        facing a challenge in which he has to prove that he knows how to ride a horse
        and plan battles. Ratiorg is sitting on his digital horse in the top left corner
        of an n × m board. The horse can only make moves similar to those of a knight
        chess piece. Prior to any action, Ratiorg should define values a and b (0 < a ≤
        b), which will specify the horse's moves: each move the horse will change one of
        its coordinates by a, and the other one by b.
        Ratiorg needs to define such a and b that will let him end up in the bottom
        right corner. How many ways are there to do this?
        Example
        For n = 3 and m = 3, the output should be
        horsebot(n, m) = 3.
        Ratiorg can define three pairs: (1, 1), (1, 2) and (2, 2). Here's how he can
        travel to the bottom right corner in each case:
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] integer n
        The height of the field.
        Guaranteed constraints:
        2 ≤ n ≤ 10.
        [input] integer m
        The width of the field.
        Guaranteed constraints:
        2 ≤ m ≤ 10.
        [output] integer
        The number of pairs (a, b) Ratiorg can define to get to the bottom right corner.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Graphs.NeverendingGrids
{
    class horsebotClass
    {
        int horsebot(int n, int m) {
            var directions = new (int x, int y)[] { (1, 1), (1, -1), (-1, 1), (-1, -1) };
            int max = Math.Max(n, m);
            int result = 0;
            for(var b = 1; b < max; b++)
            {
                for(var a = 1; a <= b; a++)
                {
                    if (NewMethod(n, m, directions.SelectMany(t => new[] { (a: t.x * a, b: t.y * b), (a: t.x * b, b: t.y * a) }).ToArray()))
                        result++;
                }
            }
            return result;
        }
        bool NewMethod(int n, int m, (int b, int a)[] moves)
        {
            var used = Enumerable.Range(0, n).Select(_ => new bool[m]).ToArray();
            var stack = new Stack<(int x, int y)>();
            stack.Push((0, 0));
            while (stack.Count > 0)
            {
                var p = stack.Pop();
                if (used[p.y][p.x]) continue;
                used[p.y][p.x] = true;
                foreach (var move in moves)
                {
                    var x = p.x + move.a;
                    if (x < 0 || x >= m) continue;
                    var y = p.y + move.b;
                    if (y < 0 || y >= n) continue;
                    if (used[y][x]) continue;
                    if (x == m - 1 && y == n - 1) return true;
                    stack.Push((x, y));
                }
            }
            return false;
        }
    }
}
