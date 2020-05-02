/*
    Status:   Solved
    Imported: 2020-05-02 12:05
    By:       Casper
    Url:      https://app.codesignal.com/arcade/intro/level-11/o2uq6eTuvk7atGadR

    Description:
        Given a string, return its encoding defined as follows:
        First, the string is divided into the least possible number of disjoint
        substrings consisting of identical characters
        for example, "aabbbc" is divided into ["aa", "bbb", "c"]
        Next, each substring with length greater than one is replaced with a
        concatenation of its length and the repeating character
        for example, substring "bbb" is replaced by "3b"
        Finally, all the new strings are concatenated together in the same order and a
        new string is returned.
        Example
        For s = "aabbbc", the output should be
        lineEncoding(s) = "2a3bc".
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] string s
        String consisting of lowercase English letters.
        Guaranteed constraints:
        4 ≤ s.length ≤ 15.
        [output] string
        Encoded version of s.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Intro.RainbowOfClarity
{
    class lineEncodingClass
    {
        string lineEncoding(string s) {
            StringBuilder result = new StringBuilder();
            char last = '\0';
            int count = 0;
            void Append()
            {
                if (last != '\0')
                {
                    if (count > 1)
                    {
                        result.Append(count);
                    }
                    result.Append(last);
                }
            }
            foreach(var c in s)
            {
                if (c != last)
                {
                    Append();
                    last = c;
                    count = 0;
                }
                count++;
            }
            Append();
            return result.ToString();
        }
    }
}
