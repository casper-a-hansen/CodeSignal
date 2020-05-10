/*
    Status:   Solved
    Imported: 2020-05-10 12:53
    By:       Casper
    Url:      https://app.codesignal.com/arcade/graphs-arcade/contours-of-everything/PmSaQEhfNqCPFfGrW

    Description:
        You decided to create an automatic image recognizer that will determine the
        object in the image based on its contours. The main recognition system is
        already implemented, and now you need to start the teaching process.
        Today you want to teach your program to recognize bull patterns, which means
        that you need to implement a function that, given the adjacency matrix
        representing the contour, will determine whether it's a bull or not.
        You noticed that although all bull heads are similar there is some variation in
        the shapes of their horns, so there are several possible bull contours. The
        image below shows all such contours.
        Given the object's contour as an undirected graph represented by adjacency
        matrix adj determine whether it's a bull or not.
        Example
        For
        adj = [[false, true, false, false, false],
        [true, false, true, true, false],
        [false, true, false, true, false],
        [false, true, true, false, true],
        [false, false, false, true, false]]
        the output should be
        isBull(adj) = true.
        Here's how the given graph looks like:
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] array.array.boolean adj
        An adjacency matrix of an undirected graph.
        Guaranteed constraints:
        adj.length == 5,
        adj[i].length == 5.
        [output] boolean
        true if the given contour is a bull, false otherwise.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Graphs.ContoursOfEverything
{
    class isBullClass
    {
        bool isBull(bool[][] adj) {
            if (adj.Length <= 3) return false;  // Not even cities for the head
            if (Enumerable.Range(0, adj.Length).Any(i => adj[i][i])) return false;  // Loops not part of the bull
            // cities is an array of (int City, int[] Roads)
            var cities = adj.Select((a,i) => (City: i, Roads: a.Select((a, i) => (a, i)).Where(t => t.a).Select(t => t.i).ToArray())).ToArray();
            Print("Cities", cities);
            if (cities.Sum(c => c.Roads.Length) != 10) return false;
            var horns = cities.Where(c => c.Roads.Length == 1).ToArray();
            Print("Horns", horns);
            if (horns.Length > 2 || horns.Length == 0) return false;  // None or more than two horns not allowed.
            var head = new HashSet<int>();
            var allTaken = new HashSet<int>();
            foreach(var tip in horns)
            {
                Print("Tip", tip);
                allTaken.Add(tip.City);
                var horn = cities[tip.Roads[0]];
                Print("Horn", horn);
                allTaken.Add(horn.City);
                while(horn.Roads.Length == 2)
                {
                    Console.WriteLine($"AllTaken: {string.Join(",", allTaken)}");
                    horn = cities[horn.Roads.First(c => !allTaken.Contains(c))];
                    Print("Horn", horn);
                    allTaken.Add(horn.City);
                }
                if (horn.Roads.Length == 1) return false;  // Horn ends without head,
                head.Add(horn.City);
            }
            Console.WriteLine($"AllTaken: {string.Join(",", allTaken)}");
            Print("Head", head.Select(c => cities[c]));
            if (head.Count == 1)
            {
                Console.WriteLine("Horns end it one point of the head");
                // Check that the single end point of the horn(s) has roads to two diffent cities that has a road to eachother.
                var rest = cities[head.First()].Roads.Where(r => !allTaken.Contains(r)).ToArray();
                Print("Head 2,3", rest.Select(c => cities[c]));
                if (rest.Length != 2) return false;
                var other = cities[rest[0]].Roads.Where(r => !allTaken.Contains(r)).ToArray();
                if (other.Length != 1) return false;
                return other[0] == rest[1];
            }
            Console.WriteLine("Horns end in two points of the head");
            // Check that the two end points of the horns has roads to a common city.
            return head.SelectMany(i => cities[i].Roads.Where(r => !allTaken.Contains(r))).Distinct().Count() == 1;
        }
        void Print(string text, IEnumerable<(int City, int[] Roads)> list)
        {
            Console.Write(text);
            Console.Write(": ");
            bool first = true;
            foreach(var item in list)
            {
                if (!first) Console.Write(", ");
                first = false;
                Print(item);
            }
            Console.WriteLine();
        }
        void Print(string text, (int City, int[] Roads) item)
        {
            Console.Write(text);
            Console.Write(": ");
            Print(item);
            Console.WriteLine();
        }
        void Print((int City, int[] Roads) item)
        {
            Console.Write("(");
            Console.Write(item.City);
            Console.Write(" - ");
            Console.Write(string.Join(",", item.Roads));
            Console.Write(")");
        }
    }
}
