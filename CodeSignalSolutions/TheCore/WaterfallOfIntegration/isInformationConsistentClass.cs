/*
    Status:   Solved
    Imported: 2020-05-02 13:06
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/waterfall-of-integration/jkuhbNn7AdeCC7z7R

    Description:
        Court is in session. We got a group of witnesses who have all taken an oath to
        tell the truth. The prosecutor is pointing at the defendants one by one and
        asking each witnesses a simple question - "guilty or not?". The witnesses are
        allowed to respond in one of the following three ways:
        I am sure he/she is guilty.
        I am sure he/she is innocent.
        I have no idea.
        The prosecutor has a hunch that one of the witnesses might not be telling the
        truth so she decides to cross-check all of their testimonies and see if the
        information gathered is consistent, i.e. there are no two witnesses A and B and
        a defendant C such that A says C is guilty while B says C is innocent.
        Example
        For
        evidences = [[ 0, 1, 0, 1],
        [-1, 1, 0, 0],
        [-1, 0, 0, 1]]
        the output should be
        isInformationConsistent(evidences) = true;
        For
        evidences = [[ 1, 0],
        [-1, 0],
        [ 1, 1],
        [ 1, 1]]
        the output should be
        isInformationConsistent(evidences) = false.
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] array.array.integer evidences
        2-dimensional array of integers representing the set of testimonials.
        evidences[i][j] is the testimonial of the ith witness on the jth defendant. -1
        means "innocent", 0 means "no idea", and 1 means "guilty".
        Guaranteed constraints:
        2 ≤ evidences.length ≤ 5,
        2 ≤ evidences[0].length ≤ 10,
        evidences[i].length = evidences[j].length,
        -1 ≤ evidences[i][j] ≤ 1.
        [output] boolean
        true if the evidence is consistent, false otherwise.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.WaterfallOfIntegration
{
    class isInformationConsistentClass
    {
        bool isInformationConsistent(int[][] evidences) {
            var width = evidences[0].Length;
            for(var e = 0; e < width; e++) {
                bool guilty = false; bool notGuilty = false;
                for(var i = 0; i < evidences.Length; i++) {
                    switch (evidences[i][e])
                    {
                        case 1: guilty = true; break;
                        case -1: notGuilty = true; break;
                    }
                }
                if (guilty && notGuilty) return false;
            }
            return true;
        }
    }
}
