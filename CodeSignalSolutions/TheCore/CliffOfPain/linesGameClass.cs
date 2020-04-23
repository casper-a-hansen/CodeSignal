using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeSignalSolutions.TheCore.CliffOfPain 
{
    class linesGameClass
    {
        char[][] field;
        int height;
        int width;
        char[] newBalls;
        int[][] newBallsCoordinates;
        int newBallIndex = 0;
        int linesGame(char[][] field, int[][] clicks, char[] newBalls, int[][] newBallsCoordinates)
        {
            this.field = field;
            height = field.Length;
            width = field[0].Length;
            this.newBalls = newBalls;
            this.newBallsCoordinates = newBallsCoordinates;

            Show();

            int result = 0;
            int[] clickedBall = null;
            foreach (var click in clicks)
            {
                Console.WriteLine();
                var c = GetCell(click);
                Console.WriteLine($"Clicked {click[1]}, {click[0]} and found {c}");
                if (c == '.')
                {
                    if (clickedBall != null)
                    {
                        var ball = GetCell(clickedBall);
                        if (HasClearPath(clickedBall, click))
                        {
                            SetCell(clickedBall, '.');
                            SetCell(click, ball);
                            Console.WriteLine($"Moving {ball} to {click[1]}, {click[0]}");
                            int points = CheckAll();
                            result += points;
                            if (points == 0)
                            {
                                result += ThreeBalls();
                            }
                            clickedBall = null;
                        }
                        else
                        {
                            Console.WriteLine("But no clear path!");
                        }
                    }
                }
                else
                {
                    clickedBall = click;
                }
                Show();
            }
            return result;
        }

        void Show()
        {
            foreach (var row in field)
            {
                Console.WriteLine(string.Join(' ', row));
            }
        }
        char GetCell(int[] pos) => field[pos[0]][pos[1]];
        void SetCell(int[] pos, char color) => field[pos[0]][pos[1]] = color;
        bool HasClearPath(int[] from, int[] to)
        {
            // Position is stored as one integer y * width + x -> x = integer % width and y = integer / width.
            var toKey = to[0] * width + to[1];
            HashSet<int> considered = new HashSet<int>();
            considered.Add(from[0] * width + from[1]);
            List<int[]> connections = new List<int[]>() { from };
            while (true)
            {
                List<int[]> newConnections = new List<int[]>(connections.Count * 4);
                foreach (var pos in connections)
                {
                    foreach (var test in new (int dx, int dy)[] { (-1, 0), (1, 0), (0, -1), (0, 1) })
                    {
                        var testPos = new int[] { pos[0] + test.dy, pos[1] + test.dx };
                        if (testPos[0] < 0 || testPos[0] >= width) continue;
                        if (testPos[1] < 0 || testPos[1] >= height) continue;
                        var testKey = testPos[0] * width + testPos[1];
                        if (testKey == toKey) return true;
                        if (field[testPos[0]][testPos[1]] != '.') continue;
                        if (!considered.Add(testKey)) continue;
                        newConnections.Add(testPos);
                    }
                }
                if (newConnections.Count == 0) break;
                connections = newConnections; // New connections to test.
            }
            return false;
        }
        int CheckRows(int[] pos)
        {
            (int dx, int dy)[] rows = new (int dx, int dy)[] { (1, 0), (0, 1), (1, 1), (-1, 1) };
            int result = 0;
            char ball = GetCell(pos);
            IEnumerable<int[]> Follow(int dx, int dy)
            {
                int y = pos[0], x = pos[1];
                while (true)
                {
                    x += dx;
                    y += dy;
                    if (x < 0 || x >= width) break;
                    if (y < 0 || y >= height) break;
                    if (field[y][x] != ball) break;
                    yield return new int[] { y, x };
                }
            }
            foreach (var row in rows)
            {
                int count = Follow(row.dx, row.dy).Count() + Follow(-row.dx, -row.dy).Count() + 1;
                if (count >= 5)
                {
                    SetCell(pos, '.');
                    foreach (var cell in Follow(row.dx, row.dy).Concat(Follow(-row.dx, -row.dy)))
                    {
                        SetCell(cell, '.');
                    }
                    result += count + 1;
                }
            }
            if (result > 0) result--;
            return result;
        }
        int ThreeBalls()
        {
            for (int i = 0; i < 3; i++)
            {
                if (newBallIndex >= newBalls.Length) { Console.WriteLine("Out of new balls"); break; }
                SetCell(newBallsCoordinates[newBallIndex], newBalls[newBallIndex]);
                //            result += CheckRows(newBallsCoordinates[newBallIndex]);
                newBallIndex++;
            }
            return CheckAll();
        }
        int CheckAll()
        {
            bool IsValid((int x, int y) pos) => pos.x >= 0 && pos.x < width && pos.y >= 0 && pos.y < height;
            List<List<int[]>> rows = new List<List<int[]>>();
            foreach (var rule in new (int dx, int dy, int sx, int sy, int ix, int iy)[] {
                    (1, 0, 0, 1, 0, 0), (0, 1, 1, 0, 0, 0),
                    (1, 1, 1, 0, 0, 0), (1, 1, 0, 1, 0, 1),
                    (1, -1, 0, 1, 0, 0), (1, -1, 1, 0, 1 ,8) })
            {
                for (var s = (x: rule.ix, y: rule.iy); IsValid(s); s = (x: s.x + rule.sx, y: s.y + rule.sy))
                {
                    List<int[]> row = null;
                    var color = '.';
                    for (var d = s; IsValid(d); d = (x: d.x + rule.dx, y: d.y + rule.dy))
                    {
                        var pos = new int[] { d.y, d.x };
                        var ball = GetCell(pos);
                        if (color != '.')
                        {
                            if (ball == color)
                            {
                                row.Add(pos);
                            }
                            else
                            {
                                if (row.Count >= 5) rows.Add(row);
                                row = null;
                                color = '.';
                            }
                        }
                        if (color == '.')
                        {
                            if (ball != '.') row = new List<int[]>() { pos };
                            color = ball;
                        }
                    }
                    if (row != null && row.Count >= 5) rows.Add(row);
                }
            }
            Console.WriteLine($"Found {rows.Count} rows");
            if (rows.Count == 0) return 0;
            foreach (var pos in rows.SelectMany(r => r))
            {
                SetCell(pos, '.');
            }
            return rows.Count + rows.Sum(r => r.Count) - 1;
        }
    }
}
