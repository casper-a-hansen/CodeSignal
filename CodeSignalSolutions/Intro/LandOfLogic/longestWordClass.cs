/*
    Status:   Solved
    Imported: 2020-04-26 13:13
    By:       Casper
    Url:      https://app.codesignal.com/arcade/intro/level-12/s9qvXv4yTaWg8g4ma

    Description:
        Define a word as a sequence of consecutive English letters. Find the longest
        word from the given string.
        
        Example
        
        For text = "Ready, steady, go!", the
        output should be
        longestWord(text) = "steady".
        
        Input/Output
        
        [execution time
        limit] 3 seconds (cs)
        
        [input] string text
        
        Guaranteed constraints:
        4 ≤
        text.length ≤ 50.
        
        [output] string
        
        The longest word from text. It's guaranteed
        that there is a unique output.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Intro.LandOfLogic
{
    class longestWordClass
    {
        string longestWord(string text) {
            var regex = new Regex(@"\b[a-z]+\b", RegexOptions.IgnoreCase);
            string longest = "";
            foreach(Match m in regex.Matches(text)) {
                if (longest.Length < m.Value.Length)
                    longest = m.Value;
            }
            return longest;
        }
    }
}
