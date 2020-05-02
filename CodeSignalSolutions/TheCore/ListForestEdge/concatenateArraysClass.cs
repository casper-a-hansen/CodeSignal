/*
    Status:   Solved
    Imported: 2020-05-02 12:12
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/list-forest-edge/GeqSK26bvdrarkGH9

    Description:
        Given two arrays of integers a and b, obtain the array formed by the elements of
        a followed by the elements of b.
        Example
        For a = [2, 2, 1] and b = [10, 11], the output should be
        concatenateArrays(a, b) = [2, 2, 1, 10, 11].
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] array.integer a
        Guaranteed constraints:
        1 ≤ a.length ≤ 10,
        1 ≤ a[i] ≤ 15.
        [input] array.integer b
        Guaranteed constraints:
        0 ≤ b.length ≤ 10,
        1 ≤ b[i] ≤ 15.
        [output] array.integer
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.ListForestEdge
{
    class concatenateArraysClass
    {
        int[] concatenateArrays(int[] a, int[] b) {
            var result = new int[a.Length + b.Length];
            Array.Copy(a, result, a.Length);
            Array.ConstrainedCopy(b, 0, result, a.Length, b.Length);
            return result;
        }
    }
}
