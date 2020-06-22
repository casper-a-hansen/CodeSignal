/*
    Status:   Solved
    Imported: 2020-06-14 22:30
    By:       Casper
    Url:      https://app.codesignal.com/arcade/graphs-arcade/orienteering/eoScXP4FKuWtcEuGQ

    Description:
        Not long ago you saw an orienteering competition on TV and immediately wanted to
        try it yourself. You've joined an orienteering club and started preparing for
        the upcoming competitions. You liked participation so much that you decided to
        organize your very own competition, and an unusual one.
        In this race the participants should find such a path from start to finish that
        they will spend no more than T minutes on each road. When a participant leaves a
        location, the time on their stopwatch is set to T, and the countdown begins. If
        they can't make it to the next location in T seconds, they lose the race.
        You have already picked a location for the start, but not yet settled for the
        finish. To decide which location to choose, for each of the n locations you'd
        like to calculate the minimum value of T that makes it possible to complete the
        race from start to this location.
        Given the start location, the number of locations n and the roads connecting
        them, return the number of different minimum possible value of T for every
        finish location.
        Example
        For n = 5, start = 3, and
        roads = [[1, 2, 3],
        [2, 3, 1],
        [2, 4, 2],
        [3, 5, 4],
        [4, 5, 3]]
        the output should be
        timeConstrainedOrienteering(n, start, roads) = 4.
        The minimum possible values of T for locations from 1 to n are 3, 1, 0, 2 and 3
        respectively, 4 distinct values in total.
        Here's how the locations are connected:
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] integer n
        The number of locations.
        Guaranteed constraints:
        2 ≤ n ≤ 105.
        [input] integer start
        The location you picked as a start of the race.
        Guaranteed constraints:
        1 ≤ start ≤ n.
        [input] array.array.integer roads
        A two-dimensional array representing the roads. Each road is given in the format
        [loc1, loc2, t], which means that it takes t minutes to reach loc2 from loc1
        (both given 1-based).
        It is guaranteed that every two locations are connected by roads.
        Guaranteed constraints:
        1 ≤ roads.length ≤ 5 · 104,
        roads[i].length = 3,
        1 ≤ roads[i][0], roads[i][1] ≤ n,
        0 ≤ roads[i][2] ≤ 105.
        [output] integer
        The number of different possible values of T for the races that start at the
        start and end at the finish for every finish location from 1 to n.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Graphs.Orienteering
{
    class timeConstrainedOrienteeringClass
    {
        int timeConstrainedOrienteering(int n, int start, int[][] roads)
        {
            var adj = Enumerable.Range(0, n).Select(_ => new List<(int vertice, int time)>()).ToArray();
            foreach(var road in roads)
            {
                adj[road[0] - 1].Add((road[1], road[2]));
                adj[road[1] - 1].Add((road[0], road[2]));
            }
            var time = Enumerable.Range(0, n).Select(_ => int.MaxValue).ToArray();
            var stack = new SortedSet<(int vertice, int time)>();
            time[start - 1] = 0;
            stack.Add((start, time[start - 1]));
            while(stack.Count > 0)
            {
                var p = stack.First();
                stack.Remove(p);
                foreach (var a in adj[p.vertice - 1])
                {
                    if (time[a.vertice - 1] > Math.Max(p.time, a.time))
                    {
                        if (time[a.vertice - 1] != int.MaxValue)
                        {
                            stack.Remove((a.vertice, time[a.vertice - 1]));
                        }
                        time[a.vertice - 1] = Math.Max(p.time, a.time);
                        stack.Add((a.vertice, time[a.vertice - 1]));
                    }
                }
            }
            return time.Distinct().Count();
        }
        class Comparer : IComparer<(int vertice, int time)>
        {
            public int Compare((int vertice, int time) a, (int vertice, int time) b)
            {
                if (a.time != b.time) return a.time - b.time;
                return a.vertice - b.vertice;
            }
        }
    }
}
