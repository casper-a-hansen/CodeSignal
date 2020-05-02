/*
    Imported:   2020-05-02 12:04
    Created By: Casper
    Url:        https://app.codesignal.com/arcade/intro
*/
using NUnit.Framework;
using CodeSignalSolutions;
using CodeSignalSolutions.Intro.DarkWilderness;

namespace Intro
{
    public class DarkWilderness
    {
        /*
            Imported: 2020-05-02 12:04
            By:       Casper
            Url:      https://app.codesignal.com/arcade/intro/level-9/xHvruDnQCx7mYom3T
        */
        [Test]
        public void growingPlant()
        {
            Test.Execute(typeof(growingPlantClass),
                @"upSpeed: 100
                downSpeed: 10
                desiredHeight: 910
                Expected Output: 10",
                @"upSpeed: 10
                downSpeed: 9
                desiredHeight: 4
                Expected Output: 1",
                @"upSpeed: 5
                downSpeed: 2
                desiredHeight: 7
                Expected Output: 2",
                @"upSpeed: 7
                downSpeed: 3
                desiredHeight: 443
                Expected Output: 110",
                @"upSpeed: 6
                downSpeed: 5
                desiredHeight: 10
                Expected Output: 5"
            );
        }
        /*
            Imported: 2020-05-02 12:04
            By:       Casper
            Url:      https://app.codesignal.com/arcade/intro/level-9/r9azLYp2BDZPyzaG2
        */
        [Test]
        public void knapsackLight()
        {
            Test.Execute(typeof(knapsackLightClass),
                @"value1: 10
                weight1: 5
                value2: 6
                weight2: 4
                maxW: 8
                Expected Output: 10",
                @"value1: 10
                weight1: 5
                value2: 6
                weight2: 4
                maxW: 9
                Expected Output: 16",
                @"value1: 5
                weight1: 3
                value2: 7
                weight2: 4
                maxW: 6
                Expected Output: 7",
                @"value1: 10
                weight1: 2
                value2: 11
                weight2: 3
                maxW: 1
                Expected Output: 0",
                @"value1: 15
                weight1: 2
                value2: 20
                weight2: 3
                maxW: 2
                Expected Output: 15",
                @"value1: 2
                weight1: 5
                value2: 3
                weight2: 4
                maxW: 5
                Expected Output: 3",
                @"value1: 4
                weight1: 3
                value2: 3
                weight2: 4
                maxW: 4
                Expected Output: 4",
                @"value1: 3
                weight1: 5
                value2: 3
                weight2: 8
                maxW: 10
                Expected Output: 3"
            );
        }
        /*
            Imported: 2020-05-02 12:04
            By:       Casper
            Url:      https://app.codesignal.com/arcade/intro/level-9/AACpNbZANCkhHWNs3
        */
        [Test]
        public void longestDigitsPrefix()
        {
            Test.Execute(typeof(longestDigitsPrefixClass),
                @"inputString: ""123aa1""
                Expected Output: ""123""",
                @"inputString: ""0123456789""
                Expected Output: ""0123456789""",
                @"inputString: ""  3) always check for whitespaces""
                Expected Output: """"",
                @"inputString: ""12abc34""
                Expected Output: ""12""",
                @"inputString: ""the output is 42""
                Expected Output: """"",
                @"inputString: ""aaaaaaa""
                Expected Output: """""
            );
        }
        /*
            Imported: 2020-05-02 12:04
            By:       Casper
            Url:      https://app.codesignal.com/arcade/intro/level-9/hoLtYWbjdrD2PF6yo
        */
        [Test]
        public void digitDegree()
        {
            Test.Execute(typeof(digitDegreeClass),
                @"n: 5
                Expected Output: 0",
                @"n: 100
                Expected Output: 1",
                @"n: 91
                Expected Output: 2",
                @"n: 99
                Expected Output: 2",
                @"n: 1000000000
                Expected Output: 1",
                @"n: 9
                Expected Output: 0",
                @"n: 73
                Expected Output: 2",
                @"n: 877
                Expected Output: 2",
                @"n: 777773
                Expected Output: 3",
                @"n: 304
                Expected Output: 1"
            );
        }
        /*
            Imported: 2020-05-02 12:04
            By:       Casper
            Url:      https://app.codesignal.com/arcade/intro/level-9/6M57rMTFB9MeDeSWo
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
    }
}
