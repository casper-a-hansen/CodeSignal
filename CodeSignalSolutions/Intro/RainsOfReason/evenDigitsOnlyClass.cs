/*
    Status:   Solved
    Imported: 2020-04-26 13:10
    By:       Casper
    Url:      https://app.codesignal.com/arcade/intro/level-6/6cmcmszJQr6GQzRwW

    Description:
        Check if all digits of the given integer are even.
        
        Example
        
        For n = 248622, the
        output should be
        evenDigitsOnly(n) = true;
        For n = 642386, the output should be
        evenDigitsOnly(n) = false.
        
        Input/Output
        
        [execution time limit] 3 seconds (cs)
        [input] integer n
        
        Guaranteed constraints:
        1 ≤ n ≤ 109.
        
        [output] boolean
        
        true
        if all digits of n are even, false otherwise.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Intro.RainsOfReason
{
    class evenDigitsOnlyClass
    {
        bool evenDigitsOnly(int n) {
            var evenDigits = new HashSet<Char>(){'0', '2', '4', '6', '8'};
            return n.ToString().All(c => evenDigits.Contains(c));
        }
    }
}
