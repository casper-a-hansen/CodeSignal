/*
    Status:   Solved
    Imported: 2020-04-26 13:34
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/regular-hell/mj4qdJqZknbkHNzhK

    Description:
        A sentence is considered correct if:
        
        it starts with a capital letter;
        it ends
        with a full stop, question mark or exclamation point ('.', '?' or '!');
        full
        stops, question marks and exclamation points don't appear anywhere else in the
        sentence.
        
        Given a sentence, return true if it is correct and false otherwise.
        Example
        
        For sentence = "This is an example of *correct* sentence.",
        the output
        should be
        isSentenceCorrect(sentence) = true;
        
        For sentence = "!this sentence is
        TOTALLY incorrecT",
        the output should be
        isSentenceCorrect(sentence) = false.
        Input/Output
        
        [execution time limit] 3 seconds (cs)
        
        [input] string sentence
        
        A
        string without newline characters.
        
        Guaranteed constraints:
        2 ≤ sentence.length
        ≤ 100.
        
        [output] boolean
        
        true if the given sentence is correct, false
        otherwise.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.RegularHell
{
    class isSentenceCorrectClass
    {
        bool isSentenceCorrect(string sentence)
        {
          Regex regex = new Regex(@"^[A-Z][^.?!]*[.?!]$");
          return regex.IsMatch(sentence);
        }
    }
}
