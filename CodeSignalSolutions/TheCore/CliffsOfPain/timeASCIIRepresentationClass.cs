/*
    Status:   Solved
    Imported: 2020-05-02 21:38
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/cliffs-of-pain/iGBDQE3KjqbYyF8DH

    Description:
        John has always liked analog clocks more than digital ones. He's been dreaming
        about turning his digital clock into an analog one for as long as he can
        remember, and now he met you, a great programmer, so his dream is about to come
        true.
        The screen of his digital clock is a simple 17 × 17 rectangle of pixels. It
        always shows four digits: the first two stand for hours and second two for
        minutes (John's clock uses the 24-hour format). Each digit is located in a 17 ×
        4 rectangle, with the leftmost column always empty, and the other three columns
        filled according to this pattern with the proper scaling:
        After the first two digits there is a separating column containing one symbol
        ':' at its center.
        Now John asks you to make his clock show time in the format similar to analog
        clocks. Here's how: an analog clock can be represented as a circle (the clock's
        borders) and two segments (the clock's hands). To show it on the 17 × 17 screen,
        you should light the pixels on it so that the pixel with coordinates (x, y) is
        enabled if and only if the minimal distance to the circle or one of the segments
        is less than sqrt(0.5).
        John wants you to implement the function that changes the digital representation
        to the analog one as described above. Given a 17 × 17 rectangle dtime
        representing digital time representation, return the analog representation of
        the same time.
        Please note that for the early prototype you have to develop, both of the
        clock's hands should have the same length.
        Example
        For
        dtime = [
        ['.', '*', '*', '*', '.', '.', '*', '.', '.', '.', '*', '*', '*', '.', '*', '*',
        '*'],
        ['.', '*', '.', '*', '.', '.', '*', '.', '.', '.', '.', '.', '*', '.', '*', '.',
        '*'],
        ['.', '*', '.', '*', '.', '.', '*', '.', '.', '.', '.', '.', '*', '.', '*', '.',
        '*'],
        ['.', '*', '.', '*', '.', '.', '*', '.', '.', '.', '.', '.', '*', '.', '*', '.',
        '*'],
        ['.', '*', '.', '*', '.', '.', '*', '.', '.', '.', '.', '.', '*', '.', '*', '.',
        '*'],
        ['.', '*', '.', '*', '.', '.', '*', '.', '.', '.', '.', '.', '*', '.', '*', '.',
        '*'],
        ['.', '*', '.', '*', '.', '.', '*', '.', '.', '.', '.', '.', '*', '.', '*', '.',
        '*'],
        ['.', '*', '.', '*', '.', '.', '*', '.', '.', '.', '.', '.', '*', '.', '*', '.',
        '*'],
        ['.', '*', '.', '*', '.', '.', '*', '.', ':', '.', '*', '*', '*', '.', '*', '.',
        '*'],
        ['.', '*', '.', '*', '.', '.', '*', '.', '.', '.', '.', '.', '*', '.', '*', '.',
        '*'],
        ['.', '*', '.', '*', '.', '.', '*', '.', '.', '.', '.', '.', '*', '.', '*', '.',
        '*'],
        ['.', '*', '.', '*', '.', '.', '*', '.', '.', '.', '.', '.', '*', '.', '*', '.',
        '*'],
        ['.', '*', '.', '*', '.', '.', '*', '.', '.', '.', '.', '.', '*', '.', '*', '.',
        '*'],
        ['.', '*', '.', '*', '.', '.', '*', '.', '.', '.', '.', '.', '*', '.', '*', '.',
        '*'],
        ['.', '*', '.', '*', '.', '.', '*', '.', '.', '.', '.', '.', '*', '.', '*', '.',
        '*'],
        ['.', '*', '.', '*', '.', '.', '*', '.', '.', '.', '.', '.', '*', '.', '*', '.',
        '*'],
        ['.', '*', '*', '*', '.', '.', '*', '.', '.', '.', '*', '*', '*', '.', '*', '*',
        '*']
        the output should be
        timeASCIIRepresentation(dtime) = [
        ['.', '.', '.', '.', '*', '*', '*', '*', '*', '*', '*', '*', '*', '.', '.', '.',
        '.'],
        ['.', '.', '.', '*', '*', '.', '.', '.', '.', '.', '.', '.', '*', '*', '.', '.',
        '.'],
        ['.', '.', '*', '*', '.', '.', '.', '.', '.', '.', '.', '.', '.', '*', '*', '.',
        '.'],
        ['.', '*', '*', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '*', '*', '*',
        '.'],
        ['*', '*', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '*', '.', '.', '*',
        '*'],
        ['*', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '*', '.', '.', '.', '.',
        '*'],
        ['*', '.', '.', '.', '.', '.', '.', '.', '.', '.', '*', '.', '.', '.', '.', '.',
        '*'],
        ['*', '.', '.', '.', '.', '.', '.', '.', '.', '*', '.', '.', '.', '.', '.', '.',
        '*'],
        ['*', '.', '.', '.', '.', '.', '.', '.', '*', '.', '.', '.', '.', '.', '.', '.',
        '*'],
        ['*', '.', '.', '.', '.', '.', '.', '.', '*', '.', '.', '.', '.', '.', '.', '.',
        '*'],
        ['*', '.', '.', '.', '.', '.', '.', '.', '*', '.', '.', '.', '.', '.', '.', '.',
        '*'],
        ['*', '.', '.', '.', '.', '.', '.', '.', '*', '.', '.', '.', '.', '.', '.', '.',
        '*'],
        ['*', '*', '.', '.', '.', '.', '.', '.', '*', '.', '.', '.', '.', '.', '.', '*',
        '*'],
        ['.', '*', '*', '.', '.', '.', '.', '.', '*', '.', '.', '.', '.', '.', '*', '*',
        '.'],
        ['.', '.', '*', '*', '.', '.', '.', '.', '*', '.', '.', '.', '.', '*', '*', '.',
        '.'],
        ['.', '.', '.', '*', '*', '.', '.', '.', '*', '.', '.', '.', '*', '*', '.', '.',
        '.'],
        ['.', '.', '.', '.', '*', '*', '*', '*', '*', '*', '*', '*', '*', '.', '.', '.',
        '.']
        (Enabled pixels are painted red to make them more visible).
        Here is the geometrical representation of an analog clock showing time 01:30.
        Enabled pixel are painted red.
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] array.array.char dtime
        Digital time representation, where dtime[x][y] is equal to '*' if the pixel with
        coordinates (x, y) is enabled and '.' otherwise. It is guaranteed that the given
        time is correct, and that dtime[8][8] = ':'.
        Guaranteed constraints:
        dtime.length = 17,
        dtime[i].length = 17.
        [output] array.array.char
        Representation of the same time on the same rectangle, but in an analog clock
        format.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.CliffsOfPain
{
    class timeASCIIRepresentationClass
    {
        char[][] timeASCIIRepresentation(char[][] dtime) {
            var time = ReadTime(dtime);
            Console.WriteLine(time.ToString());
            char[][] result = Round();
            SetHand(result, (time.Hours * 60.0 + time.Minutes) / 720.0);
            SetHand(result, (double)time.Minutes / 60.0);
            return result;
        }
        // Content of the top row and the three middle rows (0,7,8,9)
        Dictionary<string, int> digits = new Dictionary<string, int>() {
            { "****.**.**.*", 0 },
            { ".*..*..*..*.", 1 },
            { "***..*****..", 2 },
            { "***..****..*", 3 },
            { "*.**.****..*", 4 },
            { "****..***..*", 5 },
            { "****..****.*", 6 },
            { "***..*..*..*", 7 },
            { "****.*****.*", 8 },
            { "****.****..*", 9 },
        };
        TimeSpan ReadTime(char[][] dtime)
        {
            int time = 0;
            foreach(var p in new [] {1, 5, 10, 14 })
            {
                var key = new string(new [] {0, 7, 8, 9}.SelectMany(r => Enumerable.Range(p, 3).Select(c => dtime[r][c])).ToArray());
                digits.TryGetValue(key, out int digit);
                Console.Write(digit);
                time = 10 * time + digit;
            }
            Console.WriteLine();
            return TimeSpan.FromMinutes((time / 100 * 60) + time % 100);
        }
        char[][] Round()
        {
            return new char[][] {
                "....*********....".ToArray(),
                "...**.......**...".ToArray(),
                "..**.........**..".ToArray(),
                ".**...........**.".ToArray(),
                "**.............**".ToArray(),
                "*...............*".ToArray(),
                "*...............*".ToArray(),
                "*...............*".ToArray(),
                "*...............*".ToArray(),
                "*...............*".ToArray(),
                "*...............*".ToArray(),
                "*...............*".ToArray(),
                "**.............**".ToArray(),
                ".**...........**.".ToArray(),
                "..**.........**..".ToArray(),
                "...**.......**...".ToArray(),
                "....*********....".ToArray(),
            };
        }
        double maxDist = Math.Sqrt(0.5);
        void SetHand(char[][] clock, double pos)
        {
            clock[8][8] = '*';
            var sin = Math.Sin(pos * Math.PI * 2.0);
            var cos = -Math.Cos((double) pos * Math.PI * 2.0);
            for (double i = 0.0; i <= 8.0; i += 0.2)
            {
                var yd = 8 + cos * i;
                var xd = 8 + sin * i;
                for(int y = (int)yd - 1; y <= (int)yd + 1; y++)
                {
                    if (y < 0 || y > 17) continue;
                    for (int x = (int)xd - 1; x <= (int)xd + 1; x++)
                    {
                        if (x < 0 || x > 17) continue;
                        var dist = Math.Abs(Math.Sqrt((yd - y) * (yd - y) + (xd - x) * (xd - x)));
                        if (dist < maxDist)
                        {
                            clock[y][x] = '*';
                        }
                    }
                }
            }
        }
    }
}
