/*
    Status:   Solved
    Imported: 2020-05-02 13:09
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/chess-tavern/SJRNgqggTaktuCJGj

    Description:
        Imagine a standard chess board with only two white and two black knights placed
        in their standard starting positions: the white knights on b1 and g1; the black
        knights on b8 and g8.
        There are two players: one plays for white, the other for black. During each
        move, the player picks one of his knights and moves it to an unoccupied square
        according to standard chess rules. Thus, a knight on d5 can move to any of the
        following squares: b6, c7, e7, f6, f4, e3, c3, and b4, as long as it is not
        occupied by either a friendly or an enemy knight.
        The players take turns in making moves, starting with the white player. Given
        the configuration p of the knights after an unspecified number of moves,
        determine whose turn it is.
        Example
        For p = "b1;g1;b8;g8", the output should be
        whoseTurn(p) = true.
        The configuration corresponds to the initial state of the game. Thus, it's
        white's turn.
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] string p
        The positions of the four knights, starting with white knights, separated by a
        semicolon, in the chess notation.
        Guaranteed constraints:
        p.length = 11.
        [output] boolean
        true if white is to move, false otherwise.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.ChessTavern
{
    class whoseTurnClass
    {
        // Since a knight moves from a black to a white cell and both have a knight on a white and a black cell we only need to check colors.
        bool whoseTurn(string p) =>p.Split(';').Sum(p => ((p[0] - 'a') + (p[1] - '1')) % 2) % 2 == 0;
    }
}
