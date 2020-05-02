/*
    Status:   Solved
    Imported: 2020-05-02 11:59
    By:       Casper
    Url:      https://app.codesignal.com/arcade/intro/level-4/Xfeo7r9SBSpo3Wico

    Description:
        Given a string, find out if its characters can be rearranged to form a
        palindrome.
        Example
        For inputString = "aabb", the output should be
        palindromeRearranging(inputString) = true.
        We can rearrange "aabb" to make "abba", which is a palindrome.
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] string inputString
        A string consisting of lowercase English letters.
        Guaranteed constraints:
        1 ≤ inputString.length ≤ 50.
        [output] boolean
        true if the characters of the inputString can be rearranged to form a
        palindrome, false otherwise.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Intro.ExploringTheWaters
{
    class palindromeRearrangingClass
    {
        bool palindromeRearranging(string inputString) {
            var odds = inputString.GroupBy(c => c).Select(g => g.Count()).Where(c => (c % 2) == 1).Count();
            return odds <= 1;
        }
    }
}
