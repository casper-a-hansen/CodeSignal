/*
    Status:   Solved
    Imported: 2020-05-02 13:09
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/chess-tavern/NhRZQrrMqeWYL9L9Z

    Description:
        Consider a bishop, a knight and a rook on an n × m chessboard. They are said to
        form a triangle if each piece attacks exactly one other piece and is attacked by
        exactly one piece. Calculate the number of ways to choose positions of the
        pieces to form a triangle.
        Note that the bishop attacks pieces sharing the common diagonal with it; the
        rook attacks in horizontal and vertical directions; and, finally, the knight
        attacks squares which are two squares horizontally and one square vertically, or
        two squares vertically and one square horizontally away from its position.
        Example
        For n = 2 and m = 3, the output should be
        chessTriangle(n, m) = 8.
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] integer n
        Guaranteed constraints:
        1 ≤ n ≤ 40.
        [input] integer m
        Guaranteed constraints:
        1 ≤ m ≤ 40,
        3 ≤ n · m.
        [output] integer
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.ChessTavern
{
    class chessTriangleClass
    {
        int chessTriangle(int n, int m) {
            var sizes = new (int x, int y)[] {(2,3), (3,2), (2,4), (4,2), (3,4), (4,3), (3,3), (3,3)};
            return sizes.Where(s => n >= s.x && m >= s.y).Select(s => (n - s.x + 1) * (m - s.y + 1) * 8).Sum();
        }
    }
}
