/*
    Status:   Solved
    Imported: 2020-04-26 13:29
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/list-backwoods/fmYdsYcGfaTu4yTQt

    Description:
        You are watching a volleyball tournament, but you missed the beginning of the
        very first game of your favorite team. Now you're curious about how the coach
        arranged the players on the field at the start of the game.
        
        The team you favor
        plays in the following formation:
        
        0 3 0
        4 0 2
        0 6 0
        5 0 1
        
        
        where positive
        numbers represent positions occupied by players. After the team gains the serve,
        its members rotate one position in a clockwise direction, so the player in
        position 2 moves to position 1, the player in position 3 moves to position 2,
        and so on, with the player in position 1 moving to position 6.
        
        Here's how the
        players change their positions:
        
        Given the current formation of the team and the
        number of times k it gained the serve, find the initial position of each player
        in it.
        
        Example
        
        For
        
        formation = [["empty",   "Player5", "empty"],
        ["Player4", "empty",   "Player2"],
                     ["empty",   "Player3", "empty"],
        ["Player6", "empty",   "Player1"]]
        
        
        and k = 2, the output should be
        volleyballPositions(formation, k) = [
            ["empty",   "Player1", "empty"],
        ["Player2", "empty",   "Player3"],
            ["empty",   "Player4", "empty"],
        ["Player5", "empty",   "Player6"]
        ]
        
        
        For
        
        formation = [["empty", "Alice",
        "empty"],
                     ["Bob",   "empty", "Charlie"],
                     ["empty",
        "Dave",  "empty"],
                     ["Eve",   "empty", "Frank"]]
        
        
        and k = 6, the
        output should be
        
        volleyballPositions(formation, k) = [
            ["empty", "Alice",
        "empty"],
            ["Bob",   "empty", "Charlie"],
            ["empty", "Dave",  "empty"],
        ["Eve",   "empty", "Frank"]
        ]
        
        
        Input/Output
        
        [execution time limit] 3 seconds
        (cs)
        
        [input] array.array.string formation
        
        Array of strings representing names
        of the players in the positions corresponding to those in the schema above.
        It
        is guaranteed that for each empty position the corresponding element of
        formation is "empty".
        It is also guaranteed that there is no player called
        "empty" in the team.
        
        Guaranteed constraints:
        formation.length = 4,
        formation[i].length = 3.
        
        [input] integer k
        
        The number of times the team gained
        the serve.
        
        Guaranteed constraints:
        0 ≤ k ≤ 109.
        
        [output] array.array.string
        Team arrangement at the start of the game.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.ListBackwoods
{
    class volleyballPositionsClass
    {
        string[][] volleyballPositions(string[][] formation, int k) {
            var order = new (int X, int Y)[]{
                (X: 2, Y: 3),
                (X: 1, Y: 2),
                (X: 0, Y: 3),
                (X: 0, Y: 1),
                (X: 1, Y: 0),
                (X: 2, Y: 1)
            };
         
            string Player(int player) {
                return formation[order[player].Y][order[player].X];
            }
            void SetPlayer(int player, string name) {
                formation[order[player].Y][order[player].X] = name;
            }
            var max = k % order.Length;
            for(var ik = 0; ik < max; ik++) {
                var tmp = Player(0);
                for(var p = 0; p < order.Length - 1; p++) {
                    SetPlayer(p, Player(p + 1));
                }
                SetPlayer(order.Length - 1, tmp);
            }
            return formation;
        }
    }
}
