/*
    Status:   Solved
    Imported: 2020-05-10 12:52
    By:       Casper
    Url:      https://app.codesignal.com/arcade/graphs-arcade/contours-of-everything/3QCs2Td5vzj8sorAR

    Description:
        You decided to create an automatic image recognizer that will determine the
        object in the image based on its contours. The main recognition system is
        already implemented, and now you need to start the teaching process.
        Today you want to teach your program to recognize star patterns in the image of
        the night sky, which means that you need to implement a function that, given the
        adjacency matrix representing a number of contours in the sky, will find the
        number of stars in it.
        The graph representing some contour is cosidered to be a star if it is a tree of
        size 2 or if it is a tree of size k > 2 with one internal node (which is a tree
        root at the same time) and k - 1 leaves.
        Here is an example of some stars:
        Given the sky objects' contours as an undirected graph represented by its
        adjacency matrix adj, calculate the number of stars in it.
        Example
        For
        adj = [[false, true, false, false, false],
        [true, false, false, false, false],
        [false, false, false, true, false],
        [false, false, true, false, false],
        [false, false, false, false, false]]
        the output should be
        countStars(adj) = 2.
        Here's what the given graph looks like:
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] array.array.boolean adj
        An adjacency matrix of an undirected graph.
        Guaranteed constraints:
        2 < adj.length ≤ 100,
        adj[i].length == adj.length.
        [output] integer
        The number of star contours in the sky.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Graphs.ContoursOfEverything
{
    class countStarsClass
    {
        int countStars(bool[][] adj) {
            var roads = new List<int[]>();
            var cities = new int[adj.Length];
            for(var f = 0; f < adj.Length; f++)
            {
                for(var t = f; t < adj.Length; t++)
                {
                    if (adj[f][t])
                    {
                        roads.Add(new[]{f, t});
                        cities[f]++;
                        cities[t]++;
                    }
                }
            }
        //    Console.WriteLine($"Roads: {roads.Count}");
        //    Console.WriteLine($"Cities: {string.Join(",", cities)}");
            var taken = new HashSet<int>();
            int result = 0;
            for(var r = 0; r < roads.Count; r++)
            {
                if (!taken.Add(roads[r][0])) continue;
                taken.Add(roads[r][1]);
        //        Console.WriteLine($"Taken: {string.Join(",", taken)}");
                var star = roads[r].ToHashSet();
                var s = r + 1;
                while(s < roads.Count)
                {
                    if (star.Contains(roads[s][0]) || star.Contains(roads[s][1]))
                    {
                        taken.Add(roads[s][0]);
                        taken.Add(roads[s][1]);
        //                Console.WriteLine($"Taken: {string.Join(",", taken)}");
        //                Console.WriteLine($"Findings {r}: {string.Join(",", star)}");
                        if (!(!star.Add(roads[s][0]) && !star.Add(roads[s][1])))
                        {
                            s = r;
        //                    Console.WriteLine($"Findings {r}: {string.Join(",", star)}");
                        }
                    }
                    s++;
                }
                if (star.Count == 2)
                {
        //            Console.WriteLine($"Star: {string.Join(",", star)}");
                    result++;
                }
                else if (star.Count >= 3)
                {
                    // Looking for only one center.
                    if (star.Count(i => cities[i] != 1) == 1)
                    {
                        var city = star.First(i => cities[i] != 1);
                        if (cities[city] != star.Count - 1) continue;   // Has a road from center to center.
        //                Console.WriteLine($"Star: {string.Join(",", star)}");
                        result++;
                    }
                }
            }
            return result;
        }
    }
}
