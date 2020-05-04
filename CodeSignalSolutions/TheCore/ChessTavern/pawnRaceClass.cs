/*
    Status:   Solved
    Imported: 2020-05-02 13:10
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/chess-tavern/ybkbv7e6qMaucZWig

    Description:
        Pawn race is a game for two people, played on an ordinary 8 × 8 chessboard. The
        first player has a white pawn, the second one - a black pawn. Initially the
        pawns are placed somewhere on the board so that the 1st and the 8th rows are not
        occupied. Players take turns to make a move.
        White pawn moves upwards, black one moves downwards. The following moves are
        allowed:
        one-cell move on the same vertical in the allowed direction;
        two-cell move on the same vertical in the allowed direction, if the pawn is
        standing on the 2nd (for the white pawn) or the 7th (for the black pawn) row.
        Note that even with the two-cell move a pawn can't jump over the opponent's
        pawn;
        capture move one cell forward in the allowed direction and one cell to the left
        or to the right.
        The purpose of the game is to reach the the 1st row (for the black pawn) or the
        8th row (for the white one), or to capture the opponent's pawn.
        Given the initial positions and whose turn it is, determine who will win or
        declare it a draw (i.e. it is impossible for any player to win). Assume that the
        players play optimally.
        Example
        For white = "e2", black = "e7", and toMove = 'w', the output should be
        pawnRace(white, black, toMove) = "draw";
        For white = "e3", black = "d7", and toMove = 'b', the output should be
        pawnRace(white, black, toMove) = "black";
        For white = "a7", black = "h2", and toMove = 'w', the output should be
        pawnRace(white, black, toMove) = "white".
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] string white
        Coordinates of the white pawn in the chess notation.
        [input] string black
        Position of the black pawn in the same notation. It is guaranteed that white ≠
        black.
        [input] char toMove
        'w' if it is the first player's turn, 'b' otherwise.
        [output] string
        "white", "black" or "draw" depending on the result of the game.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.ChessTavern
{
    class pawnRaceClass
    {
        string pawnRace(string white, string black, char toMove) {
            if (white[0] == black[0] && white[1] < black[1]) return "draw";
            var piece = new string[]{white, black};
            var winner = new string[]{"white", "black"};
            var direction = new int[]{1, -1};
            var baserow = new char[]{'2', '7'};
            var destrow = new char[]{'8', '1'};
            Console.WriteLine(string.Join(" - ", piece));
            var current = toMove == 'w' ? 0 : 1;
            while(true) {
                var opponent = 1 - current ;
                var dy = direction[current];
                if (Math.Abs((int)piece[current][0] - (int)piece[opponent][0]) == 1) {
                        Console.WriteLine("The can take eachother");
                    if ((char)(piece[current][1] + direction[current]) == piece[opponent][1]) return winner[current];
                    if (piece[current][1] == baserow[current]) {
                        Console.WriteLine($"{winner[current]} is on its baserow {baserow[current]}");
                        // We can move 1 or 2, if we pick the right we might win
                        var diff = Math.Abs(piece[current][1] - piece[opponent][1]);
                        if (diff == 2 || diff == 4) {
                            dy *= 2;
                        }
                    }
                } else if (piece[current][1] == baserow[current]) {
                    dy *= 2;  // We need to move as fast as possible.
                }
                var row = (char)(piece[current][1] + dy);
                if (row == destrow[current]) return winner[current];
                piece[current] = piece[current][0].ToString() + row.ToString();
                Console.WriteLine(string.Join(" - ", piece));
                current = opponent;
            }
        }
    }
}
