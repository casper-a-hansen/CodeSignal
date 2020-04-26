/*
    Status:   Solved
    Imported: 2020-04-26 13:33
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/time-river/ywMyCTspqGXPWRZx5

    Description:
        Check if the given string is a correct time representation of the 24-hour clock.
        Example
        
        For time = "13:58", the output should be
        validTime(time) = true;
        For
        time = "25:51", the output should be
        validTime(time) = false;
        For time =
        "02:76", the output should be
        validTime(time) = false.
        
        Input/Output
        
        [execution
        time limit] 3 seconds (cs)
        
        [input] string time
        
        A string representing time in
        HH:MM format. It is guaranteed that the first two characters, as well as the
        last two characters, are digits.
        
        [output] boolean
        
        true if the given
        representation is correct, false otherwise.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.TimeRiver
{
    class validTimeClass
    {
        bool validTime(string time) {
            var split = time.Split(':').Select(s => int.Parse(s)).ToArray();
            if (split.Length != 2) return false;
            return 0 <= split[0] && split[0] < 24 && 0 <= split[1] && split[1] < 60;
        }
    }
}
