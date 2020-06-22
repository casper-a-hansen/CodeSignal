/*
    Status:   Solved
    Imported: 2020-06-22 23:19
    By:       Casper
    Url:      https://app.codesignal.com/arcade/graphs-arcade/orienteering/vhRnxuezwBeLjy7y3

    Description:
        Not long ago you saw an orienteering competition on TV and immediately wanted to
        try it yourself. You've joined an orienteering club and started preparing for
        the upcoming competitions. You liked participation so much decided to organize
        your very own competition, and an unusual one.
        In this race the participants should find such a path from start to finish that
        they will spend no more than T minutes on each road. When a participant leaves a
        location, the time on their stopwatch is set to T, and the countdown begins. If
        they can't make it to the next location in T seconds, they lose the race.
        You haven't yet chosen locations for the start and for the finish. To decide
        which locations to chose, for each ordered pair of locations (a, b) you'd like
        to calculate the minimum value of T that makes it possible to complete the race
        that starts at a and finishes at b.
        Given the number of locations n and one-way roads connecting them, for every
        start and every finish locations return the minimum possible value of T.
        Example
        For n = 3 and
        roads = [[0, 1, 100000],
        [5, 0, 2],
        [4, -1, 0]]
        the output should be
        timeConstrainedOrienteering2(n, roads) = [[0, 1, 2],
        [4, 0, 2],
        [4, 4, 0]]
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] integer n
        The number of locations.
        Guaranteed constraints:
        2 ≤ n ≤ 120.
        [input] array.array.integer roads
        A two-dimensional array of roads represented by an adjacency matrix. Each
        element roads[i][j] is either a non-negative integer (that means that there
        exists a road from location i to location j and it takes roads[i][j] minutes to
        traverse it), or -1 if there is no road in that direction.
        Guaranteed constraints:
        roads.length = n,
        roads[i].length = n,
        -1 ≤ roads[i][j] ≤ 105,
        roads[i][i] = 0.
        [output] array.array.integer
        A square matrix of length n, where the element at the ith row and the jth column
        is the minimum possible value of T for the race that starts at the ith location
        and ends at the jth location. If there is no such T, it should be equal to -1
        instead.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Graphs.Orienteering
{
    class timeConstrainedOrienteering2Class
    {
        int[][] timeConstrainedOrienteering2(int n, int[][] roads) {
            var adj = Enumerable.Range(0, n).Select(_ => new List<(int vertice, int time)>(n)).ToArray();
            for(var a = 0; a < n; a++)
            {
                for(var b = 0; b < n; b++)
                {
                    if (a != b)
                    {
                        var time = roads[a][b];
                        if (time != -1) adj[a].Add((b, time));
                    }
                }
            }
            var result = new int[n][];
            for (var a = 0; a < n; a++)
            {
                var route = ShortestPath(adj, a);
                // route[0] is the shortest path from a to 0 and route[1] is the shortest path to 1
                for (var i = 0; i < route.Length; i++)
                {
                    if (route[i] == int.MaxValue)
                        route[i] = -1;
                }
                if (roads[a][a] != -1 && (route[a] == -1 || route[a] > roads[a][a]))
                    route[a] = roads[a][a];
                result[a] = route;
            }
            return result;
        }
        int[] ShortestPath(List<(int vertice, int time)>[] adj, int a)
        {
            var time = Enumerable.Range(0, adj.Length).Select(_ => int.MaxValue).ToArray();
            var stack = new SortedSet<(int vertice, int time)>(new Comparer());
            stack.Add((a, 0));
            while(stack.Count != 0)
            {
                var p = stack.First();
                stack.Remove(p);
                foreach (var r in adj[p.vertice])
                {
                    var newTime = Math.Max(p.time, r.time);
                    if (time[r.vertice] > newTime)
                    {
                        if (time[r.vertice] != int.MaxValue)
                        {
                            stack.Remove((r.vertice, time[r.vertice]));
                        }
                        time[r.vertice] = newTime;
                        stack.Add((r.vertice, newTime));
                    }
                }
            }
            return time;
        }
        class Comparer : IComparer<(int vertice, int time)>
        {
            public int Compare((int vertice, int time) a, (int vertice, int time) b)
            {
                if (a.time != b.time) return a.time.CompareTo(b.time);
                return a.vertice.CompareTo(b.vertice);
            }
        }
    }
}
