/*
    Status:   Solved
    Imported: 2020-04-26 13:32
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/chess-tavern/FfjPkYvo9ah6wgXem

    Description:
        In ChessLand there is a small but proud chess bishop with a recurring dream. In
        the dream the bishop finds itself on an n × m chessboard with mirrors along each
        edge, and it is not a bishop but a ray of light. This ray of light moves only
        along diagonals (the bishop can't imagine any other types of moves even in its
        dreams), it never stops, and once it reaches an edge or a corner of the
        chessboard it reflects from it and moves on.
        
        Given the initial position and the
        direction of the ray, find its position after k steps where a step means either
        moving from one cell to the neighboring one or reflecting from a corner of the
        board.
        
        Example
        
        For boardSize = [3, 7], initPosition = [1, 2],
        initDirection =
        [-1, 1], and k = 13, the output should be
        chessBishopDream(boardSize,
        initPosition, initDirection, k) = [0, 1].
        
        Here is the bishop's path:
        
        [1, 2] ->
        [0, 3] -(reflection from the top edge)-> [0, 4] -> 
        [1, 5] -> [2, 6]
        -(reflection from the bottom right corner)-> [2, 6] ->
        [1, 5] -> [0, 4]
        -(reflection from the top edge)-> [0, 3] ->
        [1, 2] -> [2, 1] -(reflection from
        the bottom edge)-> [2, 0] -(reflection from the left edge)->
        [1, 0] -> [0, 1]
        Input/Output
        
        [execution time limit] 3 seconds (cs)
        
        [input] array.integer
        boardSize
        
        An array of two integers, the number of rows and columns,
        respectively. Rows are numbered by integers from 0 to boardSize[0] - 1, columns
        are numbered by integers from 0 to boardSize[1] - 1 (both inclusive).
        Guaranteed constraints:
        1 ≤ boardSize[i] ≤ 20.
        
        [input] array.integer
        initPosition
        
        An array of two integers, indices of the row and the column where
        the bishop initially stands, respectively.
        
        Guaranteed constraints:
        0 ≤
        initPosition[i] < boardSize[i].
        
        [input] array.integer initDirection
        
        An array
        of two integers representing the initial direction of the bishop. If it stands
        in (a, b), the next cell he'll move to is (a + initDirection[0], b +
        initDirection[1]) or whichever it'll reflect to in case it runs into a mirror
        immediately.
        
        Guaranteed constraints:
        initDirection[i] ∈ {-1, 1}.
        
        [input]
        integer k
        
        Guaranteed constraints:
        1 ≤ k ≤ 109.
        
        [output] array.integer
        
        The
        position of the bishop after k steps.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.ChessTavern
{
    class chessBishopDreamClass
    {
        int[] chessBishopDream(int[] boardSize, int[] initPosition, int[] initDirection, int k) {
            int Offset(int i) {
                var distance = k + (initDirection[i] > 0 ? initPosition[i] : boardSize[i] - initPosition[i] - 1);
                var wallOffset = distance % boardSize[i];
                var direction = (distance / boardSize[i]) % 2;
                if (initDirection[i] == -1) direction = 1 - direction;
                return direction == 0 ? wallOffset : boardSize[i] - wallOffset - 1;
            }
            return new int[]{Offset(0), Offset(1)};
        }
    }
}
