/*
    Status:   Solved
    Imported: 2020-04-26 13:23
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/mirror-lake/BLbGNY3kEcvKjBCFC

    Description:
        Let's call two integers A and B friends if each integer from the array divisors
        is either a divisor of both A and B or neither A nor B. If two integers are
        friends, they are said to be in the same clan. How many clans are the integers
        from 1 to k, inclusive, broken into?
        
        Example
        
        For divisors = [2, 3] and k = 6,
        the output should be
        numberOfClans(divisors, k) = 4.
        
        The numbers 1 and 5 are
        friends and form a clan, 2 and 4 are friends and form a clan, and 3 and 6 do not
        have friends and each is a clan by itself. So the numbers 1 through 6 are broken
        into 4 clans.
        
        Input/Output
        
        [execution time limit] 3 seconds (cs)
        
        [input]
        array.integer divisors
        
        A non-empty array of positive integers.
        
        Guaranteed
        constraints:
        2 ≤ divisors.length < 10,
        1 ≤ divisors[i] ≤ 10.
        
        [input] integer k
        A positive integer.
        
        Guaranteed constraints:
        5 ≤ k ≤ 10.
        
        [output] integer

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.MirrorLake
{
    class numberOfClansClass
    {
        int numberOfClans(int[] divisors, int k) {
            return Enumerable.Range(1, k).Select(i => (Value: i, Divisors: string.Join("", divisors.Select(d => i % d == 0 ? 
        "T" : "F")))).GroupBy(t => t.Divisors).Count();
        }
    }
}
