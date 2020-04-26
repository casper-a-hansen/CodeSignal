/*
    Status:   Solved
    Imported: 2020-04-26 12:21
    By:       Casper
    Url:      https://app.codesignal.com/arcade/intro/level-1/s5PbmwxfECC52PWyQ

    Description:
        Given the string, check if it is a palindrome.
        
        Example
        
        For inputString =
        "aabaa", the output should be
        checkPalindrome(inputString) = true;
        For
        inputString = "abac", the output should be
        checkPalindrome(inputString) = false;
        For inputString = "a", the output should be
        checkPalindrome(inputString) = true.
        Input/Output
        
        [execution time limit] 3 seconds (cs)
        
        [input] string inputString
        A non-empty string consisting of lowercase characters.
        
        Guaranteed constraints:
        1 ≤ inputString.length ≤ 105.
        
        [output] boolean
        
        true if inputString is a
        palindrome, false otherwise.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Intro.TheJourneyBegins
{
    class checkPalindromeClass
    {
        bool checkPalindrome(string inputString) {
            for(int i = 0; i < inputString.Length / 2; i++)
            {
                var start = inputString[i];
                var end = inputString[inputString.Length - 1 - i];
                if (end != start)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
