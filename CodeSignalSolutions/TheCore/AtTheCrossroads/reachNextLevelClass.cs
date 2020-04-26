/*
    Status:   Solved
    Imported: 2020-04-26 13:16
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/at-the-crossroads/m9wjpkCjgofg7gs8N

    Description:
        You are playing an RPG game. Currently your experience points (XP) total is
        equal to experience. To reach the next level your XP should be at least at
        threshold. If you kill the monster in front of you, you will gain more
        experience points in the amount of the reward.
        
        Given values experience,
        threshold and reward, check if you reach the next level after killing the
        monster.
        
        Example
        
        For experience = 10, threshold = 15, and reward = 5, the
        output should be
        reachNextLevel(experience, threshold, reward) = true;
        For
        experience = 10, threshold = 15, and reward = 4, the output should be
        reachNextLevel(experience, threshold, reward) = false.
        
        Input/Output
        
        [execution
        time limit] 3 seconds (cs)
        
        [input] integer experience
        
        Guaranteed constraints:
        3 ≤ experience ≤ 250.
        
        [input] integer threshold
        
        Guaranteed constraints:
        5 ≤
        threshold ≤ 300.
        
        [input] integer reward
        
        Guaranteed constraints:
        2 ≤ reward ≤
        65.
        
        [output] boolean
        
        true if you reach the next level, false otherwise.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.AtTheCrossroads
{
    class reachNextLevelClass
    {
        bool reachNextLevel(int experience, int threshold, int reward) {
            return experience + reward >= threshold;
        }
    }
}
