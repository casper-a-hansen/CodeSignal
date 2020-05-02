/*
    Status:   Solved
    Imported: 2020-05-02 13:05
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/waterfall-of-integration/ZMR5n7vJbexnLrgaM

    Description:
        In the popular Minesweeper game you have a board with some mines and those cells
        that don't contain a mine have a number in it that indicates the total number of
        mines in the neighboring cells. Starting off with some arrangement of mines we
        want to create a Minesweeper game setup.
        Example
        For
        matrix = [[true, false, false],
        [false, true, false],
        [false, false, false]]
        the output should be
        minesweeper(matrix) = [[1, 2, 1],
        [2, 1, 1],
        [1, 1, 1]]
        Check out the image below for better understanding:
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] array.array.boolean matrix
        A non-empty rectangular matrix consisting of boolean values - true if the
        corresponding cell contains a mine, false otherwise.
        Guaranteed constraints:
        2 ≤ matrix.length ≤ 100,
        2 ≤ matrix[0].length ≤ 100.
        [output] array.array.integer
        Rectangular matrix of the same size as matrix each cell of which contains an
        integer equal to the number of mines in the neighboring cells. Two cells are
        called neighboring if they share at least one corner.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.WaterfallOfIntegration
{
    class minesweeperClass
    {
        int[][] minesweeper(bool[][] matrix) {
            var surroundings = new (int X, int Y)[]{
                (X: -1, Y: -1),
                (X: 0, Y: -1),
                (X: 1, Y: -1),
                (X: -1, Y: 0),
                (X: 1, Y: 0),
                (X: -1, Y: 1),
                (X: 0, Y: 1),
                (X: 1, Y: 1)
            };
            var result = matrix.Select(a => new int[a.Length]).ToArray();
            void Bomb(int x, int y) {
                foreach(var offset in surroundings) {
                    var pX = x + offset.X;
                    var pY = y + offset.Y;
                    if (pX < 0 || pY < 0) continue;
                    if (pY >= matrix.Length) continue;
                    if (pX >= matrix[pY].Length) continue;
                    result[pY][pX]++;
                }
            }
            for(var y = 0; y < matrix.Length; y++) {
                var row = matrix[y];
                for(var x = 0; x < row.Length; x++) {
                    if (row[x]) {
                        Bomb(x, y);
                    }
                }
            }
            return result;
        }
    }
}
