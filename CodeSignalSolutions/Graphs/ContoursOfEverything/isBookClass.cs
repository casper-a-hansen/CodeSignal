/*
    Status:   Solved
    Imported: 2020-05-10 12:52
    By:       Casper
    Url:      https://app.codesignal.com/arcade/graphs-arcade/contours-of-everything/5DmC8isJ3GBRcMJo2

    Description:
        You decided to create an automatic image recognizer that will determine the
        object in the image based on its contours. The main recognition system is
        already implemented, and now you need to start the teaching process.
        Today you want to teach your program to recognize book patterns, which means
        that you need to implement a function that, given the adjacency matrix
        representing the contour, will determine whether it's a book or not.
        A book consists of a base and may have any number of pages.
        The book's base consists of a single edge connecting two nodes, and it is a
        common edge for all the pages. Besides that, every page has only one node
        connected to both sides of the base.
        Here is an example of a book:
        Given the object's contour as an undirected graph represented by its adjacency
        matrix adj determine whether it's a book or not.
        Example
        For
        adj = [[false, true, true, true],
        [true, false, true, true],
        [true, true, false, false],
        [true, true, false, false]]
        the output should be
        isBook(adj) = true.
        Here's how the given graph looks like:
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] array.array.boolean adj
        An adjacency matrix of an undirected graph.
        Guaranteed constraints:
        2 ≤ adj.length < 100,
        adj[i].length == adj.length.
        [output] boolean
        true if the given contour is a book, false otherwise.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Graphs.ContoursOfEverything
{
    class isBookClass
    {
        bool isBook(bool[][] adj) {
            if (adj.Length == 1) return false;
            if (Enumerable.Range(0, adj.Length).Any(i => adj[i][i])) return false;
            var count = adj.Where(a => a.Count(r => r) == adj.Length -1).Count();
            if (adj.Length == 3 && count == 3) return true;
            if (adj.Length == 2 && count == 2) return true;
            if (count != 2) return false;
            if (adj.Length <= 3) return true;
            if (adj.Where(a => a.Count(r => r) == 2).Count() != adj.Length - 2) return false;
            return true;
        }
    }
}
