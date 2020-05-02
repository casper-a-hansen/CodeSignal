/*
    Status:   Solved
    Imported: 2020-05-02 12:06
    By:       Casper
    Url:      https://app.codesignal.com/arcade/intro/level-12/ywMyCTspqGXPWRZx5

    Description:
        Check if the given string is a correct time representation of the 24-hour clock.
        Example
        For time = "13:58", the output should be
        validTime(time) = true;
        For time = "25:51", the output should be
        validTime(time) = false;
        For time = "02:76", the output should be
        validTime(time) = false.
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] string time
        A string representing time in HH:MM format. It is guaranteed that the first two
        characters, as well as the last two characters, are digits.
        [output] boolean
        true if the given representation is correct, false otherwise.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Intro.LandOfLogic
{
    class validTimeClass
    {
        bool validTime(string time) {
            var hours = int.Parse(time.Substring(0, 2));
            if (hours > 23) return false;
            var minutes = int.Parse(time.Substring(3,2));
            return minutes < 60;
        }
    }
}
