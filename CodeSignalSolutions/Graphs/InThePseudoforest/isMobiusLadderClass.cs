/*
    Status:   Solved
    Imported: 2020-05-19 20:49
    By:       Casper
    Url:      https://app.codesignal.com/arcade/graphs-arcade/in-the-pseudoforest/9MPHNYoJQeviGsBEf

    Description:
        You've been studying trees a lot lately, and became an expert in caterpillar
        trees. Now that you know everything about them, you're ready to climb one.
        However, in order to climb such tree you need a special ladder that you call a
        mobius ladder.
        A mobius ladder is a slightly modified proper ladder. Firstly, let's define what
        proper ladder is: a proper ladder is a ladder that can be represented by a graph
        containing two chains of vertices with n vertices in each one, where the ith
        vertex of the first chain is connected to the ith vertex of the second chain.
        For example, a proper ladder with 8 vertices looks like this:
        A mobius ladder is a proper ladder with two more connections: the first vertex
        of the first chain is connected to the last vertex of the second chain, and last
        vertex of the first chain is connected to the first vertex of the second chain.
        For example, here is a mobius ladder with 8 vertices:
        You found a ladder that can be represented by n vertices in the attic. Now you
        need to check if it is a mobius ladder, to make sure it can be used to climb a
        caterpillar tree.
        Example
        For n = 6 and ladder = [[0, 1], [1, 2], [2, 3], [3, 4], [4, 5], [5, 0]], the
        output should be
        isMobiusLadder(n, ladder) = false.
        For n = 8 and
        ladder = [[0, 1], [0, 2], [0, 7], [1, 3], [1, 6], [2, 3],
        [2, 4], [3, 5], [4, 5], [4, 6], [5, 7], [6, 7]]
        the output should be isMobiusLadder(n, ladder) = true.
        This is the test from the description:
        For n = 10 and
        ladder = [[0, 1], [0, 3], [0, 7], [0, 9], [1, 2],
        [1, 4], [1, 8], [2, 3], [2, 5], [2, 9],
        [3, 4], [3, 6], [4, 5], [4, 7], [5, 6],
        [5, 8], [6, 7], [6, 9], [7, 8], [8, 9]]
        the output should be isMobiusLadder(n, ladder) = false.
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] integer n
        An even integer, the number of vertices that represent your ladder.
        Guaranteed constraints:
        2 ≤ n ≤ 5 · 104.
        [input] array.array.integer ladder
        Edges of the ladder drawn in the plan. ladder[i] for each valid i contains two
        elements and represents an edge that connects ladder[i][0] and ladder[i][1].
        It is guaranteed that between any two vertices there is no more than one edge.
        Guaranteed constraints:
        0 ≤ ladder.length ≤ 75000,
        ladder[i].length = 2,
        0 ≤ ladder[i][j] < n.
        [output] boolean
        true if the given ladder represents a mobius ladder, false otherwise.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Graphs.InThePseudoforest
{
    class isMobiusLadderClass
    {
        bool isMobiusLadder(int n, int[][] ladder) {
                    if (!BuildAdjList(n, ladder, out var adj)) return false;
                    if (adj.Any(a => a.Count != 3)) return false;
                    // Try to build squares of ladder.
                    /*[[0,1],[0,2],[0,7],[1,3],[1,6],[2,3],[2,4],[3,5],[4,5],[4,6],[5,7],[6,7]]*/
                    foreach (var square in Enumerable.Range(0, n)
                        .SelectMany(a => adj[a].Select(b => (a,b)))
                        .SelectMany(t => adj[t.b].Where(c => c != t.a).Select(c => (t.a, t.b, c)))
                        .SelectMany(t => adj[t.c].Where(d => d != t.b).Select(d => (t.a, t.b, t.c, d)))
                        .SelectMany(t => adj[t.d].Where(e => t.a == e).Select(_ => t)))
                    {
                        var ladderLeft = new LinkedList<int>();
                        var ladderRight = new LinkedList<int>();
                        var used = new bool[n];
                        //Console.WriteLine($"Trying with square: {square}");
                        used[square.a] = true;
                        used[square.b] = true;
                        used[square.c] = true;
                        used[square.d] = true;
                        ladderLeft.AddLast(square.a);
                        ladderLeft.AddLast(square.b);
                        ladderRight.AddLast(square.d);
                        ladderRight.AddLast(square.c);
                        // Extend bottom
                        while (true)
                        {
                            var bottom = adj[ladderLeft.First()].Where(b => !used[b])
                                .SelectMany(b => adj[b].Where(c => !used[c] && c != ladderLeft.First()).Select(c => (b, c)))
                                .SelectMany(t => adj[t.c].Where(d => d == ladderRight.First()).Select(_ => t))
                                .Take(1).ToArray();
                            if (bottom.Length == 0) break;
                            used[bottom[0].b] = true;
                            used[bottom[0].c] = true;
                            ladderLeft.AddFirst(bottom[0].b);
                            ladderRight.AddFirst(bottom[0].c);
                        }
                        // Extend top
                        while (true)
                        {
                            var top = adj[ladderLeft.Last()].Where(b => !used[b])
                                .SelectMany(b => adj[b].Where(c => !used[c] && c != ladderLeft.Last()).Select(c => (b, c)))
                                .SelectMany(t => adj[t.c].Where(d => d == ladderRight.Last()).Select(_ => t))
                                .Take(1).ToArray();
                            if (top.Length == 0) break;
                            used[top[0].b] = true;
                            used[top[0].c] = true;
                            ladderLeft.AddLast(top[0].b);
                            ladderRight.AddLast(top[0].c);
                        }
                        if (!used.All(b => b)) continue;  // Not all are used, start all over with a different square.
                        if (adj[ladderLeft.First()].Contains(ladderRight.Last())
                            && adj[ladderLeft.Last()].Contains(ladderRight.First())) return true;
                    }
                    return false;
                }
                bool BuildAdjList(int n, int[][] edges, out List<int>[] adj)
                {
                    adj = new List<int>[n];
                    for(var i = 0; i < n; i++) adj[i] = new List<int>();
                    foreach(var a in edges)
                    {
                        if (a[0] == a[1]) return false;  // Do not allow loop back.
                        adj[a[0]].Add(a[1]);
                        //if (a[0]==a[1]) continue;
                        adj[a[1]].Add(a[0]);
                    }
                    return true;
                }
    }
}
