/*
    Status:   Solved
    Imported: 2020-04-26 13:17
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/corner-of-0s-and-1s/dShYZZT4WmvpmfpgB

    Description:
        You're given an arbitrary 32-bit integer n. Take its binary representation,
        split bits into it in pairs (bit number 0 and 1, bit number 2 and 3, etc.) and
        swap bits in each pair. Then return the result as a decimal number.
        
        Example
        For n = 13, the output should be
        swapAdjacentBits(n) = 14.
        
        1310 = 11012 ~>
        {11}{01}2 ~> 11102 = 1410.
        
        For n = 74, the output should be
        swapAdjacentBits(n)
        = 133.
        
        7410 = 010010102 ~> {01}{00}{10}{10}2 ~> 100001012 = 13310.
        Note the
        preceding zero written in front of the initial number: since both numbers are
        32-bit integers, they have 32 bits in their binary representation. The preceding
        zeros in other cases don't matter, so they are omitted. Here, however, it does
        make a difference.
        
        Input/Output
        
        [execution time limit] 3 seconds (cs)
        
        [input]
        integer n
        
        Guaranteed constraints:
        0 ≤ n < 230.
        
        [output] integer

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.CornerOf0sAnd1s
{
    class swapAdjacentBitsClass
    {
        int swapAdjacentBits(int n)
        {
          return (int)((((uint)n & 0x55555555) << 1) | (((uint)n & 0xAAAAAAAA) >> 1));
        }
    }
}
