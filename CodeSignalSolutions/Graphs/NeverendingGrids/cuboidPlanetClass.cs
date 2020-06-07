/*
    Status:   Solved
    Imported: 2020-06-06 16:54
    By:       Casper
    Url:      https://app.codesignal.com/arcade/graphs-arcade/neverending-grids/kpp94L9QXMdaHrQ5X

    Description:
        Little Ratiorg was so tired of being bullied by other bots and mighty
        CodeFighters that he decided to join the Ninja Bots Training camp. It is known
        that any bot that manages to solve all the challenges becomes an ultimate master
        of algorithms, and that is exactly what Ratiorg is aiming at.
        Ratiorg has become so cool that the authorities decided to send him on a special
        mission to the remote cuboid planet of size a × b × c, not yet inhabited by
        bots. In order to prepare for the mission, Ratiorg has to understand the
        properties of the planet by training on its net here, on Earth. Here's how the
        planet and the net on which the bot is going to prepare for the mission look
        like:
        The net is divided into 6 areas, with each area representing one of the planet's
        surfaces. Each of the areas is divided into a grid with cells of size 1 × 1,
        with some of the cells being impassable. The coordinates of each cell can be
        represented in the format (area, row, column), where area stands for the area
        number shown in the net image above, and (row, column) stands for 0-based cell's
        position in this area. It is possible to move between two cells if they share a
        common side.
        Ratiorg would like understand how close the net he's going to train on is to the
        conditions of the planet. In order to do this, he would like to calculate the
        difference between the numbers of pairs of cells that are reachable from one
        another on a cuboid and the number of pairs of cells that are reachable from one
        another on a net (note that only pairs of different cells should be counted, and
        the order of cells in a pair doesn't matter, i.e. (a, b) is the same pair as (b,
        a)).
        Given the dimensions of the cuboid and the impassableCells, calculate the value
        Ratiorg is interested in.
        Example
        For cuboid = [1, 2, 3] and
        impassableCells = [[1, 0, 0], [3, 0, 1], [3, 2, 0], [4, 0, 1], [5, 1, 0]],
        the output should be
        cuboidPlanet(cuboid, impassableCells) = 106.
        On a cuboid, all cells but the impassable ones are reachable from one another,
        so the total number of reachable pairs equals 17 * 16 / 2 = 136.
        Here's how the net of this cuboid looks like:
        There are four areas in which all cells are connected. Thus, the number of pairs
        of cells that are reachable from one another is
        3 * 2 / 2 + 4 * 3 / 2 + 4 * 3 / 2 + 6 * 5 / 2 = 30.
        Thus, the answer is 136 - 30 = 106.
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] array.integer cuboid
        Array of three elements, the size of the cuboid in the format [a, b, c].
        Guaranteed constraints:
        cuboid.length = 3,
        1 ≤ cuboid[i] ≤ 50.
        [input] array.array.integer impassableCells
        Array of impassable cells, where each cell is given as an array of three
        elements in the format described above.
        It is guaranteed that no cell is given twice, and that each cell is valid (i.e.
        its coordinates belong to one of the cells of the grid).
        Guaranteed constraints:
        0 ≤ impassableCells.length ≤ 2 · (ab + ac + bc),
        impassableCells[i].length = 3.
        [output] integer
        The difference between the pairs of cells reachable from one another on the
        cuboid and on the net.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Graphs.NeverendingGrids
{
    class cuboidPlanetClass
    {
        (int h, int w)[] surfaces = new (int h, int w)[] { (0, 2), (0, 1), (0, 2), (2, 1), (0, 1), (2, 1) };
        // It is index 0 = Up, index 1 = down, index 2 = left, 3 = right
        (int y, int x)[] moves = new (int y, int x)[] { (-1, 0), (1, 0), (0, -1), (0, 1) };
        enum Change { Same, Inverted, Zero, Max, OtherSame, OtherInverted};
        struct Connection
        {
            public Connection(int destinationSurface, Change row = Change.Zero, Change column = Change.Zero)
            {
                DestinationSurface = destinationSurface;
                Row = row;
                Column = column;
            }
            public int DestinationSurface { get; private set; }
            public Change Row { get; private set; }
            public Change Column { get; private set; }
            public override string ToString()
            {
                return $"{DestinationSurface}, {Row}, {Column}";
            }
        }
        struct Pos
        {
            public Pos(int surface, int row, int column)
            {
                Surface = surface;
                Row = row;
                Column = column;
            }
            public int Surface { get; private set; }
            public int Row { get; private set; }
            public int Column { get; private set; }
            public void Set(bool[][][] board, bool value = true)
            {
                if (Surface == -1) return;
                if (Surface < 0 || Surface >= board.Length) return;
                if (Row < 0 || Row >= board[Surface].Length) return;
                if (Column < 0 || Column >= board[Surface][0].Length) return;
                board[Surface][Row][Column] = value;
            }
            public bool Get(bool[][][] board)
            {
                if (Surface == -1) return true;
                return board[Surface][Row][Column];
            }
            public override string ToString()
            {
                return $"({Surface}, {Row}, {Column})";
            }
        }
        static Connection[][] cuboidConnections = new Connection[][] {
            new Connection[] { // Surface 0 moving:
                new Connection(5, Change.OtherSame, Change.Zero),      // Up
                new Connection(3, Change.OtherInverted, Change.Zero),  // Down
                new Connection(4, Change.Inverted, Change.Zero),           // Left
                new Connection(1, Change.Same, Change.Zero) },         // Right
            new Connection[] { // Surface 1 moving:
                new Connection(5, Change.Max, Change.Same),            // Up
                new Connection(3, Change.Zero, Change.Same),           // Down
                new Connection(0, Change.Same, Change.Max),            // Left
                new Connection(2, Change.Same, Change.Zero) },         // Right
            new Connection[] { // Surface 2 moving:
                new Connection(5, Change.OtherInverted, Change.Max),   // Up
                new Connection(3, Change.OtherSame, Change.Max),       // Down
                new Connection(1, Change.Same, Change.Max),            // Left
                new Connection(4, Change.Inverted, Change.Max) },          // Right
            new Connection[] { // Surface 3 moving:
                new Connection(1, Change.Max, Change.Same),            // Up
                new Connection(4, Change.Zero, Change.Same),           // Down
                new Connection(0, Change.Max, Change.OtherInverted),   // Left
                new Connection(2, Change.Max, Change.OtherSame) },     // Right
            new Connection[] { // Surface 4 moving:
                new Connection(3, Change.Max, Change.Same),            // Up
                new Connection(5, Change.Zero, Change.Same),           // Down
                new Connection(0, Change.Inverted, Change.Zero),       // Left
                new Connection(2, Change.Inverted, Change.Max) },      // Right
            new Connection[] { // Surface 5 moving:
                new Connection(4, Change.Max, Change.Same),            // Up
                new Connection(1, Change.Zero, Change.Same),           // Down
                new Connection(0, Change.Zero, Change.OtherSame),      // Left
                new Connection(2, Change.Zero, Change.OtherInverted) },// Right
        };
        static Connection[][] simulatorConnections = new Connection[][] {
            new Connection[] {  // Side 0 moving:
                new Connection(-1),          // Up (not possible)
                new Connection(-1),          // Down (not possible)
                new Connection(-1),          // Left (not possible)
                new Connection(1, Change.Same, Change.Zero) },         // Right
            new Connection[] { // Side 1 moving:
                new Connection(-1),          // Up (not possible)
                new Connection(3, Change.Zero, Change.Same),           // Down
                new Connection(0, Change.Same, Change.Max),            // Left
                new Connection(2, Change.Same, Change.Zero) },         // Right
            new Connection[] { // Side 2 moving:
                new Connection(-1),          // Up (not possible)
                new Connection(-1),          // Down (not possible)
                new Connection(1, Change.Same, Change.Max),            // Left
                new Connection(-1) },        // Right (not possible)
            new Connection[] { // Side 3 moving:
                new Connection(1, Change.Max, Change.Same),            // Up
                new Connection(4, Change.Zero, Change.Same),           // Down
                new Connection(-1),          // Left (not possible)
                new Connection(-1) },        // Right (not possible)
            new Connection[] { // Side 4 moving:
                new Connection(3, Change.Max, Change.Same),            // Up
                new Connection(5, Change.Zero, Change.Same),           // Down
                new Connection(-1),          // Left (not possible)
                new Connection(-1) },        // Right (not possible)
            new Connection[] { // Side 5 moving:
                new Connection(4, Change.Max, Change.Same),            // Up
                new Connection(-1),          // Down (not possible)
                new Connection(-1),          // Left (not possible)
                new Connection(-1) },        // Right (not possible)
        };
        int cuboidPlanet(int[] cuboid, int[][] impassableCells)
        {
            //TestConnections(cuboid, cuboidConnections);
            //return 0;
            // Find groups of cells that is connected.
            // First as a cube: In test 1 it is one group of 17 cells meaning there are 17 * 16 / 2 = 136 cell pairs.
            // Second as a simulated cube: In test 1 it is groups with 3, 4, 4, and 6 cells meaning there are
            //   3 * 2 / 2 + 4 * 3 / 2 + 4 * 3 / 2 + 6 * 5 / 2 = 30 cell pairs
            // Return the difference between the cube and simulated cube: 136 - 30 = 106
            int cuboidPairs = 0;
            foreach (var cells in ConnectedCells(cuboid, impassableCells, cuboidConnections))
                cuboidPairs += cells <= 1 ? 0 : cells * (cells - 1) / 2;
            int simulartorPairs = 0;
            foreach (var cells in ConnectedCells(cuboid, impassableCells, simulatorConnections))
                simulartorPairs += cells <= 1 ? 0 : cells * (cells - 1) / 2;
            return cuboidPairs - simulartorPairs;
        }
        private void TestConnections(int[] cuboid, Connection[][] connections)
        {
            for (var surface = 0; surface < surfaces.Length; surface++)
            {
                Console.WriteLine($"Surface {surface}");
                var maxRow = cuboid[surfaces[surface].h];
                var maxColumn = cuboid[surfaces[surface].w];
                var board = ConstructBoard(cuboid);
                for (var row = 0; row < maxRow; row += 2)
                {
                    var left = new Pos(surface, row, 0);
                    left.Set(board);
                    left = Move(board, connections, left, 2);
                    left.Set(board);
                    var right = new Pos(surface, row, maxColumn - 1);
                    right.Set(board);
                    right = Move(board, connections, right, 3);
                    right.Set(board);
                }
                for (int column = 0; column < maxColumn; column += 2)
                {
                    var top = new Pos(surface, 0, column);
                    top.Set(board);
                    top = Move(board, connections, top, 0);
                    top.Set(board);
                    var bottom = new Pos(surface, maxRow - 1, column);
                    bottom.Set(board);
                    bottom = Move(board, connections, bottom, 1);
                    bottom.Set(board);
                }
                Show(board);
                Console.WriteLine();
            }
        }
        bool[][][] ConstructBoard(int[] cuboid, int[][] impassableCells = null)
        {
            var board = surfaces.Select(s => Enumerable.Range(0, cuboid[s.h]).Select(_ => new bool[cuboid[s.w]]).ToArray()).ToArray();
            if (impassableCells != null)
            {
                foreach (var impassable in impassableCells)
                {
                    board[impassable[0]][impassable[1]][impassable[2]] = true;
                }
            }
            return board;
        }
        IEnumerable<int> ConnectedCells(int[] cuboid, int[][] impassableCells, Connection[][] connections)
        {
            var board = ConstructBoard(cuboid, impassableCells);
            //Show(board);
            for(var s = 0; s < board.Length; s++)
            {
                var surface = board[s];
                for(var r = 0; r < surface.Length; r++)
                {
                    var row = surface[r];
                    for(var c = 0; c < row.Length; c++)
                    {
                        if (!row[c])
                        {
                            yield return CountCells(board, new Pos(s, r, c), connections);
                        }
                    }
                }
            }
        }
        Pos Move(bool[][][] board, Connection[][] connections, Pos pos, int move)
        {
            Pos result = new Pos(pos.Surface, pos.Row + moves[move].y, pos.Column + moves[move].x);
            if (result.Row < 0 || result.Row >= board[result.Surface].Length || result.Column < 0 || result.Column >= board[result.Surface][0].Length)
            {
                var connection = connections[result.Surface][move];
                result = new Pos(connection.DestinationSurface,
                    connection.Row switch
                    {
                        Change.Same => result.Row,
                        Change.Zero => 0,
                        Change.Max => board[connection.DestinationSurface].Length - 1,
                        Change.Inverted => (board[connection.DestinationSurface].Length - 1) - result.Row,
                        Change.OtherSame => result.Column,
                        Change.OtherInverted => (board[connection.DestinationSurface].Length - 1) - result.Column,
                        _ => -1
                    },
                    connection.Column switch
                    {
                        Change.Same => result.Column,
                        Change.Zero => 0,
                        Change.Max => board[connection.DestinationSurface][0].Length - 1,
                        Change.Inverted => (board[connection.DestinationSurface][0].Length - 1) - result.Column,
                        Change.OtherSame => result.Row,
                        Change.OtherInverted => (board[connection.DestinationSurface][0].Length - 1) - result.Row,
                        _ => -1
                    });
            }
            return result;
        }
        int CountCells(bool[][][] board, Pos start, Connection[][] connections)
        {
            int result = 0;
            var stack = new Stack<Pos>();
            stack.Push(start);
            while(stack.Count > 0)
            {
                var p = stack.Pop();
                if (p.Get(board)) continue;
                p.Set(board);
                result++;
                for(var move = 0; move < moves.Length; move++)
                {
                    var pos = Move(board, connections, p, move);
                    if (pos.Get(board)) continue;
                    stack.Push(pos);
                }
            }
            return result;
        }
        void Show(bool[][][] board)
        {
            // Display board
            // -------------
            // | 0 | 1 | 2 |
            // -------------
            //     | 3 |
            //     -----
            //     | 4 |
            //     -----
            //     | 5 |
            //     -----
            var topLine = new string('-', (board[0][0].Length + board[1][0].Length + board[2][0].Length) * 2 + 7);
            Console.WriteLine(topLine);
            for(var row = 0; row < board[0].Length; row++)
            {
                for(var surface = 0; surface < 3; surface++)
                {
                    Console.Write("| ");
                    for (var column = 0; column < board[surface][0].Length; column++)
                    {
                        Console.Write(board[surface][row][column] ? "# " : ". ");
                    }
                }
                Console.WriteLine("|");
            }
            Console.WriteLine(topLine);
            var leftIndent = new string(' ', board[0][0].Length * 2 + 2);
            var middleLine = leftIndent + new string('-', board[1][0].Length * 2 + 3);
            for (var surface = 3; surface < 6; surface++)
            {
                for(var row = 0; row < board[surface].Length; row++)
                {
                    Console.Write(leftIndent);
                    Console.Write("| ");
                    for(var column = 0; column < board[surface][0].Length; column++)
                    {
                        Console.Write(board[surface][row][column] ? "# " : ". ");
                    }
                    Console.WriteLine("|");
                }
                Console.WriteLine(middleLine);
            }
        }
    }
}
