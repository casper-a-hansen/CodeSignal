/*
    Status:   Solved
    Imported: 2020-05-02 11:59
    By:       Casper
    Url:      https://app.codesignal.com/arcade/intro/level-5/veW5xJednTy4qcjso

    Description:
        An IP address is a numerical label assigned to each device (e.g., computer,
        printer) participating in a computer network that uses the Internet Protocol for
        communication. There are two versions of the Internet protocol, and thus two
        versions of addresses. One of them is the IPv4 address.
        Given a string, find out if it satisfies the IPv4 address naming rules.
        Example
        For inputString = "172.16.254.1", the output should be
        isIPv4Address(inputString) = true;
        For inputString = "172.316.254.1", the output should be
        isIPv4Address(inputString) = false.
        316 is not in range [0, 255].
        For inputString = ".254.255.0", the output should be
        isIPv4Address(inputString) = false.
        There is no first number.
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] string inputString
        A string consisting of digits, full stops and lowercase English letters.
        Guaranteed constraints:
        1 ≤ inputString.length ≤ 30.
        [output] boolean
        true if inputString satisfies the IPv4 address naming rules, false otherwise.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Intro.IslandOfKnowledge
{
    class isIPv4AddressClass
    {
        bool isIPv4Address(string inputString) {
            Regex regex = new Regex(@"^\d{1,3}$");
            var split = inputString.Split('.');
            if (split.Length != 4) return false;
            if (split.Any(s => s=="")) return false;
            if (split.Any(s => !regex.IsMatch(s))) return false;
            if (split.Any(s => int.Parse(s) > 255)) return false;
            return true;
        }
    }
}
