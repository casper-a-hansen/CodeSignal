/*
    Status:   Solved
    Imported: 2020-04-26 13:27
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/spring-of-integration/PSeEALZTxd93zBHS7

    Description:
        Consider a string containing only letters and whitespaces. It is allowed to
        replace some (possibly, none) whitespaces with newline symbols to obtain a
        multiline text. Call a multiline text beautiful if and only if each of its lines
        (i.e. substrings delimited by a newline character) contains an equal number of
        characters (only letters and whitespaces should be taken into account when
        counting the total while newline characters shouldn't). Call the length of the
        line the text width.
        
        Given a string and some integers l and r (l ≤ r), check if
        it's possible to obtain a beautiful text from the string with a text width
        that's within the range [l, r].
        
        Example
        
        For inputString = "Look at this
        example of a correct text", l = 5, and r = 15, the output should be
        beautifulText(inputString, l, r) = true.
        
        We can replace 13th and 26th
        characters with '\n', and obtain the following multiline text of width 12:
        
        Look
        at this
        example of a
        correct text
        
        
        For inputString = "abc def ghi", l = 4, and
        r = 10, the output should be
        beautifulText(inputString, l, r) = false.
        
        There
        are two ways to obtain a text with lines of equal length from this input, one
        has width = 3 and another has width = 11 (this is a one-liner). Both of these
        values are not within our bounds.
        
        Input/Output
        
        [execution time limit] 3
        seconds (cs)
        
        [input] string inputString
        
        Guaranteed constraints:
        10 ≤
        inputString.length ≤ 40.
        
        [input] integer l
        
        A positive integer.
        
        Guaranteed
        constraints:
        1 ≤ l ≤ r.
        
        [input] integer r
        
        A positive integer.
        
        Guaranteed
        constraints:
        l ≤ r ≤ 15.
        
        [output] boolean

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.SpringOfIntegration
{
    class beautifulTextClass
    {
        bool beautifulText(string inputString, int l, int r) {
            for(int len = l; len < r + 1; len ++) {
                if (CanBreak(inputString.Trim(), len)) return true;
            }
            return false;
        }
         
        bool CanBreak(string inputString, int len) {
            Console.WriteLine($"Testing len {len}");
            var pos = 0;
            while (pos < inputString.Length) {
                Console.WriteLine($"   \"{inputString.Substring(pos, Math.Min(inputString.Length - pos, len))}\"");
                var newPos = pos + len;
                if (newPos == inputString.Length) return true;
                if (newPos > inputString.Length) return false;
                if (inputString[newPos] != ' ') return false;
                while (newPos < inputString.Length && inputString[newPos] == ' ') {
                    newPos++;
                }
                pos = newPos;
            }
            return true;
        }
    }
}
