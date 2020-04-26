/*
    Status:   Solved
    Imported: 2020-04-26 12:22
    By:       Casper
    Url:      https://app.codesignal.com/arcade/intro/level-3/fzsCQGYbxaEcTr2bL

    Description:
        Given an array of strings, return another array containing all of its longest
        strings.
        
        Example
        
        For inputArray = ["aba", "aa", "ad", "vcd", "aba"], the
        output should be
        allLongestStrings(inputArray) = ["aba", "vcd", "aba"].
        Input/Output
        
        [execution time limit] 3 seconds (cs)
        
        [input] array.string
        inputArray
        
        A non-empty array.
        
        Guaranteed constraints:
        1 ≤ inputArray.length ≤
        10,
        1 ≤ inputArray[i].length ≤ 10.
        
        [output] array.string
        
        Array of the longest
        strings, stored in the same order as in the inputArray.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Intro.SmoothSailing
{
    class allLongestStringsClass
    {
        string[] allLongestStrings(string[] inputArray) {
            int maxLength = 0;
            List<string> result = new List<string>();
            foreach(var str in inputArray)
            {
                if (str.Length > maxLength)
                {
                    result.Clear();
                    maxLength = str.Length;
                }
                if (str.Length == maxLength)
                {
                    result.Add(str);
                }
            }
            return result.ToArray();
        }
    }
}
