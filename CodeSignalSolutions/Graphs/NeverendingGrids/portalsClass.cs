/*
    Status:   Solved
    Imported: 2020-06-07 11:37
    By:       Casper
    Url:      https://app.codesignal.com/arcade/graphs-arcade/neverending-grids/9dANZWyT332KTyJCw

    Description:
        Little Ratiorg was so tired of being bullied by other bots and mighty
        CodeFighters that he decided to join the Ninja Bots Training camp. It is known
        that any bot that manages to solve all the challenges becomes an ultimate master
        of algorithms, and that is exactly what Ratiorg is aiming at.
        Ratiorg has already improved his physical strength considerably, and now it's
        time to hone his mental skills. As it turned out, the bot has what it takes to
        be a great magician: he has what appears to be an infinite source of mana
        somewhere inside his little mechanical body. In the next challenge, Ratiorg will
        have to use it. The bot is standing in the top left corner of the rectangular
        grid, some cells of which are impassable. His goal is to make it to the bottom
        right corner in no more than maxTime seconds.
        Ratiorg can move between two passable cells if they share a common side, and
        each move takes 1 second. He can also set an arbitrary number of portals into
        passable cells; moreover, he can even set them remotely and instantly, i.e.
        there's no need to reach the cell to set a portal there, and setting a portal
        takes no time. Ratiorg can instantly move between any pair of cells with
        portals. However, setting a portal to the cell at (x, y) costs manacost[x][y]
        mana points.
        Given the maxTime and the manacost matrix, calculate the minimum amount of mana
        Ratiorg will have to use to finish the challenge in time.
        Example
        For maxTime = 4 and
        manacost = [[1, -1, -1],
        [5, -1, -1],
        [4,  6,  8]]
        the output should be portals(maxTime, manacost) = 0.
        The cheapest way to get to the bottom right corner takes 4 seconds and doesn't
        require any portals.
        For maxTime = 3 and
        manacost = [[1, -1, -1],
        [5, -1, -1],
        [4,  6,  8]]
        the output should be
        portals(maxTime, manacost) = 5.
        The best plan is to set portals into the top left and the bottom left corners
        (the total manacost equals 1 + 4 = 5). After that, you can reach the bottom left
        corner instantly and then make two moves rightwards in 2 seconds.
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] integer maxTime
        A non-negative integer, the maximum number of seconds you can spend to get to
        the bottom right corner.
        Guaranteed constraints:
        0 ≤ maxTime ≤ 200.
        [input] array.array.integer manacost
        A rectangular matrix. If manacost[x][y] > 0, then the cell (x, y) is passable
        and it costs manacost[x][y] mana points to set a portal into it. Otherwise
        cost[x][y] = -1, and the cell (x, y) is impassable.
        It is guaranteed that both the top left corner (manacost[0][0]) and the bottom
        right corner (manacost[manacost.length - 1][manacost[0].length - 1]) are
        passable.
        Guaranteed constraints:
        1 ≤ manacost.length ≤ 300,
        1 ≤ manacost[0].length ≤ 300,
        -1 ≤ manacost[i][j] ≤ 1000.
        [output] integer
        The minimum number of mana points required to get to the bottom right corner.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Graphs.NeverendingGrids
{
    class portalsClass
    {
        bool reachedEnd = false;
        int portals(int maxTime, int[][] manacost)
        {
            var startList = Walk(manacost, (x: 0, y: 0), maxTime).ToArray();
            if (reachedEnd) return 0;
            if (startList.Length == 0) return 0;
            var endList = Walk(manacost, (x: manacost[0].Length - 1, y: manacost.Length - 1), maxTime).ToArray();
            if (endList.Length == 0) return 0;
            return startList.SelectMany(s => endList.Where(e => s.seconds + e.seconds <= maxTime).Select(e => s.mana + e.mana)).Min();
        }
        static (int x, int y)[] directions = new (int x, int y)[]{ (0, 1), (0, -1), (1, 0), (-1, 0) };
        IEnumerable<(int mana, int seconds)> Walk(int[][] manacost, (int x, int y) start, int maxTime)
        {
            var used = manacost.Select(a => a.Select(m => m == -1).ToArray()).ToArray();
            reachedEnd = false;
            var queue = new Queue<(int x, int y, int seconds)>();
            queue.Enqueue((start.x, start.y, 0));
            while(queue.Count > 0)
            {
                var p = queue.Dequeue();
                if (p.x == manacost[0].Length - 1 && p.y == manacost.Length - 1) reachedEnd = true;
                if (used[p.y][p.x]) continue;
                used[p.y][p.x] = true;
                yield return (mana: manacost[p.y][p.x], p.seconds);
                var seconds = p.seconds + 1;
                if (seconds > maxTime) continue;
                foreach(var d in directions)
                {
                    var x = p.x + d.x;
                    var y = p.y + d.y;
                    if (x < 0 || x >= manacost[0].Length || y < 0 || y >= manacost.Length) continue;
                    if (used[y][x]) continue;
                    queue.Enqueue((x, y, seconds));
                }
            }
        }
    }
}
