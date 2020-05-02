/*
    Status:   Solved
    Imported: 2020-05-02 12:04
    By:       Casper
    Url:      https://app.codesignal.com/arcade/intro/level-9/6M57rMTFB9MeDeSWo

    Description:
        Given the positions of a white bishop and a black pawn on the standard chess
        board, determine whether the bishop can capture the pawn in one move.
        The bishop has no restrictions in distance for each move, but is limited to
        diagonal movement. Check out the example below to see how it can move:
        Example
        For bishop = "a1" and pawn = "c3", the output should be
        bishopAndPawn(bishop, pawn) = true.
        For bishop = "h1" and pawn = "h3", the output should be
        bishopAndPawn(bishop, pawn) = false.
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] string bishop
        Coordinates of the white bishop in the chess notation.
        Guaranteed constraints:
        bishop.length = 2,
        'a' ≤ bishop[0] ≤ 'h',
        1 ≤ bishop[1] ≤ 8.
        [input] string pawn
        Coordinates of the black pawn in the same notation.
        Guaranteed constraints:
        pawn.length = 2,
        'a' ≤ pawn[0] ≤ 'h',
        1 ≤ pawn[1] ≤ 8.
        [output] boolean
        true if the bishop can capture the pawn, false otherwise.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Intro.DarkWilderness
{
    class bishopAndPawnClass
    {
        bool bishopAndPawn(string bishop, string pawn) {
            var bX = (int)(bishop[0] - 'a');
            var bY = (int)(bishop[1] - '1');
            var pX = (int)(pawn[0] - 'a');
            var pY = (int)(pawn[1] - '1');
            return Math.Abs(bX - pX) == Math.Abs(bY - pY);
        }
    }
}
