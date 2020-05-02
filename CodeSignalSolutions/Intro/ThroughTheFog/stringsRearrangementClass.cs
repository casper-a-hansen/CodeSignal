/*
    Status:   Solved
    Imported: 2020-05-02 12:02
    By:       Casper
    Url:      https://app.codesignal.com/arcade/intro/level-7/PTWhv2oWqd6p4AHB9

    Description:
        Given an array of equal-length strings, you'd like to know if it's possible to
        rearrange the order of the elements in such a way that each consecutive pair of
        strings differ by exactly one character. Return true if it's possible, and false
        if not.
        Note: You're only rearranging the order of the strings, not the order of the
        letters within the strings!
        Example
        For inputArray = ["aba", "bbb", "bab"], the output should be
        stringsRearrangement(inputArray) = false.
        There are 6 possible arrangements for these strings:
        ["aba", "bbb", "bab"]
        ["aba", "bab", "bbb"]
        ["bbb", "aba", "bab"]
        ["bbb", "bab", "aba"]
        ["bab", "bbb", "aba"]
        ["bab", "aba", "bbb"]
        None of these satisfy the condition of consecutive strings differing by 1
        character, so the answer is false.
        For inputArray = ["ab", "bb", "aa"], the output should be
        stringsRearrangement(inputArray) = true.
        It's possible to arrange these strings in a way that each consecutive pair of
        strings differ by 1 character (eg: "aa", "ab", "bb" or "bb", "ab", "aa"), so
        return true.
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] array.string inputArray
        A non-empty array of strings of lowercase letters.
        Guaranteed constraints:
        2 ≤ inputArray.length ≤ 10,
        1 ≤ inputArray[i].length ≤ 15.
        [output] boolean
        Return true if the strings can be reordered in such a way that each neighbouring
        pair of strings differ by exactly one character (false otherwise).
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Intro.ThroughTheFog
{
    class stringsRearrangementClass
    {
        bool stringsRearrangement(string[] inputArray) {
            List<int> usedIndexes = new List<int>(inputArray.Length);
            return Permutate(inputArray, usedIndexes);
        }
        bool OneDifference(string a, string b, int level)
        {
            var result = a.Zip(b, (ca,cb) => ca == cb).Count(eq => !eq) == 1;
            Console.WriteLine($"{new string(' ', level)}Testing: {a} {b} - {result}");
            return result;
        }
        bool Permutate(string[] inputArray, List<int> usedIndexes)
        {
            for(var i = 0; i < inputArray.Length; i++)
            {
                if (!usedIndexes.Contains(i))
                {
                    if (usedIndexes.Count >= 1)
                    {
                        if (!OneDifference(inputArray[usedIndexes[usedIndexes.Count - 1]], inputArray[i], usedIndexes.Count))
                            continue;   // No reason to try any combination after this one.
                        if (inputArray.Length == usedIndexes.Count + 1)
                            return true;
                    }
                    usedIndexes.Add(i);
                    if (Permutate(inputArray, usedIndexes))
                        return true;
                    usedIndexes.RemoveAt(usedIndexes.Count - 1);
                }
            }
            return false;
        }
    }
}
