/*
    Status:   Solved
    Imported: 2020-05-02 12:09
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/at-the-crossroads/7jaup9HprdJno2diw

    Description:
        In tennis, the winner of a set is based on how many games each player wins. The
        first player to win 6 games is declared the winner unless their opponent had
        already won 5 games, in which case the set continues until one of the players
        has won 7 games.
        Given two integers score1 and score2, your task is to determine if it is
        possible for a tennis set to be finished with a final score of score1 : score2.
        Example
        For score1 = 3 and score2 = 6, the output should be
        tennisSet(score1, score2) = true.
        Since player 1 hadn't reached 5 wins, the set ends once player 2 has won 6
        games.
        For score1 = 8 and score2 = 5, the output should be
        tennisSet(score1, score2) = false.
        Since both players won at least 5 games, the set would've ended once one of them
        won the 7th one.
        For score1 = 6 and score2 = 5, the output should be
        tennisSet(score1, score2) = false.
        This set will continue until one of these players wins their 7th game, so this
        can't be the final score.
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] integer score1
        Number of games won by the 1st player, non-negative integer.
        Guaranteed constraints:
        0 ≤ score1 ≤ 10.
        [input] integer score2
        Number of games won by the 2nd player, non-negative integer.
        Guaranteed constraints:
        0 ≤ score2 ≤ 10.
        [output] boolean
        true if score1 : score2 represents a possible score for an ended set, false
        otherwise.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.AtTheCrossroads
{
    class tennisSetClass
    {
        bool tennisSet(int score1, int score2) {
            if (score1 == score2) {
                Console.WriteLine("a");
                return false;
            }
            var winner = Math.Max(score1, score2);
            var looser = Math.Min(score1, score2);
            if (winner == 6 && looser < 5) {
                Console.WriteLine("b");
                return true;
            } else if (winner == 7 && looser >= 5) {
                Console.WriteLine("d");
                return true;
            } else {
                Console.WriteLine("f");
                return false;
            }
        }
    }
}
