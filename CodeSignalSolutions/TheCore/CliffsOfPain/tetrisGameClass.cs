/*
    Status:   Solved
    Imported: 2020-04-26 13:36
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/cliffs-of-pain/exzzbEDpoo5Ax4j4Q

    Description:
        Let's play Tetris! But first we need to define the rules, especially since they
        probably differ from the way you've played Tetris before.
        
        There is an empty
        field with 20 rows and 10 columns, which is initially empty. Random pieces
        appear on the field, each composed of four square blocks. You can't change the
        piece's shape, but you can rotate it 90 degree clockwise (possibly several
        times) and choose which columns it will appear within. Once you've rotated the
        piece and have set its starting position, it appears at the topmost row where
        you placed it and falls down until it can't fall any further. The objective of
        the game is to create horizontal lines composed of 10 blocks. When such a line
        is created, it disappears, and all lines above the deleted one move down. The
        player receives 1 point for each deleted row.
        
        Your task is to implement an
        algorithm that places each new piece optimally. The piece is considered to be
        placed optimally if:
        
        The total number of blocks in the rows this piece will
        occupy after falling down is maximized;
        Among all positions with that value
        maximized, this position requires the least number of rotations;
        Among all
        positions that require the minimum number of rotations, this one is the leftmost
        one (i.e. the leftmost block's position is as far to the left as possible).
        
        The
        piece can't leave the field. It is guaranteed that it is always possible to
        place the Tetris piece in the field.
        
        Implement this algorithm and calculate the
        number of points that you will get for the given set of pieces.
        
        Example
        
        For
        pieces = [[[".", "#", "."], 
                   ["#", "#", "#"]],
                  [["#", ".",
        "."], 
                   ["#", "#", "#"]],
                  [["#", "#", "."],
        [".", "#", "#"]],
                  [["#", "#", "#", "#"]],
                  [["#", "#", "#",
        "#"]],
                  [["#", "#"], 
                   ["#", "#"]]]
        
        
        the output should be
        tetrisGame(pieces) = 1.
        
        For this explanation, we are representing each block by
        the index of the piece it belongs to. After the first 5 blocks fall, the field
        looks like this:
        
        ...
        . . . . . . . . . .
        . . . . . . . . . .
        . . . . . . . . .
        .
        . . . . . . . . . .
        . . . . . . . . 3 4
        . . . . . . . . 3 4
        . 0 . 1 . 2 2 . 3
        4
        0 0 0 1 1 1 2 2 3 4
        
        
        
        Note that the 0th, 1st, and 2nd pieces all fell down
        without rotating, while the 3rd and the 4th pieces were rotated one time each.
        Since there is now a row composed of 10 blocks, it is deleted, and you get 1
        point.
        
        When the last piece falls, the final field looks like this:
        
        ...
        . . . .
        . . . . . .
        . . . . . . . . . .
        . . . . . . . . . .
        . . . . . . . . . .
        . . . .
        . . . . . .
        5 5 . . . . . . 3 4
        5 5 . . . . . . 3 4
        . 0 . 1 . 2 2 . 3 4
        Input/Output
        
        [execution time limit] 3 seconds (cs)
        
        [input]
        array.array.array.char pieces
        
        A non-empty array of pieces in the order in which
        they fall. Each piece is represented as a rectangular matrix, where '#'
        represents a block and '.' represents an empty cell.
        
        Each piece consists of 4
        blocks, and each block shares a common side with at least one another block.
        It's guaranteed that each piece contains neither empty rows nor empty columns.
        Guaranteed constraints:
        3 ≤ pieces.length ≤ 30,
        1 ≤ pieces[i].length ≤ 2,
        2 ≤
        pieces[i][j].length ≤ 4.
        
        [output] integer
        
        The number of points you will have
        by the end of the game.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.CliffsOfPain
{
    class tetrisGameClass
    {
        List<char[]> _board;
                int pieceNo = -1;
                int tetrisGame(char[][][] pieces)
                {
                    _board = Enumerable.Range(0, 20).Select(d => NewRow()).ToList();
                    var result = 0;
                    foreach (var piece in pieces)
                    {
                        result += AddPiece(piece);
                        Show();
                        Console.WriteLine();
                    }
                    return result;
                }
                public int AddPiece(char[][] piece)
                {
                    pieceNo++;
                    // The bottom of the board is row 19 and the top is row 0
                    var fit = BestFit(piece);
                    PlacePiece(piece, fit.row, fit.column, fit.rotation);
                    return RemoveFull();
                }
                public char[][] Board => _board.ToArray();
                int RemoveFull()
                {
                    int result = 0;
                    int row = 19;
                    while (row >= 0 && !Empty(row))
                    {
                        if (Full(row))
                        {
                            _board.RemoveAt(row);
                            _board.Insert(0, NewRow());
                            result++;
                        }
                        else
                        {
                            row--;
                        }
                    }
                    return result;
                }
                void PlacePiece(char[][] piece, int row, int column, int rotation)
                {
                    char c = pieceNo < 10 ? (char)(pieceNo + '0') : (char)(pieceNo - 10 + 'A');
                    for (var i = 0; i < rotation; i++) piece = Rotate(piece);
         
                    for (var y = 0; y < piece.Length; y++)
                    {
                        for (var x = 0; x < piece[y].Length; x++)
                        {
                            if (piece[y][x] == '#')
                            {
                                _board[row - piece.Length + y + 1][column + x] = c;
                            }
                        }
                    }
                }
                (int blocks, int column, int rotation, int row) BestFit(char[][] piece)
                {
                    var originalPiece = piece;
                    int maxRow = 0;
                    while (maxRow < 20 && Empty(maxRow)) maxRow++;
                    maxRow--;
                    (int blocks, int column, int rotation, int row) best = (blocks: -1, column: -1, rotation: -1, row: -1);
                    for (var rotation = 0; rotation < 4; rotation++)
                    {
                        for (int c = 0; c < 10 - piece[0].Length + 1; c++)
                        {
                            int rowno = Fits(piece, c, maxRow);
                            if (rowno == -1) continue;
                            // Occupy: how many blocks is occupied in the rows that this piece will be in.
                            var blocks = Enumerable.Range(rowno - piece.Length + 1, piece.Length).Sum(r => _board[r].Count(a 
        => a != '.'));
                            if (blocks > best.blocks)
                            {
                                best = (blocks: blocks, column: c, rotation: rotation, row: rowno);
                            }
                        }
                        piece = Rotate(piece);
                        if (rotation == 2 && Same(originalPiece, piece)) break;
                    }
                    return best;
                }
                int Fits(char[][] piece, int column, int maxRow)
                {
                    bool IsFit(int row)
                    {
                        for (var p = piece.Length - 1; p >= 0; p--)
                        {
                            var pr = piece[p];
                            for (var i = 0; i < pr.Length; i++)
                            {
                                if (pr[i] == '#' && _board[row - piece.Length + p + 1][column + i] != '.') return false;
                            }
                        }
                        return true;
                    }
                    bool CanDrop(int row)
                    {
                        int width = piece[0].Length;
                        char[] blocks = piece[piece.Length - 1].ToArray();
                        for (int r = row - 1; r >= maxRow; r--)
                        {
                            var line = r - (row - piece.Length + 1);
                            if (line >= 0)
                            {
                                for(int c = 0; c < width; c++)
                                {
                                    if (piece[line][c] != '.')
                                        blocks[c] = '#';
                                }
                            }
                            for (int c = column; c < column + width; c++)
                            {
                                if (blocks[c - column] != '.' && _board[r][c] != '.') return false;
                            }
                        }
                        return true;
                    }
                    for (int row = 19; row >= maxRow; row--)
                    {
                        if (IsFit(row) && CanDrop(row)) return row;
                    }
                    return -1;
                }
                char[] NewRow() => Enumerable.Range(0, 10).Select(d => '.').ToArray();
         
                char[][] Rotate(char[][] piece)
                {
                    // Rotate 90 degree Clockwise
                    var width = piece[0].Length;
                    var height = piece.Length;
                    return Enumerable.Range(0, width).Select(y => Enumerable.Range(0, height).Select(x => piece[height - x - 1]
        [y]).ToArray()).ToArray();
                }
                bool Full(int row) => _board[row].All(c => c != '.');
                bool Empty(int row) => _board[row].All(c => c == '.');
                public void Show(string text = null)
                {
                    if (!string.IsNullOrEmpty(text))
                        Console.WriteLine(text);
                    bool skip = true;
                    for (var r = 0; r < 20; r++)
                    {
                        if (skip && !Empty(r)) skip = false;
                        if (!skip) Console.WriteLine(string.Join(" ", _board[r]) + (Full(r) ? " <--- removed" : ""));
                    }
                }
                public bool Same(char[][] pieceA, char[][] pieceB)
                {
                    if (pieceA.Length != pieceB.Length) return false;
                    return pieceA.Zip(pieceB, (a, b) => a.SequenceEqual(b)).All(b => b);
                }
    }
}
