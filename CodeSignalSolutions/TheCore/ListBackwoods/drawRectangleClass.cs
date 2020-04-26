/*
    Status:   Solved
    Imported: 2020-04-26 13:29
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/list-backwoods/uFQEiM4trARdm2z46

    Description:
        You are implementing a command-line version of the Paint app. Since the command
        line doesn't support colors, you are using different characters to represent
        pixels. Your current goal is to support rectangle x1 y1 x2 y2 operation, which
        draws a rectangle that has an upper left corner at (x1, y1) and a lower right
        corner at (x2, y2). Here the x-axis points from left to right, and the y-axis
        points from top to bottom.
        
        Given the initial canvas state and the array that
        represents the coordinates of the two corners, return the canvas state after the
        operation is applied. For the details about how rectangles are painted, see the
        example.
        
        Example
        
        For
        
        canvas = [['a', 'a', 'a', 'a', 'a', 'a', 'a', 'a'],
        ['a', 'a', 'a', 'a', 'a', 'a', 'a', 'a'],
                  ['a', 'a', 'a', 'a', 'a',
        'a', 'a', 'a'],
                  ['b', 'b', 'b', 'b', 'b', 'b', 'b', 'b'],
        ['b', 'b', 'b', 'b', 'b', 'b', 'b', 'b']]
        
        
        and rectangle = [1, 1, 4, 3], the
        output should be
        
        drawRectangle(canvas, rectangle) = [['a', 'a', 'a', 'a', 'a',
        'a', 'a', 'a'],
                          					['a', '*', '-', '-', '*', 'a', 'a', 'a'],
        ['a', '|', 'a', 'a', '|', 'a', 'a', 'a'],
                          					['b', '*', '-',
        '-', '*', 'b', 'b', 'b'],
                          					['b', 'b', 'b', 'b', 'b', 'b',
        'b', 'b']]
        
        
        Here is the rectangle, colored for illustration:
        
        
        [['a', 'a', 'a',
        'a', 'a', 'a', 'a', 'a'],
        ['a', '*', '-', '-', '*', 'a', 'a', 'a'],
        ['a', '|',
        'a', 'a', '|', 'a', 'a', 'a'],
        ['b', '*', '-', '-', '*', 'b', 'b', 'b'],
        ['b',
        'b', 'b', 'b', 'b', 'b', 'b', 'b']]
        
        
        Note that rectangle sides are depicted as
        -s and |s, asterisks (*) stand for its corners and all of the other "pixels"
        remain the same.
        
        Input/Output
        
        [execution time limit] 3 seconds (cs)
        
        [input]
        array.array.char canvas
        
        A non-empty rectangular matrix of characters.
        Guaranteed constraints:
        2 ≤ canvas.length ≤ 10,
        2 ≤ canvas[0].length ≤ 10.
        [input] array.integer rectangle
        
        Array of four integers - [x1, y1, x2, y2].
        Guaranteed constraints:
        0 ≤ x1 < x2 < canvas[i].length,
        0 ≤ y1 < y2 <
        canvas.length.
        
        [output] array.array.char

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.ListBackwoods
{
    class drawRectangleClass
    {
        char[][] drawRectangle(char[][] canvas, int[] rectangle) {
         
            canvas[rectangle[1]][rectangle[0]] = '*';
            canvas[rectangle[1]][rectangle[2]] = '*';
            canvas[rectangle[3]][rectangle[0]] = '*';
            canvas[rectangle[3]][rectangle[2]] = '*';
            for(var x = rectangle[0] + 1; x < rectangle[2]; x++) {
                canvas[rectangle[1]][x] = '-';
                canvas[rectangle[3]][x] = '-';
            }
            for(var y = rectangle[1] + 1; y < rectangle[3]; y++) {
                canvas[y][rectangle[0]]= '|';
                canvas[y][rectangle[2]] = '|';
            }
            return canvas;
        }
    }
}
