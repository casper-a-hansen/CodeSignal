/*
    Status:   Solved
    Imported: 2020-05-02 12:50
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/well-of-integration/ZCD7NQnED724bJtjN

    Description:
        Given a rectangular matrix of characters, add a border of asterisks(*) to it.
        Example
        For
        picture = ["abc",
        "ded"]
        the output should be
        addBorder(picture) = ["*****",
        "*abc*",
        "*ded*",
        "*****"]
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] array.string picture
        A non-empty array of non-empty equal-length strings.
        Guaranteed constraints:
        1 ≤ picture.length ≤ 100,
        1 ≤ picture[i].length ≤ 100.
        [output] array.string
        The same matrix of characters, framed with a border of asterisks of width 1.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.WellOfIntegration
{
    class addBorderClass
    {
        string[] addBorder(string[] picture) {
            var result = new string[picture.Length + 2];
            for(var i = 0; i < picture.Length; i++) {
                result[i + 1] = "*" + picture[i] + "*";
            }
            result[0] = new string('*', picture[0].Length + 2);
            result[result.Length - 1] = result[0];
            return result;
        }
    }
}
