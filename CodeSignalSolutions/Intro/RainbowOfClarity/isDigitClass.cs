/*
    Status:   Solved
    Imported: 2020-05-02 12:05
    By:       Casper
    Url:      https://app.codesignal.com/arcade/intro/level-11/Zr2XXEpkBPtYWqPJu

    Description:
        Determine if the given character is a digit or not.
        Example
        For symbol = '0', the output should be
        isDigit(symbol) = true;
        For symbol = '-', the output should be
        isDigit(symbol) = false.
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] char symbol
        A character which is either a digit or not.
        Guaranteed constraints:
        Given symbol is from ASCII table.
        [output] boolean
        true if symbol is a digit, false otherwise.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Intro.RainbowOfClarity
{
    class isDigitClass
    {
        bool isDigit(char symbol) {
            return symbol >= '0' && symbol <= '9';
        }
    }
}
