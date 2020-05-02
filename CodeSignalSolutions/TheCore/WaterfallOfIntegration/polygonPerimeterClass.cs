/*
    Status:   Solved
    Imported: 2020-05-02 13:05
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/waterfall-of-integration/L7KWEYbPoornGyf7K

    Description:
        You have a rectangular white board with some black cells. The black cells create
        a connected black figure, i.e. it is possible to get from any black cell to any
        other one through connected adjacent (sharing a common side) black cells.
        Find the perimeter of the black figure assuming that a single cell has unit
        length.
        It's guaranteed that there is at least one black cell on the table.
        Example
        For
        matrix = [[false, true,  true ],
        [true,  true,  false],
        [true,  false, false]]
        the output should be
        polygonPerimeter(matrix) = 12.
        For
        matrix = [[true, true,  true],
        [true, false, true],
        [true, true,  true]]
        the output should be
        polygonPerimeter(matrix) = 16.
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] array.array.boolean matrix
        A matrix of booleans representing the rectangular board where true means a black
        cell and false means a white one.
        Guaranteed constraints:
        2 ≤ matrix.length ≤ 5,
        2 ≤ matrix[0].length ≤ 5.
        [output] integer
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.WaterfallOfIntegration
{
    class polygonPerimeterClass
    {
        int polygonPerimeter(bool[][] matrix) {
            var height = matrix.Length;
            var width = matrix[0].Length;
            int sides(int x, int y) {
                if (!matrix[y][x]) return 0;
                int result = 0;
                if (x == 0) result++;
                else if (!matrix[y][x-1]) result++;
                if (x == width - 1) result++;
                else if (!matrix[y][x+1]) result++;
                if (y == 0) result++;
                else if (!matrix[y-1][x]) result++;
                if (y == height - 1) result++;
                else if (!matrix[y+1][x]) result++;
                return result;
            }
            int result = 0;
            for(var y = 0; y < height; y++) {
                for(var x = 0; x < width; x++) {
                    result += sides(x,y);
                }
            }
            return result;
        }
    }
}
