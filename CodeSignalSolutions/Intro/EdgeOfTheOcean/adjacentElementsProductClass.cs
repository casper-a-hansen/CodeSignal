/*
    Status:   Solved
    Imported: 2020-05-02 11:53
    By:       Casper
    Url:      https://app.codesignal.com/arcade/intro/level-2/xzKiBHjhoinnpdh6m

    Description:
        Given an array of integers, find the pair of adjacent elements that has the
        largest product and return that product.
        Example
        For inputArray = [3, 6, -2, -5, 7, 3], the output should be
        adjacentElementsProduct(inputArray) = 21.
        7 and 3 produce the largest product.
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] array.integer inputArray
        An array of integers containing at least two elements.
        Guaranteed constraints:
        2 ≤ inputArray.length ≤ 10,
        -1000 ≤ inputArray[i] ≤ 1000.
        [output] integer
        The largest product of adjacent elements.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Intro.EdgeOfTheOcean
{
    class adjacentElementsProductClass
    {
        int adjacentElementsProduct(int[] inputArray) {
            int result = int.MinValue;
            for(var i = 0; i < inputArray.Length - 1; i++)
            {
                var product = inputArray[i] * inputArray[i + 1];
                if (product > result)
                {
                    result = product;
                }
            }
            return result;
        }
    }
}
