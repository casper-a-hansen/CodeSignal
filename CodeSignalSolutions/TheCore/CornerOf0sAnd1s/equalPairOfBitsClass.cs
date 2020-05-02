/*
    Status:   Solved
    Imported: 2020-05-02 12:10
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/corner-of-0s-and-1s/6SLJChm9N3fEgr2R7

    Description:
        You're given two integers, n and m. Find position of the rightmost pair of equal
        bits in their binary representations (it is guaranteed that such a pair exists),
        counting from right to left.
        Return the value of 2position_of_the_found_pair (0-based).
        Example
        For n = 10 and m = 11, the output should be
        equalPairOfBits(n, m) = 2.
        1010 = 10102, 1110 = 10112, the position of the rightmost pair of equal bits is
        the bit at position 1 (0-based) from the right in the binary representations.
        So the answer is 21 = 2.
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] integer n
        Guaranteed constraints:
        0 ≤ n ≤ 230.
        [input] integer m
        Guaranteed constraints:
        0 ≤ m ≤ 230.
        [output] integer
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.CornerOf0sAnd1s
{
    class equalPairOfBitsClass
    {
        int equalPairOfBits(int n, int m)
        {
          return 1 << (Enumerable.Range(0,31).First(b => (n&(1<<b))==(m&(1<<b))));
        }
    }
}
