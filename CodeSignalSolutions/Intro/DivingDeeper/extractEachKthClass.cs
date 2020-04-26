/*
    Status:   Solved
    Imported: 2020-04-26 13:11
    By:       Casper
    Url:      https://app.codesignal.com/arcade/intro/level-8/3AgqcKrxbwFhd3Z3R

    Description:
        Given array of integers, remove each kth element from it.
        
        Example
        
        For
        inputArray = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10] and k = 3, the output should be
        extractEachKth(inputArray, k) = [1, 2, 4, 5, 7, 8, 10].
        
        Input/Output
        [execution time limit] 3 seconds (cs)
        
        [input] array.integer inputArray
        Guaranteed constraints:
        5 ≤ inputArray.length ≤ 15,
        -20 ≤ inputArray[i] ≤ 20.
        [input] integer k
        
        Guaranteed constraints:
        1 ≤ k ≤ 10.
        
        [output] array.integer
        inputArray without elements k - 1, 2k - 1, 3k - 1 etc.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Intro.DivingDeeper
{
    class extractEachKthClass
    {
        int[] extractEachKth(int[] inputArray, int k) {
            return inputArray
                .Select((v, i) => new Tuple<int, int>(i, v))
                .Where(t => ((t.Item1 + 1) % k) != 0)
                .Select(t => t.Item2)
                .ToArray();
        }
    }
}
