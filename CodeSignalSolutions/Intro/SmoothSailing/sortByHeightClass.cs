/*
    Status:   Solved
    Imported: 2020-04-26 12:22
    By:       Casper
    Url:      https://app.codesignal.com/arcade/intro/level-3/D6qmdBL2NYz49XHwM

    Description:
        Some people are standing in a row in a park. There are trees between them which
        cannot be moved. Your task is to rearrange the people by their heights in a
        non-descending order without moving the trees. People can be very tall!
        
        Example
        For a = [-1, 150, 190, 170, -1, -1, 160, 180], the output should be
        sortByHeight(a) = [-1, 150, 160, 170, -1, -1, 180, 190].
        
        Input/Output
        [execution time limit] 3 seconds (cs)
        
        [input] array.integer a
        
        If a[i] = -1,
        then the ith position is occupied by a tree. Otherwise a[i] is the height of a
        person standing in the ith position.
        
        Guaranteed constraints:
        1 ≤ a.length ≤
        1000,
        -1 ≤ a[i] ≤ 1000.
        
        [output] array.integer
        
        Sorted array a with all the
        trees untouched.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Intro.SmoothSailing
{
    class sortByHeightClass
    {
        int[] sortByHeight(int[] a) {
            var people = a.Where(h => h != -1).OrderBy(h => h).ToArray();
            var p = 0;
            for(var i = 0; i < a.Length; i++)
            {
                if (a[i] != -1)
                {
                    a[i] = people[p];
                    p++;
                }
            }
            return a;
        }
    }
}
