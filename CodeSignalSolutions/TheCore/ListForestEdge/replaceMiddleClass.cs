/*
    Status:   Solved
    Imported: 2020-05-02 12:13
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/list-forest-edge/APD5T5CybxTtfkdjL

    Description:
        We define the middle of the array arr as follows:
        if arr contains an odd number of elements, its middle is the element whose index
        number is the same when counting from the beginning of the array and from its
        end;
        if arr contains an even number of elements, its middle is the sum of the two
        elements whose index numbers when counting from the beginning and from the end
        of the array differ by one.
        Given array arr, your task is to find its middle, and, if it consists of two
        elements, replace those elements with the value of middle. Return the resulting
        array as the answer.
        Example
        For arr = [7, 2, 2, 5, 10, 7], the output should be
        replaceMiddle(arr) = [7, 2, 7, 10, 7].
        The middle consists of two elements, 2 and 5. These two elements should be
        replaced with their sum, i.e. 7.
        For arr = [-5, -5, 10], the output should be
        replaceMiddle(arr) = [-5, -5, 10].
        The middle is defined as a single element -5, so the initial array with no
        changes should be returned.
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] array.integer arr
        The given array.
        Guaranteed constraints:
        2 ≤ arr.length ≤ 104,
        -103 ≤ arr[i] ≤ 103.
        [output] array.integer
        arr with its middle replaced by a single element, or the initial array if the
        middle consisted of a single element to begin with.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.ListForestEdge
{
    class replaceMiddleClass
    {
        int[] replaceMiddle(int[] arr) {
            if (arr.Length == 0) return arr;
            if (arr.Length % 2 == 1) return arr;
            var middle = arr[arr.Length / 2 - 1] + arr[arr.Length / 2];
            var result = new int[arr.Length - 1];
            Array.Copy(arr, result, arr.Length / 2 - 1);
            result[result.Length / 2] = middle;
            Array.ConstrainedCopy(arr, result.Length / 2 + 2, result, result.Length / 2 + 1, result.Length / 2);
            return result;
        }
    }
}
