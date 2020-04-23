using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSignalSolutions.TheCore.CliffOfPain
{
    class game2048Class
    {
        private int[][] _grid;
        int[][] game2048(int[][] grid, string path)
        {
            try
            {
                _grid = grid;
                foreach (var k in path)
                {
                    switch (k)
                    {
                        case 'R':
                            Move((row, cell) => grid[row][3 - cell], (row, cell, value) => grid[row][3 - cell] = value);
                            break;
                        case 'L':
                            Move((row, cell) => grid[row][cell], (row, cell, value) => grid[row][cell] = value);
                            break;

                        case 'D':
                            Move((row, cell) => grid[3 - cell][row], (row, cell, value) => grid[3 - cell][row] = value);
                            break;
                        case 'U':
                            Move((row, cell) => grid[cell][row], (row, cell, value) => grid[cell][row] = value);
                            break;
                    }
                    Show();
                }
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            return grid;
        }

        void Move(Func<int, int, int> cellValue, Action<int, int, int> setCellValue)
        {
            for (var row = 0; row < 4; row++)
            {
                var min = 1;
                var changed = false;
                do
                {
                    changed = false;
                    for (int cell = min; cell < 4; cell++)
                    {
                        var value = cellValue(row, cell);
                        if (value != 0)
                        {
                            var prev = cellValue(row, cell - 1);
                            if (prev == 0)
                            {
                                setCellValue(row, cell - 1, value);
                                setCellValue(row, cell, 0);
                                changed = true;
                            }
                            if (value == prev)
                            {
                                setCellValue(row, cell - 1, value + prev);
                                setCellValue(row, cell, 0);
                                changed = true;
                                min = cell + 1;
                            }
                        }
                    }
                } while (changed);
            }
            Show();
        }

        void Show()
        {
            foreach (var g in _grid) Console.WriteLine(string.Join(" ", g)); Console.WriteLine();
        }
    }
}
