/*
    Status:   Solved
    Imported: 2020-04-26 13:10
    By:       Casper
    Url:      https://app.codesignal.com/arcade/intro/level-6/t97bpjfrMDZH8GJhi

    Description:
        Given two cells on the standard chess board, determine whether they have the
        same color or not.
        
        Example
        
        For cell1 = "A1" and cell2 = "C3", the output
        should be
        chessBoardCellColor(cell1, cell2) = true.
        
        For cell1 = "A1" and cell2
        = "H3", the output should be
        chessBoardCellColor(cell1, cell2) = false.
        Input/Output
        
        [execution time limit] 3 seconds (cs)
        
        [input] string cell1
        Guaranteed constraints:
        cell1.length = 2,
        'A' ≤ cell1[0] ≤ 'H',
        1 ≤ cell1[1] ≤
        8.
        
        [input] string cell2
        
        Guaranteed constraints:
        cell2.length = 2,
        'A' ≤
        cell2[0] ≤ 'H',
        1 ≤ cell2[1] ≤ 8.
        
        [output] boolean
        
        true if both cells have the
        same color, false otherwise.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Intro.RainsOfReason
{
    class chessBoardCellColorClass
    {
        bool chessBoardCellColor(string cell1, string cell2) {
            var color1 = ((cell1[0] - 'A') + (cell1[1] - '1')) % 2;
            var color2 = ((cell2[0] - 'A') + (cell2[1] - '1')) % 2;
            return color1 == color2;
        }
    }
}
