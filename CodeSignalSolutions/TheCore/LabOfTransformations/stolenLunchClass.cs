/*
    Status:   Solved
    Imported: 2020-04-26 13:26
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/lab-of-transformations/M97sbwRp3tGy8uAb8

    Description:
        When you recently visited your little nephew, he told you a sad story: there's a
        bully at school who steals his lunch every day, and locks it away in his locker.
        He also leaves a note with a strange, coded message. Your nephew gave you one of
        the notes in hope that you can decipher it for him. And you did: it looks like
        all the digits in it are replaced with letters and vice versa. Digit 0 is
        replaced with 'a', 1 is replaced with 'b' and so on, with digit 9 replaced by
        'j'.
        
        The note is different every day, so you decide to write a function that
        will decipher it for your nephew on an ongoing basis.
        
        Example
        
        For note =
        "you'll n4v4r 6u4ss 8t: cdja", the output should be
        stolenLunch(note) = "you'll
        never guess it: 2390".
        
        Input/Output
        
        [execution time limit] 3 seconds (cs)
        [input] string note
        
        A string consisting of lowercase English letters, digits,
        punctuation marks and whitespace characters (' ').
        
        Guaranteed constraints:
        0 ≤
        note.length ≤ 500.
        
        [output] string
        
        The deciphered note.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.LabOfTransformations
{
    class stolenLunchClass
    {
        string stolenLunch(string note) {
            StringBuilder result = new StringBuilder(note.Length);
            foreach(char c in note)
            {
                var d = c;
                if ('0' <= c && c <= '9')
                {
                    d = (char)(c - '0' + 'a');
                }
                else if ('a' <= c && c <= 'j')
                {
                    d = (char)(c - 'a' + '0');
                }
                result.Append(d);
            }
            return result.ToString();
        }
    }
}
