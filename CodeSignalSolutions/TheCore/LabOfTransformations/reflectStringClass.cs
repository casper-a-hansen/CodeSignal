/*
    Status:   Solved
    Imported: 2020-04-26 13:25
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/lab-of-transformations/8nAgfjhDvKCpxwGWF

    Description:
        Define an alphabet reflection as follows: a turns into z, b turns into y, c
        turns into x, ..., n turns into m, m turns into n, ..., z turns into a.
        
        Define
        a string reflection as the result of applying the alphabet reflection to each of
        its characters.
        
        Reflect the given string.
        
        Example
        
        For inputString = "name",
        the output should be
        reflectString(inputString) = "mznv".
        
        Input/Output
        [execution time limit] 3 seconds (cs)
        
        [input] string inputString
        
        A string of
        lowercase characters.
        
        Guaranteed constraints:
        3 ≤ inputString.length ≤ 1000.
        [output] string

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.LabOfTransformations
{
    class reflectStringClass
    {
        string reflectString(string inputString) {
            return string.Join("", inputString.Select(c => (char)('z' - c + 'a')));
        }
    }
}
