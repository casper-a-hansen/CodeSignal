/*
    Status:   Solved
    Imported: 2020-04-26 12:21
    By:       Casper
    Url:      https://app.codesignal.com/arcade/intro/level-2/2mxbGwLzvkTCKAJMG

    Description:
        Given a sequence of integers as an array, determine whether it is possible to
        obtain a strictly increasing sequence by removing no more than one element from
        the array.
        
        Note: sequence a0, a1, ..., an is considered to be a strictly
        increasing if a0 < a1 < ... < an. Sequence containing only one element is also
        considered to be strictly increasing.
        
        Example
        
        For sequence = [1, 3, 2, 1], the
        output should be
        almostIncreasingSequence(sequence) = false.
        
        There is no one
        element in this array that can be removed in order to get a strictly increasing
        sequence.
        
        For sequence = [1, 3, 2], the output should be
        almostIncreasingSequence(sequence) = true.
        
        You can remove 3 from the array to
        get the strictly increasing sequence [1, 2]. Alternately, you can remove 2 to
        get the strictly increasing sequence [1, 3].
        
        Input/Output
        
        [execution time
        limit] 3 seconds (cs)
        
        [input] array.integer sequence
        
        Guaranteed constraints:
        2
        ≤ sequence.length ≤ 105,
        -105 ≤ sequence[i] ≤ 105.
        
        [output] boolean
        
        Return
        true if it is possible to remove one element from the array in order to get a
        strictly increasing sequence, otherwise return false.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Intro.EdgeOfTheOcean
{
    class almostIncreasingSequenceClass
    {
        bool almostIncreasingSequence(int[] sequence) 
        {
            return TryRemoveHighestValue(sequence) || TryRemoveLowestValue(sequence);
        }
         
        bool TryRemoveLowestValue(int[] sequence)
        {
            bool removedOne = false;
            var lastTested = int.MaxValue;
            foreach(var value in sequence.Reverse())
            {
                if (value >= lastTested)
                {
                    // Remove the value i (don't change lastTested)
                    if (removedOne)
                    {
                        return false;
                    }
                    removedOne = true;
                }
                else
                {
                    lastTested = value;
                }
            }
            return true;
        }
         
        bool TryRemoveHighestValue(int[] sequence)
        {
            bool removedOne = false;
            var lastTested = int.MinValue;
            foreach(var value in sequence)
            {
                if (value <= lastTested)
                {
                    // Remove the value i (don't change lastTested)
                    if (removedOne)
                    {
                        return false;
                    }
                    removedOne = true;
                }
                else
                {
                    lastTested = value;
                }
            }
            return true;
        }
    }
}
