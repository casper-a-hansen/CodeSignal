/*
    Status:   Solved
    Imported: 2020-04-26 13:25
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/well-of-integration/Ghe6HWhFft8h6fR49

    Description:
        Consider two following representations of a non-negative integer:
        
        A simple
        decimal integer, constructed of a non-empty sequence of digits from 0 to 9;
        An
        integer with at least one digit in a base from 2 to 16 (inclusive), enclosed
        between # characters, and preceded by the base, which can only be a number
        between 2 and 16 in the first representation. For digits from 10 to 15
        characters a, b, ..., f and A, B, ..., F are used.
        
        Additionally, both
        representations may contain underscore (_) characters; they are used only as
        separators for improving legibility of numbers and can be ignored while
        processing a number.
        
        Your task is to determine whether the given string is a
        valid integer representation.
        
        Note: this is how integer numbers are represented
        in the programming language Ada.
        
        Example
        
        For line = "123_456_789", the output
        should be
        adaNumber(line) = true;
        For line = "16#123abc#", the output should be
        adaNumber(line) = true;
        For line = "10#123abc#", the output should be
        adaNumber(line) = false;
        For line = "10#10#123ABC#", the output should be
        adaNumber(line) = false;
        For line = "10#0#", the output should be
        adaNumber(line) = true;
        For line = "10##", the output should be
        adaNumber(line)
        = false.
        
        Input/Output
        
        [execution time limit] 3 seconds (cs)
        
        [input] string
        line
        
        A non-empty string.
        
        Guaranteed constraints:
        2 ≤ line.length ≤ 30.
        [output] boolean
        
        true if line is a valid integer representation, false
        otherwise.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.WellOfIntegration
{
    class adaNumberClass
    {
        bool adaNumber(string line) {
            line = line.Replace("_", "");
            if (string.IsNullOrEmpty(line)) return false;
            var parts = line.Split('#');
            if (parts.Length == 1) {
                // This is a plain integer;
                return line.All(c => ('0' <= c && c <= '9'));
            } else if (parts.Length != 3) {
                return false;
            }
            if (parts[0] == "") return false;
            if (parts[1] == "") return false;
            if (!parts[0].All(c => ('0' <= c && c <= '9'))) return false;
         
            int numberBase = int.Parse(parts[0]);
            if (numberBase > 16) return false;
            if (numberBase < 2) return false;
            return parts[1].All(c => IsValid(numberBase, c));
        }
        bool IsValid(int numberBase, char c) {
            if (c == '_') return true;
            int digit = -1;
            if ('0' <= c && c <= '9') {
                digit = (int)(c - '0');
            } else if ('a' <= c && c <= 'f') {
                digit = (int)(c - 'a') + 10;
            } else if ('A' <= c && c <= 'F') {
                digit = (int)(c - 'A') + 10;
            } else {
                return false;
            }
            return digit < numberBase;
        }
    }
}
