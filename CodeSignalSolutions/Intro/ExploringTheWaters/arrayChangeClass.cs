/*
    Status:   Solved
    Imported: 2020-04-26 12:39
    By:       Casper
    Url:      https://app.codesignal.com/arcade/intro/level-4/xvkRbxYkdHdHNCKjg

    Description:
        You are given an array of integers. On each move you are allowed to increase
        exactly one of its element by one. Find the minimal number of moves required to
        obtain a strictly increasing sequence from the input.
        
        Example
        
        For inputArray =
        [1, 1, 1], the output should be
        arrayChange(inputArray) = 3.
        
        Input/Output
        [execution time limit] 3 seconds (cs)
        
        [input] array.integer inputArray
        Guaranteed constraints:
        3 ≤ inputArray.length ≤ 105,
        -105 ≤ inputArray[i] ≤ 105.
        [output] integer
        
        The minimal number of moves needed to obtain a strictly
        increasing sequence from inputArray.
        It's guaranteed that for the given test
        cases the answer always fits signed 32-bit integer type.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Intro.ExploringTheWaters
{
    class arrayChangeClass
    {
        int arrayChange(int[] inputArray) {
            // adjust
            int last = int.MinValue;
            int result = 0;
            for(var i = 0; i < inputArray.Length; i++)
            {
                var v = inputArray[i];
                if (last >= v)
                {
                    result += last + 1 - v;
                    last = last + 1;
                }
                else
                {
                    last = v;
                }
            }
            return result;
        }
    }
}
