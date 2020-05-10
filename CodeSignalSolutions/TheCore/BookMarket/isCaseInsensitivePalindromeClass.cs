/*
    Status:   Solved
    Imported: 2020-05-02 12:47
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/book-market/G9wj2j6zaWwFWsise

    Description:
        Given a string, check if it can become a palindrome through a case change of
        some (possibly, none) letters.
        Example
        For inputString = "AaBaa", the output should be
        isCaseInsensitivePalindrome(inputString) = true.
        "aabaa" is a palindrome as well as "AABAA", "aaBaa", etc.
        For inputString = "abac", the output should be
        isCaseInsensitivePalindrome(inputString) = false.
        All the strings which can be obtained via changing case of some group of
        letters, i.e. "abac", "Abac", "aBAc" and 13 more, are not palindromes.
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] string inputString
        Non-empty string consisting of English letters.
        Guaranteed constraints:
        4 ≤ inputString.length ≤ 10.
        [output] boolean
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.BookMarket
{
    class isCaseInsensitivePalindromeClass
    {
        bool isCaseInsensitivePalindrome(string inputString) {
            if (string.IsNullOrEmpty(inputString)) return true;
            for(var i = 0; i < inputString.Length / 2; i++)
            {
                if (!inputString[i].ToString().Equals(inputString[inputString.Length - i - 1].ToString(), StringComparison.OrdinalIgnoreCase))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
