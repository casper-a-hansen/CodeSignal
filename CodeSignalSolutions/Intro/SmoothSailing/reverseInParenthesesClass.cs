/*
    Status:   Solved
    Imported: 2020-04-26 12:22
    By:       Casper
    Url:      https://app.codesignal.com/arcade/intro/level-3/9DgaPsE2a7M6M2Hu6

    Description:
        Write a function that reverses characters in (possibly nested) parentheses in
        the input string.
        
        Input strings will always be well-formed with matching ()s.
        Example
        
        For inputString = "(bar)", the output should be
        reverseInParentheses(inputString) = "rab";
        For inputString = "foo(bar)baz", the
        output should be
        reverseInParentheses(inputString) = "foorabbaz";
        For
        inputString = "foo(bar)baz(blim)", the output should be
        reverseInParentheses(inputString) = "foorabbazmilb";
        For inputString =
        "foo(bar(baz))blim", the output should be
        reverseInParentheses(inputString) =
        "foobazrabblim".
        Because "foo(bar(baz))blim" becomes "foo(barzab)blim" and then
        "foobazrabblim".
        
        Input/Output
        
        [execution time limit] 3 seconds (cs)
        
        [input]
        string inputString
        
        A string consisting of lowercase English letters and the
        characters ( and ). It is guaranteed that all parentheses in inputString form a
        regular bracket sequence.
        
        Guaranteed constraints:
        0 ≤ inputString.length ≤ 50.
        [output] string
        
        Return inputString, with all the characters that were in
        parentheses reversed.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Intro.SmoothSailing
{
    class reverseInParenthesesClass
    {
        string reverseInParentheses(string inputString) {
            int i = 0;
            return HandleParentheses(inputString, ref i);
        }
        string HandleParentheses(string inputString, ref int i) {
            StringBuilder result = new StringBuilder(inputString.Length);
            while(i < inputString.Length) {
                var c = inputString[i];
                if (c == ')')
                {
                    i++;
                    break;
                }
                else if (c == '(')
                {
                    i++;
                    var tmp = Reverse(HandleParentheses(inputString, ref i));
                    result.Append(tmp);
                }
                else
                {
                    result.Append(c);
                    i++;
                }
            }
            return result.ToString();
        }
        string Reverse(string inputString)
        {
            return new string(inputString.Reverse().ToArray());
        }
    }
}
