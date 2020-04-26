/*
    Imported:   2020-04-26 13:31
    Created By: Casper
    Url:        https://app.codesignal.com/arcade/code-arcade
*/
using NUnit.Framework;
using CodeSignalSolutions;
using CodeSignalSolutions.TheCore.ChessTavern;

namespace TheCore
{
    public class ChessTavern
    {
    /*
        Imported: 2020-04-26 13:31
        By:       Casper
        Url:      https://app.codesignal.com/arcade/code-arcade/chess-tavern/6M57rMTFB9MeDeSWo
    */
    [Test]
    public void bishopAndPawn()
    {
        Test.Execute(typeof(bishopAndPawnClass),
            @"bishop: ""a1""
            pawn: ""c3""
            Expected Output: true",
            @"bishop: ""h1""
            pawn: ""h3""
            Expected Output: false",
            @"bishop: ""a5""
            pawn: ""c3""
            Expected Output: true",
            @"bishop: ""g1""
            pawn: ""f3""
            Expected Output: false",
            @"bishop: ""e7""
            pawn: ""d6""
            Expected Output: true",
            @"bishop: ""e7""
            pawn: ""a3""
            Expected Output: true",
            @"bishop: ""e3""
            pawn: ""a7""
            Expected Output: true",
            @"bishop: ""a1""
            pawn: ""h8""
            Expected Output: true",
            @"bishop: ""a1""
            pawn: ""h7""
            Expected Output: false",
            @"bishop: ""h1""
            pawn: ""a8""
            Expected Output: true"
        );
    }
    /*
        Imported: 2020-04-26 13:32
        By:       Casper
        Url:      https://app.codesignal.com/arcade/code-arcade/chess-tavern/zqDuSLMHhAknqnLtA
    */
    [Test]
    public void chessKnightMoves()
    {
        Test.Execute(typeof(chessKnightMovesClass),
            @"cell: ""a1""
            Expected Output: 2",
            @"cell: ""c2""
            Expected Output: 6",
            @"cell: ""h8""
            Expected Output: 2",
            @"cell: ""d5""
            Expected Output: 8",
            @"cell: ""a2""
            Expected Output: 3",
            @"cell: ""h7""
            Expected Output: 3",
            @"cell: ""h6""
            Expected Output: 4",
            @"cell: ""b2""
            Expected Output: 4",
            @"cell: ""f4""
            Expected Output: 8"
        );
    }
    /*
        Imported: 2020-04-26 13:32
        By:       Casper
        Url:      https://app.codesignal.com/arcade/code-arcade/chess-tavern/wGLCfzpdcA2o9kSpD
    */
    [Test]
    public void bishopDiagonal()
    {
        Test.Execute(typeof(bishopDiagonalClass),
            @"bishop1: ""d7""
            bishop2: ""f5""
            Expected Output: [""c8"", 
             ""h3""]",
            @"bishop1: ""d8""
            bishop2: ""b5""
            Expected Output: [""b5"", 
             ""d8""]",
            @"bishop1: ""a1""
            bishop2: ""h8""
            Expected Output: [""a1"", 
             ""h8""]",
            @"bishop1: ""g3""
            bishop2: ""e1""
            Expected Output: [""e1"", 
             ""h4""]",
            @"bishop1: ""b4""
            bishop2: ""e7""
            Expected Output: [""a3"", 
             ""f8""]",
            @"bishop1: ""h1""
            bishop2: ""a1""
            Expected Output: [""a1"", 
             ""h1""]"
        );
    }
    /*
        Imported: 2020-04-26 13:32
        By:       Casper
        Url:      https://app.codesignal.com/arcade/code-arcade/chess-tavern/SJRNgqggTaktuCJGj
    */
    [Test]
    public void whoseTurn()
    {
        Test.Execute(typeof(whoseTurnClass),
            @"p: ""b1;g1;b8;g8""
            Expected Output: true",
            @"p: ""c3;g1;b8;g8""
            Expected Output: false",
            @"p: ""g1;g2;g3;g4""
            Expected Output: true",
            @"p: ""f8;h1;f3;c2""
            Expected Output: false",
            @"p: ""a5;d3;c4;h3""
            Expected Output: false",
            @"p: ""f8;g1;h2;h5""
            Expected Output: false",
            @"p: ""a6;g1;a5;a4""
            Expected Output: true",
            @"p: ""g5;h1;a2;h5""
            Expected Output: false",
            @"p: ""e1;f7;f8;b4""
            Expected Output: false",
            @"p: ""g2;d7;h5;h1""
            Expected Output: true"
        );
    }
    /*
        Imported: 2020-04-26 13:32
        By:       Casper
        Url:      https://app.codesignal.com/arcade/code-arcade/chess-tavern/FfjPkYvo9ah6wgXem
    */
    [Test]
    public void chessBishopDream()
    {
        Test.Execute(typeof(chessBishopDreamClass),
            @"boardSize: [3, 7]
            initPosition: [1, 2]
            initDirection: [-1, 1]
            k: 13
            Expected Output: [0, 1]",
            @"boardSize: [1, 2]
            initPosition: [0, 0]
            initDirection: [1, 1]
            k: 6
            Expected Output: [0, 1]",
            @"boardSize: [2, 2]
            initPosition: [1, 0]
            initDirection: [1, 1]
            k: 12
            Expected Output: [1, 0]",
            @"boardSize: [1, 1]
            initPosition: [0, 0]
            initDirection: [1, -1]
            k: 1000000000
            Expected Output: [0, 0]",
            @"boardSize: [2, 3]
            initPosition: [1, 2]
            initDirection: [-1, -1]
            k: 41
            Expected Output: [0, 2]",
            @"boardSize: [17, 19]
            initPosition: [14, 8]
            initDirection: [1, -1]
            k: 239239
            Expected Output: [4, 17]",
            @"boardSize: [17, 19]
            initPosition: [16, 18]
            initDirection: [1, 1]
            k: 239239239
            Expected Output: [10, 2]"
        );
    }
    /*
        Imported: 2020-04-26 13:32
        By:       Casper
        Url:      https://app.codesignal.com/arcade/code-arcade/chess-tavern/NhRZQrrMqeWYL9L9Z
    */
    [Test]
    public void chessTriangle()
    {
        Test.Execute(typeof(chessTriangleClass),
            @"n: 2
            m: 3
            Expected Output: 8",
            @"n: 1
            m: 30
            Expected Output: 0",
            @"n: 3
            m: 3
            Expected Output: 48",
            @"n: 2
            m: 2
            Expected Output: 0",
            @"n: 5
            m: 2
            Expected Output: 40"
        );
    }
    /*
        Imported: 2020-04-26 13:32
        By:       Casper
        Url:      https://app.codesignal.com/arcade/code-arcade/chess-tavern/3hvEEqS7wuoEMZJJC
    */
    [Test]
    public void amazonCheckmate()
    {
        Test.Execute(typeof(amazonCheckmateClass),
            @"king: ""d3""
            amazon: ""e4""
            Expected Output: [5, 21, 0, 29]",
            @"king: ""a1""
            amazon: ""g5""
            Expected Output: [0, 29, 1, 29]",
            @"king: ""a3""
            amazon: ""e4""
            Expected Output: [1, 32, 1, 23]",
            @"king: ""f3""
            amazon: ""f2""
            Expected Output: [6, 11, 0, 38]",
            @"king: ""b7""
            amazon: ""a8""
            Expected Output: [0, 10, 0, 45]",
            @"king: ""f7""
            amazon: ""d3""
            Expected Output: [4, 28, 1, 21]",
            @"king: ""g2""
            amazon: ""c3""
            Expected Output: [9, 21, 0, 24]",
            @"king: ""f3""
            amazon: ""c1""
            Expected Output: [4, 18, 0, 32]",
            @"king: ""d4""
            amazon: ""h8""
            Expected Output: [0, 18, 0, 36]"
        );
    }
    /*
        Imported: 2020-04-26 13:32
        By:       Casper
        Url:      https://app.codesignal.com/arcade/code-arcade/chess-tavern/ybkbv7e6qMaucZWig
    */
    [Test]
    public void pawnRace()
    {
        Test.Execute(typeof(pawnRaceClass),
            @"white: ""e2""
            black: ""e7""
            toMove: ""w""
            Expected Output: ""draw""",
            @"white: ""e3""
            black: ""d7""
            toMove: ""b""
            Expected Output: ""black""",
            @"white: ""a7""
            black: ""h2""
            toMove: ""w""
            Expected Output: ""white""",
            @"white: ""c5""
            black: ""b7""
            toMove: ""w""
            Expected Output: ""black""",
            @"white: ""g2""
            black: ""a3""
            toMove: ""b""
            Expected Output: ""black""",
            @"white: ""h4""
            black: ""g7""
            toMove: ""w""
            Expected Output: ""white""",
            @"white: ""f2""
            black: ""h6""
            toMove: ""w""
            Expected Output: ""white""",
            @"white: ""d3""
            black: ""h2""
            toMove: ""b""
            Expected Output: ""black""",
            @"white: ""a3""
            black: ""d5""
            toMove: ""w""
            Expected Output: ""black""",
            @"white: ""c3""
            black: ""e7""
            toMove: ""b""
            Expected Output: ""black""",
            @"white: ""g4""
            black: ""e4""
            toMove: ""w""
            Expected Output: ""black""",
            @"white: ""f4""
            black: ""h6""
            toMove: ""b""
            Expected Output: ""white""",
            @"white: ""b5""
            black: ""f3""
            toMove: ""w""
            Expected Output: ""black""",
            @"white: ""c5""
            black: ""e5""
            toMove: ""b""
            Expected Output: ""white""",
            @"white: ""c6""
            black: ""e2""
            toMove: ""w""
            Expected Output: ""black""",
            @"white: ""f6""
            black: ""h4""
            toMove: ""b""
            Expected Output: ""white""",
            @"white: ""e3""
            black: ""f4""
            toMove: ""w""
            Expected Output: ""white""",
            @"white: ""a6""
            black: ""f7""
            toMove: ""w""
            Expected Output: ""white""",
            @"white: ""e7""
            black: ""h3""
            toMove: ""b""
            Expected Output: ""white""",
            @"white: ""c7""
            black: ""e6""
            toMove: ""w""
            Expected Output: ""white""",
            @"white: ""g2""
            black: ""f2""
            toMove: ""b""
            Expected Output: ""black""",
            @"white: ""f2""
            black: ""e5""
            toMove: ""w""
            Expected Output: ""white""",
            @"white: ""c2""
            black: ""d7""
            toMove: ""b""
            Expected Output: ""white""",
            @"white: ""d4""
            black: ""e3""
            toMove: ""w""
            Expected Output: ""black""",
            @"white: ""h3""
            black: ""g6""
            toMove: ""b""
            Expected Output: ""black"""
        );
    }
    }
}
