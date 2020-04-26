/*
    Status:   Solved
    Imported: 2020-04-26 13:23
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/mirror-lake/fQpfgxiY6aGiGHLtv

    Description:
        Given a rectangular matrix containing only digits, calculate the number of
        different 2 × 2 squares in it.
        
        Example
        
        For
        
        matrix = [[1, 2, 1],
                  [2,
        2, 2],
                  [2, 2, 2],
                  [1, 2, 3],
                  [2, 2, 1]]
        
        
        the
        output should be
        differentSquares(matrix) = 6.
        
        Here are all 6 different 2 × 2
        squares:
        
        1 2
        2 2
        2 1
        2 2
        2 2
        2 2
        2 2
        1 2
        2 2
        2 3
        2 3
        2 1
        
        Input/Output
        [execution time limit] 3 seconds (cs)
        
        [input] array.array.integer matrix
        Guaranteed constraints:
        1 ≤ matrix.length ≤ 100,
        1 ≤ matrix[i].length ≤ 100,
        0 ≤
        matrix[i][j] ≤ 9.
        
        [output] integer
        
        The number of different 2 × 2 squares in
        matrix.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.MirrorLake
{
    class differentSquaresClass
    {
        int differentSquares(int[][] matrix) {
            var maxY = matrix.Length - 1;
            var maxX = matrix[0].Length - 1;
            var set = new HashSet<string>(maxY * maxX);
            for(var y = 0; y < maxY; y++) {
                for(var x = 0; x < maxX; x++) {
                    var square = $"{matrix[y][x]},{matrix[y][x+1]},{matrix[y+1][x]},{matrix[y+1][x+1]}";
                    set.Add(square);
                }
            }
            return set.Count;
        }
    }
}
