using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.CliffOfPain
{
    public static class PyraminxTest
    {
        public static void Execute()
        {
            int failed = 0;
            int testNo = 0;
            foreach(var test in tests)
            {
                testNo++;
                Console.WriteLine($"Test: {testNo}");
                var pyraminx = new pyraminxPuzzleClass();
                var result = pyraminx.Execute(test.faceColors, test.moves);

                if (test.expected.Zip(result, (e, r) => e.SequenceEqual(r)).All(b => b))
                {
                    Console.WriteLine("Result was correct");
                }
                else
                {
                    Console.WriteLine("Result was wrong");
                    Console.WriteLine("Expected:");
                    pyraminxPuzzleClass.Show(test.expected);
                    Console.WriteLine("Your result:");
                    pyraminxPuzzleClass.Show(result);
                    failed++;
                }
            }
            Console.WriteLine($"Your result was {failed} failed out of {tests.Length}");
        }

        static (char[] faceColors, string[] moves, char[][] expected)[] tests = new (char[] faceColors, string[] moves, char[][] expected)[]
        {
            (faceColors: new char[]{'R', 'G', 'Y', 'O' }, moves: new string[]{"B", "b'", "u'", "R"}, expected: new char[][]{
                new char[] {'Y','Y','Y','Y','R','R','R','R','G' },
                new char[] {'G','R','O','O','O','G','G','G','G' },
                new char[] {'Y','O','Y','G','O','O','G','G','Y' },
                new char[] {'R','O','O','R','O','Y','Y','R','R' } } ),
             (faceColors: new char[] {'R', 'G', 'Y', 'O' }, moves: new string[] {"l", "l'" }, expected: new char[][] {
                new char[] {'R','R','R','R','R','R','R','R','R' },
                new char[] {'G','G','G','G','G','G','G','G','G' },
                new char[] {'Y','Y','Y','Y','Y','Y','Y','Y','Y' },
                new char[] {'O','O','O','O','O','O','O','O','O' } } ),
             (faceColors: new char[] { 'R', 'G', 'Y', 'O' }, moves: new string[] {"l", "l'", "u", "R", "U'", "L", "R'", "u'", "l'", "L'", "r" }, expected: new char[][]{
                new char[] {'Y','O','R','G','G','G','G','G','G' },
                new char[] {'G','O','G','Y','O','O','Y','Y','Y' },
                new char[] {'R','G','R','R','O','Y','Y','Y','Y' },
                new char[] {'R','R','R','R','O','O','O','O','R' } } ),
             (faceColors: new char[]{'R', 'G', 'Y', 'O' }, moves: new string[]{ "r" }, expected: new char[][]{
                new char[] {'R','R','R','G','R','R','G','G','G' },
                new char[] {'G','O','G','G','O','O','O','G','G' },
                new char[] {'Y','Y','Y','Y','Y','Y','Y','Y','Y' },
                new char[] {'R','R','R','R','O','O','O','O','O' } }),
            (faceColors: new char[]{'A', 'B', 'C', 'D' }, moves: new string[] {"l", "l'", "r'", "r", "u", "U", "u'", "R'", "L", "R", "L'", "B'", "U'", "b", "B", "b'" }, expected: new char[][]{
                new char[] {'A','A','A','A','A','A','A','A','A' },
                new char[] {'B','B','B','B','B','B','B','B','B' },
                new char[] {'C','C','C','C','C','C','C','C','C' },
                new char[] {'D','D','D','D','D','D','D','D','D' } }),
        };
    }
    public class pyraminxPuzzleClass
    {
        public char[][] Execute(char[] faceColors, string[] moves)
        {
            return pyraminxPuzzle(faceColors, moves);
        }

        char[][] pyraminxPuzzle(char[] faceColors, string[] moves)
        {
            var result = faceColors.Select(c => Enumerable.Range(0, 9).Select(d => c).ToArray()).ToArray();

            foreach (var move in moves.Reverse())
            {
                var reversedMove = move.EndsWith("'") ? move.Substring(0, 1) : move + "'";
                Console.WriteLine($"Changed command from {move} to {reversedMove}");
                result = Move(reversedMove, result);
                Show(result);
            }
            return result;
        }

        static char[][] Move(string move, char[][] pyraminx)
        {
            var result = pyraminx.Select(r => r.Select(c => c).ToArray()).ToArray();  // Deep Clone

            foreach (var i in moves[move])
            {
                var instr = i + i.Substring(0, 2);
                for (var p = 0; p < i.Length; p += 2)
                {
                    result[(int)(instr[p + 2] - '0')][(int)(instr[p + 3] - '0')] = pyraminx[(int)(instr[p] - '0')][(int)(instr[p + 1] - '0')];
                }
            }

            return result;
        }

        public static void Show(char[][] pyraminx)
        {
            foreach (var line in layout)
            {
                Console.WriteLine(regexLayout.Replace(line, m => new string(pyraminx[(int)m.Value[0] - '0'][(int)m.Value[1] - '0'], 2)));
            }
            Console.WriteLine();
        }
        static readonly string[] layout = new string[] {
            @"     /\          /\          /\",
            @"    /24\        /00\        /38\",
            @"   /\25/\      /\02/\      /\37/\",
            @"  /26\/21\    /01\/03\    /33\/36\",
            @" /\27/\22/\  /\05/\07/\  /\32/\35/\",
            @"/28\/23\/20\/04\/06\/08\/30\/31\/34\",
            @"            \18/\16/\14/",
            @"             \/17\/15\/",
            @"              \13/\11/",
            @"               \/12\/",
            @"                \10/",
            @"                 \/",
        };
        static readonly Regex regexLayout = new Regex("[0-3][0-8]");

        //  2. Left      0: Front:   3: Right 
        //                   U
        //       4           0           8
        //     6 5 1       1 2 3       3 7 6
        //   8 7 3 2 0   4 5 6 7 8   0 2 1 5 4
        //             L           R
        //               8 7 6 5 4
        //                 3 2 1
        //                   0
        //                   B
        //              1. Bottom
        // Note that these moves can only work from one set to another, so duplicate the Pyraminx take values from old and place in new.
        // Moves are like "003824" meaning (0,0)->(3,8)->(2,4)->(0,0)
        static readonly Dictionary<string, string[]> moves = new Dictionary<string, string[]>() {
            { "B", new string[] { "102834" } },
            { "b", new string[] { "102834", "112336", "122735", "132631" } },
            { "B'", new string[] { "103428" } },
            { "b'", new string[] { "103428", "113623", "123527", "133126" } },
            { "R'", new string[] { "083014" } },
            { "r'", new string[] { "083014", "033116", "073215", "063311" } },
            { "R", new string[] { "081430" } },
            { "r", new string[] { "081430", "031631", "071532", "061133" } },
            { "L'", new string[] { "041820" } },
            { "l'", new string[] { "041820", "011623", "051722", "061321" } },
            { "L", new string[] { "042018" } },
            { "l", new string[] { "042018", "012316", "052217", "062113" } },
            { "U", new string[] { "003824" } },
            { "u", new string[] { "003824", "013326", "023725", "033621" } },
            { "U'", new string[] { "002438" } },
            { "u'", new string[] { "002438", "012633", "022537", "032136" } },
        };

    }
}
