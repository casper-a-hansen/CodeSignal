/*
    Status:   Solved
    Imported: 2020-04-26 13:16
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/at-the-crossroads/sgDWKCFQHHi5D3Szj

    Description:
        You're given three integers, a, b and c. It is guaranteed that two of these
        integers are equal to each other. What is the value of the third integer?
        Example
        
        For a = 2, b = 7, and c = 2, the output should be
        extraNumber(a, b, c)
        = 7.
        
        The two equal numbers are a and c. The third number (b) equals 7, which is
        the answer.
        
        Input/Output
        
        [execution time limit] 3 seconds (cs)
        
        [input]
        integer a
        
        Guaranteed constraints:
        1 ≤ a ≤ 109.
        
        [input] integer b
        
        Guaranteed
        constraints:
        1 ≤ b ≤ 109.
        
        [input] integer c
        
        Guaranteed constraints:
        1 ≤ c ≤
        109.
        
        [output] integer

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.AtTheCrossroads
{
    class extraNumberClass
    {
        int extraNumber(int a, int b, int c) {
            if (a == b) {
                return c;
            } else if (a == c) {
                return b;
            } else if (b == c) {
                return a;
            }
            return -1;
        }
    }
}
