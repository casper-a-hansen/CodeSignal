/*
    Status:   Solved
    Imported: 2020-05-02 13:10
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/time-river/DKjM5qLz5ccK2ukhH

    Description:
        You have been watching a video for some time. Knowing the total video duration
        find out what portion of the video you have already watched.
        Example
        For part = "02:20:00" and total = "07:00:00", the output should be
        videoPart(part, total) = [1, 3].
        You have watched 1 / 3 of the whole video.
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] string part
        A string of the following format "hh:mm:ss" representing the time you have been
        watching the video.
        [input] string total
        A string of the following format "hh:mm:ss" representing the total video
        duration.
        [output] array.integer
        An array of the following format [a, b] (where a / b is a reduced fraction).
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.TimeRiver
{
    class videoPartClass
    {
        int[] videoPart(string part, string total) {
            var p = part.Split(':').Reverse().Select((s, i) => (int)(int.Parse(s) * Math.Pow(60, i))).Sum();
            var t = total.Split(':').Reverse().Select((s, i) => (int)(int.Parse(s) * Math.Pow(60, i))).Sum();
            Console.WriteLine($"{p} / {t}");
            bool found = true;
            while(found) {
                found = false;
                for(var v = 2; v <= p; v++) {
                    if (p % v == 0 && t % v == 0) {
                        p = p / v;
                        t = t / v;
                        Console.WriteLine($"{p} / {t}");
                        found = true;
                        break;
                    }
                }
            }
            Console.WriteLine($"{p} / {t}");
            return new int[]{p, t};
        }
    }
}
