/*
    Status:   Solved
    Imported: 2020-05-02 12:14
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/labyrinth-of-nested-loops/pNfGgNk46YZ4c4RW5

    Description:
        Let's say that number a feels comfortable with number b if a ≠ b and b lies in
        the segment [a - s(a), a + s(a)], where s(x) is the sum of x's digits.
        How many pairs (a, b) are there, such that a < b, both a and b lie on the
        segment [l, r], and each number feels comfortable with the other (so a feels
        comfortable with b and b feels comfortable with a)?
        Example
        For l = 10 and r = 12, the output should be
        comfortableNumbers(l, r) = 2.
        Here are all values of s(x) to consider:
        s(10) = 1, so 10 is comfortable with 9 and 11;
        s(11) = 2, so 11 is comfortable with 9, 10, 12 and 13;
        s(12) = 3, so 12 is comfortable with 9, 10, 11, 13, 14 and 15.
        Thus, there are 2 pairs of numbers comfortable with each other within the
        segment [10; 12]: (10, 11) and (11, 12).
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] integer l
        Guaranteed constraints:
        1 ≤ l ≤ r ≤ 1000.
        [input] integer r
        Guaranteed constraints:
        1 ≤ l ≤ r ≤ 1000.
        [output] integer
        The number of pairs satisfying all the above conditions.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.LabyrinthOfNestedLoops
{
    class comfortableNumbersClass
    {
        int comfortableNumbers(int l, int r) {
            var unique = new HashSet<(int,int)>();
            for(var i = l; i <= r; i++) {
                var li = Math.Max(l, i - s(i));
                var ri = Math.Min(r, i + s(i));
        //        Console.WriteLine($"{li},{ri}");
                for(var a = li; a <= ri; a++) {
                    for(var b = a + 1; b <= ri; b++) {
                        if (b <= (a + s(a)) && a >= (b - s(b))) {
                            unique.Add((a,b));
        //                    Console.WriteLine($"Added {a},{b}");
                        }
                    }
                }
            }
            return unique.Count;
        }
        int s(int x) {
            return x.ToString().Select(c => (int)(c - '0')).Sum();
        }
    }
}
