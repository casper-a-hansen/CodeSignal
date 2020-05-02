/*
    Status:   Solved
    Imported: 2020-05-02 13:04
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/list-backwoods/kfwTN8pdx9uP8bcHS

    Description:
        The longest diagonals of a square matrix are defined as follows:
        the first longest diagonal goes from the top left corner to the bottom right
        one;
        the second longest diagonal goes from the top right corner to the bottom left
        one.
        Given a square matrix, your task is to swap its longest diagonals by exchanging
        their elements at the corresponding positions.
        Example
        For
        matrix = [[1, 2, 3],
        [4, 5, 6],
        [7, 8, 9]]
        the output should be
        swapDiagonals(matrix) = [[3, 2, 1],
        [4, 5, 6],
        [9, 8, 7]]
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] array.array.integer matrix
        Guaranteed constraints:
        1 ≤ matrix.length ≤ 100,
        matrix.length = matrix[i].length,
        1 ≤ matrix[i][j] ≤ 105.
        [output] array.array.integer
        Matrix with swapped diagonals.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.ListBackwoods
{
    class swapDiagonalsClass
    {
        int[][] swapDiagonals(int[][] matrix) {
            int length = matrix.Length;
            int half = length / 2;
            for(var i = 0; i < length; i++) {
                var temp = matrix[i][i];
                matrix[i][i] = matrix[i][length - i - 1];
                matrix[i][length - i - 1] = temp;
            }
            return matrix;
        }
    }
}
