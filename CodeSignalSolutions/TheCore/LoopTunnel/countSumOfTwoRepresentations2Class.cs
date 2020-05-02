/*
    Status:   Solved
    Imported: 2020-05-02 12:11
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/loop-tunnel/hBw5BJiZ4LmXcy92u

    Description:
        Given integers n, l and r, find the number of ways to represent n as a sum of
        two integers A and B such that l ≤ A ≤ B ≤ r.
        Example
        For n = 6, l = 2, and r = 4, the output should be
        countSumOfTwoRepresentations2(n, l, r) = 2.
        There are just two ways to write 6 as A + B, where 2 ≤ A ≤ B ≤ 4: 6 = 2 + 4 and
        6 = 3 + 3.
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] integer n
        A positive integer.
        Guaranteed constraints:
        5 ≤ n ≤ 109.
        [input] integer l
        A positive integer.
        Guaranteed constraints:
        1 ≤ l ≤ r.
        [input] integer r
        A positive integer.
        Guaranteed constraints:
        l ≤ r ≤ 109,
        r - l ≤ 106.
        [output] integer
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.LoopTunnel
{
    class countSumOfTwoRepresentations2Class
    {
        int countSumOfTwoRepresentations2(int n, int l, int r) {
            var start = Math.Max(l, n - r);
            var end = Math.Min(r, n - l);
            var middle = (start + end) / 2;
            Console.WriteLine($"Area: {start}-{end}  Middle: {middle}");
            return Math.Max(0, middle - start + 1);
        }
    }
}
