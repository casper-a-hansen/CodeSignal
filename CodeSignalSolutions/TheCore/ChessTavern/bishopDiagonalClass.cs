/*
    Status:   Solved
    Imported: 2020-04-26 13:32
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/chess-tavern/wGLCfzpdcA2o9kSpD

    Description:
        In the Land Of Chess, bishops don't really like each other. In fact, when two
        bishops happen to stand on the same diagonal, they immediately rush towards the
        opposite ends of that same diagonal.
        
        Given the initial positions (in chess
        notation) of two bishops, bishop1 and bishop2, calculate their future positions.
        Keep in mind that bishops won't move unless they see each other along the same
        diagonal.
        
        Example
        
        For bishop1 = "d7" and bishop2 = "f5", the output should be
        bishopDiagonal(bishop1, bishop2) = ["c8", "h3"].
        
        For bishop1 = "d8" and bishop2
        = "b5", the output should be
        bishopDiagonal(bishop1, bishop2) = ["b5", "d8"].
        The bishops don't belong to the same diagonal, so they don't move.
        Input/Output
        
        [execution time limit] 3 seconds (cs)
        
        [input] string bishop1
        Coordinates of the first bishop in chess notation.
        
        Guaranteed constraints:
        bishop1.length = 2,
        'a' ≤ bishop1[0] ≤ 'h',
        1 ≤ bishop1[1] ≤ 8.
        
        [input] string
        bishop2
        
        Coordinates of the second bishop in the same notation.
        
        Guaranteed
        constraints:
        bishop2.length = 2,
        'a' ≤ bishop2[0] ≤ 'h',
        1 ≤ bishop2[1] ≤ 8.
        [output] array.string
        
        Coordinates of the bishops in lexicographical order after
        they check the diagonals they stand on.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.ChessTavern
{
    class bishopDiagonalClass
    {
        string[] bishopDiagonal(string bishop1, string bishop2) {
            int x1= PosX(bishop1), y1 = PosY(bishop1), x2 = PosX(bishop2), y2 = PosY(bishop2);
            if (Math.Abs(x1-x2) == Math.Abs(y1-y2)) {
                var dx = Math.Sign(x1 - x2);
                var dy = Math.Sign(y1 - y2);
                bishop1 = Move(x1,y1,dx,dy);
                bishop2 = Move(x2,y2,-dx,-dy);
            }
            if (bishop1.CompareTo(bishop2) > 0) {
                (bishop1, bishop2) = (bishop2, bishop1);
            }
            return new string[]{ bishop1, bishop2};
        }
        int PosX(string pos) => (int)(pos[0] - 'a');
        int PosY(string pos) => (int)(pos[1] - '1');
        string ToPos(int x, int y) => ((char)(x + 'a')).ToString() + ((char)(y + '1')).ToString();
        bool Valid(int p) => 0 <= p && p < 8;
        string Move(int x, int y, int dx, int dy) {
            for(int i = 0; i < 8; i++) {
                if (!Valid(x + dx) || !Valid(y + dy)) {
                    return ToPos(x,y);
                }
                x += dx;
                y += dy;
            }
            return null;
        }
    }
}
