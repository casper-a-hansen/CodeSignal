/*
    Status:   Solved
    Imported: 2020-04-26 13:10
    By:       Casper
    Url:      https://app.codesignal.com/arcade/intro/level-6/PWLT8GBrv9xXy4Dui

    Description:
        Given a string, your task is to replace each of its characters by the next one
        in the English alphabet; i.e. replace a with b, replace b with c, etc (z would
        be replaced by a).
        
        Example
        
        For inputString = "crazy", the output should be
        alphabeticShift(inputString) = "dsbaz".
        
        Input/Output
        
        [execution time limit] 3
        seconds (cs)
        
        [input] string inputString
        
        A non-empty string consisting of
        lowercase English characters.
        
        Guaranteed constraints:
        1 ≤ inputString.length ≤
        1000.
        
        [output] string
        
        The resulting string after replacing each of its
        characters.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Intro.RainsOfReason
{
    class alphabeticShiftClass
    {
        string alphabeticShift(string inputString) {
            return new string(inputString.Select(c => c == 'z' ? 'a' : (char)(c + 1)).ToArray());
         
        }
    }
}
