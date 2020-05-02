/*
    Status:   Solved
    Imported: 2020-05-03 00:06
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/secret-archives/oAwCH6ecrzA4ARb6d

    Description:
        During your most recent trip to Codelandia you decided to buy a brand new
        CodePlayer, a music player that (allegedly) can work with any possible media
        format. As it turns out, this isn't true: the player can't read lyrics written
        in the LRC format. It can, however, read the SubRip format, so now you want to
        translate all the lyrics you have from LRC to SubRip.
        Since you are a pro programmer (no noob would ever get to Codelandia!), you're
        happy to implement a function that, given lrcLyrics and songLength, returns the
        lyrics in SubRip format.
        Example
        For
        lrcLyrics = ["[00:12.00] Happy birthday dear coder,",
        "[00:17.20] Happy birthday to you!"]
        and songLength = "00:00:20", the output should be
        lrc2subRip(lrcLyrics, songLength) = [
        "1",
        "00:00:12,000 --> 00:00:17,200",
        "Happy birthday dear coder,",
        "",
        "2",
        "00:00:17,200 --> 00:00:20,000",
        "Happy birthday to you!"
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] array.string lrcLyrics
        Lyrics in LRC format. Each string has the format [MM:SS.xx] <song_line>, (note
        the whitespace character after the time) where:
        MM:SS.xx is the lyrics time (it is guaranteed that the elements of lrcLyrics are
        sorted in ascending order of this time);
        0 ≤ int(xx) ≤ 99;
        0 ≤ int(SS) ≤ 59;
        0 ≤ int(MM) ≤ 99;
        <song_line> is the corresponding lyrics line.
        Guaranteed constraints:
        1 ≤ lrcLyrics.length ≤ 50,
        1 ≤ lrcLyrics[i].length ≤ 100.
        [input] string songLength
        The length of the song in the format "HH:MM:SS". It is guaranteed that it is
        greater than the last time in lrcLyrics.
        Guaranteed constraints:
        0 ≤ int(HH) ≤ 2,
        0 ≤ int(MM) ≤ 59,
        0 ≤ int(SS) ≤ 59.
        [output] array.string
        The given lyrics in the SubRip format. For each line in the lrcLyrics, three new
        lines should be generated:
        the first line is the 1-based lyrics line number;
        the second line should be in the format HH1:MM1:SS1,xxx1 --> HH2:MM2:SS2,xxx2,
        where:
        HH1:MM1:SS1,xxx1 the time the row starts;
        HH2:MM2:SS2,xxx2 when the next lyrics should appear, or the length of the song
        if it's the last lyrics line;
        the last line is the lyrics text itself.
        Each pair of consecutive three-lines groups should be separated by a single
        empty string.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.SecretArchives
{
    class lrc2subRipClass
    {
        string[] lrc2subRip(string[] lrcLyrics, string songLength) {
            Regex regex = new Regex(@"^\[(.*?)\]\s*(.*)$");
            List<string> result = new List<string>();
            for(var i = 0; i < lrcLyrics.Length; i++) {
                result.Add((i + 1).ToString());
                var match = regex.Match(lrcLyrics[i]);
                var len = songLength + ",000";
                if ( i + 1 < lrcLyrics.Length) {
                    len = TransMorgrif(regex.Match(lrcLyrics[i + 1]).Groups[1].Value);
                }
                Console.WriteLine($"{match.Groups[1].Value} - {len}");
                result.Add($"{TransMorgrif(match.Groups[1].Value)} --> {len}");
                result.Add(match.Groups[2].Value);
                if ( i + 1 < lrcLyrics.Length) {
                    result.Add("");
                }
            }
            return result.ToArray();
        }
        string TransMorgrif(string inputString) {
            // 00:17.20 -> 00:00:17,200
            var split = inputString.Split(':', '.');
            var min = int.Parse(split[0]);
            split[0] = (min / 60).ToString("00") + ":" + (min % 60).ToString("00");
            return inputString = split[0] + ":" + split[1] + "," + split[2] + "0";
        }
    }
}
