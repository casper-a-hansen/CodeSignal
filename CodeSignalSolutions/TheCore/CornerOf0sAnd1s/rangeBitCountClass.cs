/*
    Status:   Solved
    Imported: 2020-04-26 13:17
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/corner-of-0s-and-1s/eC2Zxu5H5SnuKxvPT

    Description:
        You are given two numbers a and b where 0 ≤ a ≤ b. Imagine you construct an
        array of all the integers from a to b inclusive. You need to count the number of
        1s in the binary representations of all the numbers in the array.
        
        Example
        
        For
        a = 2 and b = 7, the output should be
        rangeBitCount(a, b) = 11.
        
        Given a = 2 and
        b = 7 the array is: [2, 3, 4, 5, 6, 7]. Converting the numbers to binary, we get
        [10, 11, 100, 101, 110, 111], which contains 1 + 2 + 1 + 2 + 2 + 3 = 11 1s.
        Input/Output
        
        [execution time limit] 3 seconds (cs)
        
        [input] integer a
        Guaranteed constraints:
        0 ≤ a ≤ b.
        
        [input] integer b
        
        Guaranteed constraints:
        a
        ≤ b ≤ 10.
        
        [output] integer

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.CornerOf0sAnd1s
{
    class rangeBitCountClass
    {
        int rangeBitCount(int a, int b) {
            return Enumerable.Range(a, b - a + 1).Sum(v => Ones(v));
        }
         
        int Ones(int value) {
            switch(value)
            {
                case 0: return 0;
                case 1: 
                case 2: 
                case 4: 
                case 8: return 1;
                case 3: 
                case 5: 
                case 6: 
                case 9: 
                case 10: return 2;
                case 7: return 3;
                default: return int.MinValue;
            }
        }
    }
}
