/*
    Status:   Solved
    Imported: 2020-04-26 13:28
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/list-backwoods/Nh48Nqxb2zGx2NvYK

    Description:
        Given a rectangular matrix and integers a and b, consider the union of the ath
        row and the bth (both 0-based) column of the matrix (i.e. all cells that belong
        either to the ath row or to the bth column, or to both). Return sum of all
        elements of that union.
        
        Example
        
        For
        
        matrix = [[1, 1, 1, 1], 
                  [2, 2,
        2, 2], 
                  [3, 3, 3, 3]]
        
        
        a = 1, and b = 3, the output should be
        crossingSum(matrix, a, b) = 12.
        
        Here (2 + 2 + 2 + 2) + (1 + 3) = 12.
        Input/Output
        
        [execution time limit] 3 seconds (cs)
        
        [input] array.array.integer
        matrix
        
        2-dimensional array of integers representing a rectangular matrix.
        Guaranteed constraints:
        1 ≤ matrix.length ≤ 500,
        1 ≤ matrix[0].length ≤ 500,
        1 ≤
        matrix[i][j] ≤ 105.
        
        [input] integer a
        
        A non-negative integer less than the
        number of matrix rows.
        
        Guaranteed constraints:
        0 ≤ a < matrix.length.
        
        [input]
        integer b
        
        A non-negative integer less than the number of matrix columns.
        Guaranteed constraints:
        0 ≤ b < matrix[i].length.
        
        [output] integer

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.ListBackwoods
{
    class crossingSumClass
    {
        int crossingSum(int[][] matrix, int a, int b) {
            int sum = 0;
            int height = matrix.Length;
            int width = matrix[0].Length;
            for(var x = 0; x < width; x++) {
                sum+= matrix[a][x];
            }
            for(var y = 0; y < height; y++) {
                sum += matrix[y][b];
            }
            sum -= matrix[a][b];
            return sum;
        }
    }
}
