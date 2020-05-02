/*
    Status:   Solved
    Imported: 2020-05-02 12:48
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/book-market/MX94DWTrwQw2gLrTi

    Description:
        You are implementing your own HTML editor. To make it more comfortable for
        developers you would like to add an auto-completion feature to it.
        Given the starting HTML tag, find the appropriate end tag which your editor
        should propose.
        If you are not familiar with HTML, consult with this note.
        Example
        For startTag = "<button type='button' disabled>", the output should be
        htmlEndTagByStartTag(startTag) = "</button>";
        For startTag = "<i>", the output should be
        htmlEndTagByStartTag(startTag) = "</i>".
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] string startTag
        Guaranteed constraints:
        3 ≤ startTag.length ≤ 75.
        [output] string
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.BookMarket
{
    class htmlEndTagByStartTagClass
    {
        string htmlEndTagByStartTag(string startTag) {
            var regex = new Regex(@"<(\w+)\b");
            var match = regex.Match(startTag);
            if (!match.Success) return "";
            return "</" + match.Groups[1].Value + ">";
        }
    }
}
