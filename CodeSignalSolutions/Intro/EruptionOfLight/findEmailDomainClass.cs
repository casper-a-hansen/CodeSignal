/*
    Status:   Solved
    Imported: 2020-05-02 12:05
    By:       Casper
    Url:      https://app.codesignal.com/arcade/intro/level-10/TXFLopNcCNbJLQivP

    Description:
        An email address such as "John.Smith@example.com" is made up of a local part
        ("John.Smith"), an "@" symbol, then a domain part ("example.com").
        The domain name part of an email address may only consist of letters, digits,
        hyphens and dots. The local part, however, also allows a lot of different
        special characters. Here you can look at several examples of correct and
        incorrect email addresses.
        Given a valid email address, find its domain part.
        Example
        For address = "prettyandsimple@example.com", the output should be
        findEmailDomain(address) = "example.com";
        For address = "fully-qualified-domain@codesignal.com", the output should be
        findEmailDomain(address) = "codesignal.com".
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] string address
        Guaranteed constraints:
        10 ≤ address.length ≤ 50.
        [output] string
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Intro.EruptionOfLight
{
    class findEmailDomainClass
    {
        string findEmailDomain(string address) {
            var parts = address.Split('@');
            return parts[parts.Length - 1];
        }
    }
}
