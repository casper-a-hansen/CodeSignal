/*
    Status:   Solved
    Imported: 2020-04-26 13:19
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/list-forest-edge/ND8nghbndTNKPP4Tb

    Description:
        Reversing an array can be a tough task, especially for a novice programmer. Mary
        just started coding, so she would like to start with something basic at first.
        Instead of reversing the array entirely, she wants to swap just its first and
        last elements.
        
        Given an array arr, swap its first and last elements and return
        the resulting array.
        
        Example
        
        For arr = [1, 2, 3, 4, 5], the output should be
        firstReverseTry(arr) = [5, 2, 3, 4, 1].
        
        Input/Output
        
        [execution time limit] 3
        seconds (cs)
        
        [input] array.integer arr
        
        Guaranteed constraints:
        0 ≤ arr.length
        ≤ 50,
        -104 ≤ arr[i] ≤ 104.
        
        [output] array.integer
        
        Array arr with its first and
        its last elements swapped.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.ListForestEdge
{
    class firstReverseTryClass
    {
        int[] firstReverseTry(int[] arr) {
            if (arr.Length < 2) return arr;
            var first = arr[0];
            var last = arr[arr.Length - 1];
            arr[0] = last;
            arr[arr.Length - 1] = first;
            return arr;
        }
    }
}
