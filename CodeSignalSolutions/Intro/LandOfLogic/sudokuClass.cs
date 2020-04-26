/*
    Status:   Solved
    Imported: 2020-04-26 13:14
    By:       Casper
    Url:      https://app.codesignal.com/arcade/intro/level-12/tQgasP8b62JBeirMS

    Description:
        Sudoku is a number-placement puzzle. The objective is to fill a 9 × 9 grid with
        digits so that each column, each row, and each of the nine 3 × 3 sub-grids that
        compose the grid contains all of the digits from 1 to 9.
        
        This algorithm should
        check if the given grid of numbers represents a correct solution to Sudoku.
        Example
        
        For
        grid = [[1, 3, 2, 5, 4, 6, 9, 8, 7],
                [4, 6, 5, 8, 7, 9, 3,
        2, 1],
                [7, 9, 8, 2, 1, 3, 6, 5, 4],
                [9, 2, 1, 4, 3, 5, 8, 7, 6],
        [3, 5, 4, 7, 6, 8, 2, 1, 9],
                [6, 8, 7, 1, 9, 2, 5, 4, 3],
                [5, 7,
        6, 9, 8, 1, 4, 3, 2],
                [2, 4, 3, 6, 5, 7, 1, 9, 8],
                [8, 1, 9, 3,
        2, 4, 7, 6, 5]]
        
        
        the output should be
        sudoku(grid) = true;
        
        For
        grid = [[1, 3,
        2, 5, 4, 6, 9, 2, 7],
                [4, 6, 5, 8, 7, 9, 3, 8, 1],
                [7, 9, 8, 2,
        1, 3, 6, 5, 4],
                [9, 2, 1, 4, 3, 5, 8, 7, 6],
                [3, 5, 4, 7, 6, 8,
        2, 1, 9],
                [6, 8, 7, 1, 9, 2, 5, 4, 3],
                [5, 7, 6, 9, 8, 1, 4, 3,
        2],
                [2, 4, 3, 6, 5, 7, 1, 9, 8],
                [8, 1, 9, 3, 2, 4, 7, 6, 5]]
        the output should be
        sudoku(grid) = false.
        
        The output should be false: each of
        the nine 3 × 3 sub-grids should contain all of the digits from 1 to 9.
        These
        examples are represented on the image below.
        
        Input/Output
        
        [execution time
        limit] 3 seconds (cs)
        
        [input] array.array.integer grid
        
        A matrix representing 9
        × 9 grid already filled with numbers from 1 to 9.
        
        Guaranteed constraints:
        grid.length = 9,
        grid[i].length = 9,
        1 ≤ grid[i][j] ≤ 9.
        
        [output] boolean
        
        true
        if the given grid represents a correct solution to Sudoku, false otherwise.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Intro.LandOfLogic
{
    class sudokuClass
    {
        bool sudoku(int[][] grid) {
            for(var i = 0; i < 9; i++) {
                if (!CheckRow(grid, i) || !CheckColumn(grid, i) || !CheckBlock(grid, i)) return false;
            }
            return true;
        }
         
        bool CheckRow(int[][] grid, int y) {
            HashSet<int> unique = new HashSet<int>();
         
            for(var x = 0; x < 9; x++) {
                if (!unique.Add(grid[y][x])) return false;
            }
            return true;
        }
        bool CheckColumn(int[][] grid, int x) {
            HashSet<int> unique = new HashSet<int>();
         
            for(var y = 0; y < 9; y++) {
                if (!unique.Add(grid[y][x])) return false;
            }
            return true;
        }
         
        bool CheckBlock(int[][] grid, int i) {
            // Block 0 starts at 0,0, Block 1 starts at 3,0, Block 3 starts at 0,3
            var startY = (i % 3) * 3;  // y = 0 at block 0, 3, 6
            var startX = (i/3) * 3;
         
            HashSet<int> unique = new HashSet<int>();
            for(var y = startY; y < startY + 3; y++) {
                for(var x = startX; x < startX + 3; x++) {
                    if (!unique.Add(grid[y][x])) return false;
                }
            }
            return true;
        }
    }
}
