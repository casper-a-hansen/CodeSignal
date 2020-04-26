/*
    Status:   Solved
    Imported: 2020-04-26 13:20
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/labyrinth-of-nested-loops/EQSjA5PRfyHueeNkj

    Description:
        Find the number of ways to express n as sum of some (at least two) consecutive
        positive integers.
        
        Example
        
        For n = 9, the output should be
        isSumOfConsecutive2(n) = 2.
        
        There are two ways to represent n = 9: 2 + 3 + 4 =
        9 and 4 + 5 = 9.
        
        For n = 8, the output should be
        isSumOfConsecutive2(n) = 0.
        There are no ways to represent n = 8.
        
        Input/Output
        
        [execution time limit] 3
        seconds (cs)
        
        [input] integer n
        
        A positive integer.
        
        Guaranteed constraints:
        1
        ≤ n ≤ 104.
        
        [output] integer

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.LabyrinthOfNestedLoops
{
    class isSumOfConsecutive2Class
    {
        int isSumOfConsecutive2(int n) {
            int result = 0;
            for(int i = 1; i < n; i++) {
                int sum = 0;
                for(int v = i; sum < n; v++) {
                    sum += v;
                }
                if (sum == n) {
                    result++;
                }
            }
            return result;
        }
    }
}
