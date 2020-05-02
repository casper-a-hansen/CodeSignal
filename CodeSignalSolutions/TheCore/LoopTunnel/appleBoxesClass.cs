/*
    Status:   Solved
    Imported: 2020-05-02 12:11
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/loop-tunnel/scG8AFsPuqQGx8Qjf

    Description:
        You have k apple boxes full of apples. Each square box of size m contains m × m
        apples. You just noticed two interesting properties about the boxes:
        The smallest box is size 1, the next one is size 2,..., all the way up to size
        k.
        Boxes that have an odd size contain only yellow apples. Boxes that have an even
        size contain only red apples.
        Your task is to calculate the difference between the number of red apples and
        the number of yellow apples.
        Example
        For k = 5, the output should be
        appleBoxes(k) = -15.
        There are 1 + 3 * 3 + 5 * 5 = 35 yellow apples and 2 * 2 + 4 * 4 = 20 red
        apples, making the answer 20 - 35 = -15.
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] integer k
        A positive integer.
        Guaranteed constraints:
        1 ≤ k ≤ 40.
        [output] integer
        The difference between the two types of apples.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.LoopTunnel
{
    class appleBoxesClass
    {
        int appleBoxes(int k) {
            var yellow = Enumerable.Range(1, k).Where(p => (p % 2) == 1).Sum(p => p*p);
            var red = Enumerable.Range(1, k).Where(p => (p % 2) == 0).Sum(p => p*p);
            Console.WriteLine($"Yellow: {yellow}  Red: {red}");
            return red - yellow;
        }
    }
}
