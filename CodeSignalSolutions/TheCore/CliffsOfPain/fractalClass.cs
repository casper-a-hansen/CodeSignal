/*
    Status:   Solved
    Imported: 2020-04-26 13:37
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/cliffs-of-pain/7g9K4ZqrmE6yad5P7

    Description:
        Your task is to draw a special fractal after n iterations. The fractal consists
        of unit connectors '|' and '_'.
        
        For n = 1 the fractal looks as follows:
        
        _
        _|
        Now assume that you have already made N iterations and drawn the f(N) fractal.
        To draw the f(N + 1) fractal do the following:
        Note that every fractal has
        exactly two edge points which can be connected to the edge points of other
        fractals using the unit connectors.
        At first, take the f(N) fractal and place it
        in the top left corner. As the next step, put f(N) rotated by 0°, 90°, 180° or
        270° in the remaining 3 quarters - top right, bottom left and bottom right - so
        that it is possible to connect all four of them by adding exactly 3 unit
        connectors between the adjacent fractal edge points.
        Note that there is always
        exactly one possible combination of rotations which allows to connect all 4 f(N)
        fractals together.
        
        See examples below for better understanding.
        
        Example
        
        For n
        = 1, the output should be
        fractal(n) = [[' ', '_', ' '],       
                      ['
        ', '_', '|']]
        
        In other words, it should represent      _
        the following picture:
        _| 
        
        For n = 2, the output should be
        fractal(n) = [[' ', '_', ' ', ' ', ' ',
        '_', ' '],      
                      [' ', '_', '|', ' ', '|', '_', ' '],
        ['|', ' ', ' ', '_', ' ', ' ', '|'],
        ['|', '_', '|', ' ', '|', '_', '|']]
        
        Or, to put it differently:  _   _
        _| |_
                                   |  _  |
                                   |_| |_|
        For n = 3, the output should be
        fractal(n) = [[" ", "_", " ", " ", " ", "_",
        "_", "_", " ", " ", " ", "_", "_", "_", " "], 
                      [" ", "_", "|", "
        ", "|", "_", " ", " ", "|", "_", "|", " ", " ", "_", "|"], 
                      ["|",
        " ", " ", "_", " ", " ", "|", " ", " ", "_", " ", " ", "|", "_", " "],
        ["|", "_", "|", " ", "|", "_", "|", " ", "|", " ", "|", "_", "_", "_", "|"],
        [" ", "_", " ", " ", " ", "_", " ", " ", "|", " ", " ", "_", "_", "_", " "],
        ["|", " ", "|", "_", "|", " ", "|", " ", "|", "_", "|", " ", " ", "_", "|"],
        ["|", "_", " ", " ", " ", "_", "|", " ", " ", "_", " ", " ", "|", "_", " "],
        [" ", "_", "|", " ", "|", "_", "_", "_", "|", " ", "|", "_", "_", "_", "|"]]
        The fractal looks as follows:
        
                              _   ___   ___
        _| |_  |_|  _|
                             |  _  |  _  |_ 
                             |_| |_|
        | |___|
                              _   _  |  ___ 
                             | |_| | |_|
        _|
                             |_   _|  _  |_ 
                              _| |___| |___|
        Input/Output
        
        [execution time limit] 3 seconds (cs)
        
        [input] integer n
        
        A
        positive integer.
        
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
        char[][] fractal(int n) {
            var result = new[] {
                new []{' ', '_', ' '}, 
                new []{' ', ' ', '|'}, 
                new []{' ', '_', ' '}};
         
            Show(ArrangeResult(result));
            for (int number = 1; number < n; number++)
            {
                result = NextIteration(result);
                Show(ArrangeResult(result));
            }
            return ArrangeResult(result);
        }
         
        char[][] NextIteration(char[][] old)
        {
            char[][] result = Enumerable.Range(0, old.Length * 2 + 1)
                .Select(i=> Enumerable.Range(0, old[0].Length * 2 + 1).Select(_=> ' ').ToArray())
                .ToArray();
         
            Paste(result, old, 0, 0);
            return result;
        }
        void Paste(char[][] dest, char[][] source, int x, int y)
        {
            for(var i = 0; i < source.Length; i++)
            {
                var row = source[i];
                for(var j = 0; j < row.Length; j++)
                {
                    dest[i + y][j + x] = source[i][j]; 
                }
            }
        }
         
        void Show(char[][] fractal)
        {
            foreach(var row in fractal)
            {
                Console.WriteLine(string.Join("", row));
            }
        }
         
        char[][] ArrangeResult(char[][] input)
        {
            List<char[]> output = input.Select(a => a.ToArray()).ToList();
         
            // Move all | one down e.g.:
            // _             _
            //  |   becomes   
            // _             _|
            for(var r = output.Count - 2; r >= 0; r--)
            {
                var row = output[r];
                var nextRow = output[r + 1];
                for(var c = 0; c < row.Length; c++)
                {
                    if (row[c] == '|') { row[c] = ' '; nextRow[c] = '|'; }
                }
            }
         
            // Remove empty lines.
            // _             _
            //      becomes  _|
            // _|           
            for(var r = output.Count - 1; r >= 0; r--)
            {
                var row = output[r];
                if (row.All(c => c == ' '))
                {
                    output.RemoveAt(r);
                }
            }
         
            // Insert a _ between "_ _" to make "___"
            for(var r = 0; r < output.Count - 1; r++)
            {
                var row = output[r];
                for(var c = 0; c < row.Length - 2; c++)
                {
                    if (row[c] == '_' && row[c + 1] == ' ' && row[c + 2] == '_') row[c + 1] = '_';
                }
            }
         
            return output.ToArray();
        }
    }
}
