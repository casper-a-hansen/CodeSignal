/*
    Status:   Solved
    Imported: 2020-05-02 12:54
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/spring-of-integration/dwA8RtDF86WucuoaQ

    Description:
        Given an array of 2k integers (for some integer k), perform the following
        operations until the array contains only one element:
        On the 1st, 3rd, 5th, etc. iterations (1-based) replace each pair of consecutive
        elements with their sum;
        On the 2nd, 4th, 6th, etc. iterations replace each pair of consecutive elements
        with their product.
        After the algorithm has finished, there will be a single element left in the
        array. Return that element.
        Example
        For inputArray = [1, 2, 3, 4, 5, 6, 7, 8], the output should be
        arrayConversion(inputArray) = 186.
        We have [1, 2, 3, 4, 5, 6, 7, 8] -> [3, 7, 11, 15] -> [21, 165] -> [186], so the
        answer is 186.
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] array.integer inputArray
        Guaranteed constraints:
        1 ≤ inputArray.length ≤ 27,
        -100 ≤ inputArray[i] ≤ 100.
        [output] integer
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.SpringOfIntegration
{
    class arrayConversionClass
    {
        int arrayConversion(int[] inputArray) {
            var result = new List<int>(inputArray);
            while(true) {
                var newResult = new List<int>();
                Console.WriteLine($"Adding: {string.Join(",", result)}");
                for(var i = 0; i < result.Count; i += 2) {
                    newResult.Add(result[i] + (result.Count == i + 1 ? 0 : result[i + 1]));
                }
                result = new List<int>(newResult);
                if (result.Count == 1) break;
                newResult.Clear();
                Console.WriteLine($"Multiply: {string.Join(",", result)}");
                for(var i = 0; i < result.Count; i += 2) {
                    newResult.Add(result[i] * (result.Count == i + 1 ? 1 : result[i + 1]));
                }
                result = new List<int>(newResult);
                if (result.Count == 1) break;
            }
            return result[0];
        }
    }
}
