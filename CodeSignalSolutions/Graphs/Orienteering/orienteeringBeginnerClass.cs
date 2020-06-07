/*
    Status:   Unsolved
    Imported: 2020-06-07 11:38
    By:       Casper
    Url:      https://app.codesignal.com/arcade/graphs-arcade/orienteering/TYt5rotw5phqWRuTF

    Description:
        Not long ago you saw an orienteering competition on TV and immediately wanted to
        try it yourself. You've joined an orienteering club and started preparing for
        the upcoming competitions.
        To test your skills, the coach asked you to enter the beginners' competition. In
        this race your objective is to reach the finish from the start by the shortest
        path. You were given a map that shows n different locations (including start and
        finish) connected by roads of different lengths. You are only allowed to
        traverse roads in one direction (i.e. all roads are one-way), but since this is
        competition for beginners the organizers chose such an orientation of the roads
        that if you constantly move along roads, you'll eventually reach the finish and
        if you leave some location you will never return there.
        Given the number of locations n and the roads between them, find the length of
        the shortest path between the start (location with number 0) and the finish
        (location with number n - 1).
        Example
        For n = 6 and
        roads = [[[1, 3]],
        [[4, 1], [3, 2]],
        [[1, 0]],
        [[5, 3]],
        [[5, 5]],
        []]
        the output should be
        orienteeringBeginner(n, roads) = 8.
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] integer n
        The number of locations.
        Guaranteed constraints:
        1 ≤ n ≤ 105.
        [input] array.array.array.integer roads
        Array representing roads between locations as an adjacency list.
        roads[i][j] = [k, l] means that there is a road between location i and location
        k of length l.
        Guaranteed constraints:
        roads.length == n,
        0 ≤ roads[i].length ≤ n - 1,
        roads[i][j].length = 2,
        0 ≤ roads[i][j][0] < n,
        0 ≤ roads[i][j][1] ≤ 1000.
        [output] integer
        The length of the shortest path between the start (location 0) and the finish
        (location n - 1).
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Graphs.Orienteering
{
    class orienteeringBeginnerClass
    {
        int orienteeringBeginner(int n, int[][][] roads) 
        {
            return 0;
        }
    }
}
