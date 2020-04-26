/*
    Status:   Solved
    Imported: 2020-04-26 13:09
    By:       Casper
    Url:      https://app.codesignal.com/arcade/intro/level-5/ZMR5n7vJbexnLrgaM

    Description:
        In the popular Minesweeper game you have a board with some mines and those cells
        that don't contain a mine have a number in it that indicates the total number of
        mines in the neighboring cells. Starting off with some arrangement of mines we
        want to create a Minesweeper game setup.
        
        Example
        
        For
        
        matrix = [[true, false,
        false],
                  [false, true, false],
                  [false, false, false]]
        
        
        the
        output should be
        
        minesweeper(matrix) = [[1, 2, 1],
                               [2,
        1, 1],
                               [1, 1, 1]]
        
        
        Check out the image below for better
        understanding:
        
        Input/Output
        
        [execution time limit] 3 seconds (cs)
        
        [input]
        array.array.boolean matrix
        
        A non-empty rectangular matrix consisting of boolean
        values - true if the corresponding cell contains a mine, false otherwise.
        Guaranteed constraints:
        2 ≤ matrix.length ≤ 100,
        2 ≤ matrix[0].length ≤ 100.
        [output] array.array.integer
        
        Rectangular matrix of the same size as matrix each
        cell of which contains an integer equal to the number of mines in the
        neighboring cells. Two cells are called neighboring if they share at least one
        corner.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Intro.IslandOfKnowledge
{
    class minesweeperClass
    {
        int[][] minesweeper(bool[][] matrix) {
            var result = Enumerable.Range(0, matrix.Length).Select(i => new int[matrix[0].Length]).ToArray();
         
            for(var y = 0; y < matrix.Length; y++)
            {
                var row = matrix[y];
                for(var x = 0; x < row.Length; x++)
                {
                    if (row[x])
                    {
                        // There is a bomb, inc the 8 surrouding
                        var resultRow = result[y];
                        if (x > 0) resultRow[x - 1]++;
                        if (x < row.Length - 1) resultRow[x + 1]++;
                        if (y > 0)
                        {
                            resultRow = result[y - 1];
                            if (x > 0) resultRow[x - 1]++;
                            resultRow[x]++;
                            if (x < row.Length - 1) resultRow[x + 1]++;
                        }
                        if (y < matrix.Length - 1)
                        {
                            resultRow = result[y + 1];
                            if (x > 0) resultRow[x - 1]++;
                            resultRow[x]++;
                            if (x < row.Length - 1) resultRow[x + 1]++;
                        }
                    }
                }
            }
            return result;
        }
    }
}
