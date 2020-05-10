/*
    Status:   Solved
    Imported: 2020-05-10 12:53
    By:       Casper
    Url:      https://app.codesignal.com/arcade/graphs-arcade/contours-of-everything/gLs2qAzAGivaxYSAq

    Description:
        You decided to create an automatic image recognizer that will determine the
        object in the image based on its contours. The main recognition system is
        already implemented, and now you need to start the teaching process.
        Today you want to teach your program to recognize flower patterns, which means
        that you need to implement a function that, given the adjacency matrix
        representing the contour, will determine whether it's a flower or not.
        The flower contour consists of several (at least one) petals.
        Petal contours are the same-sized (of size greater than 2) complete graphs with
        exactly one common vertex.
        Here are some examples of the flower contours:
        Given the object's contour as an undirected graph represented by adjacency
        matrix adj determine whether it's a flower or not.
        Example
        For
        adj = [[false, true, true, true, true],
        [true, false, true, false, false],
        [true, true, false, false, false],
        [true, false, false, false, true],
        [true, false, false, true, false]]
        the output should be
        isFlower(adj) = true.
        Here's what the given graph looks like:
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] array.array.boolean adj
        An adjacency matrix of an undirected graph.
        Guaranteed constraints:
        2 < adj.length < 100,
        adj[i].length == adj.length .
        [output] boolean
        true if the given contour is a flower, false otherwise.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Graphs.ContoursOfEverything
{
    class isFlowerClass
    {
        bool isFlower(bool[][] adj) {
            if (adj.Select((a, i) => a[i]).Any(b => b)) return false;  // Checking for nodes pointing at itself.
            var nodes = adj.Select((a, i) => (Node: i, Nodes: a.Select((n, i) => (n, i)).Where(t => t.n).Select(t => t.i).ToArray())).ToArray();
            if (adj.Length == 3) return nodes.All(n => n.Nodes.Length == 2);
            // Get the node with most connections.
            // If the flower only contains one leaf then center is a random node
            var center = nodes.Aggregate((n0, n1) => n0.Nodes.Length > n1.Nodes.Length ? n0 : n1);
            // Check that center is connected to all the other nodes.
            if (center.Nodes.Length != adj.Length - 1) return false;
            var used = new HashSet<int>() {center.Node};
            int leafSize = -1;
            Console.WriteLine($"Checking leafs - center is {center.Node}");
            foreach(var node in center.Nodes)
            {
                if (!used.Add(node)) continue;
                Console.WriteLine($"Used: {string.Join(",", used)}");
                // Check that every node in the leaf is connected to every other node (ignoring center)
                var leaf = nodes[node].Nodes.Where(n => n != center.Node).Select(n => nodes[n]).ToArray();
                if (leafSize == -1) leafSize = leaf.Length;
                else if (leafSize != leaf.Length) return false;
                Console.WriteLine($"LeafSize: {leafSize}");
                for(var i = 0; i < leaf.Length; i++)
                {
                    Console.WriteLine($"Leaf {i} - {leaf[i].Node} - ({string.Join(",", leaf[i].Nodes)}) - center is {center.Node}");
                    used.Add(leaf[i].Node);
                    for(var j = i + 1; j < leaf.Length; j++)
                    {
                        Console.WriteLine($"Other {j} - {leaf[j].Node} - ({string.Join(",", leaf[j].Nodes)}) - center is {center.Node}");
                        if (!leaf[i].Nodes.Contains(leaf[j].Node)) return false;
                    }
                }
            }
            return true;
        }
    }
}
