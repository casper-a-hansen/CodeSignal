/*
    Status:   Solved
    Imported: 2020-04-26 13:12
    By:       Casper
    Url:      https://app.codesignal.com/arcade/intro/level-10/ppZ9zSufpjyzAsSEx

    Description:
        Given a string, find the shortest possible string which can be achieved by
        adding characters to the end of initial string to make it a palindrome.
        
        Example
        For st = "abcdc", the output should be
        buildPalindrome(st) = "abcdcba".
        Input/Output
        
        [execution time limit] 3 seconds (cs)
        
        [input] string st
        
        A string
        consisting of lowercase English letters.
        
        Guaranteed constraints:
        3 ≤ st.length
        ≤ 10.
        
        [output] string

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Intro.EruptionOfLight
{
    class buildPalindromeClass
    {
        string buildPalindrome(string st) {
            var endChar = st[st.Length - 1];
            var endPos = 0;
            string result;
            do
            {
                endPos = st.IndexOf(endChar, endPos);
                result = st + new String(st.Substring(0, endPos).Reverse().ToArray());
                endPos++;
            } while(!IsPalindrome(result));
            return result;
        }
         
        bool IsPalindrome(string st)
        {
            for(int i = 0, j = st.Length - 1; i < j; i++, j--)
            {
                if (st[i] != st[j]) return false;
            }
            return true;
        }
    }
}
