/*
    Status:   Solved
    Imported: 2020-06-07 10:18
    By:       Casper
    Url:      https://app.codesignal.com/arcade/graphs-arcade/neverending-grids/sPEWN2g9LDk87RYpm

    Description:
        Little Ratiorg was so tired of being bullied by other bots and mighty
        CodeFighters that he decided to join the Ninja Bots Training camp. It is known
        that any bot that manages to solve all the challenges becomes an ultimate master
        of algorithms, and that is exactly what Ratiorg is aiming at.
        His training is now officially over, and Ratiorg is ready to get back to
        CodeSignal and show who's the boss. To make his appearance more imposing,
        Ratiorg is planning to take a tank and drive it back home. However, the bot will
        have to travel through the forest covered in trees so strong that they can hold
        back even a tank, so not every tank can make it through this forest.
        Since Ratiorg finished the trainings as the best student, he can pick any tank
        he likes. There are a lot of tanks of all possible sizes. All available tanks
        are square, can only move in one of the four directions (leftwards, rightwards,
        downwards or upwards), and can't move over the trees.
        The Ninja Bots Training camp is located at the top left corner of the forest,
        and CodeFigts bots camp is located at its bottom right corner. Given the map of
        the forest, find the maximum size of the tank Ratiorg can take in order to get
        from the training camp to the CodeFigths bot camp.
        Example
        For
        forest =  [[true, true, true,  true],
        [true, true, false, true],
        [true, true, true,  true],
        [true, true, true,  true]]
        the output should be
        tankbot(forest) = 2.
        For
        forest = [[false, true, true],
        [true,  true, true]]
        the output should be
        tankbot(forest) = 0.
        There is a tree right at the entrance of the Training Camp, so there's no way to
        get out of there by tank.
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] array.array.boolean forest
        A rectangular matrix of booleans which represents grid of the forest. true
        represents a free cell, and false represents a cell with a tree on it.
        Guaranteed constraints:
        2 ≤ forest.length ≤ 120,
        2 ≤ forest[0].length ≤ 120.
        [output] integer
        The maximum length of the tank Ratiorg can take. If there is no way to get home
        by tank, return 0 instead.
        O(log(min(forest.length, forest[0].length)) · forest.length · forest[0].length ·
        min(forest.length, forest[0].length)2)
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Graphs.NeverendingGrids
{
    class tankbotClass
    {
        int tankbot(bool[][] forest) {
            for(var result = Math.Min(forest.Length,  forest[0].Length); result >= 1; result--)
            {
                if(MakePath(forest, result)) return result;
            }
            return 0;
        }
        (int y, int x)[] directions = new (int y, int x)[]{(1,0),(-1,0),(0,1),(0,-1)};
        bool MakePath(bool[][] forest, int tankSize)
        {
            Console.WriteLine($"Tank size {tankSize}");
            var height = forest.Length - tankSize;
            var width = forest[0].Length - tankSize;
            var used = forest.Select(a=> new bool[a.Length]).ToArray();
            // Whenever there is a tree we mark the surroundings as used e.g:
            // When tank size is 2 and forest is 4 x 4
            // . U U V
            // . U T V
            // . . . V
            // V V V V
            // T = Tree, V = void, U = used.
            for(var y = 0; y < forest.Length; y++)
            {
                for(var x = 0; x < forest[0].Length; x++)
                {
                    if (!forest[y][x])
                    {
                        for(var t = Math.Max(0, y - tankSize + 1); t <= y; t++)
                        {
                            for(var l = Math.Max(0, x - tankSize + 1); l <= x; l++)
                            {
                                used[t][l] = true;
                            }
                        }
                    }
                }
            }
            //Show(forest, used);
            var queue = new Queue<(int x, int y)>();
            queue.Enqueue((0, 0));
            while(queue.Count > 0)
            {
                var p = queue.Dequeue();
                if (used[p.y][p.x]) continue;
                used[p.y][p.x] = true;
                if (p.y == height && p.x == width) return true;
                // Try all directions from here.
                foreach(var direction in directions)
                {
                    var x = p.x + direction.x;
                    var y = p.y + direction.y;
                    if (x < 0 || x > width || y < 0 || y > height) continue;
                    if (used[y][x]) continue;
                    queue.Enqueue((x, y));
                }
            }
            return false;
        }
        void Show(bool[][] forest, bool[][] used)
        {
            for(var y = 0; y < forest.Length; y++)
            {
                for(var x = 0; x < forest[0].Length; x++)
                {
                    Console.Write((forest[y][x], used[y][x]) switch {
                        (true, false) => '.',
                        (true, true) => 'U',
                        (false, false) => 't',
                        (false, true) => 'T'
                    });
                }
                Console.WriteLine();
            }
        }
    }
}
