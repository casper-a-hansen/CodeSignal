/*
    Status:   Solved
    Imported: 2020-05-02 12:13
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/list-forest-edge/vPJB7T28fyCeh2Ljn

    Description:
        Remove a part of a given array between given 0-based indexes l and r
        (inclusive).
        Example
        For inputArray = [2, 3, 2, 3, 4, 5], l = 2, and r = 4, the output should be
        removeArrayPart(inputArray, l, r) = [2, 3, 5].
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] array.integer inputArray
        Guaranteed constraints:
        2 ≤ inputArray.length ≤ 104,
        -105 ≤ inputArray[i] ≤ 105.
        [input] integer l
        Left index of the part to be removed (0-based).
        Guaranteed constraints:
        0 ≤ l ≤ r.
        [input] integer r
        Right index of the part to be removed (0-based).
        Guaranteed constraints:
        l ≤ r < inputArray.length.
        [output] array.integer
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.ListForestEdge
{
    class removeArrayPartClass
    {
        int[] removeArrayPart(int[] inputArray, int l, int r) {
            var result = new int[inputArray.Length + l - r - 1];
            Array.Copy(inputArray, result, l);
            Array.ConstrainedCopy(inputArray, r + 1, result, l, inputArray.Length - r - 1);
            return result;
        }
    }
}
