/*
    Status:   Solved
    Imported: 2020-04-26 13:10
    By:       Casper
    Url:      https://app.codesignal.com/arcade/intro/level-6/6Wv4WsrsMJ8Y2Fwno

    Description:
        Correct variable names consist only of English letters, digits and underscores
        and they can't start with a digit.
        
        Check if the given string is a correct
        variable name.
        
        Example
        
        For name = "var_1__Int", the output should be
        variableName(name) = true;
        For name = "qq-q", the output should be
        variableName(name) = false;
        For name = "2w2", the output should be
        variableName(name) = false.
        
        Input/Output
        
        [execution time limit] 3 seconds (cs)
        [input] string name
        
        Guaranteed constraints:
        1 ≤ name.length ≤ 10.
        
        [output]
        boolean
        
        true if name is a correct variable name, false otherwise.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Intro.RainsOfReason
{
    class variableNameClass
    {
        bool variableName(string name) {
            Regex regex = new Regex(@"^[_a-z]\w*$", RegexOptions.IgnoreCase);
            return regex.IsMatch(name);
        }
    }
}
