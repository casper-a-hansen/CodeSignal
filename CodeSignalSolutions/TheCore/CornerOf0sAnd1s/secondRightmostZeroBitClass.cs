/*
    Status:   Solved
    Imported: 2020-05-02 12:10
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/corner-of-0s-and-1s/9nSj6DgqLDsBePJha

    Description:
        Presented with the integer n, find the 0-based position of the second rightmost
        zero bit in its binary representation (it is guaranteed that such a bit exists),
        counting from right to left.
        Return the value of 2position_of_the_found_bit.
        Example
        For n = 37, the output should be
        secondRightmostZeroBit(n) = 8.
        3710 = 1001012. The second rightmost zero bit is at position 3 (0-based) from
        the right in the binary representation of n.
        Thus, the answer is 23 = 8.
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] integer n
        Guaranteed constraints:
        4 ≤ n ≤ 230.
        [output] integer
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.CornerOf0sAnd1s
{
    class secondRightmostZeroBitClass
    {
        int secondRightmostZeroBit(int n)
        {
          return (int)Math.Pow(2, Convert.ToString(n, 2).Length - Convert.ToString(n, 2).LastIndexOf('0',Convert.ToString(n, 2).LastIndexOf('0') - 1) - 1);
        }
    }
}
