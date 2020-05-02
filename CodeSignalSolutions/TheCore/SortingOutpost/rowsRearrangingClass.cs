/*
    Status:   Solved
    Imported: 2020-05-02 13:08
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/sorting-outpost/vuXQuYFReJPe6hHAf

    Description:
        Given a rectangular matrix of integers, check if it is possible to rearrange its
        rows in such a way that all its columns become strictly increasing sequences
        (read from top to bottom).
        Example
        For
        matrix = [[2, 7, 1],
        [0, 2, 0],
        [1, 3, 1]]
        the output should be
        rowsRearranging(matrix) = false;
        For
        matrix = [[6, 4],
        [2, 2],
        [4, 3]]
        the output should be
        rowsRearranging(matrix) = true.
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] array.array.integer matrix
        A 2-dimensional array of integers.
        Guaranteed constraints:
        1 ≤ matrix.length ≤ 10,
        1 ≤ matrix[0].length ≤ 10,
        -300 ≤ matrix[i][j] ≤ 300.
        [output] boolean
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.SortingOutpost
{
    class rowsRearrangingClass
    {
        bool rowsRearranging(int[][] matrix) {
            var width = matrix[0].Length;
            if (Enumerable.Range(0, width)
                .Any(i => matrix.Select(a => a[i]).Distinct().Count() != matrix.Length)) {
                return false;
            }
            var order =  Enumerable.Range(0, width)
                .Select(c => matrix.Select((a,r) => (v: a[c],r))
                    .OrderByDescending(t => t.v)
                    .Select(t => t.r).ToArray())
                .ToArray();
            return order.All(a => a.SequenceEqual(order[0]));
        }
    }
}
