/*
    Status:   Solved
    Imported: 2020-05-02 13:11
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/regular-hell/YhqzFvdnHMffQA22q

    Description:
        Implement a function that replaces each digit in the given string with a '#'
        character.
        Example
        For input = "There are 12 points", the output should be
        replaceAllDigitsRegExp(input) = "There are ## points".
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] string input
        Guaranteed constraints:
        5 ≤ input.length ≤ 20.
        [output] string
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.RegularHell
{
    class replaceAllDigitsRegExpClass
    {
        string replaceAllDigitsRegExp(string input)
        {
          return Regex.Replace(input, "[0-9]", "#");
        }
    }
}
