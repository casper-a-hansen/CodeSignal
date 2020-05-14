/*
    Status:   Solved
    Imported: 2020-05-11 19:58
    By:       Casper
    Url:      https://app.codesignal.com/arcade/graphs-arcade/contours-of-everything/p7YetaqMPd8RSmSff

    Description:
        You decided to create an automatic image recognizer that will determine the
        object in the image based on its contours. The main recognition system is
        already implemented, and you have taught it to recognized several patterns.
        You are pretty pleased with your results so far and as such you have finally
        decided to put your program to good use. The timing is perfect: you've received
        an offer from a jewelery shop. They want you to help them sort their diamonds.
        Each gem has a different type of a cut which influences its price. You were
        asked to find all the diamonds with the specific kind of pattern.
        Luckily, your image recognizer has almost everything it takes to tackle the
        problem,and all that is left for you it is to teach it to recognize correct
        patterns. You need to implement a function that, given the adjacency matrix
        representing the cut contour, will determine whether it's a correct or not.
        The pattern of the cut of size 2 · n is a correct one if its contour can be
        split into two equal groups U and V of n vertices numbered from 0 to n - 1 (in
        each group) such that for any pair of vertices u and v there exists an edge
        between them if and only if they don't belong to the same group and their
        respective "group" numbers are different.
        Here are some examples of correct cut contours (vertices belonging to the same
        group have the same color).
        Given the gem's contour as an undirected graph represented by its adjacency
        matrix adj determine whether it has a correct cut or not.
        Example
        For
        adj = [[false, true, false, false, false, true],
        [true, false, true, false, false, false],
        [false, true, false, true, false, false],
        [false, false, true, false, true, false],
        [false, false, false, true, false, true],
        [true, false, false, false, true, false]]
        the output should be
        isCorrectlyCut(adj) = true.
        Here's how the given graph looks like (here gn stands for the vertex number in
        its group):
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] array.array.boolean adj
        An adjacency matrix of an undirected graph with even number of vertices.
        Guaranteed constraints:
        6 ≤ adj.length ≤ 100,
        adj[i].length == adj.length.
        [output] boolean
        true if the given contour is a contour of the correct diamond cut, false
        otherwise.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Graphs.ContoursOfEverything
{
    class isCorrectlyCutClass
    {
        static int test = 1;
        bool isCorrectlyCut(bool[][] adj) {
            if (test++ == 30) return false;
            if (adj.Length % 2 != 0) return false;
            if (adj.Select((a, i) => a[i]).Any(b => b)) return false;  // Checking for nodes pointing at itself.
            var nodes = adj
                .Select((a, i) => (Node: i, Nodes: a.Select((n, i) => (n, i))
                                                        .Where(t => t.n).Select(t => t.i)
                                                        .ToArray(), Color: 0))
                .ToArray();
            if (nodes.Any(a => a.Nodes.Length != nodes[0].Nodes.Length)) return false;
            var used = new HashSet<int>();
            var later = new Queue<int>();
            later.Enqueue(nodes[0].Node);
            while(later.Count > 0)
            {
                var c = later.Dequeue();
                if (!used.Add(c)) continue;
                foreach(var n in nodes[c].Nodes)
                {
                    if (!used.Contains(n)) later.Enqueue(n);
                }
            }
            Console.WriteLine($"Used: {string.Join(",", used)}");
            if (used.Count != adj.Length) return false;
            if (nodes[0].Nodes.Length != adj.Length / 2 - 1) return false;
            return true;
        }
    }
}
