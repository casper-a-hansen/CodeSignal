/*
    Status:   Solved
    Imported: 2020-04-26 13:25
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/well-of-integration/QmK8kHTyKqh8xDoZk

    Description:
        You have a long strip of paper with integers written on it in a single line from
        left to right. You wish to cut the paper into exactly three pieces such that
        each piece contains at least one integer and the sum of the integers in each
        piece is the same. You cannot cut through a number, i.e. each initial number
        will unambiguously belong to one of the pieces after cutting. How many ways can
        you do it?
        
        It is guaranteed that the sum of all elements in the array is
        divisible by 3.
        
        Example
        
        For a = [0, -1, 0, -1, 0, -1], the output should be
        threeSplit(a) = 4.
        
        Here are all possible ways:
        
        [0, -1] [0, -1] [0, -1]
        [0, -1]
        [0, -1, 0] [-1]
        [0, -1, 0] [-1, 0] [-1]
        [0, -1, 0] [-1] [0, -1]
        
        Input/Output
        [execution time limit] 3 seconds (cs)
        
        [input] array.integer a
        
        Guaranteed
        constraints:
        5 ≤ a.length ≤ 104,
        -108 ≤ a[i] ≤ 108.
        
        [output] integer
        
        It's
        guaranteed that for the given test cases the answer always fits signed 32-bit
        integer type.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.WellOfIntegration
{
    class threeSplitClass
    {
        int threeSplit(int[] a) {
            int result = 0;
            long size = a.Sum(v => Convert.ToInt64(v)) / 3;
            long s1 = 0;
            for (int g1 = 0; g1 < a.Length; g1++) {
                s1 += a[g1];
                if (s1 == size) {
                    long s2 = 0;
                    for (int g2 = g1 + 1; g2 < a.Length; g2++) {
                        s2 += a[g2];
                        if (s2 == size) {
                            if (g2 < a.Length - 1) {
                                result++;
                            }
                        }
                    }
                }
            }
            return result;
        }
    }
}
