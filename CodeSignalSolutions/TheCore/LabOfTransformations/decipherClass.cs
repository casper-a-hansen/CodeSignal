/*
    Status:   Solved
    Imported: 2020-04-26 13:26
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/lab-of-transformations/dB9drnfWzpiWznESA

    Description:
        Consider the following ciphering algorithm:
        
        For each character replace it with
        its code.
        Concatenate all of the obtained numbers.
        
        Given a ciphered string,
        return the initial one if it is known that it consists only of lowercase
        letters.
        
        Note: here the character's code means its decimal ASCII code, the
        numerical representation of a character used by most modern programming
        languages.
        
        Example
        
        For cipher = "10197115121", the output should be
        decipher(cipher) = "easy".
        
        Explanation: charCode('e') = 101, charCode('a') =
        97, charCode('s') = 115 and charCode('y') = 121.
        
        Input/Output
        
        [execution time
        limit] 3 seconds (cs)
        
        [input] string cipher
        
        A non-empty string which is
        guaranteed to be a cipher for some other string of lowercase letters.
        Guaranteed constraints:
        2 ≤ cipher.length ≤ 100.
        
        [output] string

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.LabOfTransformations
{
    class decipherClass
    {
        string decipher(string cipher) {
            var result = new StringBuilder();
            var value = 0;
            foreach(var c in cipher)
            {
                value = value * 10 + (int)(c - '0');
                if (value >= 97)
                {
                    result.Append((char)value);
                    value = 0;
                }
            }
            return result.ToString();
        }
    }
}
