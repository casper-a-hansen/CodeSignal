/*
    Status:   Solved
    Imported: 2020-04-26 13:34
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/regular-hell/AMx2WqCoq2PEcJTEp

    Description:
        You are given a string consisting of words separated by whitespace characters,
        where the words consist only of English letters. Your task is to swap pairs of
        consecutive words and return the result.
        
        Example
        
        For s = "CodeFight On", the
        output should be
        swapAdjacentWords(s) = "On CodeFight";
        For s = "How are you
        today guys", the output should be
        swapAdjacentWords(s) = "are How today you
        guys".
        
        Input/Output
        
        [execution time limit] 3 seconds (cs)
        
        [input] string s
        
        A
        string consisting of whitespace characters (' ') and English letters. There is
        exactly one whitespace character between two consecutive words, and both the
        first and the last characters of s are not equal to ' '.
        
        Guaranteed
        constraints:
        0 ≤ s.length ≤ 100.
        
        [output] string
        
        String s with pairs of
        adjacent words swapped.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.RegularHell
{
    class swapAdjacentWordsClass
    {
        string swapAdjacentWords(string s) {
          return Regex.Replace(s, @"\b(\w+)\s+(\w+)\b", "$2 $1");
        }
    }
}
