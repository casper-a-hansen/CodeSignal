/*
    Status:   Solved
    Imported: 2020-05-02 11:54
    By:       Casper
    Url:      https://app.codesignal.com/arcade/intro/level-4/xYXfzQmnhBvEKJwXP

    Description:
        Two arrays are called similar if one can be obtained from another by swapping at
        most one pair of elements in one of the arrays.
        Given two arrays a and b, check whether they are similar.
        Example
        For a = [1, 2, 3] and b = [1, 2, 3], the output should be
        areSimilar(a, b) = true.
        The arrays are equal, no need to swap any elements.
        For a = [1, 2, 3] and b = [2, 1, 3], the output should be
        areSimilar(a, b) = true.
        We can obtain b from a by swapping 2 and 1 in b.
        For a = [1, 2, 2] and b = [2, 1, 1], the output should be
        areSimilar(a, b) = false.
        Any swap of any two elements either in a or in b won't make a and b equal.
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] array.integer a
        Array of integers.
        Guaranteed constraints:
        3 ≤ a.length ≤ 105,
        1 ≤ a[i] ≤ 1000.
        [input] array.integer b
        Array of integers of the same length as a.
        Guaranteed constraints:
        b.length = a.length,
        1 ≤ b[i] ≤ 1000.
        [output] boolean
        true if a and b are similar, false otherwise.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Intro.ExploringTheWaters
{
    class areSimilarClass
    {
        bool areSimilar(int[] a, int[] b) {
            int error = -1;
            for(var i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                {
                    if (error == -2)
                    {
                        return false;  // More than once
                    }
                    else if (error == -1)
                    {
                        error = i;  // First difference
                    }
                    else
                    {
                        if  (a[error] == b[i] && b[error] == a[i])
                        {
                            error = -2;  // Next difference is just a swaop
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
    }
}
