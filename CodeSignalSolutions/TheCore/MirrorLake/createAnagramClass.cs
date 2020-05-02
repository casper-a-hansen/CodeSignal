/*
    Status:   Solved
    Imported: 2020-05-02 12:49
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/mirror-lake/BsShkFDfbkWxozmMN

    Description:
        You are given two strings s and t of the same length, consisting of uppercase
        English letters. Your task is to find the minimum number of "replacement
        operations" needed to get some anagram of the string t from the string s. A
        replacement operation is performed by picking exactly one character from the
        string s and replacing it by some other character.
        Example
        For s = "AABAA" and t = "BBAAA", the output should be
        createAnagram(s, t) = 1;
        For s = "OVGHK" and t = "RPGUC", the output should be
        createAnagram(s, t) = 4.
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] string s
        Guaranteed constraints:
        5 ≤ s.length ≤ 35.
        [input] string t
        Guaranteed constraints:
        t.length = s.length.
        [output] integer
        The minimum number of replacement operations needed to get an anagram of the
        string t from the string s.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.MirrorLake
{
    class createAnagramClass
    {
        int createAnagram(string s, string t) {
            var sdic = s.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
            var tdic = t.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
            int result = 0;
            foreach(var si in sdic) {
                tdic.TryGetValue(si.Key, out int value);
                if (si.Value > value) {
                    result += si.Value - value;
                }
            }
            return result;
        }
    }
}
