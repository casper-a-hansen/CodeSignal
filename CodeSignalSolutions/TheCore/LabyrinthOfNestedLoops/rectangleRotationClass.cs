/*
    Status:   Solved
    Imported: 2020-04-26 13:21
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/labyrinth-of-nested-loops/tuKA5f3zpzkKKejJx

    Description:
        A rectangle with sides equal to even integers a and b is drawn on the Cartesian
        plane. Its center (the intersection point of its diagonals) coincides with the
        point (0, 0), but the sides of the rectangle are not parallel to the axes;
        instead, they are forming 45 degree angles with the axes.
        
        How many points with
        integer coordinates are located inside the given rectangle (including on its
        sides)?
        
        Example
        
        For a = 6 and b = 4, the output should be
        rectangleRotation(a,
        b) = 23.
        
        The following picture illustrates the example, and the 23 points are
        marked green.
        
        Input/Output
        
        [execution time limit] 3 seconds (cs)
        
        [input]
        integer a
        
        A positive even integer.
        
        Guaranteed constraints:
        2 ≤ a ≤ 50.
        [input] integer b
        
        A positive even integer.
        
        Guaranteed constraints:
        2 ≤ b ≤ 50.
        [output] integer
        
        The number of inner points with integer coordinates.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.LabyrinthOfNestedLoops
{
    class rectangleRotationClass
    {
        int rectangleRotation(int a, int b) {
            int n1 = (int)Math.Floor(a / 2 / 1.414) * 2 + 1;
            int n2 = (int)Math.Floor(b / 2 / 1.414) * 2 + 1;
            int n3 = ((int)Math.Floor(((a - 1.414) / 2) / 1.414) + 1) * 2;
            int n4 = ((int)Math.Floor(((b - 1.414) / 2) / 1.414) + 1) * 2;
            return n1 * n2 + n3 * n4;
        }
        /*int rectangleRotation(int a, int b) {
            double pixelSpace = Math.Sqrt(2 * 0.5 * 0.5);
            int aP = (int)(a / pixelSpace / 2.0) * 2 + 1;
            int bP = (int)(b / pixelSpace / 2.0) * 2 + 1;
            var result = aP * bP;
            Console.WriteLine($"{aP}x{bP} = {result}");
            result -= (aP / 2) * ((bP + 1) / 2);
            Console.WriteLine($"-{aP/2} * {(bP + 1) / 2} = {(aP / 2) * ((bP + 1) / 2)}");
            Console.WriteLine($"{aP}x{bP} = {result}");
            result -= ((aP + 1) / 2) * (bP / 2);
            Console.WriteLine($"-{(aP +1)/2} * {bP/2} = {((aP + 1) / 2) * (bP / 2)}");
            Console.WriteLine($"{aP}x{bP} = {result}");
            return result;
        }*/
    }
}
