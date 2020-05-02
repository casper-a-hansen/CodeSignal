/*
    Status:   Solved
    Imported: 2020-05-02 12:48
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/mirror-lake/rNrF4v5etMdFNKD3s

    Description:
        A ciphertext alphabet is obtained from the plaintext alphabet by means of
        rearranging some characters. For example "bacdef...xyz" will be a simple
        ciphertext alphabet where a and b are rearranged.
        A substitution cipher is a method of encoding where each letter of the plaintext
        alphabet is replaced with the corresponding (i.e. having the same index) letter
        of some ciphertext alphabet.
        Given two strings, check whether it is possible to obtain them from each other
        using some (possibly, different) substitution ciphers.
        Example
        For string1 = "aacb" and string2 = "aabc", the output should be
        isSubstitutionCipher(string1, string2) = true.
        Any ciphertext alphabet that starts with acb... would make this transformation
        possible.
        For string1 = "aa" and string2 = "bc", the output should be
        isSubstitutionCipher(string1, string2) = false.
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] string string1
        A string consisting of lowercase English characters.
        Guaranteed constraints:
        1 ≤ string1.length ≤ 10.
        [input] string string2
        A string consisting of lowercase English characters of the same length as
        string1.
        Guaranteed constraints:
        string2.length = string1.length.
        [output] boolean
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.MirrorLake
{
    class isSubstitutionCipherClass
    {
        bool isSubstitutionCipher(string string1, string string2) {
            var dic = new Dictionary<char,char>();
            var unique = new HashSet<char>();
            for(var i = 0; i < string1.Length; i++) {
                if (!dic.TryGetValue(string1[i], out char cipher)) {
                    dic.Add(string1[i], string2[i]);
                    if (!unique.Add(string2[i])) return false;
                } else {
                    if (cipher != string2[i]) return false;
                }
            }
            return true;
        }
    }
}
