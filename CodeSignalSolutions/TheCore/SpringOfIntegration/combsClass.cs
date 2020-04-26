/*
    Status:   Solved
    Imported: 2020-04-26 13:27
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/spring-of-integration/6ceKutpnCs4LzBKgf

    Description:
        Miss X has only two combs in her possession, both of which are old and miss a
        tooth or two. She also has many purses of different length, in which she carries
        the combs. The only way they fit is horizontally and without overlapping. Given
        teeth' positions on both combs, find the minimum length of the purse she needs
        to take them with her.
        
        It is guaranteed that there is at least one tooth at
        each end of the comb.
        It is also guaranteed that the total length of two strings
        is smaller than 32.
        Note, that the combs can not be rotated/reversed.
        
        Example
        For comb1 = "*..*" and comb2 = "*.*", the output should be
        combs(comb1, comb2) =
        5.
        
        Although it is possible to place the combs like on the first picture, the
        best way to do this is either picture 2 or picture 3.
        
        Input/Output
        
        [execution
        time limit] 3 seconds (cs)
        
        [input] string comb1
        
        A comb is represented as a
        string. If there is an asterisk ('*') in the ith position, there is a tooth
        there. Otherwise there is a dot ('.'), which means there is a missing tooth on
        the comb.
        
        Guaranteed constraints:
        3 ≤ comb1.length ≤ 8.
        
        [input] string comb2
        The second comb is represented in the same way as the first one.
        
        Guaranteed
        constraints:
        1 ≤ comb2.length ≤ 5.
        
        [output] integer
        
        The minimum length of a
        purse Miss X needs.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.SpringOfIntegration
{
    class combsClass
    {
        int combs(string comb1, string comb2) {
            return Math.Min(combs2(comb1,comb2), combs2(comb2,comb1));
        }
         
        int combs2(string comb1, string comb2) {
            for(var o = 1; o < comb1.Length; o++) {
                var success = true;
                var max = Math.Min(comb1.Length - o, comb2.Length);
                for(var i = 0; i < max; i++) {
                    success = comb1[i+o] != '*' || comb2[i] != '*';
                    if (!success) break;
                }
                if (success) return Math.Max(comb1.Length, comb2.Length + o);
            }
            return comb1.Length + comb2.Length;
        }
    }
}
