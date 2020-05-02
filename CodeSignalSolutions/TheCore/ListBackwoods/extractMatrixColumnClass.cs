/*
    Status:   Solved
    Imported: 2020-05-02 13:03
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/list-backwoods/zwXiykHLor6eKHaLY

    Description:
        Given a rectangular matrix and an integer column, return an array containing the
        elements of the columnth column of the given matrix (the leftmost column is the
        0th one).
        Example
        For
        matrix = [[1, 1, 1, 2],
        [0, 5, 0, 4],
        [2, 1, 3, 6]]
        and column = 2, the output should be
        extractMatrixColumn(matrix, column) = [1, 0, 3].
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] array.array.integer matrix
        2-dimensional array of integers representing a rectangular matrix.
        Guaranteed constraints:
        1 ≤ matrix.length ≤ 500,
        1 ≤ matrix[i].length ≤ 500,
        0 ≤ matrix[i][j] ≤ 105.
        [input] integer column
        An integer not greater than the number of matrix columns.
        Guaranteed constraints:
        0 ≤ column ≤ matrix[i].length - 1.
        [output] array.integer
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.ListBackwoods
{
    class extractMatrixColumnClass
    {
        int[] extractMatrixColumn(int[][] matrix, int column) {
            var result = new int[matrix.Length];
            for(var i = 0; i < matrix.Length; i++) {
                result[i] = matrix[i][column];
            }
            return result;
        }
    }
}
