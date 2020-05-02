/*
    Status:   Solved
    Imported: 2020-05-02 12:02
    By:       Casper
    Url:      https://app.codesignal.com/arcade/intro/level-8/8N7p3MqzGQg5vFJfZ

    Description:
        Given a string, find the number of different characters in it.
        Example
        For s = "cabca", the output should be
        differentSymbolsNaive(s) = 3.
        There are 3 different characters a, b and c.
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] string s
        A string of lowercase English letters.
        Guaranteed constraints:
        3 ≤ s.length ≤ 1000.
        [output] integer
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Intro.DivingDeeper
{
    class differentSymbolsNaiveClass
    {
        int differentSymbolsNaive(string s) {
            return s.GroupBy(c => c).Count();
        }
    }
}
