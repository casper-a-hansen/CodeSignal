/*
    Status:   Solved
    Imported: 2020-04-26 13:19
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/list-forest-edge/gmZFbpR9cirL3Jpf2

    Description:
        Given an integer size, return array of length size filled with 1s.
        
        Example
        
        For
        size = 4, the output should be
        createArray(size) = [1, 1, 1, 1].
        
        Input/Output
        [execution time limit] 3 seconds (cs)
        
        [input] integer size
        
        A positive integer.
        Guaranteed constraints:
        1 ≤ size ≤ 1000.
        
        [output] array.integer

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.ListForestEdge
{
    class createArrayClass
    {
        int[] createArray(int size) {
            var result = new int[size];
            for(int i = 0; i < size; i++) {
                result[i] = 1;
            }
            return result;
        }
    }
}
