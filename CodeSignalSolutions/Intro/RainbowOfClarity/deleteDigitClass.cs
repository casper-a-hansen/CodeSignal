/*
    Status:   Solved
    Imported: 2020-04-26 13:13
    By:       Casper
    Url:      https://app.codesignal.com/arcade/intro/level-11/vpfeqDwGZSzYNm2uX

    Description:
        Given some integer, find the maximal number you can obtain by deleting exactly
        one digit of the given number.
        
        Example
        
        For n = 152, the output should be
        deleteDigit(n) = 52;
        For n = 1001, the output should be
        deleteDigit(n) = 101.
        Input/Output
        
        [execution time limit] 3 seconds (cs)
        
        [input] integer n
        Guaranteed constraints:
        10 ≤ n ≤ 106.
        
        [output] integer

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Intro.RainbowOfClarity
{
    class deleteDigitClass
    {
        int deleteDigit(int n) {
            var str = n.ToString();
            var index = 0;
            var min = str[0];
            for(var i = 1; i < str.Length; i++) {
                var c = str[i];
                if (c < min) {
                    min = c;
                    index = i;
                }
                if (c > min) break;
            }
            if (index == 0) {
                    str = str.Substring(1);
                Console.WriteLine("c:" + str);
                }
                else
                {
                    str = str.Substring(0, index) + str.Substring(index + 1);
                Console.WriteLine("d:" + str);
                }
            return int.Parse(str);
        }
    }
}
