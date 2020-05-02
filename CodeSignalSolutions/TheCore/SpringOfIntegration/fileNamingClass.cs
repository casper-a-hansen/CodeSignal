/*
    Status:   Solved
    Imported: 2020-05-02 13:03
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/spring-of-integration/sqZ9qDTFHXBNrQeLC

    Description:
        You are given an array of desired filenames in the order of their creation.
        Since two files cannot have equal names, the one which comes later will have an
        addition to its name in a form of (k), where k is the smallest positive integer
        such that the obtained name is not used yet.
        Return an array of names that will be given to the files.
        Example
        For names = ["doc", "doc", "image", "doc(1)", "doc"], the output should be
        fileNaming(names) = ["doc", "doc(1)", "image", "doc(1)(1)", "doc(2)"].
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] array.string names
        Guaranteed constraints:
        5 ≤ names.length ≤ 1000,
        1 ≤ names[i].length ≤ 15.
        [output] array.string
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.SpringOfIntegration
{
    class fileNamingClass
    {
        string[] fileNaming(string[] names) {
            var result = new string[names.Length];
            var nameCount = new Dictionary<string, int>();
            var uniqueNames = new HashSet<string>();
            for(var i = 0; i < names.Length; i++) {
                Console.WriteLine(names[i]);
                while(true) {
                    var name = names[i];
                    if (nameCount.TryGetValue(name, out int count)) {
                        nameCount[name] = ++count;
                        name += $"({count})";
                    } else {
                        nameCount[name] = 0;
                    }
                    Console.WriteLine($"  {name}");
                    if (uniqueNames.Add(name)) {
                        result[i] = name;
                        break;
                    }
                }
            }
            return result;
        }
    }
}
