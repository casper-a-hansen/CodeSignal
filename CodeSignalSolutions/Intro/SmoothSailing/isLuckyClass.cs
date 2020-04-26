/*
    Status:   Solved
    Imported: 2020-04-26 12:22
    By:       Casper
    Url:      https://app.codesignal.com/arcade/intro/level-3/3AdBC97QNuhF6RwsQ

    Description:
        Ticket numbers usually consist of an even number of digits. A ticket number is
        considered lucky if the sum of the first half of the digits is equal to the sum
        of the second half.
        
        Given a ticket number n, determine if it's lucky or not.
        Example
        
        For n = 1230, the output should be
        isLucky(n) = true;
        For n = 239017,
        the output should be
        isLucky(n) = false.
        
        Input/Output
        
        [execution time limit] 3
        seconds (cs)
        
        [input] integer n
        
        A ticket number represented as a positive
        integer with an even number of digits.
        
        Guaranteed constraints:
        10 ≤ n < 106.
        [output] boolean
        
        true if n is a lucky ticket number, false otherwise.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Intro.SmoothSailing
{
    class isLuckyClass
    {
        bool isLucky(int n) {
            var digits = n.ToString().Select(c => int.Parse(c.ToString())).ToArray();
            var half = digits.Length / 2;
         
            var sum1 = digits.Take(half).Sum();
            var sum2 = digits.Skip(half).Sum();
            return sum1 == sum2;
        }
    }
}
