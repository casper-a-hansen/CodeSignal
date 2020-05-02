/*
    Status:   Solved
    Imported: 2020-05-02 13:14
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/cliffs-of-pain/P2ECpmqBqtm4jmRXC

    Description:
        Your task is to imitate a turn-based variation of the popular "Snake" game.
        You are given the initial configuration of the board and a list of commands
        which the snake follows one-by-one. The game ends if one of the following
        happens:
        the snake tries to eat its tail;
        the snake tries to move out of the board;
        it executes all the given commands.
        Output the board configuration after the game ends.
        Example
        For
        gameBoard = [['.', '.', '.', '.'],
        ['.', '.', '<', '*'],
        ['.', '.', '.', '*']]
        and commands = "FFFFFRFFRRLLF", the output should be
        snakeGame(gameBoard, commands) = [['.', '.', '.', '.'],
        ['X', 'X', 'X', '.'],
        ['.', '.', '.', '.']]
        For
        gameBoard = [['.', '.', '^', '.', '.'],
        ['.', '.', '*', '*', '.'],
        ['.', '.', '.', '*', '*']]
        and commands = "RFRF", the output should be
        snakeGame(gameBoard, commands) = [['.', '.', 'X', 'X', '.'],
        ['.', '.', 'X', 'X', '.'],
        ['.', '.', '.', 'X', '.']]
        For
        gameBoard = [['.', '.', '*', '>', '.'],
        ['.', '*', '*', '.', '.'],
        ['.', '.', '.', '.', '.']]
        and commands = "FRFFRFFRFLFF", the output should be
        snakeGame(gameBoard, commands) = [['.', '.', '.', '.', '.'],
        ['<', '*', '*', '.', '.'],
        ['.', '.', '*', '.', '.']]
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] array.array.char gameBoard
        A rectangular matrix of characters. It is guaranteed that it represents a
        correct game board configuration, i.e. there is exactly one snake. Direction of
        snake's head is depicted by one of the following characters ('^', '>', 'v',
        '<'). All of the other snake's body parts are depicted by '*'s (note, that if
        the snake has length 1 then there is no asterisks in its representation). All
        cells which are not occupied by the snake are depicted by '.'s.
        It is guaranteed that all snake cells are connected and no snake cell has more
        than two neighbors.
        Guaranteed constraints:
        1 ≤ gameBoard.length ≤ 10,
        1 ≤ gameBoard[0].length ≤ 10.
        [input] string commands
        A list of commands, where 'F' means go one cell forward in the current
        direction, 'L' and 'R' mean change current direction 90 degrees left
        (counter-clockwise) or right (clockwise) correspondingly.
        Guaranteed constraints:
        0 ≤ commands.length ≤ 40.
        [output] array.array.char
        Configuration of the board after the end of the game.
        If the snake dies, output its state before the losing move and replace each of
        the cells it occupied with Xs.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.CliffsOfPain
{
    class snakeGameClass
    {
        char[][] _gameBoard;
                int width;
                int height;
                char[][] snakeGame(char[][] gameBoard, string commands)
                {
                    _gameBoard = gameBoard;
                    width = gameBoard[0].Length;
                    height = gameBoard.Length;
                    Show();
                    var snake = Snake(out var direction);
                    var end = snake.Length - 1;
                    var snakePos = snake[0];
                    Console.WriteLine($"Snake: {string.Join("-", snake)}");
                    Show();
                    foreach (var c in commands)
                    {
                        direction = c switch { 'L' => Left(direction), 'R' => Right(direction), _ => direction };
                        if (c == 'F')
                        {
                            if (!Move(snakePos, direction, out var newPos) || Value(newPos) == '*')
                            {
                                foreach (var pos in snake) setValue(pos, 'X');
                                break;
                            }
                            setValue(snake[end], '.');   // Delete tail.
                            setValue(snakePos, '*');
                            snakePos = newPos;
                            snake[end-- % snake.Length] = snakePos;
                            if (end < 0) end = snake.Length - 1;
                        }
                        else
                        {
                            var newDir = c switch { 'L' => Left(direction), 'R' => Right(direction), _ => direction };
                            Console.WriteLine($"{newDir} -> {direction} {c}");
                        }
                        setValue(snakePos, DirectionChar(direction));
                        Show();
                    }
                    return gameBoard;
                }
                (int X, int Y)[] Snake(out (int dx, int dy) direction)
                {
                    List<(int X, int Y)> snake = new List<(int X, int Y)>();
                    var pos = _gameBoard.SelectMany((a, y) => a.Select((c, x) => (x, y, c)).Where(t => t.c != '.' && t.c != '*'))
                        .Select(t => (X: t.x, Y: t.y))
                        .First();
                    snake.Add(pos);
                    direction = Value(pos) switch
                    {
                        '<' => (dx: -1, dy: 0),
                        '>' => (dx: 1, dy: 0),
                        '^' => (dx: 0, dy: -1),
                        'v' => (dx: 0, dy: 1),
                        _ => (dx: 0, dy: 0)
                    };
                    var dir = (dx: -direction.dx, dy: -direction.dy);
                    while (true)
                    {
                        if (Move(pos, dir, out var newPos) && Value(newPos) == '*')
                        {
                            snake.Add(newPos);
                            pos = newPos;
                        }
                        else if (Move(pos, Left(dir), out newPos) && Value(newPos) == '*')
                        {
                            snake.Add(newPos);
                            pos = newPos;
                            dir = Left(dir);
                        }
                        else if (Move(pos, Right(dir), out newPos) && Value(newPos) == '*')
                        {
                            snake.Add(newPos);
                            pos = newPos;
                            dir = Right(dir);
                        }
                        else
                        {
                            return snake.ToArray();
                        }
                    }
                }
                void setValue((int X, int Y) pos, char value)
                {
                    Console.WriteLine($"Writing {pos} to {value}");
                    _gameBoard[pos.Y][pos.X] = value;
                }
                char Value((int X, int Y) pos)
                {
                    Console.WriteLine($"Reading {pos}");
                    return _gameBoard[pos.Y][pos.X];
                }
                bool Move((int X, int Y) pos, (int dx, int dy) direction, out (int X, int Y) newPos)
                {
                    newPos = (X: pos.X + direction.dx, Y: pos.Y + direction.dy);
                    return 0 <= newPos.X && newPos.X < width && 0 <= newPos.Y && newPos.Y < height;
                }
                char DirectionChar((int dx, int dy) direction) => direction switch
                {
                    (1, 0) => '>',
                    (-1, 0) => '<',
                    (0, 1) => 'v',
                    (0, -1) => '^',
                    _ => '*'
                };
                (int dx, int dy) Left((int dx, int dy) direction) => direction switch
                {
                    (1, 0) => (dx: 0, dy: -1),
                    (-1, 0) => (dx: 0, dy: 1),
                    (0, 1) => (dx: 1, dy: 0),
                    (0, -1) => (dx: -1, dy: 0),
                    _ => (dx: 0, dy: 0)
                };
                (int dx, int dy) Right((int dx, int dy) direction) => direction switch
                {
                    (1, 0) => (dx: 0, dy: 1),
                    (-1, 0) => (dx: 0, dy: -1),
                    (0, 1) => (dx: -1, dy: 0),
                    (0, -1) => (dx: 1, dy: 0),
                    _ => (dx: 0, dy: 0)
                };
                void Show()
                {
                    Console.WriteLine();
                    foreach (var a in _gameBoard) Console.WriteLine(string.Join(" ", a));
                }
    }
}
