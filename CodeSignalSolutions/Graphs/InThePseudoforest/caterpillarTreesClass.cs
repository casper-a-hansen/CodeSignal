/*
    Status:   Solved
    Imported: 2020-05-18 20:34
    By:       Casper
    Url:      https://app.codesignal.com/arcade/graphs-arcade/in-the-pseudoforest/EywKKTcqGrfbavDrw

    Description:
        Not long ago you discovered a wonderful tree in the nearby woods that made you
        very curious about the greenery around you. You went to the nearby woods and
        drew various plants in your notebook. The plants in the woods have various
        structures: some of them even contain loops!
        Anyway, for now you are interested only in trees. You came up with a brand new
        property: you call a tree a caterpillar if there exists a path in it, such that
        each vertex of a tree either belongs to this path or is connected to one of its
        vertices by a single edge. To find out more about them, you would like to write
        a program that will find all interesting trees in the structures you drew in
        your notebook.
        The plants you drew consist of n vertices and are connected by several edges.
        Calculate the number of regular trees and caterpillar trees in the structures
        you drew in your notebook.
        Example
        For n = 21 and
        edges = [[0, 1], [1, 2], [2, 3], [2, 4], [4, 5], [4, 6], [4, 7],
        [4, 8], [4, 9], [4, 10], [10, 11], [11, 12], [11, 13],
        [11, 14], [14, 15], [14, 16], [14, 17], [14, 18], [14, 19]]
        the output should be caterpillarTrees(n, edges) = [2, 2].
        There are two connected components and both of them are trees and caterpillar
        trees.
        For n = 22 and
        edges = [[0, 1], [1, 2], [2, 3], [2, 4], [4, 5], [4, 6], [4, 7],
        [4, 8], [4, 9], [4, 10], [10, 11], [11, 12], [11, 13],
        [11, 14], [14, 15], [14, 16], [14, 17], [14, 18], [14, 19], [13, 20]]
        the output should be caterpillarTrees(n, edges) = [2, 1].
        The first connected component is a tree, but not a caterpillar tree, because
        vertex 20 is not directly connected to the central path.
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] integer n
        The number of vertices in the structures drawn in your notebook.
        Guaranteed constraints:
        1 ≤ n ≤ 105.
        [input] array.array.integer edges
        Edges drawn in the notebook. edges[i] for each valid i contains two elements and
        represents an edge that connects edges[i][0] and edges[i][1].
        It is guaranteed that between any two vertices there is no more than one edge.
        Guaranteed constraints:
        0 ≤ edges.length ≤ 105,
        edges[i].length = 2,
        0 ≤ edges[i][j] < n.
        [output] array.integer
        Array of two integers, where the first represents the number of trees in your
        woods and the second represents the number of caterpillar trees in it.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Graphs.InThePseudoforest
{
    class caterpillarTreesClass
    {
        int[] caterpillarTrees(int n, int[][] edges) {
            int[][] adj;
            {
                var dic = edges
                    .SelectMany(a => a[0] == a[1] ? new int[][] { a } : new int[][] { a, new[] { a[1], a[0] } })
                    .GroupBy(a => a[0])
                    .ToDictionary(g => g.Key, g => g.Select(a => a[1]).ToArray());
                adj = Enumerable.Range(0, n).Select(i => dic.ContainsKey(i) ? dic[i] : Array.Empty<int>()).ToArray();
            }
            int caterpillarTreeCount = 0;
            int treeCount = 0;
            var used = new bool[n];
            for(var node = 0; node < n; node++)
            {
                if (used[node]) continue;
                if (adj[node].Length == 1 && adj[node][0] == node) continue;
                bool isTree = true;
                bool isCaterpillarTree = true;
                var tree = new HashSet<int>();
                var stack = new Stack<(int current, int parent)>();
                stack.Push((node, node));
                while(stack.Count > 0)
                {
                    (var current, var parent) = stack.Pop();
                    used[current] = true;
                    tree.Add(current);
                    foreach(var next in adj[current])
                    {
                        if (next == parent) continue;
                        if (used[next])
                        {
                            // Found a loop (of any size)
                            // But need to set used for the entire tree (actually non-tree.)
                            isTree = false;
                            isCaterpillarTree = false;
                        }
                        else
                        {
                            stack.Push((next, current));
                        }
                    }
                }
                if (isTree)
                {
                    foreach(var current in tree)
                    {
                        if (adj[current].Length == 1) continue;
                        var branches = adj[current].Count(i => adj[i].Length > 1);
                        if (branches > 2)
                        {
                            isCaterpillarTree = false;
                            break;
                        }
                    }
                }
                if (isTree) treeCount++;
                if (isCaterpillarTree) caterpillarTreeCount++;
            }
            return new[] { treeCount, caterpillarTreeCount };
        }
    }
}
