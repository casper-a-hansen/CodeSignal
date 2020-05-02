/*
    Status:   Solved
    Imported: 2020-05-02 13:13
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/secret-archives/qSvgj5FdyeuxTN9qJ

    Description:
        John has always had trouble remembering chess game positions. To help himself
        with remembering, he decided to store game positions in strings. He came up with
        the following position notation:
        The notation is built for the current game position row by row from top to
        bottom, with '/' separating each row notation;
        Within each row, the contents of each square are described from the leftmost
        column to the rightmost;
        Each piece is identified by a single letter taken from the standard English
        names ('P' = pawn, 'N' = knight, 'B' = bishop, 'R' = rook, 'Q' = queen, 'K' =
        king);
        White pieces are designated using upper-case letters ("PNBRQK") while black
        pieces use lowercase ("pnbrqk");
        Empty squares are noted using digits 1 through 8 (the number of empty squares
        from the last piece);
        Empty lines are noted as "8".
        For example, for the initial position (shown in the picture below) the notation
        will look like this:
        "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR"
        After the white pawn moves from e2 to e4, the notation will be as follows:
        "rnbqkbnr/pppppppp/8/8/4P3/8/PPPP1PPP/RNBQKBNR"
        John has written down some positions using his notation, and now he wants to
        rotate the board 90 degrees clockwise and see what notation for the new board
        would look like. Help him with this task.
        Example
        For notation = "rnbqkbnr/pppppppp/8/8/4P3/8/PPPP1PPP/RNBQKBNR", the output
        should be
        chessNotation(notation) = "RP4pr/NP4pn/BP4pb/QP4pq/K2P2pk/BP4pb/NP4pn/RP4pr".
        The notation corresponds to the initial position with one move made (white pawn
        from e2 to e4).
        After rotating the board, it will look like this:
        So, the notation of the new position is
        "RP4pr/NP4pn/BP4pb/QP4pq/K2P2pk/BP4pb/NP4pn/RP4pr".
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] string notation
        Game position in John's notation. It is guaranteed that notation is correct, but
        not guaranteed that it represents a valid game position.
        Guaranteed constraints:
        15 ≤ notation.length ≤ 71.
        [output] string
        Notation for the position of the game board, rotated 90 degrees clockwise.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.SecretArchives
{
    class chessNotationClass
    {
        string chessNotation(string notation) {
            var board = notation.Split('/');
            char PieceAt(int row, int cell) {
                var no = 0;
                foreach(var c in board[row]) {
                    if ('1' <= c && c <= '8') {
                        var spaces = (int)c - '0';
                        no += spaces;
                        if (cell < no) return ' ';
                    } else {
                        if (cell == no) return c;
                        no++;
                    }
                }
                Console.WriteLine($"{row},{cell} is not found");
                return  '?';
            }
            var newBoard = new List<string>();
            for(var r = 0; r < 8; r++) {
                var row = "";
                for(var c = 0; c < 8; c++) {
                    var p = PieceAt(7 - c, r);
                    if (p == ' ') {
                        if (row == "") {
                            row += '1';
                        } else {
                            var s = row[row.Length - 1];
                            if ('0' <= s && s <= '8') {
                                row = row.Substring(0, row.Length - 1) + (char)(s + 1);
                            } else {
                                row += '1';
                            }
                        }
                    } else {
                        row += p;
                    }
                }
                newBoard.Add(row);
            }
            return string.Join("/", newBoard);
        }
    }
}
