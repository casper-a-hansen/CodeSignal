/*
    Status:   Solved
    Imported: 2020-05-30 16:08
    By:       Casper
    Url:      https://app.codesignal.com/arcade/graphs-arcade/neverending-grids/HPiABBdPjKW8JvLAy

    Description:
        Little Ratiorg was tired of being bullied by other bots and mighty CodeFighters,
        so he joined the Ninja Bots Training camp. Any bot that manages to solve all the
        challenges becomes an ultimate master of algorithms, and that is exactly what
        Ratiorg wants.
        It's been several weeks, and Ratiorg is getting strong enough that he's making
        some enemies. They're starting to feel threatened, which is why they sabotaged
        his next challenge. Here's how they did it:
        Ratiorg is about to be locked up in one of multiple rooms in a rectangular
        hangar. The rooms are securely locked: it is possible to leave a room only in
        one direction specific to this room. The problem is, the villains have messed
        the system up, so now there is no way to finish the challenge from certain
        rooms. The challenge will be over if Ratiorg successfully leaves the hangar
        (i.e. leaves the rectangle that represents it).
        To figure out the odds of Ratiorg's success, you'd like to calculate the number
        of rooms, starting from which Ratiorg won't be able to finish the challenge.
        Implement a function that will return this number.
        Example
        For
        hangar = [['U', 'L'],
        ['R', 'L']]
        the output should be
        sabotage(hangar) = 2.
        Ratiorg won't be able to get out of the hangar if he starts from either of the
        bottom rooms.
        Check out the image below for more context:
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] array.array.char hangar
        A non-empty rectangular matrix. The possible values of hangar[i] are:
        'L' if it's possible to move to the left;
        'R' if it's possible to move to the right;
        'U' if it's possible to move up;
        'D' if it's possible to move down.
        Guaranteed constraints:
        1 ≤ hangar.length ≤ 150,
        1 ≤ hangar[0].length ≤ 150.
        [output] integer
        The number of rooms from which it's impossible to finish the challenge.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Graphs.NeverendingGrids
{
    class sabotageClass
    {
        int sabotage(char[][] hangar) {
            int result = 0;
            for(var y = 0; y < hangar.Length; y++)
            {
                for(var x = 0; x < hangar[0].Length; x++)
                {
                    if (CannotLeave(hangar, x, y)) result++;
                }
            }
            return result;
        }
        bool CannotLeave(char[][] hangar, int x, int y)
        {
            // L, R, U, D gives directions in untested rooms
            // t = currently testing this room
            // i = infinite loop (cannot leave room)
            // o = Going out.
            var tested = new List<(int x, int y)>();
            while(true)
            {
                var command = hangar[y][x];
                switch(command)
                {
                    case 'L':
                        hangar[y][x] = 't';
                        tested.Add((x, y));
                        x--;
                        break;
                    case 'R':
                        hangar[y][x] = 't';
                        tested.Add((x, y));
                        x++;
                        break;
                    case 'U':
                        hangar[y][x] = 't';
                        tested.Add((x, y));
                        y--;
                        break;
                    case 'D':
                        hangar[y][x] = 't';
                        tested.Add((x, y));
                        y++;
                        break;
                    case 'o':
                        foreach (var p in tested)
                            hangar[p.y][p.x] = 'o';
                        return false;
                    case 't':
                    case 'i':
                        foreach (var p in tested)
                            hangar[p.y][p.x] = 'i';
                        return true;
                }
                if (y < 0 || y >= hangar.Length || x < 0 || x >= hangar[0].Length)
                {
                    foreach (var p in tested)
                        hangar[p.y][p.x] = 'o';
                    return false;
                }
            }
        }
    }
}
