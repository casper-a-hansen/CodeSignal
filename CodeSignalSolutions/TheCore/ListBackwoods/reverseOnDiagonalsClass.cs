/*
    Status:   Solved
    Imported: 2020-05-02 13:04
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/list-backwoods/Akspcu9ewiYapWkrp

    Description:
        The longest diagonals of a square matrix are defined as follows:
        the first longest diagonal goes from the top left corner to the bottom right
        one;
        the second longest diagonal goes from the top right corner to the bottom left
        one.
        Given a square matrix, your task is to reverse the order of elements on both of
        its longest diagonals.
        Example
        For
        matrix = [[1, 2, 3],
        [4, 5, 6],
        [7, 8, 9]]
        the output should be
        reverseOnDiagonals(matrix) = [[9, 2, 7],
        [4, 5, 6],
        [3, 8, 1]]
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] array.array.integer matrix
        Guaranteed constraints:
        1 ≤ matrix.length ≤ 100,
        matrix.length = matrix[i].length,
        1 ≤ matrix[i][j] ≤ 105.
        [output] array.array.integer
        Matrix with the order of elements on its longest diagonals reversed.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.ListBackwoods
{
    class reverseOnDiagonalsClass
    {
        int[][] reverseOnDiagonals(int[][] matrix) {
            var length = matrix.Length;
            var half = length / 2;
            for(var d = 0; d < half; d++) {
                var temp = matrix[d][d];
                matrix[d][d] = matrix[length - d - 1][length - d - 1];
                matrix[length - d - 1][length - d - 1] = temp;
                temp = matrix[length - d - 1][d];
                matrix[length - d - 1][d] = matrix[d][length - d - 1];
                matrix[d][length - d - 1] = temp;
            }
            return matrix;
        }
    }
}
