/*
    Status:   Solved
    Imported: 2020-05-04 22:58
    By:       Casper
    Url:      https://app.codesignal.com/arcade/graphs-arcade/kingdom-roads/pmmMeP4JkqgKbzyTy

    Description:
        Once upon a time, in a kingdom far, far away, there lived a King Byteasar VII.
        Since he reigned during the Dark Times, very little is known about his reign. It
        is known that when he ascended the throne, there were n cities in the kingdom,
        connected by several two-way roads. But before the young king managed to start
        ruling, an enemy arrived at the gates: the evil emperor Bugoleon invaded the
        kingdom and started to conquer the cities, advancing day after day.
        It is not known how long it took to capture each of the cities, but you've
        recently discovered an ancient manuscript describing that each day, Bugoleon
        captured all the cities that had at most 1 neighboring free city at that given
        moment. Knowing this fact, the number of cities n and all the roads of the
        kingdom, determine in how many days each of the cities was conquered.
        Example
        For n = 10 and
        roads = [[1, 0], [1, 2], [8, 5], [9, 7],
        [5, 6], [5, 4], [4, 6], [6, 7]]
        the output should be
        citiesConquering(n, roads) = [1, 2, 1, 1, -1, -1, -1, 2, 1, 1].
        Here's how the cities were conquered:
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] integer n
        The number of cities in the kingdom.
        Guaranteed constraints:
        1 ≤ n ≤ 100.
        [input] array.array.integer roads
        Array of two-way roads, where each road is given in the format [city1, city2],
        meaning that city1 and city2 are connected. It is guaranteed that there is at
        most one road between two cities, and no road is given twice.
        Guaranteed constraints:
        0 ≤ roads.length ≤ n · (n - 1) / 2,
        roads[i].length = 2,
        roads[i][0] ≠ roads[i][1],
        0 ≤ roads[i][j] < n.
        [output] array.integer
        An array of length n, there the ith element is the number of days it took to
        conquer the ith city, or -1 if the city wasn't conquered.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Graphs.KingdomRoads
{
    class citiesConqueringClass
    {
        int[] citiesConquering(int n, int[][] roads) {
            var cities = roads
                .SelectMany(r => new int[][]{r, new int[]{r[1], r[0]}})
                .GroupBy(r => r[0])
                .ToDictionary(g => g.Key, g => g.Select(r => r[1]).ToHashSet());
            var result = Enumerable.Range(0, n).Select(_ => 1).ToArray();
            for(var d = 1; d <= n; d++)
            {
                var conquered = cities
                    .Where(i => i.Value.Count <= 1)
                    .Select(i => new int[]{i.Key, i.Value.Count == 0 ? -1 : i.Value.FirstOrDefault()})
                    .ToList();
                if (conquered.Count == 0) break;
                Console.WriteLine($"Conquered: {string.Join(",", conquered.Select(c => c[0]))}");
                foreach(var remove in conquered)
                {
                    Console.WriteLine($"Remove {remove[0]}");
                    cities.Remove(remove[0]);
                    if (remove[1] != -1)
                    {
                        Console.WriteLine($"Remove road from {string.Join(" to ", remove)}");
                        if (cities.TryGetValue(remove[1], out HashSet<int> value))
                        {
                            value.Remove(remove[0]);
                        }
                    }
                    result[remove[0]] = d;
                    Console.WriteLine($"New result {string.Join(",", result)}");
                }
            }
            foreach(var city in cities)
            {
                result[city.Key] = -1;
            }
            return result;
        }
    }
}
