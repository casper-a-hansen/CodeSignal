/*
    Status:   Solved
    Imported: 2020-04-26 13:36
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/cliffs-of-pain/J8sBSYmWuWaNg6iXd

    Description:
        You are most likely familiar with the game 2048.
        
        2048 is played on a gray 4 × 4
        grid with numbered tiles that slide smoothly when a player moves them using one
        of the four arrow keys - Up, Down, Left or Right. On every turn, a new tile with
        a value of either 2 or 4 randomly appears on an empty spot of the board. After
        one of the keys is pressed, the tiles slide as far as possible in the chosen
        direction until they are stopped either by another tile or by the edge of the
        grid. If two tiles with the same number collide while moving, they merge into a
        tile with this number doubled. You can't merge an already merged tile in the
        same turn. If there are more than 2 tiles in the same row (column) that can
        merge, the farthest (closest to an edge) pair will be merged first (see the
        second example).
        
        In this problem you are not going to solve the 2048 puzzle,
        but you are going to find the final state of the board from the given one after
        a defined set of n arrow key presses, assuming that no new random tiles will
        appear on the empty spots.
        
        The following example shows the next state of the
        board after pressing Right.
        
        This example shows the next state of the board
        after pressing Down.
        
        
        For more details you can visit
        http://gabrielecirulli.github.io/2048/ and play online 😃
        
        You are given a
        matrix 4 × 4 which corresponds to the 2048 game grid. grid[0][0] corresponds to
        the upper left tile of the grid. Each element of the grid is equal to some power
        of 2 if there is a tile with that value in the corresponding position, and 0 if
        it corresponds to the empty spot.
        You are also given a sequence of key presses
        as a string path. Each character of the string equals L, R, U, or D
        corresponding to Left, Right, Up or Down respectively.
        Please note that in some
        cases after pressing an arrow key nothing will be changed.
        
        Example
        
        For
        
        grid =
        [[0, 0, 0, 0],
                [0, 0, 2, 2],
                [0, 0, 2, 4],
                [2, 2, 4, 8]]
        and path = "RR", the output should be
        
        game2048(grid, path) = [[0, 0, 0, 0],
        [0, 0, 0, 4],
                                [0, 0, 2, 4],
                                [0,
        0, 8, 8]]
        
        
        Input/Output
        
        [execution time limit] 3 seconds (cs)
        
        [input]
        array.array.integer grid
        
        A square matrix of size 4 × 4, the starting state of
        the board. Each value of the matrix is 0 a power of 2.
        
        Guaranteed constraints:
        grid[i][j] ∈ {0} ∪ {2i | i = 0, 1, ..., 16}.
        
        [input] string path
        
        String
        representing key presses. Each character of the string equals L, R, U, or D.
        Guaranteed constraints:
        1 ≤ path.length ≤ 30.
        
        [output] array.array.integer
        
        The
        final state of the board after the given key presses are applied.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.CliffsOfPain
{
    class game2048Class
    {
        private int[][] _grid;
        int[][] game2048(int[][] grid, string path) {
            try {
            _grid = grid;
            foreach(var k in path) {
                switch(k) 
                {
                    case 'R': 
                        Move((row, cell) => grid[row][3 - cell], (row, cell, value) => grid[row][3 - cell] = value);
                        break;
                    case 'L': 
                        Move((row, cell) => grid[row][cell], (row, cell, value) => grid[row][cell] = value);
                        break;
         
                    case 'D':
                        Move((row, cell) => grid[3 - cell][row], (row, cell, value) => grid[3 - cell][row] = value);
                        break;
                    case 'U':
                        Move((row, cell) => grid[cell][row], (row, cell, value) => grid[cell][row] = value);
                        break;
                }
                Show();
            }
            } catch(Exception e) {Console.WriteLine(e.Message);}
            return grid;
        }
         
        void Move(Func<int, int, int> cellValue, Action<int, int, int> setCellValue)
        {
            for(var row = 0; row < 4; row++)
            {
                var min = 1;
                var changed = false;
                do {
                    changed = false;
                    for(int cell = min; cell < 4; cell++)
                    {
                        var value = cellValue(row, cell);
                        if ( value != 0) {
                            var prev = cellValue(row, cell - 1);
                            if (prev == 0) {
                                setCellValue(row, cell - 1, value);
                                setCellValue(row, cell, 0);
                                changed = true;
                            }
                            if (value == prev ) {
                                setCellValue(row, cell - 1, value + prev);
                                setCellValue(row, cell, 0);
                                changed = true;
                                min = cell + 1;
                            }
                        }
                    }
                } while(changed);
            }
            Show();
        }
         
        void Show() {
            foreach(var g in _grid) Console.WriteLine(string.Join(" ", g)); Console.WriteLine();
        }
    }
}
