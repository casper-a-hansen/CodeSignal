/*
    Status:   Solved
    Imported: 2020-04-26 13:30
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/sorting-outpost/QQB7f8ouAqY6jf7xi

    Description:
        Given an array of strings, sort them in the order of increasing lengths. If two
        strings have the same length, their relative order must be the same as in the
        initial array.
        
        Example
        
        For
        
        inputArray = ["abc",
                      "",
        "aaa",
                      "a",
                      "zz"]
        
        
        the output should be
        sortByLength(inputArray) = ["",
                                    "a",
        "zz",
                                    "abc",
                                    "aaa"]
        Input/Output
        
        [execution time limit] 3 seconds (cs)
        
        [input] array.string
        inputArray
        
        A non-empty array of strings.
        
        Guaranteed constraints:
        3 ≤
        inputArray.length ≤ 100,
        0 ≤ inputArray[i].length ≤ 100.
        
        [output] array.string

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.SortingOutpost
{
    class sortByLengthClass
    {
        string[] sortByLength(string[] inputArray) {
            return inputArray.OrderBy(s => s.Length).ToArray();
        }
    }
}
