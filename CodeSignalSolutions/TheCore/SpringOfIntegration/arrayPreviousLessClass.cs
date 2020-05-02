/*
    Status:   Solved
    Imported: 2020-05-02 12:54
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/spring-of-integration/MQg7s3dKrP4caN42A

    Description:
        Given array of integers, for each position i, search among the previous
        positions for the last (from the left) position that contains a smaller value.
        Store this value at position i in the answer. If no such value can be found,
        store -1 instead.
        Example
        For items = [3, 5, 2, 4, 5], the output should be
        arrayPreviousLess(items) = [-1, 3, -1, 2, 4].
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] array.integer items
        Non-empty array of positive integers.
        Guaranteed constraints:
        3 ≤ items.length ≤ 15,
        1 ≤ items[i] ≤ 200.
        [output] array.integer
        Array containing answer values computed as described above.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.SpringOfIntegration
{
    class arrayPreviousLessClass
    {
        int[] arrayPreviousLess(int[] items) {
            var result = new int[items.Length];
            if (items.Length == 0) return result;
            result[0] = -1;
            for(var i = 1; i < items.Length; i++) {
                var min = -1;
                for(var j = i - 1; j >= 0; j--) {
                    if (items[j] < items[i]) {
                        min = items[j];
                        break;
                    }
                }
                result[i] = min;
            }
            return result;
        }
    }
}
