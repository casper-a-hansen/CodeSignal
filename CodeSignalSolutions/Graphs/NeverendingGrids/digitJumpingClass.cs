/*
    Status:   Solved
    Imported: 2020-05-29 07:39
    By:       Casper
    Url:      https://app.codesignal.com/arcade/graphs-arcade/neverending-grids/HY68Gv9BWPLefQ7CT

    Description:
        Little Ratiorg was tired of being bullied by other bots and mighty CodeFighters,
        so he joined the Ninja Bots Training camp. Any bot that manages to solve all the
        challenges becomes an ultimate master of algorithms, and that is exactly what
        Ratiorg wants.
        Facing his first challenge, Ratiorg is placed at the start position of a
        rectangular grid filled with digits from 0 to 9. With each move, Ratiorg can
        either jump to the adjacent cell (the one above, below, to the left or to the
        right of his current position), or teleport to any cell that has number x
        written on it, where x is the number written on the cell Ratiorg is currently
        standing on. Ratiorg will be able to move on to the next challenge if he manages
        to get to the finish cell in the minimum possible number of moves.
        Although the little bot is sure that he can handle the challenge, you don't want
        to leave him alone! Back Ratiorg up by implementing a function that given the
        grid, start and finish, will calculate the minimum number of moves required to
        get from start to finish.
        Example
        For
        grid = [[0, 1, 4, 2, 3],
        [1, 4, 2, 8, 2],
        [2, 2, 3, 4, 9],
        [8, 7, 2, 2, 3]]
        start = [0, 0], and finish = [3, 4], the output should be
        digitJumping(grid, start, finish) = 4.
        Here's one of the shortest paths Ratiorg can take:
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] array.array.integer grid
        A rectangular grid filled with digits in range [0...9].
        Guaranteed constraints:
        1 ≤ grid.length ≤ 300,
        1 ≤ grid[0].length ≤ 300,
        0 ≤ grid[i][j] ≤ 9.
        [input] array.integer start
        Ratiorg's initial position as an array of two elements, where the first element
        is row index, and the second one is column index.
        Guaranteed constraints:
        start.length = 2,
        0 ≤ start[0] < grid.length,
        0 ≤ start[1] < grid[0].length.
        [input] array.integer finish
        Ratioarg's destination in the same format as start.
        Guaranteed constraints:
        finish.length = 2,
        0 ≤ finish[0] < grid.length,
        0 ≤ finish[1] < grid[0].length.
        [output] integer
        The minimum number of moves required to get from start to finish.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Graphs.NeverendingGrids
{
    class digitJumpingClass
    {
        int digitJumping(int[][] grid, int[] start, int[] finish)
        {
            Dictionary<int, (int distance, int row, int column)> startDic = new Dictionary<int, (int distance, int row, int column)>();
            startDic.Add(grid[start[0]][start[1]], (0, start[0], start[1]));
            Dictionary<int, (int distance, int row, int column)> finishDic = new Dictionary<int, (int distance, int row, int column)>();
            finishDic.Add(grid[finish[0]][finish[1]], (0, finish[0], finish[1]));
            for (var radius = 1; radius <= 10; radius++)
            {
                Surroundings(grid, start[0], start[1], radius, startDic);
                Surroundings(grid, finish[0], finish[1], radius, finishDic);
                var routes = startDic
                    .Where(t => finishDic.ContainsKey(t.Key))
                    .Select(t => (start: t.Value, finish: finishDic[t.Key]))
                    .Select(t => t.start.distance + t.finish.distance +
                        (t.start.row == t.finish.row && t.start.column == t.finish.column ? 0 : 1))
                    .ToArray();
                if (routes.Length > 0) return routes.Min();
            }
            return int.MaxValue;
        }
        readonly (int rowOffset, int columnOffset)[] adjacents = new (int rowOffset, int columnOffset)[]
        {
            (1, 0), (-1, 0), (0, 1), (0, -1)
        };
        private void Surroundings(int [][] grid, int rowStart, int columnStart, int radius,
            Dictionary<int, (int distance, int row, int column)> values)
        {
            var height = grid.Length;
            var width = grid[0].Length;
            void Update(int rowOffset, int columnOffset)
            {
                var row = rowStart + rowOffset;
                var column = columnStart + columnOffset;
                if (row >= 0 && column >= 0 && row < height && column < width)
                {
                    var value = grid[row][column];
                    if (!values.TryGetValue(value, out var info))
                        values.Add(value, (distance: radius, row, column));
                }
            }
            // The number is the radius value (it is also the distance
            //     2
            //     1
            // 2 1 - 1 2
            //     1
            //     2
            foreach(var adjacent in adjacents)
                Update(adjacent.rowOffset * radius, adjacent.columnOffset * radius);
            // 4 3 -   4
            //   2 - 2 3
            // - - - - -
            // 3 2 - 2
            // 4   - 3 4
            for(var r = 1; r < radius; r++)
            {
                var ra = radius - r;
                foreach (var adjacent in adjacents)
                    Update(adjacent.rowOffset * ra + adjacent.columnOffset * r,
                            adjacent.columnOffset * ra - adjacent.rowOffset * r);
            }
            // - - - 3 -
            // 3 - - - -
            // - - - - -
            // - - - - 3
            // - 3 - - -
            for (var r = 1; r < radius - 1; r++)
            {
                var ra = radius - r;
                foreach (var adjacent in adjacents)
                    Update(adjacent.rowOffset * ra - adjacent.columnOffset * r,
                            adjacent.columnOffset * ra + adjacent.rowOffset * r);
            }
        }
    }
}
