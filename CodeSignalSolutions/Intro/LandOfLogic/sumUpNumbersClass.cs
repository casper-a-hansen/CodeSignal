/*
    Status:   Solved
    Imported: 2020-05-02 12:06
    By:       Casper
    Url:      https://app.codesignal.com/arcade/intro/level-12/YqZwMJguZBY7Hz84T

    Description:
        CodeMaster has just returned from shopping. He scanned the check of the items he
        bought and gave the resulting string to Ratiorg to figure out the total number
        of purchased items. Since Ratiorg is a bot he is definitely going to automate
        it, so he needs a program that sums up all the numbers which appear in the given
        input.
        Help Ratiorg by writing a function that returns the sum of numbers that appear
        in the given inputString.
        Example
        For inputString = "2 apples, 12 oranges", the output should be
        sumUpNumbers(inputString) = 14.
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] string inputString
        Guaranteed constraints:
        0 ≤ inputString.length ≤ 105.
        [output] integer
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Intro.LandOfLogic
{
    class sumUpNumbersClass
    {
        int sumUpNumbers(string inputString) {
            var regex = new Regex(@"\d+");
            return regex.Matches(inputString).Cast<Match>().Select(m => int.Parse(m.Value)).Sum();
        }
    }
}
