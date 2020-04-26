/*
    Status:   Solved
    Imported: 2020-04-26 13:24
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/well-of-integration/Z9opBsx5fX6XfQJdt

    Description:
        Check whether the given string is a subsequence of the plaintext alphabet.
        Example
        
        For s = "effg", the output should be
        alphabetSubsequence(s) = false;
        For s = "cdce", the output should be
        alphabetSubsequence(s) = false;
        For s =
        "ace", the output should be
        alphabetSubsequence(s) = true;
        For s = "bxz", the
        output should be
        alphabetSubsequence(s) = true.
        
        Input/Output
        
        [execution time
        limit] 3 seconds (cs)
        
        [input] string s
        
        Guaranteed constraints:
        2 ≤ s.length ≤
        15.
        
        [output] boolean
        
        true if the given string is a subsequence of the
        alphabet, false otherwise.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.WellOfIntegration
{
    class alphabetSubsequenceClass
    {
        bool alphabetSubsequence(string s) {
            var prevChar = '0';
            foreach(var c in s) {
                if (c <= prevChar) return false;
                prevChar = c;
            }
            return true;
        }
    }
}
