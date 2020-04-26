/*
    Status:   Solved
    Imported: 2020-04-26 13:32
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/chess-tavern/3hvEEqS7wuoEMZJJC

    Description:
        An amazon (also known as a queen + knight compound) is an imaginary chess piece
        that can move like a queen or a knight (or, equivalently, like a rook, bishop,
        or knight). The diagram below shows all squares which the amazon can attack from
        e4 (circles represent knight-like moves while crosses correspond to queen-like
        moves).
        
        Recently, you've come across a diagram with only three pieces left on
        the board: a white amazon, the white king, and the black king. It's black's
        move. You don't have time to determine whether the game is over or not, but
        you'd like to figure it out in your head. Unfortunately, the diagram is smudged
        and you can't see the position of the black king, so you'll need to consider all
        possible positions.
        
        Given the positions of the white pieces on a standard
        chessboard (using algebraic notation), your task is to determine the number of
        possible black king's positions such that:
        
        it's checkmate (i.e. black's king is
        under the amazon's attack and it cannot make a valid move);
        it's check (i.e.
        black's king is under the amazon's attack but it can reach a safe square in one
        move);
        it's stalemate (i.e. black's king is on a safe square but it cannot make
        a valid move);
        black's king is on a safe square and it can make a valid move.
        Note that two kings cannot be placed on two adjacent squares (including two
        diagonally adjacent ones).
        
        Example
        
        For king = "d3" and amazon = "e4", the
        output should be
        amazonCheckmate(king, amazon) = [5, 21, 0, 29].
        
        Red crosses
        correspond to the checkmate positions, orange pluses refer to check positions,
        and green circles denote safe squares.
        
        For king = "a1" and amazon = "g5", the
        output should be
        amazonCheckmate(king, amazon) = [0, 29, 1, 29].
        
        The stalemate
        position is marked by a blue square.
        
        Input/Output
        
        [execution time limit] 3
        seconds (cs)
        
        [input] string king
        
        The position of the white king, in chess
        notation.
        
        Guaranteed constraints:
        king.length = 2,
        'a' ≤ king[0] ≤ 'h',
        1 ≤
        king[1] ≤ 8.
        
        [input] string amazon
        
        The position of the white amazon, in the
        same notation.
        
        Guaranteed constraints:
        amazon.length = 2,
        'a' ≤ amazon[0] ≤
        'h',
        1 ≤ amazon[1] ≤ 8,
        amazon ≠ king.
        
        [output] array.integer
        
        An array of four
        integers, each equal to the number of black's king positions corresponding to a
        specific situation. More specifically, the array should be of the form
        [checkmate positions, check positions, stalemate positions, safe positions].

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.ChessTavern
{
    class amazonCheckmateClass
    {
        int[] amazonCheckmate(string king, string amazon) {
            var kmoves = new (int x, int y)[] {(-1,-1), (0,-1), (1,-1), (-1, 0), (1, 0), (-1, 1), (0,1), (1,1)};
            var nmoves = new (int x, int y)[] {(2,1), (2,-1), (-2,1), (-2,-1), (1,2),(1,-2),(-1,2),(-1,-2)};
            var k = (x: (int)king[0] - 'a', y: (int)king[1] - '1');
            var a = (x: (int)amazon[0] - 'a', y: (int)amazon[1] - '1');
         
            // Setup board, start with the king.
            var invalid = Enumerable.Range(0, 8).Select(d => new bool[8]).ToArray();
            bool setInvalid(int x, int y, bool inv = true) {
                if (0 > x || x >= 8) return false;
                if (0 > y || y >= 8) return false;
                invalid[y][x] = inv;
                return true;
            }
            bool isInvalid(int x, int y) {
                if (0 > x || x >= 8) return true;
                if (0 > y || y >= 8) return true;
                return invalid[y][x];
            }
            void invalidateLine(int dx, int dy) {
                int x = a.x, y = a.y;
                for(var i = 0; i < 7; i++) {
                    x += dx; y += dy;
                    if (k.x == x && k.y == y) break;
                    if (!setInvalid(x, y)) break;
                }
            }
            invalid[k.y][k.x] = true;  
            foreach(var m in kmoves) {
                setInvalid(k.x + m.x, k.y + m.y);
            }
            foreach(var n in nmoves) {
                setInvalid(n.x+a.x,n.y+a.y);
            }
            invalidateLine(1, 0);
            invalidateLine(-1, 0);
            invalidateLine(0, 1);
            invalidateLine(0, -1);
            invalidateLine(1, -1);
            invalidateLine(1, 1);
            invalidateLine(-1, -1);
            invalidateLine(-1, 1);
            if (!kmoves.Any(m => k.x+m.x==a.x && k.y+m.y==a.y)) {
                setInvalid(a.x, a.y, false);  // Amazon is not protected.
            }
         
            int checkmate = 0;
            int check = 0;
            int slatemate = 0;
            int normal = 0;
         
            var set = new HashSet<(int x, int y)>();
            for(int y = 0; y < 8; y++) {
                for(int x = 0; x < 8; x++) {
                    if ((x == k.x && y == k.y) || (x == a.x && y == a.y) ) continue;
                    if (kmoves.Any(m => x == k.x+m.x && y == k.y+m.y)) continue;
                    bool mate = kmoves.Select(m => isInvalid(x+m.x,y+m.y)).All(b => b);
                    if (isInvalid(x, y)) {
                        //if (!mate) set.Add((x, y));
                        if (mate) checkmate++;
                        else check++;
                    } else {
                        if (mate) slatemate++;
                        else normal++;
                    }
                }
            }
         
            foreach(var r in invalid.Select((a, y) => (a, y)).Reverse()) {
                Console.WriteLine(string.Join(" ", r.a.Select((b, x) => set.Contains((x,r.y)) ? "X" : (b ? "*" : "."))));
            }
            return new int[]{checkmate, check, slatemate, normal};
        }
    }
}
