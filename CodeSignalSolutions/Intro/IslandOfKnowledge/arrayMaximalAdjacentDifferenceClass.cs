/*
    Status:   Solved
    Imported: 2020-05-02 11:59
    By:       Casper
    Url:      https://app.codesignal.com/arcade/intro/level-5/EEJxjQ7oo7C5wAGjE

    Description:
        Given an array of integers, find the maximal absolute difference between any two
        of its adjacent elements.
        Example
        For inputArray = [2, 4, 1, 0], the output should be
        arrayMaximalAdjacentDifference(inputArray) = 3.
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] array.integer inputArray
        Guaranteed constraints:
        3 ≤ inputArray.length ≤ 10,
        -15 ≤ inputArray[i] ≤ 15.
        [output] integer
        The maximal absolute difference.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Intro.IslandOfKnowledge
{
    class arrayMaximalAdjacentDifferenceClass
    {
        int arrayMaximalAdjacentDifference(int[] inputArray) {
            var max = int.MinValue;
            for(var i = 0; i < inputArray.Length - 1; i++)
            {
                var diff = Math.Abs(inputArray[i] - inputArray[i + 1]);
                if (max < diff)
                {
                    max = diff;
                }
            }
            return max;
        }
    }
}
