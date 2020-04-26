/*
    Status:   Solved
    Imported: 2020-04-26 13:21
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/book-market/K2ieDm98sPDzzMepz

    Description:
        Given a string, enclose it in round brackets.
        
        Example
        
        For inputString =
        "abacaba", the output should be
        encloseInBrackets(inputString) = "(abacaba)".
        Input/Output
        
        [execution time limit] 3 seconds (cs)
        
        [input] string inputString
        Guaranteed constraints:
        0 ≤ inputString.length ≤ 10.
        
        [output] string

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.BookMarket
{
    class encloseInBracketsClass
    {
        string encloseInBrackets(string inputString) {
            return "(" + inputString + ")";
        }
    }
}
