/*
    Status:   Solved
    Imported: 2020-05-02 13:02
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/spring-of-integration/6QDtjNr3WoL5W4Kvo

    Description:
        Define crossover operation over two equal-length strings A and B as follows:
        the result of that operation is a string of the same length as the input strings
        result[i] is either A[i] or B[i], chosen at random
        Given array of strings inputArray and a string result, find for how many pairs
        of strings from inputArray the result of the crossover operation over them may
        be equal to result.
        Note that (A, B) and (B, A) are the same pair. Also note that the pair cannot
        include the same element of the array twice (however, if there are two equal
        elements in the array, they can form a pair).
        Example
        For inputArray = ["abc", "aaa", "aba", "bab"] and result = "bbb", the output
        should be
        stringsCrossover(inputArray, result) = 2.
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] array.string inputArray
        A non-empty array of equal-length strings.
        Guaranteed constraints:
        2 ≤ inputArray.length ≤ 10,
        1 ≤ inputArray[i].length ≤ 10.
        [input] string result
        A string of the same length as each of the inputArray elements.
        Guaranteed constraints:
        result.length = inputArray[i].length.
        [output] integer
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.SpringOfIntegration
{
    class stringsCrossoverClass
    {
        int stringsCrossover(string[] inputArray, string result) {
            int resultCount = 0;
            for(var a = 0; a < inputArray.Length - 1; a++) {
                var sA = inputArray[a];
                for(var b = a + 1; b < inputArray.Length; b++) {
                    if (IsCross(result, sA, inputArray[b])) {
                        resultCount++;
                    }
                }
            }
            return resultCount;
        }
        bool IsCross(string result, string A, string B) {
            for(var r = 0; r < result.Length; r++) {
                if (result[r] != A[r] && result[r] != B[r]) return false;
            }
            return true;
        }
    }
}
