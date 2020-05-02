/*
    Status:   Solved
    Imported: 2020-05-02 12:07
    By:       Casper
    Url:      https://app.codesignal.com/arcade/intro/level-12/uRWu6K8E7uLi3Qtvx

    Description:
        Construct a square matrix with a size N × N containing integers from 1 to N * N
        in a spiral order, starting from top-left and in clockwise direction.
        Example
        For n = 3, the output should be
        spiralNumbers(n) = [[1, 2, 3],
        [8, 9, 4],
        [7, 6, 5]]
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] integer n
        Matrix size, a positive integer.
        Guaranteed constraints:
        3 ≤ n ≤ 100.
        [output] array.array.integer
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Intro.LandOfLogic
{
    class spiralNumbersClass
    {
        int[][] spiralNumbers(int n) {
            var result = Enumerable.Range(0, n).Select(dummy => new int[n]).ToArray();
            int counter = 1;
            for(var offset = 0; offset <= n / 2; offset++)
            {
                // Top row
                for(var x = offset; x < n - offset; x++)
                {
                    result[offset][x] = counter++;
                }
                // Right column
                for(var y = offset + 1; y < n - offset; y++)
                {
                    result[y][n - offset - 1] = counter++;
                }
                // Bottom row
                for(var x = n - offset - 2; x >= offset; x--)
                {
                    result[n - offset - 1][x] = counter++;
                }
                // Left row
                for(var y = n - offset - 2; y >= offset + 1; y--)
                {
                    result[y][offset] = counter++;
                }
            }
            return result;
        }
    }
}
