/*
    Imported:   2020-05-02 12:05
    Created By: Casper
    Url:        https://app.codesignal.com/arcade/intro
*/
using NUnit.Framework;
using CodeSignalSolutions;
using CodeSignalSolutions.Intro.RainbowOfClarity;

namespace Intro
{
    public class RainbowOfClarity
    {
        /*
            Imported: 2020-05-02 12:05
            By:       Casper
            Url:      https://app.codesignal.com/arcade/intro/level-11/Zr2XXEpkBPtYWqPJu
        */
        [Test]
        public void isDigit()
        {
            Test.Execute(typeof(isDigitClass),
                @"symbol: ""0""
                Expected Output: true",
                @"symbol: ""-""
                Expected Output: false",
                @"symbol: ""O""
                Expected Output: false",
                @"symbol: ""1""
                Expected Output: true",
                @"symbol: ""2""
                Expected Output: true",
                @"symbol: ""!""
                Expected Output: false",
                @"symbol: ""@""
                Expected Output: false",
                @"symbol: ""+""
                Expected Output: false",
                @"symbol: ""6""
                Expected Output: true",
                @"symbol: ""(""
                Expected Output: false",
                @"symbol: "")""
                Expected Output: false"
            );
        }
        /*
            Imported: 2020-05-02 12:05
            By:       Casper
            Url:      https://app.codesignal.com/arcade/intro/level-11/o2uq6eTuvk7atGadR
        */
        [Test]
        public void lineEncoding()
        {
            Test.Execute(typeof(lineEncodingClass),
                @"s: ""aabbbc""
                Expected Output: ""2a3bc""",
                @"s: ""abbcabb""
                Expected Output: ""a2bca2b""",
                @"s: ""abcd""
                Expected Output: ""abcd""",
                @"s: ""zzzz""
                Expected Output: ""4z""",
                @"s: ""wwwwwwwawwwwwww""
                Expected Output: ""7wa7w""",
                @"s: ""ccccccccccccccc""
                Expected Output: ""15c""",
                @"s: ""qwertyuioplkjhg""
                Expected Output: ""qwertyuioplkjhg""",
                @"s: ""ssiiggkooo""
                Expected Output: ""2s2i2gk3o""",
                @"s: ""adfaaa""
                Expected Output: ""adf3a""",
                @"s: ""bbjaadlkjdl""
                Expected Output: ""2bj2adlkjdl"""
            );
        }
        /*
            Imported: 2020-05-02 12:05
            By:       Casper
            Url:      https://app.codesignal.com/arcade/intro/level-11/pwRLrkrNpnsbgMndb
        */
        [Test]
        public void chessKnight()
        {
            Test.Execute(typeof(chessKnightClass),
                @"cell: ""a1""
                Expected Output: 2",
                @"cell: ""c2""
                Expected Output: 6",
                @"cell: ""d4""
                Expected Output: 8",
                @"cell: ""g6""
                Expected Output: 6",
                @"cell: ""a3""
                Expected Output: 4",
                @"cell: ""b7""
                Expected Output: 4",
                @"cell: ""h8""
                Expected Output: 2",
                @"cell: ""h6""
                Expected Output: 4",
                @"cell: ""g8""
                Expected Output: 3",
                @"cell: ""a5""
                Expected Output: 4"
            );
        }
        /*
            Imported: 2020-05-02 12:06
            By:       Casper
            Url:      https://app.codesignal.com/arcade/intro/level-11/vpfeqDwGZSzYNm2uX
        */
        [Test]
        public void deleteDigit()
        {
            Test.Execute(typeof(deleteDigitClass),
                @"n: 152
                Expected Output: 52",
                @"n: 1001
                Expected Output: 101",
                @"n: 10
                Expected Output: 1",
                @"n: 222219
                Expected Output: 22229",
                @"n: 109
                Expected Output: 19",
                @"n: 222250
                Expected Output: 22250",
                @"n: 44435
                Expected Output: 4445",
                @"n: 12
                Expected Output: 2",
                @"n: 218616
                Expected Output: 28616",
                @"n: 861452
                Expected Output: 86452"
            );
        }
    }
}
