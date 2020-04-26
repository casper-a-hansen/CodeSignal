/*
    Status:   Solved
    Imported: 2020-04-26 13:24
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/well-of-integration/3QMXNwGfvLMoQwed7

    Description:
        A boy is walking a long way from school to his home. To make the walk more fun
        he decides to add up all the numbers of the houses that he passes by during his
        walk. Unfortunately, not all of the houses have numbers written on them, and on
        top of that the boy is regularly taking turns to change streets, so the numbers
        don't appear to him in any particular order.
        
        At some point during the walk the
        boy encounters a house with number 0 written on it, which surprises him so much
        that he stops adding numbers to his total right after seeing that house.
        
        For
        the given sequence of houses determine the sum that the boy will get. It is
        guaranteed that there will always be at least one 0 house on the path.
        
        Example
        For inputArray = [5, 1, 2, 3, 0, 1, 5, 0, 2], the output should be
        houseNumbersSum(inputArray) = 11.
        
        The answer was obtained as 5 + 1 + 2 + 3 =
        11.
        
        Input/Output
        
        [execution time limit] 3 seconds (cs)
        
        [input] array.integer
        inputArray
        
        Guaranteed constraints:
        5 ≤ inputArray.length ≤ 10,
        0 ≤
        inputArray[i] ≤ 10.
        
        [output] integer

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.WellOfIntegration
{
    class houseNumbersSumClass
    {
        int houseNumbersSum(int[] inputArray) {
            int result = 0;
            foreach(var no in inputArray) {
                if (no == 0) break;
                result += no;
            }
            return result;
        }
    }
}
