/*
    Status:   Solved
    Imported: 2020-05-02 12:12
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/loop-tunnel/H5PP5MXvYvWXxTytH

    Description:
        We want to turn the given integer into a number that has only one non-zero digit
        using a tail rounding approach. This means that at each step we take the last
        non 0 digit of the number and round it to 0 or to 10. If it's less than 5 we
        round it to 0 if it's larger than or equal to 5 we round it to 10 (rounding to
        10 means increasing the next significant digit by 1). The process stops
        immediately once there is only one non-zero digit left.
        Example
        For n = 15, the output should be
        rounders(n) = 20;
        For n = 1234, the output should be
        rounders(n) = 1000.
        1234 -> 1230 -> 1200 -> 1000.
        For n = 1445, the output should be
        rounders(n) = 2000.
        1445 -> 1450 -> 1500 -> 2000.
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] integer n
        A positive integer.
        Guaranteed constraints:
        1 ≤ value ≤ 108.
        [output] integer
        The rounded number.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.LoopTunnel
{
    class roundersClass
    {
        int rounders(int n) {
            var digit = 0;
            var mente = 0;
            var count = -1;
            foreach(var d in n.ToString().Reverse()) {
                digit = d - '0' + mente;
                mente = digit >= 5 ? 1 : 0;
                count++;
            }
            return (digit) * (int)Math.Pow(10, count);
        }
    }
}
