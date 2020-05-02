/*
    Status:   Solved
    Imported: 2020-05-02 12:14
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/labyrinth-of-nested-loops/oL7YuygJKtMSNLeJn

    Description:
        We define the weakness of number x as the number of positive integers smaller
        than x that have more divisors than x.
        It follows that the weaker the number, the greater overall weakness it has. For
        the given integer n, you need to answer two questions:
        what is the weakness of the weakest numbers in the range [1, n]?
        how many numbers in the range [1, n] have this weakness?
        Return the answer as an array of two elements, where the first element is the
        answer to the first question, and the second element is the answer to the second
        question.
        Example
        For n = 9, the output should be
        weakNumbers(n) = [2, 2].
        Here are the number of divisors and the specific weakness of each number in
        range [1, 9]:
        1: d(1) = 1, weakness(1) = 0;
        2: d(2) = 2, weakness(2) = 0;
        3: d(3) = 2, weakness(3) = 0;
        4: d(4) = 3, weakness(4) = 0;
        5: d(5) = 2, weakness(5) = 1;
        6: d(6) = 4, weakness(6) = 0;
        7: d(7) = 2, weakness(7) = 2;
        8: d(8) = 4, weakness(8) = 0;
        9: d(9) = 3, weakness(9) = 2.
        As you can see, the maximal weakness is 2, and there are 2 numbers with that
        weakness level.
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] integer n
        Guaranteed constraints:
        1 ≤ n ≤ 1000.
        [output] array.integer
        Array of two elements: the weakness of the weakest number, and the number of
        integers in range [1, n] with this weakness.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.LabyrinthOfNestedLoops
{
    class weakNumbersClass
    {
        int[] weakNumbers(int n) {
            var result = new int[2];
            var list = new List<int>();
            var maxW = 0;
            for(int w = 1; w <= n; w++) {
                var weak = weakness(w);
                if (weak >= maxW) {
                    maxW = weak;
                    list.Add(weak);
                }
            }
            result[0] = maxW;
            result[1] = list.Count(w => w == maxW);
            return result;
        }
        int weakness(int x) {
            var result = 0;
            int divisorsOfx = divisors(x);
            for(int n = 1; n < x; n++) {
                if (divisors(n) > divisorsOfx) result++;
            }
            return result;
        }
        int divisors(int x) {
            int count = 0;
            for(int d = 2; d < x; d++) {
                if (x % d == 0) count++;
            }
            return count;
        }
    }
}
