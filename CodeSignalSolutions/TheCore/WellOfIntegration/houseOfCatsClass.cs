/*
    Status:   Solved
    Imported: 2020-04-26 13:24
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/well-of-integration/RaWLwT2eb96hp4N5Z

    Description:
        There are some people and cats in a house. You are given the number of legs they
        have all together. Your task is to return an array containing every possible
        number of people that could be in the house sorted in ascending order. It's
        guaranteed that each person has 2 legs and each cat has 4 legs.
        
        Example
        
        For
        legs = 6, the output should be
        houseOfCats(legs) = [1, 3].
        
        There could be
        either 1 cat and 1 person (4 + 2 = 6) or 3 people (2 * 3 = 6).
        
        For legs = 2,
        the output should be
        houseOfCats(legs) = [1].
        
        There can be only 1 person.
        Input/Output
        
        [execution time limit] 3 seconds (cs)
        
        [input] integer legs
        
        The
        total number of legs in the house. It's guaranteed,that this number is even.
        Guaranteed constraints:
        0 ≤ legs < 50.
        
        [output] array.integer
        
        Every possible
        number of people that can be in the house.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.WellOfIntegration
{
    class houseOfCatsClass
    {
        int[] houseOfCats(int legs) {
            return Enumerable.Range(0, legs / 2 + 1).Where(p => (legs - p * 2) % 4 == 0).ToArray();
        }
    }
}
