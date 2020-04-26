/*
    Status:   Solved
    Imported: 2020-04-26 13:26
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/lab-of-transformations/vsKRjYKv4SCjzJc8r

    Description:
        Given two version strings composed of several non-negative decimal fields
        separated by periods ("."), both strings contain equal number of numeric fields.
        Return true if the first version is higher than the second version and false
        otherwise.
        
        The syntax follows the regular semver ordering rules:
        
        1.0.5 < 1.1.0
        < 1.1.5 < 1.1.10 < 1.2.0 < 1.2.2
        < 1.2.10 < 1.10.2 < 2.0.0 < 10.0.0
        
        
        There are
        no leading zeros in any of the numeric fields, i.e. you do not have to handle
        inputs like 100.020.003 (it would instead be given as 100.20.3).
        
        Example
        
        For
        ver1 = "1.2.2" and ver2 = "1.2.0", the output should be
        higherVersion(ver1,
        ver2) = true;
        For ver1 = "1.0.5" and ver2 = "1.1.0", the output should be
        higherVersion(ver1, ver2) = false.
        
        Input/Output
        
        [execution time limit] 3
        seconds (cs)
        
        [input] string ver1
        
        Guaranteed constraints:
        1 ≤ ver1.length ≤ 15.
        [input] string ver2
        
        Guaranteed constraints:
        1 ≤ ver2.length ≤ 15.
        
        [output]
        boolean

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.LabOfTransformations
{
    class higherVersionClass
    {
        bool higherVersion(string ver1, string ver2) {
            var v1 = ver1.Split('.').Select(s => int.Parse(s));
            var v2 = ver2.Split('.').Select(s => int.Parse(s));
            var compare = v1.Zip(v2, (a,b) => (Version1: a, Version2: b)).ToArray();
            foreach(var c in compare)
            {
                if (c.Version1 > c.Version2) return true;
                if (c.Version1 < c.Version2) return false;
            }
            return false;
        }
    }
}
