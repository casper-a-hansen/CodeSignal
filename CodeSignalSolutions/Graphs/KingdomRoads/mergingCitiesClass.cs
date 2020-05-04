/*
    Status:   Solved
    Imported: 2020-05-04 22:59
    By:       Casper
    Url:      https://app.codesignal.com/arcade/graphs-arcade/kingdom-roads/YRPT3woWzSnYmBudH

    Description:
        Once upon a time, in a kingdom far, far away, there lived a King Byteasar VIII.
        The king went down in history as a great warrior, since he managed to defeat a
        longtime enemy that had been capturing the kingdom's cities for more than a
        century. When the war was over, most of the cities were almost completely
        destroyed, so Byteasar decided to create new cities by merging them.
        The king decided to merge each pair of cities cityi, cityi+1 for i = 0, 2, 4,
        ... if they were connected by one of the two-way roads running through the
        kingdom.
        Initially, all information about the roads was stored in the roadRegister. Your
        task is to return the roadRegister after the merging is performed, assuming that
        after merging the cities re-indexation is done in such way that any city formed
        from cities a and b (where a < b) receives index a, and all the cities with
        numbers i (where i > b) get numbers i - 1.
        Example
        For
        roadRegister = [
        [false, true,  true,  false, false, false, true ],
        [true,  false, true,  false, true,  false, false],
        [true,  true,  false, true,  false, false, true ],
        [false, false, true,  false, false, true,  true ],
        [false, true,  false, false, false, false, false],
        [false, false, false, true,  false, false, false],
        [true,  false, true,  true,  false, false, false]
        the output should be
        mergingCities(roadRegister) = [
        [false, true,  true,  false, true ],
        [true,  false, false, true,  true ],
        [true,  false, false, false, false],
        [false, true,  false, false, false],
        [true,  true,  false, false, false]
        Here's how the cities were merged:
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] array.array.boolean roadRegister
        Since cartography was not properly developed in the kingdom, the registers were
        used instead. A register is stored as a square matrix, with its size equal to
        the number of cities in the kingdom. If roadRegister[i][j] = true, then there is
        a road between the ith and the jth cities; the road doesn't exist otherwise.
        It is guaranteed that there are no looping roads, i.e. roads that lead back to
        the same city it originated from.
        Guaranteed constraints:
        1 ≤ roadRegister.length ≤ 100,
        roadRegister[0].length = roadRegister.length,
        roadRegister[i][j] = roadRegister[j][i], i ≠ j,
        roadRegister[i][i] = false.
        [output] array.array.boolean
        The roadRegister after all the cities are merged.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Graphs.KingdomRoads
{
    class mergingCitiesClass
    {
        bool[][] mergingCities(bool[][] roadRegister)
        {
            var merge = Enumerable.Range(0, roadRegister.Length / 2)
                .Select(n => n * 2)
                .Where(n => roadRegister[n][n+1])
                .ToHashSet();
            if (merge.Count == 0) return roadRegister;
            var newCities = Enumerable.Range(0, roadRegister.Length)
                .Where(n => !merge.Contains(n - 1))
                .Select(n => merge.Contains(n) ? new []{n, n + 1} : new[]{n})
                .ToArray();
            var result = Enumerable.Range(0, roadRegister.Length - merge.Count)
                .Select(_ => new bool[roadRegister.Length - merge.Count])
                .ToArray();
            for(var f = 0; f < newCities.Length; f++)
            {
                var from = newCities[f];
                for(var t = 0; t < newCities.Length; t++)
                {
                    var to = newCities[t];
                    var road = false;
                    if (f != t)
                    {
                        road = from.SelectMany(_ => to, (r, c) => roadRegister[r][c] ? 1 : 0).Sum() > 0;
                    }
                    result[f][t] = road;
                }
            }
            return result;
        }
    }
}
