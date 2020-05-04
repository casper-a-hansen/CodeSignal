/*
    Status:   Solved
    Imported: 2020-05-04 22:58
    By:       Casper
    Url:      https://app.codesignal.com/arcade/graphs-arcade/kingdom-roads/5Emk5PFgFBWR4YiCo

    Description:
        Once upon a time, in a kingdom far, far away, there lived a King Byteasar VI. As
        any king with such a magnificent name, he was destined to leave a trace in
        history. Unfortunately, imagination wasn't one of Byteasar's strong suits, so
        the reform he came up with was quite simple: he ordered that all his kingdom's
        cities should be renamed. He didn't want to come up with new names (as a king,
        he'd have to remember them all!), so he ordered the cities to swap their names
        in such a manner that the ith city would have the name of the city number (i +
        1)th. The last city in the Byteasar's kingdom would, naturally, get the name of
        the very first city.
        The cartographers were not happy with this reform, since they had to redraw all
        the kingdom's maps. Before the reform, information about all the roads between
        the cities were stored in the roadRegister. Prior to redrawing any map, they had
        to start with updating the register. Your task is to find out the state of the
        updated register.
        Example
        For
        roadRegister = [[false, true,  true,  false],
        [true,  false, true,  false],
        [true,  true,  false, true ],
        [false, false, true,  false]]
        the output should be
        greatRenaming(roadRegister) = [[false, false, false, true ],
        [false, false, true,  true ],
        [false, true,  false, true ],
        [true,  true,  true,  false]]
        Here's how the catalog can be represented before and after the Great Renaming
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] array.array.boolean roadRegister
        Since cartography has not yet been properly developed in the kingdom, the
        registers are used instead. A register is stored as a square matrix, with its
        size equal to the number of cities in the kingdom. If roadRegister[i][j] = true,
        then there is a road between the ith and the jth cities; the road doesn't exist
        otherwise.
        It is guaranteed that there are no looping roads, i.e. roads that lead back to
        the same city it originated from.
        Guaranteed constraints:
        2 ≤ roadRegister.length ≤ 100,
        roadRegister[0].length = roadRegister.length,
        roadRegister[i][j] = roadRegister[j][i], i ≠ j,
        roadRegister[i][i] = false.
        [output] array.array.boolean
        roadRegister after the Great Renaming.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Graphs.KingdomRoads
{
    class greatRenamingClass
    {
        bool[][] greatRenaming(bool[][] roadRegister) {
            var result = Enumerable.Range(0, roadRegister.Length).Select(_ => new bool[roadRegister.Length]).ToArray();
            for(var to = 0; to < roadRegister.Length; to++)
            {
                for(var from = 0; from < roadRegister.Length; from++)
                {
                    result[to][from] = roadRegister[to == 0 ? roadRegister.Length - 1 : to - 1][from == 0 ? roadRegister.Length - 1 : from - 1];
                }
            }
            return result;
        }
    }
}
