/*
    Status:   Solved
    Imported: 2020-04-26 13:22
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/mirror-lake/chW9F8bCgxYJBcgj3

    Description:
        Given two strings a and b, both consisting only of lowercase English letters,
        your task is to calculate how many strings equal to a can be constructed using
        only letters from the string b? Each letter can be used only once and in one
        string only.
        
        Example
        
        For a = "abc" and b = "abccba", the output should be
        stringsConstruction(a, b) = 2.
        
        We can construct 2 strings a = "abc" using only
        letters from the string b.
        
        For a = "ab" and b = "abcbcb", the output should be
        stringsConstruction(a, b) = 1.
        
        Input/Output
        
        [execution time limit] 3 seconds
        (cs)
        
        [input] string a
        
        String to construct, containing only lowercase English
        letters.
        
        Guaranteed constraints:
        1 ≤ a.length ≤ 105.
        
        [input] string b
        
        String
        containing needed letters, containing only lowercase English letters.
        Guaranteed constraints:
        1 ≤ b.length ≤ 105.
        
        [output] integer
        
        The number of
        strings a that can be constructed from the string b.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.MirrorLake
{
    class stringsConstructionClass
    {
        int stringsConstruction(string a, string b) {
            var dic = b.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
            if (a.Any(c => !dic.ContainsKey(c))) return 0;
            return a.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count()).Select(i => dic[i.Key] / i.Value).Min();
        }
    }
}
