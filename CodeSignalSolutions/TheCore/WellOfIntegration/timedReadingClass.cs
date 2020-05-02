/*
    Status:   Solved
    Imported: 2020-05-02 12:51
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/well-of-integration/mJr7vgtN4X4ecL7ZA

    Description:
        Timed Reading is an educational tool used in many schools to improve and advance
        reading skills. A young elementary student has just finished his very first
        timed reading exercise. Unfortunately he's not a very good reader yet, so
        whenever he encountered a word longer than maxLength, he simply skipped it and
        read on.
        Help the teacher figure out how many words the boy has read by calculating the
        number of words in the text he has read, no longer than maxLength.
        Formally, a word is a substring consisting of English letters, such that
        characters to the left of the leftmost letter and to the right of the rightmost
        letter are not letters.
        Example
        For maxLength = 4 and
        text = "The Fox asked the stork, 'How is the soup?'",
        the output should be
        timedReading(maxLength, text) = 7.
        The boy has read the following words: "The", "Fox", "the", "How", "is", "the",
        "soup".
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] integer maxLength
        A positive integer, the maximum length of the word the boy can read.
        Guaranteed constraints:
        1 ≤ maxLength ≤ 10.
        [input] string text
        A non-empty string of English letters and punctuation marks.
        Guaranteed constraints:
        3 ≤ text.length ≤ 110.
        [output] integer
        The number of words the boy has read.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.WellOfIntegration
{
    class timedReadingClass
    {
        int timedReading(int maxLength, string text) {
            var regex = new Regex(@"\b\w+\b");
            return regex.Matches(text).Cast<Match>().Count(m => m.Value.Length <= maxLength);
        }
    }
}
