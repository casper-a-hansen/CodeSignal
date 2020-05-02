/*
    Status:   Solved
    Imported: 2020-05-02 12:13
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/labyrinth-of-nested-loops/yBFfNv5fTqhcacZ7w

    Description:
        Determine if the given number is a power of some non-negative integer.
        Example
        For n = 125, the output should be
        isPower(n) = true;
        For n = 72, the output should be
        isPower(n) = false.
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] integer n
        A positive integer.
        Guaranteed constraints:
        1 ≤ n ≤ 400.
        [output] boolean
        true if n can be represented in the form ab (a to the power of b) where a and b
        are some non-negative integers and b ≥ 2, false otherwise.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.LabyrinthOfNestedLoops
{
    class isPowerClass
    {
        bool isPower(int n) {
            if (n <= 1) return true;
            for(int i = 2; i < n; i++) {
                var power = i;
                do {
                    power *= i;
                } while(power < n);
                if (power == n) return true;
            }
            return false;
        }
    }
}
