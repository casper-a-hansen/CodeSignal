/*
    Status:   Solved
    Imported: 2020-05-10 12:53
    By:       Casper
    Url:      https://app.codesignal.com/arcade/graphs-arcade/contours-of-everything/jDf7ARdM9wYZLB28w

    Description:
        You decided to create an automatic image recognizer that will determine the
        object in the image based on its contours. The main recognition system is
        already implemented, and now you need to start the teaching process.
        Today you want to teach your program to recognize tadpole patterns, which means
        that you need to implement a function that, given the adjacency matrix
        representing the contour, will determine whether it's a tadpole or not.
        The tadpole contour consists of two parts: a head which is a cycle with n (n >
        2) vertices, and a tail which is a simple path (with at least one vertex)
        connected to the head. Here is an example:
        Given the object's contour as an undirected graph represented by its adjacency
        matrix adj determine whether it's a tadpole or not.
        Example
        For
        adj = [[false, true, true, false, false],
        [true, false, false, true, false],
        [true, false, false, true, false],
        [false, true, true, false, true],
        [false, false, false, true, false]]
        the output should be
        isTadpole(adj) = true.
        Here's what the given graph looks like:
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] array.array.boolean adj
        An adjacency matrix of an undirected graph.
        Guaranteed constraints:
        3 < adj.length < 20,
        adj[i].length == adj.length.
        [output] boolean
        true if the given contour is a tadpole, false otherwise.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Graphs.ContoursOfEverything
{
    class isTadpoleClass
    {
        bool isTadpole(bool[][] adj) {
            if (adj.Select((a, i) => a[i]).Any(b => b)) return false;  // Checking for nodes pointing at itself.
            var nodes = adj.Select((a, i) => (Node: i, Nodes: a.Select((n, i) => (n, i)).Where(t => t.n).Select(t => t.i).ToArray())).ToArray();
            if (nodes.Any(i => i.Nodes.Length == 0 || i.Nodes.Length > 3)) return false;
            if (nodes.Count(i => i.Nodes.Length == 1) != 1) return false;
            if (nodes.Count(i => i.Nodes.Length == 3) != 1) return false;
            if (nodes.Count(i => i.Nodes.Length == 2) != adj.Length - 2) return false;
            // Test 10 is two figures: a Tadpole (7,6,5+5,4,3) and a triangle (0,1,2)
            var node3 = nodes.First(i => i.Nodes.Length == 3);
            Console.WriteLine($"node3: {node3.Node} - {string.Join(",", node3.Nodes)}");
            var used = new HashSet<int>() {node3.Node};
            foreach(var node in node3.Nodes)
            {
                var n0 = node;
                if (!used.Add(n0)) continue;
                while(true)
                {
                    var n1 = nodes[n0].Nodes.Select(n => (int?)n).FirstOrDefault(n => !used.Contains(n.Value));
                    if (n1 == null) break;
                    used.Add(n1.Value);
                    Console.WriteLine($"n1 {n1.Value}");
                    n0 = n1.Value;
                }
            }
            Console.WriteLine($"Used: {string.Join(",", used)}");
            return used.Count == adj.Length;
        }
    }
}
