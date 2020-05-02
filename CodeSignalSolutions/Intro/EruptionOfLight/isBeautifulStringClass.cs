/*
    Status:   Solved
    Imported: 2020-05-02 12:05
    By:       Casper
    Url:      https://app.codesignal.com/arcade/intro/level-10/PHSQhLEw3K2CmhhXE

    Description:
        A string is said to be beautiful if each letter in the string appears at most as
        many times as the previous letter in the alphabet within the string; ie: b
        occurs no more times than a; c occurs no more times than b; etc.
        Given a string, check whether it is beautiful.
        Example
        For inputString = "bbbaacdafe", the output should be
        isBeautifulString(inputString) = true.
        This string contains 3 as, 3 bs, 1 c, 1 d, 1 e, and 1 f (and 0 of every other
        letter), so since there aren't any letters that appear more frequently than the
        previous letter, this string qualifies as beautiful.
        For inputString = "aabbb", the output should be isBeautifulString(inputString) =
        false.
        Since there are more bs than as, this string is not beautiful.
        For inputString = "bbc", the output should be isBeautifulString(inputString) =
        false.
        Although there are more bs than cs, this string is not beautiful because there
        are no as, so therefore there are more bs than as.
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] string inputString
        A string of lowercase English letters.
        Guaranteed constraints:
        3 ≤ inputString.length ≤ 50.
        [output] boolean
        Return true if the string is beautiful, false otherwise.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Intro.EruptionOfLight
{
    class isBeautifulStringClass
    {
        bool isBeautifulString(string inputString) {
            var dic = inputString.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
            var end = inputString.Max();
            var lastCount = int.MaxValue;
            for(var c = 'a'; c <= end; c++)
            {
                if (!dic.TryGetValue(c, out int count)) return false;
                if (lastCount < count) return false;
                lastCount = count;
            }
            return true;
        }
    }
}
