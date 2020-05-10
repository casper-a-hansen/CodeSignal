/*
    Status:   Solved
    Imported: 2020-05-10 12:52
    By:       Casper
    Url:      https://app.codesignal.com/arcade/graphs-arcade/contours-of-everything/shHv7RjLBCrDFN3np

    Description:
        You decided to create an automatic image recognizer that will determine the
        object in the image based on its contours. The main recognition system is
        already implemented, and now you need to start the teaching process.
        Today you want to teach your program to recognize butterfly patterns, which
        means that you need to implement a function that, given the adjacency matrix
        representing the contour, will determine whether it's a butterfly or not.
        The butterfly contour looks like this:
        Given the object's contour as an undirected graph represented by adjacency
        matrix adj determine whether it's a butterfly or not.
        Example
        For
        adj = [[false, true, true, false, false],
        [true, false, true, false, false],
        [true, true, false, true, true],
        [false, false, true, false, true],
        [false, false, true, true, false]]
        the output should be
        isButterfly(adj) = true.
        Here's what the given graph looks like:
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] array.array.boolean adj
        An adjacency matrix of an undirected graph.
        Guaranteed constraints:
        adj.length == 5,
        adj[i].length == 5.
        [output] boolean
        true if the given contour is a butterfly, false otherwise.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Graphs.ContoursOfEverything
{
    class isButterflyClass
    {
        bool isButterfly(bool[][] adj) {
            var cities = new int[5];
            for(var f = 0; f < 5; f++)
            {
                for(var t = f; t < 5; t++)
                {
                    if (adj[f][t])
                    {
                        cities[f]++;
                        cities[t]++;
                    }
                }
            }
            Console.WriteLine(string.Join(",", cities));
            return cities.Count(c => c == 2) == 4 && cities.Count(c => c == 4) == 1;
        }
    }
}
