/*
    Status:   Solved
    Imported: 2020-05-02 13:05
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/waterfall-of-integration/tQgasP8b62JBeirMS

    Description:
        Sudoku is a number-placement puzzle. The objective is to fill a 9 × 9 grid with
        digits so that each column, each row, and each of the nine 3 × 3 sub-grids that
        compose the grid contains all of the digits from 1 to 9.
        This algorithm should check if the given grid of numbers represents a correct
        solution to Sudoku.
        Example
        For
        grid = [[1, 3, 2, 5, 4, 6, 9, 8, 7],
        [4, 6, 5, 8, 7, 9, 3, 2, 1],
        [7, 9, 8, 2, 1, 3, 6, 5, 4],
        [9, 2, 1, 4, 3, 5, 8, 7, 6],
        [3, 5, 4, 7, 6, 8, 2, 1, 9],
        [6, 8, 7, 1, 9, 2, 5, 4, 3],
        [5, 7, 6, 9, 8, 1, 4, 3, 2],
        [2, 4, 3, 6, 5, 7, 1, 9, 8],
        [8, 1, 9, 3, 2, 4, 7, 6, 5]]
        the output should be
        sudoku(grid) = true;
        For
        grid = [[1, 3, 2, 5, 4, 6, 9, 2, 7],
        [4, 6, 5, 8, 7, 9, 3, 8, 1],
        [7, 9, 8, 2, 1, 3, 6, 5, 4],
        [9, 2, 1, 4, 3, 5, 8, 7, 6],
        [3, 5, 4, 7, 6, 8, 2, 1, 9],
        [6, 8, 7, 1, 9, 2, 5, 4, 3],
        [5, 7, 6, 9, 8, 1, 4, 3, 2],
        [2, 4, 3, 6, 5, 7, 1, 9, 8],
        [8, 1, 9, 3, 2, 4, 7, 6, 5]]
        the output should be
        sudoku(grid) = false.
        The output should be false: each of the nine 3 × 3 sub-grids should contain all
        of the digits from 1 to 9.
        These examples are represented on the image below.
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] array.array.integer grid
        A matrix representing 9 × 9 grid already filled with numbers from 1 to 9.
        Guaranteed constraints:
        grid.length = 9,
        grid[i].length = 9,
        1 ≤ grid[i][j] ≤ 9.
        [output] boolean
        true if the given grid represents a correct solution to Sudoku, false otherwise.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.WaterfallOfIntegration
{
    class sudokuClass
    {
        bool sudoku(int[][] grid) {
            var check = "123456789";
            for(var i = 0; i < 8; i++) {
                //Console.WriteLine("Vertical: " + string.Join("", grid[i].OrderBy(v => v)));
                if (string.Join("", grid[i].OrderBy(v => v)) != check) return false;
                //Console.WriteLine("Horizontal: " + string.Join("", Enumerable.Range(0, 9).Select(y => grid[y][i]).OrderBy(v => v)));
                if (string.Join("", Enumerable.Range(0, 9).Select(y => grid[y][i]).OrderBy(v => v)) != check) return false;
                var offsetX = (i % 3) * 3;
                var offsetY = (i / 3) * 3;
                var values = new List<int>();
                for(var y = offsetY; y < offsetY + 3; y++) {
                    for(var x = offsetX; x < offsetX + 3; x++) {
                        values.Add(grid[y][x]);
                    }
                }
                values.Sort();
                //Console.WriteLine("Block: " + string.Join("", values));
                if (string.Join("", values) != check) return false;
            }
            return true;
        }
    }
}
