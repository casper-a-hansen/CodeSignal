/*
    Status:   Solved
    Imported: 2020-04-26 13:09
    By:       Casper
    Url:      https://app.codesignal.com/arcade/intro/level-5/XC9Q2DhRRKQrfLhb5

    Description:
        You are given an array of integers representing coordinates of obstacles
        situated on a straight line.
        
        Assume that you are jumping from the point with
        coordinate 0 to the right. You are allowed only to make jumps of the same length
        represented by some integer.
        
        Find the minimal length of the jump enough to
        avoid all the obstacles.
        
        Example
        
        For inputArray = [5, 3, 6, 7, 9], the output
        should be
        avoidObstacles(inputArray) = 4.
        
        Check out the image below for better
        understanding:
        
        Input/Output
        
        [execution time limit] 3 seconds (cs)
        
        [input]
        array.integer inputArray
        
        Non-empty array of positive integers.
        
        Guaranteed
        constraints:
        2 ≤ inputArray.length ≤ 1000,
        1 ≤ inputArray[i] ≤ 1000.
        
        [output]
        integer
        
        The desired length.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Intro.IslandOfKnowledge
{
    class avoidObstaclesClass
    {
        int avoidObstacles(int[] inputArray) {
            var hash = new HashSet<int>(inputArray.Select(i => i));
            var max = inputArray.Max();
            for(var result = 1; result <= max + 1; result++)
            {
                var hit = false;
                for(var p = result; p <= max+1; p += result)
                {
                    hit = hash.Contains(p);
                    if (hit) break;
                }
                if (!hit) return result;
            }
            return -1;
        }
    }
}
