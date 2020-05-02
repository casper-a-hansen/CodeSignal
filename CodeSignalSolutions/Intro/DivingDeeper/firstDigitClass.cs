/*
    Status:   Solved
    Imported: 2020-05-02 12:02
    By:       Casper
    Url:      https://app.codesignal.com/arcade/intro/level-8/rRGGbTtwZe2mA8Wov

    Description:
        Find the leftmost digit that occurs in a given string.
        Example
        For inputString = "var_1__Int", the output should be
        firstDigit(inputString) = '1';
        For inputString = "q2q-q", the output should be
        firstDigit(inputString) = '2';
        For inputString = "0ss", the output should be
        firstDigit(inputString) = '0'.
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] string inputString
        A string containing at least one digit.
        Guaranteed constraints:
        3 ≤ inputString.length ≤ 10.
        [output] char
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Intro.DivingDeeper
{
    class firstDigitClass
    {
        char firstDigit(string inputString) {
            return inputString.First(c => c >= '0' && c <= '9');
        }
    }
}
