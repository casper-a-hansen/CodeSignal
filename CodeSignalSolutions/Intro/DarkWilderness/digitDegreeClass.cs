/*
    Status:   Solved
    Imported: 2020-05-02 12:04
    By:       Casper
    Url:      https://app.codesignal.com/arcade/intro/level-9/hoLtYWbjdrD2PF6yo

    Description:
        Let's define digit degree of some positive integer as the number of times we
        need to replace this number with the sum of its digits until we get to a one
        digit number.
        Given an integer, find its digit degree.
        Example
        For n = 5, the output should be
        digitDegree(n) = 0;
        For n = 100, the output should be
        digitDegree(n) = 1.
        1 + 0 + 0 = 1.
        For n = 91, the output should be
        digitDegree(n) = 2.
        9 + 1 = 10 -> 1 + 0 = 1.
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] integer n
        Guaranteed constraints:
        5 ≤ n ≤ 109.
        [output] integer
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Intro.DarkWilderness
{
    class digitDegreeClass
    {
        int digitDegree(int n) {
            var result = 0;
            while(n >= 10)
            {
                n = n.ToString().Select(c => (int)(c - '0')).Sum();
                result++;
            }
            return result;
        }
    }
}
