/*
    Status:   Solved
    Imported: 2020-04-26 13:15
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/intro-gates/SZB5XypsMokGusDhX

    Description:
        Given an integer n, return the largest number that contains exactly n digits.
        Example
        
        For n = 2, the output should be
        largestNumber(n) = 99.
        
        Input/Output
        [execution time limit] 3 seconds (cs)
        
        [input] integer n
        
        Guaranteed
        constraints:
        1 ≤ n ≤ 9.
        
        [output] integer
        
        The largest integer of length n.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.IntroGates
{
    class largestNumberClass
    {
        int largestNumber(int n) {
            //if (n == 9) return int.MaxValue;
            return int.Parse(new string(Enumerable.Range(0, n).Select(dummy => '9').ToArray()));
        }
    }
}
