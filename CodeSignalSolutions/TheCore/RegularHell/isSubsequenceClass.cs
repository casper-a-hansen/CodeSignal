/*
    Status:   Solved
    Imported: 2020-04-26 13:34
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/regular-hell/E6eYu8dsfwch2My27

    Description:
        Given a string s, determine if it is a subsequence of a given string t.
        
        Example
        For t = "CodeSignal" and s = "CoSi", the output should be
        isSubsequence(t, s) =
        true;
        
        For t = "CodeSignal" and s = "cosi", the output should be
        the output
        should be
        isSubsequence(t, s) = false.
        
        Input/Output
        
        [execution time limit] 3
        seconds (cs)
        
        [input] string t
        
        A string consisting of English letters,
        whitespace characters (' '), digits and punctuation marks (".,?!=*+-").
        Guaranteed constraints:
        0 ≤ t.length ≤ 500.
        
        [input] string s
        
        A string
        consisting of English letters, whitespace characters (' '), digits and
        punctuation marks (".,?!=*+-").
        
        Guaranteed constraints:
        0 ≤ s.length ≤ 50.
        [output] boolean
        
        true if the s is a subsequence of t, false otherwise.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.RegularHell
{
    class isSubsequenceClass
    {
        bool isSubsequence(string t, string s)
        {
          string pattern = "";
          foreach (char ch in s)
          {
            pattern += (".?*+".Contains(ch) ? "\\" + ch : ch.ToString()) + ".*?";
          }
          Regex regex = new Regex(pattern);
          return regex.Match(t).Success;
        }
    }
}
