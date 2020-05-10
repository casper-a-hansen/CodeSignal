/*
    Status:   Solved
    Imported: 2020-05-10 12:52
    By:       Casper
    Url:      https://app.codesignal.com/arcade/graphs-arcade/contours-of-everything/ZCzzBYpY8W5BPnNyb

    Description:
        You decided to create an automatic image recognizer that will determine the
        object in the image based on its contours. The main recognition system is
        already implemented, and now you need to start the teaching process.
        Today you want to teach your program to recognize wheel patterns, which means
        that you need to implement a function that, given the adjacency matrix
        representing the contour, will determine whether it's a wheel or not.
        The wheel contour can be thought of as a single center vertex and a regular
        polygon with n (n > 2) vertices which are all connected to the center. Here is
        an example:
        Given the object's contour as an undirected graph represented by its adjacency
        matrix adj determine whether it's a wheel or not.
        Example
        For
        adj = [[false, true, true, true, true],
        [true, false, true, false, true],
        [true, true, false, true, false],
        [true, false, true, false, true],
        [true, true, false, true, false]]
        the output should be
        isWheel(adj) = true.
        Here's what the given graph looks like:
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] array.array.boolean adj
        An adjacency matrix of an undirected graph.
        Guaranteed constraints:
        3 < adj.length < 100,
        adj[i].length == adj.length.
        [output] boolean
        true if the given contour is a wheel, false otherwise.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Graphs.ContoursOfEverything
{
    class isWheelClass
    {
        bool isWheel(bool[][] adj) {
            if (Enumerable.Range(0, adj.Length).Any(i => adj[i][i])) return false;
            // Check center.
            var centers = adj.Select((a, i) => (i, b: a.Count(c => c) == adj.Length - 1)).Where(t => t.b).Select(t => t.i).ToArray();
            Console.WriteLine($"Centers: {string.Join(",", centers)}");
            if (adj.Length == 4 && centers.Length == 4) return true;
            if (centers.Length != 1) return false;
            // Check ring.
            var taken = new HashSet<int>() { centers[0] };
            var start = centers[0] == 0 ? 1 : 0;
            var city = start;
            try
            {
                while(true)
                {
                    Console.WriteLine($"City: {city} - taken {string.Join(",", taken)}");
                    if (!taken.Add(city)) return false;
                    var next = Enumerable.Range(0, adj.Length).First(c => adj[city][c] && !taken.Contains(c));
                    if (next == start) return false;
                    city = next;
                }
            }
            catch (InvalidOperationException)
            {
                return taken.Count == adj.Length;
            }
        }
    }
}
