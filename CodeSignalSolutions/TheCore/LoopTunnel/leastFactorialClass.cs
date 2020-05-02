/*
    Status:   Solved
    Imported: 2020-05-02 12:11
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/loop-tunnel/7BFPq6TpsNjzgcpXy

    Description:
        Given an integer n, find the minimal k such that
        k = m! (where m! = 1 * 2 * ... * m) for some integer m;
        k >= n.
        In other words, find the smallest factorial which is not less than n.
        Example
        For n = 17, the output should be
        leastFactorial(n) = 24.
        17 < 24 = 4! = 1 * 2 * 3 * 4, while 3! = 1 * 2 * 3 = 6 < 17).
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] integer n
        A positive integer.
        Guaranteed constraints:
        1 ≤ n ≤ 120.
        [output] integer
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.LoopTunnel
{
    class leastFactorialClass
    {
        int leastFactorial(int n) {
            if (n == 1) return 1;
            var result = 1;
            for(var i = 2; i < 12; i++)
            {
                result = result * i;
                if (result >= n) return result;
            }
            return -1;
        }
    }
}
