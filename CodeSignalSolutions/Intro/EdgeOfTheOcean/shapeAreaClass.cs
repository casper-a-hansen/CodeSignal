/*
    Status:   Solved
    Imported: 2020-04-26 12:21
    By:       Casper
    Url:      https://app.codesignal.com/arcade/intro/level-2/yuGuHvcCaFCKk56rJ

    Description:
        Below we will define an n-interesting polygon. Your task is to find the area of
        a polygon for a given n.
        
        A 1-interesting polygon is just a square with a side
        of length 1. An n-interesting polygon is obtained by taking the n -
        1-interesting polygon and appending 1-interesting polygons to its rim, side by
        side. You can see the 1-, 2-, 3- and 4-interesting polygons in the picture
        below.
        
        Example
        
        For n = 2, the output should be
        shapeArea(n) = 5;
        For n = 3,
        the output should be
        shapeArea(n) = 13.
        
        Input/Output
        
        [execution time limit] 3
        seconds (cs)
        
        [input] integer n
        
        Guaranteed constraints:
        1 ≤ n < 104.
        
        [output]
        integer
        
        The area of the n-interesting polygon.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Intro.EdgeOfTheOcean
{
    class shapeAreaClass
    {
        int shapeArea(int n) {
            return n * n + (n - 1) * (n - 1);
        }
    }
}
