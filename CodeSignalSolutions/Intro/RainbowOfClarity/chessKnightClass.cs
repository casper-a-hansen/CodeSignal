/*
    Status:   Solved
    Imported: 2020-04-26 13:13
    By:       Casper
    Url:      https://app.codesignal.com/arcade/intro/level-11/pwRLrkrNpnsbgMndb

    Description:
        Given a position of a knight on the standard chessboard, find the number of
        different moves the knight can perform.
        
        The knight can move to a square that is
        two squares horizontally and one square vertically, or two squares vertically
        and one square horizontally away from it. The complete move therefore looks like
        the letter L. Check out the image below to see all valid moves for a knight
        piece that is placed on one of the central squares.
        
        Example
        
        For cell = "a1",
        the output should be
        chessKnight(cell) = 2.
        
        For cell = "c2", the output should
        be
        chessKnight(cell) = 6.
        
        Input/Output
        
        [execution time limit] 3 seconds (cs)
        [input] string cell
        
        String consisting of 2 letters - coordinates of the knight
        on an 8 × 8 chessboard in chess notation.
        
        Guaranteed constraints:
        cell.length =
        2,
        'a' ≤ cell[0] ≤ 'h',
        1 ≤ cell[1] ≤ 8.
        
        [output] integer

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Intro.RainbowOfClarity
{
    class chessKnightClass
    {
        int chessKnight(string cell) {
            var x = (int)(cell[0] - 'a');
            var y = (int)(cell[1] - '1');
         
            bool valid(int offsetX, int offsetY)
            {
                int newX = x + offsetX;
                if (newX < 0 || newX > 7) return false;
                int newY = y + offsetY;
                if (newY < 0 || newY > 7) return false;
                return true;
            }
            var moves = 0;
            for(var two = -2; two <= 2; two += 4)
            {
                for(var one = -1; one <= 1; one += 2)
                {
                    if (valid(two, one)) moves++;
                    if (valid(one, two)) moves++;
                }
            }
            return moves;
        }
    }
}
