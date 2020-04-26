/*
    Status:   Solved
    Imported: 2020-04-26 13:22
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/book-market/G9wj2j6zaWwFWsise

    Description:
        Given a string, check if it can become a palindrome through a case change of
        some (possibly, none) letters.
        
        Example
        
        For inputString = "AaBaa", the output
        should be
        isCaseInsensitivePalindrome(inputString) = true.
        
        "aabaa" is a
        palindrome as well as "AABAA", "aaBaa", etc.
        
        For inputString = "abac", the
        output should be
        isCaseInsensitivePalindrome(inputString) = false.
        
        All the
        strings which can be obtained via changing case of some group of letters, i.e.
        "abac", "Abac", "aBAc" and 13 more, are not palindromes.
        
        Input/Output
        [execution time limit] 3 seconds (cs)
        
        [input] string inputString
        
        Non-empty
        string consisting of English letters.
        
        Guaranteed constraints:
        4 ≤
        inputString.length ≤ 10.
        
        [output] boolean

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.BookMarket
{
    class isCaseInsensitivePalindromeClass
    {
        bool isCaseInsensitivePalindrome(string inputString) {
            return inputString.Equals(string.Join("", inputString.Reverse()), StringComparison.CurrentCultureIgnoreCase);
        }
    }
}
