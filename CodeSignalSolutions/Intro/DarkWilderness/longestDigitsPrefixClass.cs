/*
    Status:   Solved
    Imported: 2020-04-26 13:11
    By:       Casper
    Url:      https://app.codesignal.com/arcade/intro/level-9/AACpNbZANCkhHWNs3

    Description:
        Given a string, output its longest prefix which contains only digits.
        
        Example
        For inputString = "123aa1", the output should be
        longestDigitsPrefix(inputString) = "123".
        
        Input/Output
        
        [execution time limit]
        3 seconds (cs)
        
        [input] string inputString
        
        Guaranteed constraints:
        3 ≤
        inputString.length ≤ 100.
        
        [output] string

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Intro.DarkWilderness
{
    class longestDigitsPrefixClass
    {
        string longestDigitsPrefix(string inputString) {
            var regex = new Regex(@"^\d+");
            var match = regex.Match(inputString);
            if (match.Success) return match.Value;
            return "";
        }
    }
}
