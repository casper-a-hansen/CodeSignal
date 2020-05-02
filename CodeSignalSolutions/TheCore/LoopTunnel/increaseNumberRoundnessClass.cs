/*
    Status:   Solved
    Imported: 2020-05-02 12:11
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/loop-tunnel/KLbRMcWhaZi3dvYH5

    Description:
        Define an integer's roundness as the number of trailing zeroes in it.
        Given an integer n, check if it's possible to increase n's roundness by swapping
        some pair of its digits.
        Example
        For n = 902200100, the output should be
        increaseNumberRoundness(n) = true.
        One of the possible ways to increase roundness of n is to swap digit 1 with
        digit 0 preceding it: roundness of 902201000 is 3, and roundness of n is 2.
        For instance, one may swap the leftmost 0 with 1.
        For n = 11000, the output should be
        increaseNumberRoundness(n) = false.
        Roundness of n is 3, and there is no way to increase it.
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] integer n
        A positive integer.
        Guaranteed constraints:
        100 ≤ n ≤ 109.
        [output] boolean
        true if it's possible to increase n's roundness, false otherwise.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.LoopTunnel
{
    class increaseNumberRoundnessClass
    {
        bool increaseNumberRoundness(int n) {
            var s = n.ToString();
            var regex = new Regex("0[1-9]+0*$");
            return regex.IsMatch(s);
        }
    }
}
