/*
    Status:   Solved
    Imported: 2020-04-26 13:19
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/loop-tunnel/RcK4vupi8sFhakjnh

    Description:
        Imagine a white rectangular grid of n rows and m columns divided into two parts
        by a diagonal line running from the upper left to the lower right corner. Now
        let's paint the grid in two colors according to the following rules:
        
        A cell is
        painted black if it has at least one point in common with the diagonal;
        Otherwise, a cell is painted white.
        
        Count the number of cells painted black.
        Example
        
        For n = 3 and m = 4, the output should be
        countBlackCells(n, m) = 6.
        There are 6 cells that have at least one common point with the diagonal and
        therefore are painted black.
        
        For n = 3 and m = 3, the output should be
        countBlackCells(n, m) = 7.
        
        7 cells have at least one common point with the
        diagonal and are painted black.
        
        Input/Output
        
        [execution time limit] 3 seconds
        (cs)
        
        [input] integer n
        
        The number of rows.
        
        Guaranteed constraints:
        1 ≤ n ≤
        105.
        
        [input] integer m
        
        The number of columns.
        
        Guaranteed constraints:
        1 ≤ m ≤
        105.
        
        [output] integer
        
        The number of black cells.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.LoopTunnel
{
    class countBlackCellsClass
    {
        int countBlackCells(int n, int m) {
            return m + n - 1 + Factor(n, m)  - 1;
        }
         
        int countBlackCells2(int rows, int columns) {
            var width = (double)columns / (double)rows;
            var blocksPerRow = Math.Ceiling(width);
            //Console.WriteLine($"Blocks per row: {blocksPerRow}");
            var result = rows * blocksPerRow;
            //Console.WriteLine($"Ordinary blocks: {result}");
         
            // The two extra blocks that occurs when passing right through the corner of a cell.
         
            var factor = Factor(rows, columns);
            //Console.WriteLine($"Crossing a corner {factor} time(s)");
            var extraBlocks = 2 * factor - 2;
            //Console.WriteLine($"Extra blocks: {extraBlocks}");
         
            return (int)(rows * blocksPerRow) + extraBlocks;
        }
         
        int Factor(int rows, int columns)
        {
            if (rows == 1) return 1;
            for(int i = rows; i >= 2; i--) {
                if (columns % i == 0 && rows % i == 0) {
                    return i;
                }
            }
            return 1;
        }
         
         
        int countBlackCells1(int n, int m) {
            int result = 0;
            double angle = (double)m / (double)n;
            double x = 0;
            for(var y = 1; y <= n; y++) {
                double l = (double)y * angle;
                result += (int)Math.Ceiling(l + 0.001) - (int)Math.Floor(x - 0.001);
                //Console.WriteLine($"{y}:  {x:G2} -> {l:G2} -> {result}");
                x = l;
            }
            return result - 2;  // We count 2 too many because of the +/- 0.001
        }
    }
}
