/*
    Status:   Solved
    Imported: 2020-05-02 13:03
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/spring-of-integration/tKwbrKAQhoCZFqg33

    Description:
        You're given a substring s of some cyclic string. What's the length of the
        smallest possible string that can be concatenated to itself many times to obtain
        this cyclic string?
        Example
        For s = "cabca", the output should be
        cyclicString(s) = 3.
        "cabca" is a substring of a cycle string "abcabcabcabc..." that can be obtained
        by concatenating "abc" to itself. Thus, the answer is 3.
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] string s
        Guaranteed constraints:
        3 ≤ s.length ≤ 15.
        [output] integer
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.SpringOfIntegration
{
    class cyclicStringClass
    {
        int cyclicString(string s) {
            for(var len = 1; len < s.Length; len++) {
                if (IsRepeated(s.Substring(0, len), s)) return len;
            }
            return s.Length;
        }
        bool IsRepeated(string single, string s) {
            int len = single.Length;
            for(var r = len; r < s.Length - len + 1; r += len) {
                if (single != s.Substring(r, len)) return false;
            }
            if (s.Length % len == 0) return true;
            return single.Substring(0, s.Length % len) == s.Substring(s.Length / len * len);
        }
    }
}
