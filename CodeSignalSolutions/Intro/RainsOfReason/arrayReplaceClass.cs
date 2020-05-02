/*
    Status:   Solved
    Imported: 2020-05-02 12:00
    By:       Casper
    Url:      https://app.codesignal.com/arcade/intro/level-6/mCkmbxdMsMTjBc3Bm

    Description:
        Given an array of integers, replace all the occurrences of elemToReplace with
        substitutionElem.
        Example
        For inputArray = [1, 2, 1], elemToReplace = 1, and substitutionElem = 3, the
        output should be
        arrayReplace(inputArray, elemToReplace, substitutionElem) = [3, 2, 3].
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] array.integer inputArray
        Guaranteed constraints:
        0 ≤ inputArray.length ≤ 104,
        0 ≤ inputArray[i] ≤ 109.
        [input] integer elemToReplace
        Guaranteed constraints:
        0 ≤ elemToReplace ≤ 109.
        [input] integer substitutionElem
        Guaranteed constraints:
        0 ≤ substitutionElem ≤ 109.
        [output] array.integer
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Intro.RainsOfReason
{
    class arrayReplaceClass
    {
        int[] arrayReplace(int[] inputArray, int elemToReplace, int substitutionElem) {
            return inputArray.Select(i => i == elemToReplace ? substitutionElem : i).ToArray();
        }
    }
}
