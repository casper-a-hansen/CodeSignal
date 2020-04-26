/*
    Status:   Solved
    Imported: 2020-04-26 13:17
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/corner-of-0s-and-1s/e3zfPNTwTa9qTQzcX

    Description:
        Reverse the order of the bits in a given integer.
        
        Example
        
        For a = 97, the
        output should be
        mirrorBits(a) = 67.
        
        97 equals to 1100001 in binary, which is
        1000011 after mirroring, and that is 67 in base 10.
        
        For a = 8, the output
        should be
        mirrorBits(a) = 1.
        
        Input/Output
        
        [execution time limit] 3 seconds
        (cs)
        
        [input] integer a
        
        Guaranteed constraints:
        5 ≤ a ≤ 105.
        
        [output] integer

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.CornerOf0sAnd1s
{
    class mirrorBitsClass
    {
        int mirrorBits(int a) {
            return Convert.ToInt32(
                new string(
                    Convert.ToString(a, 2)
                    .Reverse()
                    .ToArray()), 2);
        }
    }
}
