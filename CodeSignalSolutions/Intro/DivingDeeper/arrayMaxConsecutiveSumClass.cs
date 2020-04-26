/*
    Status:   Solved
    Imported: 2020-04-26 13:11
    By:       Casper
    Url:      https://app.codesignal.com/arcade/intro/level-8/Rqvw3daffNE7sT7d5

    Description:
        Given array of integers, find the maximal possible sum of some of its k
        consecutive elements.
        
        Example
        
        For inputArray = [2, 3, 5, 1, 6] and k = 2, the
        output should be
        arrayMaxConsecutiveSum(inputArray, k) = 8.
        All possible sums of
        2 consecutive elements are:
        
        2 + 3 = 5;
        3 + 5 = 8;
        5 + 1 = 6;
        1 + 6 = 7.
        Thus,
        the answer is 8.
        
        Input/Output
        
        [execution time limit] 3 seconds (cs)
        
        [input]
        array.integer inputArray
        
        Array of positive integers.
        
        Guaranteed constraints:
        3
        ≤ inputArray.length ≤ 105,
        1 ≤ inputArray[i] ≤ 1000.
        
        [input] integer k
        
        An
        integer (not greater than the length of inputArray).
        
        Guaranteed constraints:
        1
        ≤ k ≤ inputArray.length.
        
        [output] integer
        
        The maximal possible sum.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Intro.DivingDeeper
{
    class arrayMaxConsecutiveSumClass
    {
        int arrayMaxConsecutiveSum(int[] inputArray, int k) {
            var sum = inputArray.Take(k).Sum();
            var maxSum = sum;
            for(int i = k; i < inputArray.Length; i++)
            {
                sum = sum - inputArray[i - k] + inputArray[i];
                if (maxSum < sum) maxSum = sum;
            }
            return maxSum;
        }
    }
}
