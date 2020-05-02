/*
    Status:   Solved
    Imported: 2020-05-02 13:08
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/sorting-outpost/D6qmdBL2NYz49XHwM

    Description:
        Some people are standing in a row in a park. There are trees between them which
        cannot be moved. Your task is to rearrange the people by their heights in a
        non-descending order without moving the trees. People can be very tall!
        Example
        For a = [-1, 150, 190, 170, -1, -1, 160, 180], the output should be
        sortByHeight(a) = [-1, 150, 160, 170, -1, -1, 180, 190].
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] array.integer a
        If a[i] = -1, then the ith position is occupied by a tree. Otherwise a[i] is the
        height of a person standing in the ith position.
        Guaranteed constraints:
        1 ≤ a.length ≤ 1000,
        -1 ≤ a[i] ≤ 1000.
        [output] array.integer
        Sorted array a with all the trees untouched.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.SortingOutpost
{
    class sortByHeightClass
    {
        int[] sortByHeight(int[] a) {
            var people = a.Select((v,i) => (Height: v, Index: i)).Where(t => t.Height != -1).OrderBy(t => t.Height).ToArray();
            Console.WriteLine(string.Join(",", people));
            var index = people.Select(t => t.Index).OrderBy(t => t).ToArray();
            Console.WriteLine(string.Join(",", index));
            foreach(var person in people.Zip(index, (p, i) => (People: p, Index: i))) {
                a[person.Index] = person.People.Height;
            }
            return a;
        }
    }
}
