/*
    Status:   Solved
    Imported: 2020-04-26 13:25
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/lab-of-transformations/QKnGhkoi4wKr6xY9b

    Description:
        Given a character, check if it represents an odd digit, an even digit or not a
        digit at all.
        
        Example
        
        For symbol = '5', the output should be
        characterParity(symbol) = "odd";
        For symbol = '8', the output should be
        characterParity(symbol) = "even";
        For symbol = 'q', the output should be
        characterParity(symbol) = "not a digit".
        
        Input/Output
        
        [execution time limit] 3
        seconds (cs)
        
        [input] char symbol
        
        A symbol to check.
        
        Guaranteed constraints:
        symbol is guaranteed to be a UTF-8 symbol.
        
        [output] string

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.LabOfTransformations
{
    class characterParityClass
    {
        string characterParity(char symbol) {
            switch(symbol) {
                case '0':
                case '2':
                case '4':
                case '6':
                case '8':
                    return "even";
                    case '1':
                    case '3':
                    case '5':
                    case '7':
                    case '9':
                    return "odd";
                    default:
                    return "not a digit";
                    
            }
         
        }
    }
}
