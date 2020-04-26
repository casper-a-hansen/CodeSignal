/*
    Status:   Solved
    Imported: 2020-04-26 13:27
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/spring-of-integration/picP24ieQnuqR4kxJ

    Description:
        Yesterday you found some shoes in the back of your closet. Each shoe is
        described by two values:
        
        type indicates if it's a left or a right shoe;
        size is
        the size of the shoe.
        
        Your task is to check whether it is possible to pair the
        shoes you found in such a way that each pair consists of a right and a left shoe
        of an equal size.
        
        Example
        
        For
        
        shoes = [[0, 21], 
                 [1, 23],
        [1, 21], 
                 [0, 23]]
        
        
        the output should be
        pairOfShoes(shoes) = true;
        For
        
        shoes = [[0, 21], 
                 [1, 23], 
                 [1, 21], 
                 [1, 23]]
        the output should be
        pairOfShoes(shoes) = false.
        
        Input/Output
        
        [execution time
        limit] 3 seconds (cs)
        
        [input] array.array.integer shoes
        
        Array of shoes. Each
        shoe is given in the format [type, size], where type is either 0 or 1 for left
        and right respectively, and size is a positive integer.
        
        Guaranteed constraints:
        1 ≤ shoes.length ≤ 200,
        1 ≤ shoes[i][1] ≤ 100.
        
        [output] boolean
        
        true if it is
        possible to pair the shoes, false otherwise.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.SpringOfIntegration
{
    class pairOfShoesClass
    {
        bool pairOfShoes(int[][] shoes) {
            var left = shoes.Where(s => s[0] == 0).Select(s => s[1]).OrderBy(s => s).ToArray();
            var right = shoes.Where(s => s[0] == 1).Select(s => s[1]).OrderBy(s => s).ToArray();
            if (left.Length != right.Length) return false;
            return left.SequenceEqual(right);
        }
    }
}
