/*
    Status:   Solved
    Imported: 2020-04-26 13:30
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/waterfall-of-integration/hqrYesGKEaKQnv7Sv

    Description:
        You are given a vertical box divided into equal columns. Someone dropped several
        stones from its top through the columns. Stones are falling straight down at a
        constant speed (equal for all stones) while possible (i.e. while they haven't
        reached the ground or they are not blocked by another motionless stone). Given
        the state of the box at some moment in time, find out which columns become
        motionless first.
        
        Example
        
        For
        
        rows = ["#..##",
                ".##.#",
        ".#.##",
                "....."]
        
        
        the output should be gravitation(rows) = [1, 4].
        Check out the image below for better understanding:
        
        Input/Output
        
        [execution
        time limit] 3 seconds (cs)
        
        [input] array.string rows
        
        A non-empty array of
        strings of equal length consisting only of #-s and .-s describing the box at a
        specific moment in time. Sharps represent stones, and dots represent empty
        cells. row[0] corresponds to the upper row. Last element of rows corresponds to
        the ground level.
        
        Guaranteed constraints:
        2 ≤ rows.length ≤ 100,
        2 ≤
        rows[i].length ≤ 100.
        
        [output] array.integer
        
        A sorted array containing numbers
        of all columns (leftmost column's number is 0) in which movements will stop at
        the same second and earlier than in any other column. Assume that if there are
        no stones in a column then movement stops immediately, i.e. after 0 seconds.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.WaterfallOfIntegration
{
    class gravitationClass
    {
        int[] gravitation(string[] rows) {
            var height = rows.Length;
            var width = rows[0].Length;
         
            var motion = new int[width];
            for(var c = 0; c < width; c++) {
                bool hasRock = false;
                int falls = 0;
                for(var r = 0; r < height; r++) {
                    if (rows[r][c] == '#') hasRock = true;
                    else if (hasRock) falls++;
                }
                motion[c] = falls;
            }
         
            var min = motion.Min();
            return motion.Select((m, i) => (Motion: m, Index: i)).Where(d => d.Motion == min).Select(d => d.Index).ToArray();
        }
    }
}
