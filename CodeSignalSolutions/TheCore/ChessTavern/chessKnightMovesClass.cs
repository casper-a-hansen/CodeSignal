/*
    Status:   Solved
    Imported: 2020-05-02 13:09
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/chess-tavern/zqDuSLMHhAknqnLtA

    Description:
        Given a position of a knight on the standard chessboard, find the number of
        different moves the knight can perform.
        The knight can move to a square that is two squares horizontally and one square
        vertically, or two squares vertically and one square horizontally away from it.
        The complete move therefore looks like the letter L. Check out the image below
        to see all valid moves for a knight piece that is placed on one of the central
        squares.
        Example
        For cell = "a1", the output should be
        chessKnightMoves(cell) = 2.
        For cell = "c2", the output should be
        chessKnightMoves(cell) = 6.
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] string cell
        String consisting of 2 letters - coordinates of the knight on an 8 × 8
        chessboard in chess notation.
        Guaranteed constraints:
        cell.length = 2,
        'a' ≤ cell[0] ≤ 'h',
        1 ≤ cell[1] ≤ 8.
        [output] integer
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.ChessTavern
{
    class chessKnightMovesClass
    {
        int chessKnightMoves(string cell) {
            var x = (int)(cell[0] - 'a');
            var y = (int)(cell[1] - '1');
            return check(x-2,y-1) + check(x-2,y+1) + check(x+2,y-1) + check(x+2,y+1) +
                check(x-1,y-2) + check(x-1,y+2) + check(x+1,y-2) + check(x+1,y+2);
        }
        int check(int x, int y) => 0 <= x && x <= 7 && 0 <= y && y <= 7 ? 1 : 0;
    }
}
