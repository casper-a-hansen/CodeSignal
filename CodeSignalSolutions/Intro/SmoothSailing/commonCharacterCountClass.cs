/*
    Status:   Solved
    Imported: 2020-05-02 11:53
    By:       Casper
    Url:      https://app.codesignal.com/arcade/intro/level-3/JKKuHJknZNj4YGL32

    Description:
        Given two strings, find the number of common characters between them.
        Example
        For s1 = "aabcc" and s2 = "adcaa", the output should be
        commonCharacterCount(s1, s2) = 3.
        Strings have 3 common characters - 2 "a"s and 1 "c".
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] string s1
        A string consisting of lowercase English letters.
        Guaranteed constraints:
        1 ≤ s1.length < 15.
        [input] string s2
        A string consisting of lowercase English letters.
        Guaranteed constraints:
        1 ≤ s2.length < 15.
        [output] integer
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Intro.SmoothSailing
{
    class commonCharacterCountClass
    {
        int commonCharacterCount(string s1, string s2) {
            var d1 = s1.GroupBy(c => c, c => c).ToDictionary(g => g.Key, g => g.Count());
            var d2 = s2.GroupBy(c => c, c => c).ToDictionary(g => g.Key, g => g.Count());
            var sum = 0;
            foreach(var i1 in d1)
            {
                if (d2.TryGetValue(i1.Key, out var count))
                {
                    sum += Math.Min(i1.Value, count);
                }
            }
            return sum;
        }
    }
}
