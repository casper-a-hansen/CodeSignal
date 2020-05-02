/*
    Status:   Solved
    Imported: 2020-05-02 23:17
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/cliffs-of-pain/7g9K4ZqrmE6yad5P7

    Description:
        Your task is to draw a special fractal after n iterations. The fractal consists
        of unit connectors '|' and '_'.
        For n = 1 the fractal looks as follows:
        _|
        Now assume that you have already made N iterations and drawn the f(N) fractal.
        To draw the f(N + 1) fractal do the following:
        Note that every fractal has exactly two edge points which can be connected to
        the edge points of other fractals using the unit connectors.
        At first, take the f(N) fractal and place it in the top left corner. As the next
        step, put f(N) rotated by 0°, 90°, 180° or 270° in the remaining 3 quarters -
        top right, bottom left and bottom right - so that it is possible to connect all
        four of them by adding exactly 3 unit connectors between the adjacent fractal
        edge points.
        Note that there is always exactly one possible combination of rotations which
        allows to connect all 4 f(N) fractals together.
        See examples below for better understanding.
        Example
        For n = 1, the output should be
        fractal(n) = [[' ', '_', ' '],
        [' ', '_', '|']]
        In other words, it should represent      _
        the following picture:                   _|
        For n = 2, the output should be
        fractal(n) = [[' ', '_', ' ', ' ', ' ', '_', ' '],
        [' ', '_', '|', ' ', '|', '_', ' '],
        ['|', ' ', ' ', '_', ' ', ' ', '|'],
        ['|', '_', '|', ' ', '|', '_', '|']]
        Or, to put it differently:  _   _
        _| |_
        |  _  |
        |_| |_|
        For n = 3, the output should be
        fractal(n) = [[" ", "_", " ", " ", " ", "_", "_", "_", " ", " ", " ", "_", "_",
        "_", " "],
        [" ", "_", "|", " ", "|", "_", " ", " ", "|", "_", "|", " ", " ", "_", "|"],
        ["|", " ", " ", "_", " ", " ", "|", " ", " ", "_", " ", " ", "|", "_", " "],
        ["|", "_", "|", " ", "|", "_", "|", " ", "|", " ", "|", "_", "_", "_", "|"],
        [" ", "_", " ", " ", " ", "_", " ", " ", "|", " ", " ", "_", "_", "_", " "],
        ["|", " ", "|", "_", "|", " ", "|", " ", "|", "_", "|", " ", " ", "_", "|"],
        ["|", "_", " ", " ", " ", "_", "|", " ", " ", "_", " ", " ", "|", "_", " "],
        [" ", "_", "|", " ", "|", "_", "_", "_", "|", " ", "|", "_", "_", "_", "|"]]
        The fractal looks as follows:
        _   ___   ___
        _| |_  |_|  _|
        |  _  |  _  |_
        |_| |_| | |___|
        _   _  |  ___
        | |_| | |_|  _|
        |_   _|  _  |_
        _| |___| |___|
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] integer n
        A positive integer.
        Guaranteed constraints:
        1 ≤ n ≤ 6.
        [output] array.array.char
        Each character can be an underscore ('_'), a vertical bar ('|') or a whitespace
        character (' ').
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.CliffsOfPain
{
    class fractalClass
    {
        char[][] fractal(int n) {
            var result = new[] {
                new []{' ', '_', ' '},
                new []{' ', ' ', '|'},
                new []{' ', '_', ' '}};
            for (int number = 1; number < n; number++)
            {
                result = NextIteration(result, number);
                Show(ArrangeResult(result));
            }
            return ArrangeResult(result);
        }
        void Show(char[][] field)
        {
            foreach(var row in field) Console.WriteLine(string.Join("", row));
        }
        char[][] NewField(int size) => Enumerable.Range(0, size)
                .Select(_=> Enumerable.Range(0, size).Select(_=> ' ').ToArray()).ToArray();
        char[][] NextIteration(char[][] old, int number)
        {
            var size = old.Length;
            var newSize = size * 2 + 1;
            var result = NewField(newSize);
            var r90 = Rotate(old);
            var r180 = Rotate(r90);
            var r270 = Rotate(r180);
            if (number % 2 == 0)
            {
                Paste(result, old, 0, 0);
                Paste(result, r180, 0, size + 1);     // Bottom left
                Paste(result, r90, size + 1, size + 1); // Bottom right
                Paste(result, r90, size + 1, 0);    // Top right
                result[0][size] = '_';
                result[newSize - 1][size] = '_';
                result[size][size + 1] = '|';
            }
            else
            {
                Paste(result, old, 0, 0);            // Top left
                Paste(result, r270, 0, size + 1);     // Bottom left
                Paste(result, r270, size + 1, size + 1); // Bottom right
                Paste(result, r180, size + 1, 0);    // Top right
                result[size][0] = '|';
                result[size][newSize - 1] = '|';
                result[size + 1][size] = '_';
            }
            return result;
        }
        char[][] Rotate(char[][] source)
        {
            int size = source.Length;
            var result = NewField(size);;
            for(var y = 0; y < size; y++)
            {
                for(var x = 0; x < size; x++)
                {
                    var value = source[y][x];
                    if (value != ' ') result[size - x - 1][y] = value == '_' ? '|' : '_';
                }
            }
            return result;
        }
        void Paste(char[][] dest, char[][] source, int x, int y)
        {
            for(var i = 0; i < source.Length; i++)
            {
                var row = source[i];
                for(var j = 0; j < row.Length; j++)
                {
                    dest[i + y][j + x] = source[i][j];
                }
            }
        }
        char[][] ArrangeResult(char[][] input)
        {
            List<char[]> output = new List<char[]>() { input[0] };
            // Move all non space one down e.g.:
            // _
            //  |   becomes  _
            // _             _|
            for(var r = 2; r < input.Length; r += 2)
            {
                var row = input[r];
                var prevRow = input[r - 1];
                output.Add(row.Select((v,i) => v == ' ' ? prevRow[i] : v).ToArray());
            }
            // Insert a _ between "_ _" to make "___"
            for(var r = 0; r < output.Count; r++)
            {
                var row = output[r];
                for(var c = 2; c < row.Length; c++)
                {
                    if (row[c] == '_' && row[c - 1] == ' ' && row[c - 2] == '_') row[c - 1] = '_';
                }
            }
            return output.ToArray();
        }
    }
}
