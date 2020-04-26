/*
    Status:   Solved
    Imported: 2020-04-26 13:14
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/intro-gates/wAGdN6FMPkx7WBq66

    Description:
        You are given a two-digit integer n. Return the sum of its digits.
        
        Example
        
        For
        n = 29, the output should be
        addTwoDigits(n) = 11.
        
        Input/Output
        
        [execution
        time limit] 3 seconds (cs)
        
        [input] integer n
        
        A positive two-digit integer.
        Guaranteed constraints:
        10 ≤ n ≤ 99.
        
        [output] integer
        
        The sum of the first and
        second digits of the input number.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.IntroGates
{
    class addTwoDigitsClass
    {
        int addTwoDigits(int n) {
            return n.ToString().Sum(c => (int)c - '0');
        }
    }
}
