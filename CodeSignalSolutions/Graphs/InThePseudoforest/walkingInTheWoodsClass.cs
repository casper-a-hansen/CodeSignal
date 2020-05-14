/*
    Status:   Solved
    Imported: 2020-05-14 23:37
    By:       Casper
    Url:      https://app.codesignal.com/arcade/graphs-arcade/in-the-pseudoforest/PfY5xCr3SYfSmAgar

    Description:
        After you got lost in the woods the last time, you made sure to memorize the
        entire map, so now you can walk around without the fear. When you were studying
        the map, you realized that it might be impossible to visit all the meadows
        walking on the roads. In order to get from one set of connected meadows to the
        other one has to go thought the thicket of thistle.
        Naturally, you don't want to struggle through the thicket too often. Given the
        number of meadows n and the map of the woods wmap storing the information about
        the roads connecting them, calculate the minimal number of times you'd have to
        go off the roads in order to visit all the meadows in one run.
        Example
        For n = 5 and wmap = [[0, 1], [2, 1], [0, 2], [3, 4]], the output should be
        walkingInTheWoods(n, wmap) = 1.
        Starting from any of first three meadows, you can visit any of them, then visit
        meadow 3 walking through thicket, and then visit meadow 4.
        Starting from any of two last meadows, you can do the same thing.
        For n = 6 and wmap = [[0, 1], [2, 1], [0, 2], [3, 4]], the output should be
        walkingInTheWoods(n, wmap) = 2.
        Here you need to visit one more meadow that isn't connected to any of the other
        ones, so you'll need to walk through the thicket one more time.
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] integer n
        The number of meadows in the woods.
        Guaranteed constraints:
        1 ≤ n ≤ 105.
        [input] array.array.integer wmap
        Edges drawn on the map. wmap[i] for each valid i contains two elements and
        represents a road that connects wmap[i][0] and wmap[i][1].
        It is guaranteed that between any two vertices there is no more than one edge.
        Guaranteed constraints:
        0 ≤ wmap.length ≤ 105,
        wmap[i].length = 2,
        0 ≤ wmap[i][j] < n.
        [output] integer
        The minimal number of times you'll need to walk through the thicket to visit all
        the meadows.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Graphs.InThePseudoforest
{
    class walkingInTheWoodsClass
    {
        int walkingInTheWoods(int n, int[][] wmap) {
            var dic = wmap
                .SelectMany(a => new int[][]{a, new []{a[1],a[0]}})
                .GroupBy(a => a[0])
                .ToDictionary(g => g.Key, g => g.Select(a => a[1]).ToArray());
            var visited = new bool[n];
            int result = 0;
            for(var i = 0; i < n; i++)
            {
                if (visited[i]) continue;
                result++;
                var stack = new Stack<int>();
                stack.Push(i);
                while(stack.Count > 0)
                {
                    var v = stack.Pop();
                    if (!dic.TryGetValue(v, out var list)) continue;
                    foreach(var d in list)
                    {
                        if (visited[d]) continue;
                        visited[d] = true;
                        stack.Push(d);
                    }
                }
            }
            return result - 1;
        }
        /*int walkingInTheWoods(int n, int[][] wmap) {
            var group = new int[n];
            var groupNo = 0;
            var connections = new HashSet<long>();
            foreach(var map in wmap)
            {
                var m0 = map[0];
                var m1 = map[1];
                var g0 = group[m0];
                var g1 = group[m1];
                if (g0 != 0)
                {
                    if (g1 == 0) group[m1] = g0;
                    else if (g1 != g0) connections.Add((long)g1 * n + g0);
                }
                else if (g1 != 0)
                {
                    if (g0 == 0) group[m0] = g1;
                    else if (g0 != g1) connections.Add((long)g1 * n + g0);
                }
                else
                {
                    groupNo++;
                    group[m0] = groupNo;
                    group[m1] = groupNo;
                }
            }
            return groupNo + group.Count(n => n == 0) - connections.Count - 1;
        }*/
    }
}
