/*
    Status:   Solved
    Imported: 2020-05-02 12:47
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/book-market/2nSEQ8CGoddTJtnbo

    Description:
        Proper nouns always begin with a capital letter, followed by small letters.
        Correct a given proper noun so that it fits this statement.
        Example
        For noun = "pARiS", the output should be
        properNounCorrection(noun) = "Paris";
        For noun = "John", the output should be
        properNounCorrection(noun) = "John".
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] string noun
        A string representing a proper noun with a mix of capital and small English
        letters.
        Guaranteed constraints:
        1 ≤ noun.length ≤ 10.
        [output] string
        Corrected (if needed) noun.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.BookMarket
{
    class properNounCorrectionClass
    {
        string properNounCorrection(string noun) {
            return noun[0].ToString().ToUpper() + (noun.Length > 1 ? noun.Substring(1).ToLower() : "");
        }
    }
}
