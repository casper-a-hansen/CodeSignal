/*
    Status:   Solved
    Imported: 2020-05-22 20:46
    By:       Casper
    Url:      https://app.codesignal.com/arcade/graphs-arcade/in-the-pseudoforest/Sby2j4SHqDncwyQjh

    Description:
        You got sick because of walking in the woods at night, and have to spend a week
        at home without going out. Looking out of the window at the nearby woods you're
        wondering if there is anything you don't yet know about them. Suddenly you see a
        beautiful and very tall tree you haven't seen before. Since you have nothing to
        do, you decide to examine its structure and draw it in your notebook.
        You became so exited about this new tree that your temperature went up, so you
        were forced to stay in bed. You can't see the tree from your bed, but luckily
        you have it drawn down. The first thing you'd like to find out about is the tree
        height. Looking at your drawing you suddenly realize that you forgot to mark the
        tree bottom and you don't know from which vertex you should start counting. Of
        course a tree height can be calculated as the length of the longest path in it
        (it is also called tree diameter). So, now you have a task you need to solve, so
        go ahead!
        Example
        For n = 10 and
        tree = [[2, 5], [5, 7], [5, 1], [1, 9], [1, 0], [7, 6], [6, 3], [3, 8], [8, 4]]
        the output should be treeDiameter(n, tree) = 7.
        The longest path is the path from vertex 4 to one vertex 9 or 0.
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] integer n
        The number of vertices in the structure you drew in your notebook.
        Guaranteed constraints:
        1 ≤ n ≤ 104.
        [input] array.array.integer tree
        Edges of the tree. tree[i] for each valid i contains two elements and represents
        an edge that connects tree[i][0] and tree[i][1].
        It is guaranteed that given graph is a tree, i.e. it is connected and has no
        cycles.
        Guaranteed constraints:
        tree.length = n - 1,
        tree[i].length = 2,
        0 ≤ tree[i][j] < n.
        [output] integer
        tree diameter of the given tree.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Graphs.InThePseudoforest
{
    class treeDiameterClass
    {
        int treeDiameter(int n, int[][] tree) {
            if (n == 1) return 0;
            BuildAdjList(n, tree, out var adjList);
            return Distance(adjList, Distance(adjList, 0).leaf).distance - 1;
        }
        (int distance, int leaf) Distance(List<int>[] adj, int start)
        {
            var distances = new int[adj.Length];
            distances[start] = 1;
            var distance = 0;
            var leaf = start;
            var stack = new Stack<int>();
            stack.Push(start);
            while(stack.Count > 0)
            {
                var current = stack.Pop();
                var nextDistance = distances[current] + 1;
                foreach(var next in adj[current])
                {
                    if (distances[next] == 0)
                    {
                        stack.Push(next);
                        distances[next] = nextDistance;
                        if (distance < nextDistance)
                        {
                            distance = nextDistance;
                            leaf = next;
                        }
                    }
                }
            }
            Console.WriteLine($"Distance {distance}  Leaf {leaf}");
            return (distance, leaf);
        }
        bool BuildAdjList(int n, int[][] edges, out List<int>[] adj)
        {
            adj = new List<int>[n];
            for (var i = 0; i < n; i++) adj[i] = new List<int>();
            foreach (var a in edges)
            {
                //if (a[0] == a[1]) return false;  // Do not allow loop back.
                adj[a[0]].Add(a[1]);
                //if (a[0]==a[1]) continue;
                adj[a[1]].Add(a[0]);
            }
            return true;
        }
    }
}
