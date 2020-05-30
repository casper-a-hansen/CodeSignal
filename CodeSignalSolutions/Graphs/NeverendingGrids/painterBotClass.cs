/*
    Status:   Solved
    Imported: 2020-05-29 21:22
    By:       Casper
    Url:      https://app.codesignal.com/arcade/graphs-arcade/neverending-grids/DAgKs7P6tw5CrYnkG

    Description:
        Little Ratiorg was tired of being bullied by other bots and mighty CodeFighters,
        so he joined the Ninja Bots Training camp. Any bot that manages to solve all the
        challenges becomes an ultimate master of algorithms, and that is exactly what
        Ratiorg wants.
        Ratiorg aced the very first challenge, and is ready to begin the second. The
        little bot is given a canvas, each pixel of which has some color. Ratiorg should
        apply several flood fill operations to the canvas, and show the resulting image
        to the judges. Each flood fill operation is given as an array of three elements
        [x, y, color], where (x, y) is the coordinates of the pixel to which the
        operation is applied, and color is the color with which the pixel and its area
        should be painted. The area that should be painted along with the initial pixel
        is defined as follows:
        Initially, only the pixel to which the operation was applied should be painted.
        Consider all pixels that are adjacent to the initial one (i.e. directly above,
        below, to the left or to the right of it). If the difference between the color
        of this pixel and the color of the initial one is not greater than d, this pixel
        should also be painted.
        For each pixel painted on this step consider all its neighbors in the same
        manner.
        Your task is to help the judges check Ratiorg's performance. Given canvas,
        operations and the value of d, return the state of the image after all
        operations have been applied.
        Example
        For
        canvas = [[0, 1, 5, 2, 4, 2, 6],
        [5, 2, 4, 6, 2, 0, 0],
        [3, 3, 3, 7, 8, 3, 2],
        [2, 1, 1, 0, 0, 0, 0]]
        operations = [[0, 0, 10], [1, 3, 3]], and d = 3,
        the output should be
        painterBot(canvas, operations, d) = [[10, 10,  3,  2,  4, 10, 6 ],
        [ 5, 10,  3,  3, 10, 10, 10],
        [10, 10, 10,  3,  3, 10, 10],
        [10, 10, 10, 10, 10, 10, 10]]
        Here's how the canvas should be painted:
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] array.array.integer canvas
        A rectangular matrix representing the canvas.
        Guaranteed constraints:
        1 ≤ canvas.length ≤ 100,
        1 ≤ canvas[0].length ≤ 100,
        0 ≤ canvas[i][j] ≤ 255.
        [input] array.array.integer operations
        Operations to be performed. Each operation is given in the format [x, y, color],
        where (x, y) is the coordinates of the initial pixes (0-based indices of row and
        column, respectively) and color is the fill color.
        Guaranteed constraints:
        0 ≤ operations.length ≤ 100,
        operations[i].length = 3,
        0 ≤ operations[i][0] < canvas.length,
        0 ≤ operations[i][1] < canvas[0].length,
        0 ≤ operations[i][2] ≤ 255.
        [input] integer d
        The value that defines the flood fill area.
        Guaranteed constraints:
        0 ≤ d ≤ 255.
        [output] array.array.integer
        The final state of the canvas.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Graphs.NeverendingGrids
{
    class painterBotClass
    {
        int[][] painterBot(int[][] canvas, int[][] operations, int d) {
            var height = canvas.Length;
            var width = canvas[0].Length;
            var offsets = new (int x, int y)[] { (1, 0), (-1, 0), (0, 1), (0, -1) };
            foreach(var operation in operations)
            {
                var originalColor = canvas[operation[0]][operation[1]];
                var minColor = originalColor - d;
                var maxColor = originalColor + d;
                var newColor = operation[2];
                var done = canvas.Select(a => new bool[a.Length]).ToArray();
                var stack = new Stack<(int x, int y)>();
                stack.Push((x: operation[1], y: operation[0]));
                while(stack.Count > 0)
                {
                    (int x, int y) = stack.Pop();
                    if (done[y][x]) continue;
                    done[y][x] = true;
                    canvas[y][x] = newColor;
                    foreach(var offset in offsets)
                    {
                        int x1 = x + offset.x;
                        if (x1 < 0 || x1 >= width) continue;
                        int y1 = y + offset.y;
                        if (y1 < 0 || y1 >= height) continue;
                        var oldColor = canvas[y1][x1];
                        if (oldColor < minColor || oldColor > maxColor) continue;
                        stack.Push((x1, y1));
                    }
                }
            }
            return canvas;
        }
    }
}
