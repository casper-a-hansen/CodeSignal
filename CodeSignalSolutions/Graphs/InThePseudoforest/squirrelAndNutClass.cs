/*
    Status:   Solved
    Imported: 2020-05-23 21:03
    By:       Casper
    Url:      https://app.codesignal.com/arcade/graphs-arcade/in-the-pseudoforest/HNjswnTuPkYkmDavw

    Description:
        Wandering in the woods, you noticed a squirrel sitting in node A of a tree. It
        didn't look like it was going to sit there forever though: there was a delicious
        nut in node B, and the squirrel looked determined to reach it by moving via the
        branches of the tree. You grabbed your camera to take a picture of the squirrel
        in node C (that's the only node that would make the picture perfect), but was
        too late: the smart rodent had already made it to node B.
        There are still a lot of nuts on the tree, and it seems that the squirrel is
        going to try and take them all. Looks like the squirrel is smart enough to
        follow only the shortest paths along the tree branches, which means you can now
        predict when the right opportunity to take a perfect picture arises. Given
        configuration of the tree and a bunch of triples consisting of numbers A, B and
        C, for each triple return true if the squirrel will run through node C on its
        path from A to B, and false otherwise.
        It is guaranteed that each node has no more than 5 branches.
        Example
        For
        tree = [1, 2,
        1, 3,
        2, 4,
        3, 5,
        3, 6]
        and
        triples = [[4, 6, 3],
        [1, 4, 2],
        [5, 6, 1]]
        the output should be
        squirrelAndNut(tree, triples) = [true, true, false].
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] array.integer tree
        An array of integers of even length, where a pair (tree[i], tree[i + 1]) for
        every even i corresponds to the branch in a tree that goes from node tree[i] to
        tree[i + 1], both 1-based.
        Guaranteed constraints:
        tree.length = 2 · (max(tree) - 1),
        1 ≤ tree[i] ≤ 10000.
        [input] array.array.integer triples
        Triples of three integers in the format [A, B, C], where A stands for the
        initial squirrel position, B stands for its destination and C stands for the
        node at which the perfect picture can be taken, all 1-based.
        Guaranteed constraints:
        1 ≤ triples.length ≤ 10000,
        triples[i].length = 3,
        1 ≤ triples[i][j] ≤ n.
        [output] array.boolean
        Array of the same length as triples, where the ith element is true if and only
        if it will be possible to take a perfect picture in the situation corresponding
        to the ith triple.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Graphs.InThePseudoforest
{
    class squirrelAndNutClass
    {
        bool[] squirrelAndNut(int[] tree, int[][] triples)
        {
            var dic = BuildTree(tree);
            var result = new bool[triples.Length];
            for (var i = 0; i < triples.Length; i++)
            {
                result[i] = IsPathVia(dic[triples[i][0]], dic[triples[i][1]], triples[i][2]);
            }
            return result;
        }
        bool IsPathVia(Node origin, Node destination, int via)
        {
            var used = new HashSet<int>();
            bool originFound = false;
            bool destinationFound = false;
            while(origin != null)
            {
                used.Add(origin.Id);
                if (origin.Id == via) originFound = true;  // Might be found in the common part branch of origin and destination
                origin = origin.Parent;
            }
            bool inUsed = false;
            while(destination != null)
            {
                if (destination.Id == via)
                {
                    destinationFound = true;
                    if (!originFound && destinationFound) return true;  // via found in destination Path only.
                }
                if (!used.Add(destination.Id))
                {
                    // We are in the common part.
                    if (originFound && destinationFound) return !inUsed;  // Found in common path so it does not count.
                    if (!originFound && !destinationFound) return false;
                    inUsed = true;
                }
                destination = destination.Parent;
            }
            return originFound && !destinationFound;
        }
        Dictionary<int, Node> BuildTree(int[] tree)
        {
            Dictionary<int, Node> dic = new Dictionary<int, Node>();
            HashSet<int> leafs = new HashSet<int>();
            for(var i = 0; i < tree.Length; i += 2)
            {
                if (!dic.TryGetValue(tree[i], out Node from))
                    dic.Add(tree[i], from = new Node(tree[i]));
                if (!dic.TryGetValue(tree[i + 1], out Node to))
                    dic.Add(tree[i + 1], to = new Node(tree[i + 1]));
                from.Children.Add(to);
                if (from.Children.Count == 1) leafs.Add(from.Id);
                else if (from.Children.Count == 2) leafs.Remove(from.Id);
                to.Children.Add(from);
                if (to.Children.Count == 1) leafs.Add(to.Id);
                else if (to.Children.Count == 2) leafs.Remove(to.Id);
            }
            // Rearrange tree:  All leafs has one link, maybe the root has too but it doesn't matter.
            var queue = new Queue<int>();
            foreach (var leaf in leafs) queue.Enqueue(leaf);
            while(queue.Count != 0)
            {
                var node = dic[queue.Dequeue()];
                if (node.Parent != null) continue;
                while(node.Children.Count(c => c.Parent == null) == 1)
                {
                    var parent = node.Children.First(c => c.Parent == null);
                    node.Children.Remove(parent);   // Remove parent from children.
                    node.Parent = parent;
                    node = parent;
                }
                if (node.Children.Count(c => c.Parent != null) > 1)
                    queue.Enqueue(node.Id);
            }
            return dic;
        }
        class Node
        {
            public Node(int id)
            {
                Id = id;
                Children = new List<Node>();
            }
            public override string ToString()
            {
                return $"{Id} ^{Parent?.Id ?? -1} -> {string.Join(",", Children.Select(n => n.Id))}";
            }
            public static Node Root()
            {
                return new Node(-1)
                {
                    Parent = null,
                };
            }
            public Node CreateChild(int id)
            {
                var node = new Node(id)
                {
                    Parent = this,
                };
                Children.Add(node);
                return node;
            }
            public int Id;
            public Node Parent;
            public List<Node> Children;
        }
    }
}
