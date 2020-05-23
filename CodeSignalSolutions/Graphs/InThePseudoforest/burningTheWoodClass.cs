/*
    Status:   Solved
    Imported: 2020-05-17 19:23
    By:       Casper
    Url:      https://app.codesignal.com/arcade/graphs-arcade/in-the-pseudoforest/GeaKuCxLvje3bfsBx

    Description:
        You've been walking in the woods you got so attached to for the entire day. The
        weather was nice and warm, the smell of the nature was wonderful, and you got so
        carried away (both literally and virtually) that didn't even notice when it
        started to get cold. Your home is too far from your current location, and you're
        barely standing on your feet having walked for so long, so you have no other
        option but to make your bed right where you are.
        Since it's really cold already, you'd like to start a campfire. Of course
        playing with fire is a bad idea, especially in dry woods, but you didn't sleep
        last night and need at least k hours of sleep to think straight the next day.
        You assume that if the fire starts in some meadow, each hour it'll spread to all
        the neighboring meadows, each of which will in turn set their neighboring
        meadows on fire in another hour.
        There are n meadows in the forest, and you're going to start a campfire in your
        current meadow start. Knowing how the meadows are connected (this information is
        given as a matrix wmap), find out which meadows may be on fire when you wake up
        after k hours and return the list of these meadows sorted in ascending order
        (don't worry about yourself - woods around you are not dry, so the fire in your
        meadow won't hurt you).
        Example
        For n = 5, wmap = [[0, 1], [1, 2], [2, 3], [3, 4], [4, 0]],
        start = 0, and k = 1, the output should be
        burningTheWood(n, wmap, start, k) = [0, 1, 4].
        For n = 7,
        wmap = [[0, 1], [1, 2], [2, 3], [3, 4],
        [4, 5], [5, 6], [6, 0], [4, 1]]
        start = 0, and k = 2, the output should be
        burningTheWood(n, wmap, start, k) = [0, 1, 2, 4, 5, 6].
        At the beginning of the first hour meadow 0 starts burning. At the second hour
        meadows 1 and 6 start burning as well. At the third hour neighbors of meadow 1 -
        meadows 2 and 4 - catch on fire, and so does the only neighbor of meadow 6 -
        meadow 5. So, at the end of the third hour meadows 0, 1, 2, 4, 5 and 6 will be
        on fire.
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] integer n
        The number of meadows in the forest.
        Guaranteed constraints:
        1 ≤ n ≤ 5 · 104.
        [input] array.array.integer wmap
        The information about the connected meadows. wmap[i] for each valid i contains
        two elements and represents a road that connects wmap[i][0] and wmap[i][1].
        It is guaranteed that between any two vertices there is no more than one edge.
        Guaranteed constraints:
        0 ≤ wmap.length ≤ 5 · 104,
        wmap[i].length = 2,
        0 ≤ wmap[i][j] < n.
        [input] integer start
        The meadow where you're going to start a campfire.
        Guaranteed constraints:
        0 ≤ start < n.
        [input] integer k
        The number of hours you're going to sleep.
        Guaranteed constraints:
        0 ≤ k ≤ 103.
        [output] array.integer
        The list of meadows that may be on fire in k hours sorted in ascending order.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Graphs.InThePseudoforest
{
    class burningTheWoodClass
    {
        int[] burningTheWood(int n, int[][] wmap, int start, int k) {
            var dic = wmap
                .SelectMany(a => new int[][]{a, new []{a[1],a[0]}})
                .GroupBy(a => a[0])
                .ToDictionary(g => g.Key, g => g.Select(a => a[1]).ToArray());
            var burned = new bool[n];
            var result = new List<int>();
            var fire = new List<int>{start};
            for(var i = -1; i < k; i++)
            {
                var nextFire = new List<int>();
                foreach(var f in fire)
                {
                    if (burned[f]) continue;
                    burned[f] = true;
                    result.Add(f);
                    if (dic.TryGetValue(f, out var list))
                    {
                        nextFire.AddRange(list);
                    }
                }
                fire = nextFire;
            }
            result.Sort();
            return result.ToArray();
        }
    }
}
