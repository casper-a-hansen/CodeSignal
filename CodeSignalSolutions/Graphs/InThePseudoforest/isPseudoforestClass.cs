/*
    Status:   Solved
    Imported: 2020-05-14 23:38
    By:       Casper
    Url:      https://app.codesignal.com/arcade/graphs-arcade/in-the-pseudoforest/4neXxESSsRy92ghTD

    Description:
        You and your friend are walking in the woods. You are gathering mushrooms and
        catching butterflies, and your friend is drawing a map of the woods: he is a
        very cautious person, who doesn't want to get lost. When you get tired of
        running around, you decide to check out the map your friend has drawn so far,
        and it strikes you: looks like the woods you're walking in represent a
        pseudoforest!
        Since you're a programmer and think in terms of algorithms, you need to write a
        function that, given a map, determines whether it is a pseudoforest or not. The
        map your friend drew represents a graph wmap of n vertices. A map is called
        pseudoforest if each of its connected components contains no more than one
        cycle.
        Example
        For n = 7 and wmap = [[0, 1], [1, 2], [2, 3], [3, 1], [3, 4], [5, 6]], the
        output should be
        isPseudoforest(n, wmap) = true.
        One of the connected components contains only one cycle (1 - 2 - 3), and the
        other one has no cycles at all.
        For n = 7 and wmap = [[0, 1], [1, 2], [2, 3], [3, 1], [3, 4], [4, 0], [5, 6]],
        the output should be
        isPseudoforest(n, wmap) = false.
        There are three cycles in one of the connected components:
        1 - 2 - 3;
        1 - 3 - 4 - 0;
        0 - 1 - 2 - 3 - 4.
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] integer n
        Number of vertices in a map.
        Guaranteed constraints:
        1 ≤ n ≤ 105.
        [input] array.array.integer wmap
        Edges drawn on the map. wmap[i] contains two elements and represents one edge
        for each valid i.
        It is guaranteed that between any two vertices there is no more than one edge.
        Guaranteed constraints:
        0 ≤ wmap.length ≤ 105,
        wmap[i].length = 2,
        0 ≤ wmap[i][j] < n,
        wmap[i][0] ≠ wmap[i][1].
        [output] boolean
        true if wmap represents a pseudoforest and false otherwise.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Graphs.InThePseudoforest
{
    class isPseudoforestClass
    {
        bool isPseudoforest(int n, int[][] wmap) {
            if (wmap.Length <= 1) return true;
            var dic = wmap
                .SelectMany(a => new int[][]{a, new[]{a[1],a[0]}})
                .GroupBy(a => a[0])
                .ToDictionary(g => g.Key, g => g.Select(a => a[1]).ToHashSet());
            var visited = new bool[n];
            for(var i = 0; i < n; i++)
            {
                if (visited[i]) continue;
                var stack = new Stack<int>();
                stack.Push(i);
                int loops = 0;
                visited[i] = true;
                while(stack.Count != 0)
                {
                    var v = stack.Pop();
                    if (!dic.TryGetValue(v, out var list)) continue;
                    foreach(var w in list.ToArray())
                    {
                        if (visited[w])
                        {
                            if (++loops == 2) return false;
                        }
                        visited[w] = true;
                        stack.Push(w);
                        dic[v].Remove(w);
                        dic[w].Remove(v);
                    }
                }
            }
            return true;
        }
    }
}
