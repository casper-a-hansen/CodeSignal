/*
    Status:   Solved
    Imported: 2020-04-26 13:16
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/at-the-crossroads/jZ4ZSiGohzFTeg4yb

    Description:
        Once Mary heard a famous song, and a line from it stuck in her head. That line
        was "Will you still love me when I'm no longer young and beautiful?". Mary
        believes that a person is loved if and only if he/she is both young and
        beautiful, but this is quite a depressing thought, so she wants to put her
        belief to the test.
        
        Knowing whether a person is young, beautiful and loved,
        find out if they contradict Mary's belief.
        
        A person contradicts Mary's belief
        if one of the following statements is true:
        
        they are young and beautiful but
        not loved;
        they are loved but not young or not beautiful.
        
        Example
        
        For young =
        true, beautiful = true, and loved = true, the output should be
        willYou(young,
        beautiful, loved) = false.
        
        Young and beautiful people are loved according to
        Mary's belief.
        
        For young = true, beautiful = false, and loved = true, the
        output should be
        willYou(young, beautiful, loved) = true.
        
        Mary doesn't believe
        that not beautiful people can be loved.
        
        Input/Output
        
        [execution time limit] 3
        seconds (cs)
        
        [input] boolean young
        
        [input] boolean beautiful
        
        [input] boolean
        loved
        
        [output] boolean
        
        true if the person contradicts Mary's belief, false
        otherwise.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.AtTheCrossroads
{
    class willYouClass
    {
        bool willYou(bool young, bool beautiful, bool loved) {
            return (young && beautiful) != loved;
        }
    }
}
