/*
    Status:   Solved
    Imported: 2020-05-02 12:49
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/mirror-lake/EeKpdMQXpBkgWjcvt

    Description:
        Given a string consisting of lowercase English letters, find the largest square
        number which can be obtained by reordering the string's characters and replacing
        them with any digits you need (leading zeros are not allowed) where same
        characters always map to the same digits and different characters always map to
        different digits.
        If there is no solution, return -1.
        Example
        For s = "ab", the output should be
        constructSquare(s) = 81.
        The largest 2-digit square number with different digits is 81.
        For s = "zzz", the output should be
        constructSquare(s) = -1.
        There are no 3-digit square numbers with identical digits.
        For s = "aba", the output should be
        constructSquare(s) = 900.
        It can be obtained after reordering the initial string into "baa" and replacing
        "a" with 0 and "b" with 9.
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] string s
        Guaranteed constraints:
        1 ≤ s.length < 10.
        [output] integer
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.MirrorLake
{
    class constructSquareClass
    {
        int constructSquare(string s) {
            var sDigitCount = s.ToString().GroupBy(c => c).Select(g => g.Count()).OrderBy(c => c).ToArray();
            var min = Math.Pow(10, s.Length - 1);
            var max = min * 10;
            var minq = (int)Math.Ceiling(Math.Sqrt(min));
            var maxq = (int)Math.Floor(Math.Sqrt(max));
            Console.WriteLine($"{minq} - {maxq} or {minq * minq}- {maxq * maxq}");
            for(var i = maxq; i >= minq; i--) {
                var value = (i*i);
                var valueDigitCount = value.ToString().GroupBy(c => c).Select(g => g.Count()).OrderBy(c => c).ToArray();
                if (valueDigitCount.SequenceEqual(sDigitCount)) {
                    return value;
                }
            }
            return -1;
        }
    }
}
