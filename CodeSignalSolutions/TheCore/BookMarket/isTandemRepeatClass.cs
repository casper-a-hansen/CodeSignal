/*
    Status:   Solved
    Imported: 2020-04-26 13:22
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/book-market/2SDWWyHY9Xw5CpphY

    Description:
        Determine whether the given string can be obtained by one concatenation of some
        string to itself.
        
        Example
        
        For inputString = "tandemtandem", the output should
        be
        isTandemRepeat(inputString) = true;
        For inputString = "qqq", the output
        should be
        isTandemRepeat(inputString) = false;
        For inputString = "2w2ww", the
        output should be
        isTandemRepeat(inputString) = false.
        
        Input/Output
        
        [execution
        time limit] 3 seconds (cs)
        
        [input] string inputString
        
        Guaranteed constraints:
        2 ≤ inputString.length ≤ 20.
        
        [output] boolean
        
        true if inputString represents a
        string concatenated to itself, false otherwise.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.BookMarket
{
    class isTandemRepeatClass
    {
        bool isTandemRepeat(string inputString) {
             if (inputString.Length % 2 != 0) return false;
             return inputString.Substring(0, inputString.Length / 2) == inputString.Substring(inputString.Length / 2);
        }
    }
}
