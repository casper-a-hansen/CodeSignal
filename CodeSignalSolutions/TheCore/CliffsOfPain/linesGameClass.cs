/*
    Status:   Solved
    Imported: 2020-04-26 13:37
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/cliffs-of-pain/DpcTH5AjYPD3g9ua6

    Description:
        Let's remember the '90s and play an old-school Lines game with the following
        rules.
        
        The game starts with a 9 × 9 field with several colored balls placed on
        its cells (there are 7 possible colors but not all colors have to be present
        initially). The player can move one ball per turn, and they may only move a ball
        if there is a clear path between the current position of the chosen ball and the
        desired destination. Clear paths are formed by neighboring empty cells. Two
        cells are neighboring if they have a common side. The goal is to remove balls by
        forming lines (horizontal, vertical or diagonal) of at least five balls of the
        same color. If the player manages to form one or more such lines, the move is
        called successful, and the balls in those lines disappear. Otherwise, the move
        is called unsuccessful, and three more balls appear on the field.
        
        You are given
        the game logs, and your task is to calculate the player's final score. Here's
        the information you have:
        
        The field state at the initial moment;
        The clicks the
        user has made. Note that a click does not necessarily result in a move:
        If the
        user clicks a ball and then another, the first click is ignored;
        If two
        consecutive clicks result in an incorrect move, they are ignored;
        After each
        unsuccessful move three more balls appear:
        newBalls contains the balls' colors;
        newBallsCoordinates contains their coordinates;
        Note that after the balls
        appear, new lines may form;
        Whenever new lines appear, they are removed and the
        player receives A + B - 1 points, where:
        A is the number of lines of at least
        five balls;
        B is the total number of balls in those lines;
        Possible ball colors
        are red, blue, orange, violet, green, yellow and cyan, which are represented in
        logs by
        "R", "B", "O", "V", "G", "Y" and "C" respectively.
        
        Example
        
        For
        
        field
        = [['.', 'G', '.', '.', '.', '.', '.', '.', '.'],
                 ['.', '.', '.', '.',
        '.', '.', '.', 'V', '.'],
                 ['.', 'O', '.', '.', 'O', '.', '.', '.',
        '.'],
                 ['.', '.', '.', '.', 'O', '.', '.', '.', '.'],
                 ['.',
        '.', '.', '.', '.', '.', '.', '.', 'O'],
                 ['.', '.', '.', '.', 'O', '.',
        '.', '.', '.'],
                 ['.', '.', '.', '.', '.', '.', '.', '.', '.'],
        ['R', '.', '.', '.', '.', '.', '.', 'B', 'R'],
                 ['.', '.', 'C', '.',
        '.', '.', '.', 'Y', 'O']]
        
        
        clicks = [[4, 8], [2, 1], [4, 4], [6, 4], [4, 8],
        [1, 2], [1, 4], [4, 8], [6, 4]],
        newBalls = ['R', 'V', 'C', 'G', 'Y', 'O'], and
        newBallsCoordinates = [[1, 2], [8, 5], [8, 6], [1, 1], [1, 8], [7, 4]], the
        output should be
        linesGame(field, clicks, newBalls, newBallsCoordinates) = 6.
        The only correct moves were:
        
        Orange ball moved from [2, 1] to [4, 4];
        Red ball
        moved from [1, 2] to [1, 4];
        Orange ball moved from [4, 8] to [6, 4]
        
        After the
        third move a vertical line with 6 orange balls appears, so it is removed and the
        player receives 1 + 6 - 1 = 6 points.
        
        For
        
        field = [['.', '.', '.', '.', '.',
        '.', '.', '.', '.'],
                 ['.', '.', '.', '.', '.', '.', '.', '.', '.'],
        ['.', '.', 'O', '.', 'O', '.', 'O', '.', '.'],
                 ['.', '.', '.', 'O',
        'O', 'O', '.', '.', '.'],
                 ['.', '.', '.', '.', '.', '.', '.', '.',
        'O'],
                 ['.', '.', '.', 'O', 'O', 'O', '.', '.', '.'],
                 ['.',
        '.', 'O', '.', 'O', '.', 'O', '.', '.'],
                 ['.', '.', '.', '.', '.', '.',
        '.', '.', '.'],
                 ['.', '.', '.', '.', '.', '.', '.', '.', '.']]
        
        
        clicks
        = [[4, 8], [4, 4]],
        newBalls = [], and
        newBallsCoordinates = [], the output
        should be
        linesGame(field, clicks, newBalls, newBallsCoordinates) = 17.
        
        After
        the move there will be three lines with exactly 5 balls of the same color, so
        the answer is 3 + (5 + 5 + 5) - 1 = 17.
        
        Input/Output
        
        [execution time limit] 3
        seconds (cs)
        
        [input] array.array.char field
        
        A rectangular matrix, where each
        element represents either a ball of some color (see above), or an empty cell
        ('.').
        It is guaranteed that initially there are no lines of five or more balls
        of the same color.
        
        Guaranteed constraints:
        field.length = 9,
        field[i].length =
        9.
        
        [input] array.array.integer clicks
        
        Each element of clicks consists of two
        integers and represents some cell from fields that was clicked.
        
        Guaranteed
        constraints:
        2 ≤ clicks.length ≤ 40,
        0 ≤ clicks[i][j] ≤ 8.
        
        [input] array.char
        newBalls
        
        It is guaranteed that there are enough elements in the array to add
        balls after each unsuccessful move.
        
        Guaranteed constraints:
        0 ≤ newBalls.length
        ≤ 60.
        
        [input] array.array.integer newBallsCoordinates
        
        The ith element
        represents the coordinates of the ith appeared ball.
        It is guaranteed that balls
        are added only to the empty cells.
        
        Guaranteed constraints:
        newBallsCoordinates.length = newBalls.length,
        newBallsCoordinates[i].length = 2,
        0 ≤ newBallsCoordinates[i][j] ≤ 8.
        
        [output] integer
        
        The player's final score.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.CliffsOfPain
{
    class linesGameClass
    {
        char[][] field;
                int height;
                int width;
                char[] newBalls;
                int[][] newBallsCoordinates;
                int newBallIndex = 0;
                int linesGame(char[][] field, int[][] clicks, char[] newBalls, int[][] newBallsCoordinates)
                {
                    this.field = field;
                    height = field.Length;
                    width = field[0].Length;
                    this.newBalls = newBalls;
                    this.newBallsCoordinates = newBallsCoordinates;
         
                    Show();
         
                    int result = 0;
                    int[] clickedBall = null;
                    foreach (var click in clicks)
                    {
                        Console.WriteLine();
                        var c = GetCell(click);
                        Console.WriteLine($"Clicked {click[1]}, {click[0]} and found {c}");
                        if (c == '.')
                        {
                            if (clickedBall != null)
                            {
                                var ball = GetCell(clickedBall);
                                if (HasClearPath(clickedBall, click))
                                {
                                    SetCell(clickedBall, '.');
                                    SetCell(click, ball);
                                    Console.WriteLine($"Moving {ball} to {click[1]}, {click[0]}");
                                    int points = CheckAll();
                                    result += points;
                                    if (points == 0)
                                    {
                                        result += ThreeBalls();
                                    }
                                    clickedBall = null;
                                }
                                else
                                {
                                    Console.WriteLine("But no clear path!");
                                }
                            }
                        }
                        else
                        {
                            clickedBall = click;
                        }
                        Show();
                    }
                    return result;
                }
         
                void Show()
                {
                    foreach (var row in field)
                    {
                        Console.WriteLine(string.Join(' ', row));
                    }
                }
                char GetCell(int[] pos) => field[pos[0]][pos[1]];
                void SetCell(int[] pos, char color) => field[pos[0]][pos[1]] = color;
                bool HasClearPath(int[] from, int[] to)
                {
                    // Position is stored as one integer y * width + x -> x = integer % width and y = integer / width.
                    var toKey = to[0] * width + to[1];
                    HashSet<int> considered = new HashSet<int>();
                    considered.Add(from[0] * width + from[1]);
                    List<int[]> connections = new List<int[]>() { from };
                    while (true)
                    {
                        List<int[]> newConnections = new List<int[]>(connections.Count * 4);
                        foreach (var pos in connections)
                        {
                            foreach (var test in new (int dx, int dy)[] { (-1, 0), (1, 0), (0, -1), (0, 1) })
                            {
                                var testPos = new int[] { pos[0] + test.dy, pos[1] + test.dx };
                                if (testPos[0] < 0 || testPos[0] >= width) continue;
                                if (testPos[1] < 0 || testPos[1] >= height) continue;
                                var testKey = testPos[0] * width + testPos[1];
                                if (testKey == toKey) return true;
                                if (field[testPos[0]][testPos[1]] != '.') continue;
                                if (!considered.Add(testKey)) continue;
                                newConnections.Add(testPos);
                            }
                        }
                        if (newConnections.Count == 0) break;
                        connections = newConnections; // New connections to test.
                    }
                    return false;
                }
                int CheckRows(int[] pos)
                {
                    (int dx, int dy)[] rows = new (int dx, int dy)[] { (1, 0), (0, 1), (1, 1), (-1, 1) };
                    int result = 0;
                    char ball = GetCell(pos);
                    IEnumerable<int[]> Follow(int dx, int dy)
                    {
                        int y = pos[0], x = pos[1];
                        while (true)
                        {
                            x += dx;
                            y += dy;
                            if (x < 0 || x >= width) break;
                            if (y < 0 || y >= height) break;
                            if (field[y][x] != ball) break;
                            yield return new int[] { y, x };
                        }
                    }
                    foreach (var row in rows)
                    {
                        int count = Follow(row.dx, row.dy).Count() + Follow(-row.dx, -row.dy).Count() + 1;
                        if (count >= 5)
                        {
                            SetCell(pos, '.');
                            foreach (var cell in Follow(row.dx, row.dy).Concat(Follow(-row.dx, -row.dy)))
                            {
                                SetCell(cell, '.');
                            }
                            result += count + 1;
                        }
                    }
                    if (result > 0) result--;
                    return result;
                }
                int ThreeBalls()
                {
                    for (int i = 0; i < 3; i++)
                    {
                        if (newBallIndex >= newBalls.Length) { Console.WriteLine("Out of new balls"); break; }
                        SetCell(newBallsCoordinates[newBallIndex], newBalls[newBallIndex]);
                        //            result += CheckRows(newBallsCoordinates[newBallIndex]);
                        newBallIndex++;
                    }
                    return CheckAll();
                }
                int CheckAll()
                {
                    bool IsValid((int x, int y) pos) => pos.x >= 0 && pos.x < width && pos.y >= 0 && pos.y < height;
                    List<List<int[]>> rows = new List<List<int[]>>();
                    foreach (var rule in new (int dx, int dy, int sx, int sy, int ix, int iy)[] {
                            (1, 0, 0, 1, 0, 0), (0, 1, 1, 0, 0, 0),
                            (1, 1, 1, 0, 0, 0), (1, 1, 0, 1, 0, 1),
                            (1, -1, 0, 1, 0, 0), (1, -1, 1, 0, 1 ,8) })
                    {
                        for (var s = (x: rule.ix, y: rule.iy); IsValid(s); s = (x: s.x + rule.sx, y: s.y + rule.sy))
                        {
                            List<int[]> row = null;
                            var color = '.';
                            for (var d = s; IsValid(d); d = (x: d.x + rule.dx, y: d.y + rule.dy))
                            {
                                var pos = new int[] { d.y, d.x };
                                var ball = GetCell(pos);
                                if (color != '.')
                                {
                                    if (ball == color)
                                    {
                                        row.Add(pos);
                                    }
                                    else
                                    {
                                        if (row.Count >= 5) rows.Add(row);
                                        row = null;
                                        color = '.';
                                    }
                                }
                                if (color == '.')
                                {
                                    if (ball != '.') row = new List<int[]>() { pos };
                                    color = ball;
                                }
                            }
                            if (row != null && row.Count >= 5) rows.Add(row);
                        }
                    }
                    Console.WriteLine($"Found {rows.Count} rows");
                    if (rows.Count == 0) return 0;
                    foreach (var pos in rows.SelectMany(r => r))
                    {
                        SetCell(pos, '.');
                    }
                    return rows.Count + rows.Sum(r => r.Count) - 1;
                }
    }
}
