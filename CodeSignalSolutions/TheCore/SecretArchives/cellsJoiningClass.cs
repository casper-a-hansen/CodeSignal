/*
    Status:   Solved
    Imported: 2020-04-26 13:35
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/secret-archives/n6KRaxBdcFv5JjQgM

    Description:
        You are writing a spreadsheet application for an ancient operating system. The
        system runs on a computer so old that it can only display ASCII graphics.
        Currently you are stuck with implementing the cells joining algorithm.
        
        You are
        given a table in ASCII graphics, where the following characters are used for
        borders: +, -, |. The rows can have different heights and the columns can have
        different widths. Each cell has an area greater than 1 (excluding the borders)
        and can contain any ASCII characters excluding +, - and |.
        
        The algorithm you
        want to implement should merge the cells within a given rectangular part of the
        table into a single cell by removing the borders between them (i.e. replace them
        with space characters (' ') and replace redundant +s with correct border
        symbols). The cells to join are represented by the coordinates of the cells at
        the extreme bottom-left and top-right of the area.
        
        Example
        For
        
        table =
        ["+----+--+-----+----+",
                 "|abcd|56|!@#$%|qwer|",
        "|1234|78|^&=()|tyui|",
                 "+----+--+-----+----+",
        "|zxcv|90|77777|stop|",
                 "+----+--+-----+----+",
        "|asdf|~~|ghjkl|100$|",
                 "+----+--+-----+----+"]
        
        
        and coords = [[2, 0],
        [1, 1]], the output should be
        
        cellsJoining(table, coords) =
        ["+----+--+-----+----+",
                                       "|abcd|56|!@#$%|qwer|",
        "|1234|78|^&=()|tyui|",
                                       "+----+--+-----+----+",
        "|zxcv 90|77777|stop|",
                                       "|       +-----+----+",
        "|asdf ~~|ghjkl|100$|",
                                       "+-------+-----+----+"]
        Input/Output
        
        [execution time limit] 3 seconds (cs)
        
        [input] array.string table
        A table in ASCII graphics. '|' and '-' characters represent borders, and '+'
        characters represent their intersection. It is guaranteed that there are no
        joined cells in the table. It's also guaranteed that the table occupies the
        entire rectangular array, i.e. its outer borders occupy the leftmost and the
        rightmost columns of the array as well as its topmost and bottommost rows.
        Guaranteed constraints:
        3 ≤ table.length ≤ 25,
        3 ≤ table[i].length ≤ 80,
        table[i].length = table[j].length.
        
        [input] array.array.integer coords
        coords[0] contains 0-based row and column indices (given in that exact order) of
        the extreme bottom left cell in the area to join, and coords[1] contains indices
        of the extreme top right cell of that region.
        
        It's guaranteed that there are at
        least two cells to be joined, and that cells with the given indices do exist in
        the table.
        
        The rows are numbered from top to bottom while the columns are
        numbered from left to right.
        
        Guaranteed constraints:
        coords.length = 2,
        coords[i].length = 2,
        0 ≤ coords[1][0] ≤ coords[0][0] < 10,
        0 ≤ coords[0][1] ≤
        coords[1][1] ≤ 25.
        
        [output] array.string
        
        Table with cells in given region
        joined into one.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.SecretArchives
{
    class cellsJoiningClass
    {
        string[] cellsJoining(string[] table, int[][] coords) {
            var columns = table[0].Select((c,i) => (c,i)).Where(i => i.c == '+').Select(i => i.i).ToArray();
            Console.WriteLine($"Columns {string.Join(",", columns)}");
            var rows = table.Select((s, i) => (c: s[0], i)).Where(i => i.c == '+').Select(i => i.i).ToArray();
            Console.WriteLine($"Rows    {string.Join(",", rows)}");
         
            void SetChar(int x, int y, char c) {
                table[y] = table[y].Substring(0, x) + c + table[y].Substring(x + 1);
            }
            var top = coords[1][0];
            var left = coords[0][1];
            var bottom = coords[0][0];
            var right = coords[1][1];
            Console.WriteLine($"{left}-{right} - {top}-{bottom}");
            // Blank out column separators
            if (right - left > 0) {
                for(var c = left + 1; c < right + 1; c++) {
                    SetChar(columns[c], rows[top], top == 0 ? '-' : '+');
                    SetChar(columns[c], rows[bottom + 1], bottom + 1 == rows.Length - 1 ? '-' : '+');
                    for(var r = rows[top] + 1; r < rows[bottom+1]; r++) {
                        SetChar(columns[c], r, ' ');
                    }
                }
            }
            // Blank out rows separators
            if (bottom - top > 0) {
                for(var r = top + 1; r < bottom + 1; r++) {
                    var blank = (left == 0 ? '|' : '+') + new string(' ', columns[right + 1] - columns[left] - 1) + (right + 1 
        == columns.Length - 1 ? '|' : '+');
                    table[rows[r]] = table[rows[r]].Substring(0, columns[left]) + blank + table[rows[r]].Substring(columns
        [right + 1] + 1);
                }
            }
         
            return table;
        }
    }
}
