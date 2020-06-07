/*
    Status:   Solved
    Imported: 2020-06-05 07:22
    By:       Casper
    Url:      https://app.codesignal.com/arcade/graphs-arcade/neverending-grids/hvJfAuqSX3HDjDZ6P

    Description:
        Little Ratiorg was tired of being bullied by other bots and mighty CodeFighters,
        so he joined the Ninja Bots Training camp. Any bot that manages to solve all the
        challenges becomes an ultimate master of algorithms, and that is exactly what
        Ratiorg wants.
        It's been several weeks, and Ratiorg is starting to boast about his newly
        obtained skills, which infuriates one of his fellow trainees. The angry bot
        decided to challenge Ratiorg to a Mobius Conquer battle to find out who's the
        strongest once and for all.
        In the Mobius Conquer battle the players fight for positions on a Möbius strip,
        created from a rectangular field by giving it a half-twist, and then joining the
        ends of the strip along its height to form a loop. Both sides of the field are
        divided into cells, some of which are marked as impassable (note that player
        positions are not considered impassable). A player is said to control a cell if
        the cell is closer to him in terms of shortest paths on the strip.
        The Mobius Conquer battle is almost over: ratiorg and his enemy have both
        reached their final positions. The only thing to do now is to determine the
        winner. Given the coordinates of both players, coordinates of the
        impassableCells and the size of the field, calculate the number of cells
        controlled by each player.
        Example
        For field = [4, 3], ratiorg = [0, 0, 0], enemy = [1, 3, 2], and
        impassableCells = [[0, 0, 1], [0, 1, 1], [0, 2, 1], [0, 2, 2],
        [1, 1, 0], [1, 2, 1], [1, 3, 0]]
        the output should be
        mobiusConquer(field, ratiorg, enemy, impassableCells) = [7, 6].
        Here's what each side of the field looks like:
        And here's what the Möbius strip obtained from it looks like:
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] array.integer field
        Array of two integers, the size of the field. The first element is its height,
        and the second one is its width.
        Guaranteed constraints:
        field.length = 2,
        1 ≤ field[i] ≤ 100.
        [input] array.integer ratiorg
        Ratiorg's position as an array of three integers. The first integer defines the
        side of the field (either 0 or 1), the second one defines the row, and the last
        one defines the column (both 0-based).
        Note, that the row and the column of the second side of the field is defined
        assuming that the first side of the field was flipped vertically.
        Guaranteed constraints:
        ratiorg.length = 3,
        0 ≤ ratiorg[0] ≤ 1,
        0 ≤ ratiorg[1] < field[0],
        0 ≤ ratiorg[2] < field[1].
        [input] array.integer enemy
        The enemy's position in the same format as ratiorg. It is guaranteed that
        ratiorg ≠ enemy.
        Guaranteed constraints:
        enemy.length = 3,
        0 ≤ enemy[0] ≤ 1,
        0 ≤ enemy[1] < field[0],
        0 ≤ enemy[2] < field[1].
        [input] array.array.integer impassableCells
        Array of impassable cells, where each cell is given in the same format as
        ratiorg and enemy. It is guaranteed that all impassable cells are unique, and
        that no impassable cell coincides with ratiorg or enemy.
        Guaranteed constraints:
        0 ≤ impassableCells.length < 2 · field[0] · field[1],
        impassableCells[i].length = 3,
        0 ≤ impassableCells[i][0] ≤ 1,
        0 ≤ impassableCells[i][1] < field[0],
        0 ≤ impassableCells[i][2] < field[1].
        [output] array.integer
        Array of two integers, where the first integer is the number of cells controlled
        by Ratiorg, and the second is the number of cells controlled by his enemy.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Graphs.NeverendingGrids
{
    class mobiusConquerClass
    {
        enum Cell { Empty, Blocked, Both, Ratiorg = 0x20000000, Enemy = 0x30000000, Which = 0x10000000, Distance = 0x0FFFFFFF };
        int[] mobiusConquer(int[] field, int[] ratiorg, int[] enemy, int[][] impassableCells) {
            // Setting up board.
            var board = Enumerable.Range(0, 2)
                .Select(_ => Enumerable.Range(0, field[0])
                    .Select(_ => new Cell[field[1]])
                    .ToArray())
                .ToArray();
            foreach(var cell in impassableCells)
                board[cell[0]][cell[1]][cell[2]] = Cell.Blocked;
            var result = new int[2];
            var queue = new Queue<(int side, int y, int x, Cell cell)>();
            queue.Enqueue((ratiorg[0], ratiorg[1], ratiorg[2], Cell.Ratiorg));
            queue.Enqueue((enemy[0], enemy[1], enemy[2], Cell.Enemy));
            while(queue.Count > 0)
            {
                var p = queue.Dequeue();
                var c = board[p.side][p.y][p.x];
                if (c == Cell.Blocked)
                    continue;
                else if (c == Cell.Empty)
                {
                    board[p.side][p.y][p.x] = p.cell;
                    result[(int)(p.cell & Cell.Which) >> 28]++;
                }
                else if (c == Cell.Both)
                    continue;
                else if ((c & Cell.Ratiorg) == Cell.Ratiorg)  // Either Ratiorg or Enemy!
                {
                    if ((p.cell & Cell.Which) != (c & Cell.Which))
                    {
                        // Cell is captured by the other player.
                        if ((p.cell & Cell.Distance) == (c & Cell.Distance))
                        {
                            // Cell is not captured by any of the players.
                            board[p.side][p.y][p.x] = Cell.Both;
                            result[((int)(c & Cell.Which) >> 28)]--;  // Decrease other players count.
                        }
                        else if ((p.cell & Cell.Distance) > (c & Cell.Distance))
                            continue;
                        else
                        {
                            // Capture cell.  (Actually doubt that this is possible
                            result[1 - ((int)(c & Cell.Which) >> 28)]++;  // Decrease other players count.
                            board[p.side][p.y][p.x] = p.cell;
                            result[(int)(c & Cell.Which) >> 28]++;
                        }
                    }
                    else
                        continue;  // Found its own cell
                }
                // Continue to next cell.
                var cell = p.cell + 1;
                if (p.y > 0) queue.Enqueue((p.side, p.y - 1, p.x, cell));
                if (p.y < field[0] - 1) queue.Enqueue((p.side, p.y + 1, p.x, cell));
                var side = p.side;
                var x = p.x + 1;
                var y = p.y;
                if (x >= field[1])
                {
                    x = 0;
                    side = 1 - side;
                }
                queue.Enqueue((side, y, x, cell));
                side = p.side;
                x = p.x - 1;
                if (x < 0)
                {
                    x = field[1] - 1;
                    side = 1 - side;
                }
                queue.Enqueue((side, y, x, cell));
            }
        //            Show(board, result);
            return result;
        }
        void Show(Cell[][][] board, int[] result)
        {
            string Display(Cell cell)
            {
                if (cell == Cell.Both) return "Both";
                if (cell == Cell.Blocked) return "Blck";
                if (cell == Cell.Empty) return " -- ";
                if ((cell & Cell.Ratiorg) == Cell.Ratiorg)
                {
                    var owner = new string[] { "Ra", "En" }[(int)(cell & Cell.Which) >> 28];
                    var distance = (int)(cell & Cell.Distance);
                    return $"{owner}{distance:D2}";
                }
                return "Unkn";
            }
            for(var s = 0; s < board.Length; s++)
            {
                Console.WriteLine($"Side: {s}");
                var side = board[s];
                foreach(var row in side)
                {
                    foreach(var cell in row)
                    {
                        Console.Write(Display(cell));
                        Console.Write(' ');
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine($"Ratiorg:{result[0]}  Enemy:{result[1]}");
        }
    }
}
