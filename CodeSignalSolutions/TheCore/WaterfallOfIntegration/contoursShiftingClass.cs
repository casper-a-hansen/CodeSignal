/*
    Status:   Solved
    Imported: 2020-04-26 13:29
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/waterfall-of-integration/LfP67YRDw2rxoLmeP

    Description:
        Mark got a rectangular array matrix for his birthday, and now he's thinking
        about all the fun things he can do with it. He likes shifting a lot, so he
        decides to shift all of its i-contours in a clockwise direction if i is even,
        and counterclockwise if i is odd.
        
        Here is how Mark defines i-contours:
        
        the
        0-contour of a rectangular array as the union of left and right columns as well
        as top and bottom rows;
        consider the initial matrix without the 0-contour: its
        0-contour is the 1-contour of the initial matrix;
        define 2-contour, 3-contour,
        etc. in the same manner by removing 0-contours from the obtained arrays.
        Implement a function that does exactly what Mark wants to do to his matrix.
        Example
        
        For
        
        matrix = [[ 1,  2,  3,  4],
                   [ 5,  6,  7,  8],
        [ 9, 10, 11, 12],
                   [13, 14, 15, 16],
                   [17, 18, 19, 20]]
        the output should be
        
        contoursShifting(matrix) = [[ 5,  1,  2,  3],
        [ 9,  7, 11,  4],
                                     [13,  6, 15,  8],
        [17, 10, 14, 12],
                                     [18, 19, 20, 16]]
        
        
        For matrix =
        [[238, 239, 240, 241, 242, 243, 244, 245]],
        the output should be
        contoursShifting(matrix) = [[245, 238, 239, 240, 241, 242, 243, 244]].
        
        Note,
        that if a contour is represented by a 1 × n array, its center is considered to
        be below it.
        
        For
        
        matrix = [[238],
                   [239],
                   [240],
        [241],
                   [242],
                   [243],
                   [244],
                   [245]]
        the output should be
        
        contoursShifting(matrix) = [[245],
        [238],
                                     [239],
                                     [240],
        [241],
                                     [242],
                                     [243],
        [244]]
        
        
        If a contour is represented by an n × 1 array, its center is considered
        to be to the left of it.
        
        Input/Output
        
        [execution time limit] 3 seconds (cs)
        [input] array.array.integer matrix
        
        Guaranteed constraints:
        1 ≤ matrix.length ≤
        100,
        1 ≤ matrix[i].length ≤ 100,
        1 ≤ matrix[i][j] ≤ 1000.
        
        [output]
        array.array.integer
        
        The given matrix with its contours shifted.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.WaterfallOfIntegration
{
    class contoursShiftingClass
    {
        int[][] contoursShifting(int[][] matrix) {
            var height = matrix.Length;
            var width = matrix[0].Length;
            var half = (Math.Min(height, width) + 1) / 2;
          //  Console.WriteLine($"{width} X {height} -> {half}");
         
            int offset = 0;
            bool clockwise = true;
            void Shift() {
                // Following the frame around to shift it clockwise or counterclockwise.
                // To shift it clockwise it follows the frame in counterclockwise direction.
                int w = (width - 2 * offset); int h = (height - 2 * offset);
                if (w == 1 && h == 1) return;
                int count = w > 1 && h > 1 ? w * 2 + h * 2 - 5 : Math.Max(w, h) - 1;
         
                int x = offset; int y = offset;
                int oX = clockwise ? -1 : 1;
                int oY = 0;
                if (w == 1) {
                    oY = oX; oX = 0;
                    if (oY == -1) y = height - offset - 1;
                } else if (h == 1) {
                    if (oX == -1) x = width - offset - 1;
                }
        //        Console.WriteLine($"shifting: {count} pairs");
                for(var c = 0; c < count; c++) {
                    int nX = x + oX; int nY = y + oY;
                    if (nX < offset || nX > width - offset - 1) {
                        oX = 0;
                        oY = y == offset ? 1 : -1;
                        nX = x; nY = y + oY;
                    } else if (nY < offset || nY > height - offset - 1) {
                        oX = x == offset ? 1 : -1;
                        oY = 0;
                        nX = x + oX; nY = y;
                    }
        //            Console.WriteLine($"Swap ({x},{y})={matrix[y][x]} and ({nX},{nY})={matrix[nY][nX]}");
                    var tmp = matrix[y][x]; matrix[y][x] = matrix[nY][nX]; matrix[nY][nX] = tmp;
                    x = nX; y = nY;
                }
            }
            for(offset = 0; offset < half; offset++) {
        //        Console.WriteLine($"Offset:{offset}  Clockwise:{clockwise}");
                Shift();
                clockwise = !clockwise;
            }
            return matrix;
        }
    }
}
