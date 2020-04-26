/*
    Status:   Solved
    Imported: 2020-04-26 13:37
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/cliffs-of-pain/PouBk693gQvXaCbPK

    Description:
        You've mastered the Rubik's Cube and got bored solving it, so now you are
        looking for a new challenge. One puzzle similar to the Rubik's Cube caught your
        attention. It's called a Pyraminx puzzle, and is a triangular pyramid-shaped
        puzzle. The parts are arranged in a pyramidal pattern on each side, while the
        layers can be rotated with respect to each vertex, and the individual tips can
        be rotated as well. There are 4 faces on the Pyraminx. The puzzle should be held
        so that one face faces you and one face faces down, as in the image below. The
        four corners are then labeled U (for up), R (for right), L (for left), and B
        (for back). The front face thus contains the U, R, and L corners.
        
        Let's write
        down all possible moves for vertex U in the following notation:
        
        U - 120°
        counterclockwise turn of topmost tip (assuming that we're looking at the
        pyraminx from the top, and vertex U is the topmost);
        U' - clockwise turn for the
        same tip;
        u - 120° counterclockwise turn of two upper layer;
        u' - clockwise turn
        for the same layers.
        
        For other vertices the moves can be described similarly:
        The first puzzle you bought wasn't assembled, so you get your professional
        pyraminx solver friend to assemble it. He does, and you wrote down all his moves
        notated as described above. Now the puzzle's faces have colors faceColors[0]
        (front face), faceColors[1] (bottom face), faceColors[2] (left face),
        faceColors[3] (right face). You want to know the initial state of the puzzle to
        repeat your friend's moves and see how he solved it.
        
        Example
        
        For faceColors =
        ['R', 'G', 'Y', 'O'] and moves = ["B", "b'", "u'", "R"], the output should be
        pyraminxPuzzle(faceColors, moves) = [['Y', 'Y', 'Y', 'Y', 'R', 'R', 'R', 'R',
        'G'],
                                             ['G', 'R', 'O', 'O', 'O', 'G', 'G',
        'G', 'G'],
                                             ['Y', 'O', 'Y', 'G', 'O', 'O',
        'G', 'G', 'Y'],
                                             ['R', 'O', 'O', 'R', 'O',
        'Y', 'Y', 'R', 'R']]
        
        
        Let's repeat the friend's steps in reverse order:
        
        Final
        state:
        
        Before the last move:
        
        One more move before that:
        
        And one more:
        Finally, the initial state:
        
        Input/Output
        
        [execution time limit] 3 seconds (cs)
        [input] array.char faceColors
        
        A distinct array of four distinct characters,
        representing the front, bottom, left and right faces, respectively.
        
        Guaranteed
        constraints:
        faceColors.length = 4.
        
        [input] array.string moves
        
        Guaranteed
        constraints:
        1 ≤ moves.length ≤ 100,
        
        moves[i] ∈ {"U", "U'", "u", "u'", "L",
        "L'", "l", "l'", 
                     "R", "R'", "r", "r'", "B", "B'", "b", "b'"}.
        [output] array.array.char
        
        Initial state of the puzzle. result[0] should contain
        9 characters corresponding to the front face, result[1] - to the bottom face,
        result[2] - to the left face and result[3] - to the right face.
        
        The colors for
        each face should be given in top-to-bottom and left-to-right order, starting
        from the marked vertex (i.e. U, B, L or R), assuming that this vertex is at the
        top of the puzzle.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.CliffsOfPain
{
    class pyraminxPuzzleClass
    {
        char[][] pyraminxPuzzle(char[] faceColors, string[] moves)
                {
                    var result = faceColors.Select(c => Enumerable.Range(0, 9).Select(d => c).ToArray()).ToArray();
         
                    foreach (var move in moves.Reverse())
                    {
                        var reversedMove = move.EndsWith("'") ? move.Substring(0, 1) : move + "'";
                        Console.WriteLine($"Changed command from {move} to {reversedMove}");
                        result = Move(reversedMove, result);
                        Show(result);
                    }
                    return result;
                }
         
                static char[][] Move(string move, char[][] pyraminx)
                {
                    var result = pyraminx.Select(r => r.Select(c => c).ToArray()).ToArray();  // Deep Clone
         
                    foreach (var i in moves[move])
                    {
                        var instr = i + i.Substring(0, 2);
                        for (var p = 0; p < i.Length; p += 2)
                        {
                            result[(int)(instr[p + 2] - '0')][(int)(instr[p + 3] - '0')] = pyraminx[(int)(instr[p] - '0')][
        (int)(instr[p + 1] - '0')];
                        }
                    }
         
                    return result;
                }
         
                public static void Show(char[][] pyraminx)
                {
                    foreach (var line in layout)
                    {
                        Console.WriteLine(regexLayout.Replace(line, m => new string(pyraminx[(int)m.Value[0] - '0'][(int)
        m.Value[1] - '0'], 2)));
                    }
                    Console.WriteLine();
                }
                static readonly string[] layout = new string[] {
                    @"     /\          /\          /\",
                    @"    /24\        /00\        /38\",
                    @"   /\25/\      /\02/\      /\37/\",
                    @"  /26\/21\    /01\/03\    /33\/36\",
                    @" /\27/\22/\  /\05/\07/\  /\32/\35/\",
                    @"/28\/23\/20\/04\/06\/08\/30\/31\/34\",
                    @"            \18/\16/\14/",
                    @"             \/17\/15\/",
                    @"              \13/\11/",
                    @"               \/12\/",
                    @"                \10/",
                    @"                 \/",
                };
                static readonly Regex regexLayout = new Regex("[0-3][0-8]");
         
                //  2. Left      0: Front:   3: Right 
                //                   U
                //       4           0           8
                //     6 5 1       1 2 3       3 7 6
                //   8 7 3 2 0   4 5 6 7 8   0 2 1 5 4
                //             L           R
                //               8 7 6 5 4
                //                 3 2 1
                //                   0
                //                   B
                //              1. Bottom
                // Note that these moves can only work from one set to another, so duplicate the Pyraminx take values from old and place in new.
                // Moves are like "003824" meaning (0,0)->(3,8)->(2,4)->(0,0)
                static readonly Dictionary<string, string[]> moves = new Dictionary<string, string[]>() {
                    { "B", new string[] { "102834" } },
                    { "b", new string[] { "102834", "112336", "122735", "132631" } },
                    { "B'", new string[] { "103428" } },
                    { "b'", new string[] { "103428", "113623", "123527", "133126" } },
                    { "R'", new string[] { "083014" } },
                    { "r'", new string[] { "083014", "033116", "073215", "063311" } },
                    { "R", new string[] { "081430" } },
                    { "r", new string[] { "081430", "031631", "071532", "061133" } },
                    { "L'", new string[] { "041820" } },
                    { "l'", new string[] { "041820", "011623", "051722", "061321" } },
                    { "L", new string[] { "042018" } },
                    { "l", new string[] { "042018", "012316", "052217", "062113" } },
                    { "U", new string[] { "003824" } },
                    { "u", new string[] { "003824", "013326", "023725", "033621" } },
                    { "U'", new string[] { "002438" } },
                    { "u'", new string[] { "002438", "012633", "022537", "032136" } },
                };
    }
}
