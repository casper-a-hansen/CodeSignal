/*
    Imported:   2020-05-02 12:50
    Created By: Casper
    Url:        https://app.codesignal.com/arcade/code-arcade
*/
using NUnit.Framework;
using CodeSignalSolutions;
using CodeSignalSolutions.TheCore.WellOfIntegration;

namespace TheCore
{
    public class WellOfIntegration
    {
        /*
            Imported: 2020-05-02 12:50
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/well-of-integration/3QMXNwGfvLMoQwed7
        */
        [Test]
        public void houseNumbersSum()
        {
            Test.Execute(typeof(houseNumbersSumClass),
                @"inputArray: [5, 1, 2, 3, 0, 1, 5, 0, 2]
                Expected Output: 11",
                @"inputArray: [4, 2, 1, 6, 0]
                Expected Output: 13",
                @"inputArray: [4, 1, 2, 3, 0, 10, 2]
                Expected Output: 10",
                @"inputArray: [0, 1, 2, 3, 0]
                Expected Output: 0",
                @"inputArray: [5, 1, 1, 3, 0, 1, 5, 0, 2]
                Expected Output: 10",
                @"inputArray: [10, 10, 10, 10, 10, 10, 10, 10, 10, 0]
                Expected Output: 90",
                @"inputArray: [10, 10, 10, 10, 10, 10, 10, 10, 0, 10]
                Expected Output: 80"
            );
        }
        /*
            Imported: 2020-05-02 12:50
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/well-of-integration/fzsCQGYbxaEcTr2bL
        */
        [Test]
        public void allLongestStrings()
        {
            Test.Execute(typeof(allLongestStringsClass),
                @"inputArray:
                [""aba"",
                 ""aa"",
                 ""ad"",
                 ""vcd"",
                 ""aba""]
                Expected Output: [""aba"",
                 ""vcd"",
                 ""aba""]",
                @"inputArray: [""aa""]
                Expected Output: [""aa""]",
                @"inputArray:
                [""abc"",
                 ""eeee"",
                 ""abcd"",
                 ""dcd""]
                Expected Output: [""eeee"",
                 ""abcd""]",
                @"inputArray:
                [""a"",
                 ""abc"",
                 ""cbd"",
                 ""zzzzzz"",
                 ""a"",
                 ""abcdef"",
                 ""asasa"",
                 ""aaaaaa""]
                Expected Output: [""zzzzzz"",
                 ""abcdef"",
                 ""aaaaaa""]",
                @"inputArray:
                [""enyky"",
                 ""benyky"",
                 ""yely"",
                 ""varennyky""]
                Expected Output: [""varennyky""]",
                @"inputArray:
                [""abacaba"",
                 ""abacab"",
                 ""abac"",
                 ""xxxxxx""]
                Expected Output: [""abacaba""]",
                @"inputArray:
                [""young"",
                 ""yooooooung"",
                 ""hot"",
                 ""or"",
                 ""not"",
                 ""come"",
                 ""on"",
                 ""fire"",
                 ""water"",
                 ""watermelon""]
                Expected Output: [""yooooooung"",
                 ""watermelon""]",
                @"inputArray:
                [""onsfnib"",
                 ""aokbcwthc"",
                 ""jrfcw""]
                Expected Output: [""aokbcwthc""]",
                @"inputArray: [""lbgwyqkry""]
                Expected Output: [""lbgwyqkry""]",
                @"inputArray: [""i""]
                Expected Output: [""i""]"
            );
        }
        /*
            Imported: 2020-05-02 12:50
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/well-of-integration/RaWLwT2eb96hp4N5Z
        */
        [Test]
        public void houseOfCats()
        {
            Test.Execute(typeof(houseOfCatsClass),
                @"legs: 6
                Expected Output: [1, 3]",
                @"legs: 2
                Expected Output: [1]",
                @"legs: 8
                Expected Output: [0, 2, 4]",
                @"legs: 4
                Expected Output: [0, 2]",
                @"legs: 44
                Expected Output: [0, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22]"
            );
        }
        /*
            Imported: 2020-05-02 12:50
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/well-of-integration/Z9opBsx5fX6XfQJdt
        */
        [Test]
        public void alphabetSubsequence()
        {
            Test.Execute(typeof(alphabetSubsequenceClass),
                @"s: ""effg""
                Expected Output: false",
                @"s: ""cdce""
                Expected Output: false",
                @"s: ""ace""
                Expected Output: true",
                @"s: ""bxz""
                Expected Output: true",
                @"s: ""cdefghijkxyzz""
                Expected Output: false",
                @"s: ""qa""
                Expected Output: false",
                @"s: ""fkyz""
                Expected Output: true",
                @"s: ""xz""
                Expected Output: true",
                @"s: ""pfyz""
                Expected Output: false",
                @"s: ""fz""
                Expected Output: true"
            );
        }
        /*
            Imported: 2020-05-02 12:50
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/well-of-integration/sGwCfM5FzX7LhLcdk
        */
        [Test]
        public void minimalNumberOfCoins()
        {
            Test.Execute(typeof(minimalNumberOfCoinsClass),
                @"coins: [1, 2, 10]
                price: 28
                Expected Output: 6",
                @"coins: [1, 5, 10, 100]
                price: 239
                Expected Output: 10",
                @"coins: [1]
                price: 8
                Expected Output: 8",
                @"coins: [1, 2, 20, 60, 120]
                price: 150
                Expected Output: 7",
                @"coins: [1, 3, 6, 30]
                price: 45
                Expected Output: 4"
            );
        }
        /*
            Imported: 2020-05-02 12:50
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/well-of-integration/ZCD7NQnED724bJtjN
        */
        [Test]
        public void addBorder()
        {
            Test.Execute(typeof(addBorderClass),
                @"picture:
                [""abc"",
                 ""ded""]
                Expected Output: [""*****"",
                 ""*abc*"",
                 ""*ded*"",
                 ""*****""]",
                @"picture: [""a""]
                Expected Output: [""***"",
                 ""*a*"",
                 ""***""]",
                @"picture:
                [""aa"",
                 ""**"",
                 ""zz""]
                Expected Output: [""****"",
                 ""*aa*"",
                 ""****"",
                 ""*zz*"",
                 ""****""]",
                @"picture:
                [""abcde"",
                 ""fghij"",
                 ""klmno"",
                 ""pqrst"",
                 ""uvwxy""]
                Expected Output: [""*******"",
                 ""*abcde*"",
                 ""*fghij*"",
                 ""*klmno*"",
                 ""*pqrst*"",
                 ""*uvwxy*"",
                 ""*******""]",
                @"picture: [""wzy**""]
                Expected Output: [""*******"",
                 ""*wzy***"",
                 ""*******""]"
            );
        }
        /*
            Imported: 2020-05-02 12:51
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/well-of-integration/mJr7vgtN4X4ecL7ZA
        */
        [Test]
        public void timedReading()
        {
            Test.Execute(typeof(timedReadingClass),
                @"maxLength: 4
                text: ""The Fox asked the stork, 'How is the soup?'""
                Expected Output: 7",
                @"maxLength: 1
                text: ""...""
                Expected Output: 0",
                @"maxLength: 3
                text: ""This play was good for us.""
                Expected Output: 3",
                @"maxLength: 3
                text: ""Suddenly he stopped, and glanced up at the houses""
                Expected Output: 5",
                @"maxLength: 6
                text: ""Zebras evolved among the Old World horses within the last four million years.""
                Expected Output: 11",
                @"maxLength: 5
                text: ""Although zebra species may have overlapping ranges, they do not interbreed.""
                Expected Output: 6",
                @"maxLength: 1
                text: ""Oh!""
                Expected Output: 0",
                @"maxLength: 5
                text: ""Now and then, however, he is horribly thoughtless, and seems to take a real delight in giving me pain.""
                Expected Output: 14"
            );
        }
        /*
            Imported: 2020-05-02 12:51
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/well-of-integration/8RiRRM3yvbuAd3MNg
        */
        [Test]
        public void electionsWinners()
        {
            Test.Execute(typeof(electionsWinnersClass),
                @"votes: [2, 3, 5, 2]
                k: 3
                Expected Output: 2",
                @"votes: [1, 3, 3, 1, 1]
                k: 0
                Expected Output: 0",
                @"votes: [5, 1, 3, 4, 1]
                k: 0
                Expected Output: 1",
                @"votes: [1, 1, 1, 1]
                k: 1
                Expected Output: 4",
                @"votes: [1, 1, 1, 1]
                k: 0
                Expected Output: 0",
                @"votes: [3, 1, 1, 3, 1]
                k: 2
                Expected Output: 2"
            );
        }
        /*
            Imported: 2020-05-02 12:51
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/well-of-integration/kvGfZZxGyjNbD7yxv
        */
        [Test]
        public void integerToStringOfFixedWidth()
        {
            Test.Execute(typeof(integerToStringOfFixedWidthClass),
                @"number: 1234
                width: 2
                Expected Output: ""34""",
                @"number: 1234
                width: 4
                Expected Output: ""1234""",
                @"number: 1234
                width: 5
                Expected Output: ""01234""",
                @"number: 0
                width: 1
                Expected Output: ""0""",
                @"number: 89
                width: 4
                Expected Output: ""0089""",
                @"number: 23456
                width: 4
                Expected Output: ""3456""",
                @"number: 899
                width: 3
                Expected Output: ""899"""
            );
        }
        /*
            Imported: 2020-05-02 12:52
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/well-of-integration/xYXfzQmnhBvEKJwXP
        */
        [Test]
        public void areSimilar()
        {
            Test.Execute(typeof(areSimilarClass),
                @"a: [1, 2, 3]
                b: [1, 2, 3]
                Expected Output: true",
                @"a: [1, 2, 3]
                b: [2, 1, 3]
                Expected Output: true",
                @"a: [1, 2, 2]
                b: [2, 1, 1]
                Expected Output: false",
                @"a: [1, 1, 4]
                b: [1, 2, 3]
                Expected Output: false",
                @"a: [1, 2, 3]
                b: [1, 10, 2]
                Expected Output: false",
                @"a: [2, 3, 1]
                b: [1, 3, 2]
                Expected Output: true",
                @"a: [2, 3, 9]
                b: [10, 3, 2]
                Expected Output: false",
                @"a: [4, 6, 3]
                b: [3, 4, 6]
                Expected Output: false",
                @"a: [832, 998, 148, 570, 533, 561, 894, 147, 455, 279]
                b: [832, 998, 148, 570, 533, 561, 455, 147, 894, 279]
                Expected Output: true",
                @"a: [832, 998, 148, 570, 533, 561, 894, 147, 455, 279]
                b: [832, 570, 148, 998, 533, 561, 455, 147, 894, 279]
                Expected Output: false"
            );
        }
        /*
            Imported: 2020-05-02 12:52
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/well-of-integration/Ghe6HWhFft8h6fR49
        */
        [Test]
        public void adaNumber()
        {
            Test.Execute(typeof(adaNumberClass),
                @"line: ""123_456_789""
                Expected Output: true",
                @"line: ""16#123abc#""
                Expected Output: true",
                @"line: ""10#123abc#""
                Expected Output: false",
                @"line: ""10#10#123ABC#""
                Expected Output: false",
                @"line: ""10#0#""
                Expected Output: true",
                @"line: ""10##""
                Expected Output: false",
                @"line: ""16#1234567890ABCDEFabcdef#""
                Expected Output: true",
                @"line: ""1600#""
                Expected Output: false",
                @"line: ""7#???#""
                Expected Output: false",
                @"line: ""4#4#""
                Expected Output: false",
                @"line: ""3454235ab534""
                Expected Output: false",
                @"line: ""1#0#""
                Expected Output: false",
                @"line: ""1_#0_#""
                Expected Output: false",
                @"line: ""17#ac#""
                Expected Output: false",
                @"line: ""2#10110#""
                Expected Output: true",
                @"line: ""2#10110""
                Expected Output: false",
                @"line: ""#2#10110""
                Expected Output: false",
                @"line: ""#2#10110#""
                Expected Output: false",
                @"line: ""9##""
                Expected Output: false"
            );
        }
        /*
            Imported: 2020-05-02 21:37
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/well-of-integration/x3ix7CY93z2bwKDtG
        */
        [Test]
        public void switchLights()
        {
            Test.Execute(typeof(switchLightsClass),
                @"a: [1, 1, 1, 1, 1]
                Expected Output: [0, 1, 0, 1, 0]",
                @"a: [0, 0]
                Expected Output: [0, 0]",
                @"a: [1, 0, 0, 1, 0, 1, 0, 1]
                Expected Output: [1, 1, 1, 0, 0, 1, 1, 0]",
                @"a: [1, 0, 0, 0, 0, 1, 1, 1, 0, 0, 1, 0, 1]
                Expected Output: [1, 1, 1, 1, 1, 0, 1, 0, 0, 0, 1, 1, 0]",
                @"a: [1, 1, 0, 0, 1]
                Expected Output: [0, 1, 1, 1, 0]",
                @"a: [1, 1, 1, 0, 1, 1, 1]
                Expected Output: [1, 0, 1, 1, 0, 1, 0]",
                @"a: [0,0,0,1,0,1,1,0,1,0,0,1,0,0,1,1,0,1,1,0,0,0,0,0,1,0,0,1,1,0,1,0,1,1,0,0,0,0,1,0,1,0,1,0,1,0,0,0,0,1,0,1,1,1,1,0,0,1,0,0,1,1,0,1,1,1,0,0,1,1,1,0,1,1,0,1,1,1,1,0,0,1,1,0,0,0,0,0,1,0,1,0,0,1,0,0,1,0,0,0,1,0,0,1,1,1,0,1,0,1,1,0,0,0,0,1,0,0,1,0,1,1,0,0,0,1,1,1,0,1,1,0,1,0,0,0,0,1,1,0,0,1,1,0,1,0,1,1,0,0,0,1,0,1,1,0,0,1,1,1,1,1,1,1,0,1,0,0,0,1,1,0,1,1,0,0,1,0,0,0,1,1,0,1,1,1,0,1,1,1,1,1,1,1,1,0,0,1,1,0,1,1,0,0,1,1,1,1,0,1,1,0,1,0,0,0,1,0,0,1,1,0,1,1,0,0,1,1,1,1,0,0,1,1,0,1,0,1,0,1,1,0,1,1,0,1,1,0,0,1,1,0,0,1,0,1,0,0,1,1,1,0,1,1,1,1,1,0,1,0,1,0,1,0,0,0,1,0,1,1,0,0,0,0,1,0,0,0,0,0,1,0,0,0,1,0,0,0,1,0,1,1,0,1,1,1,0,1,1,1,0,1,0,0,0,0,0,0,1,0,0,0,1,1,0,1]
                Expected Output: [1,1,1,0,0,1,0,0,1,1,1,0,0,0,1,0,0,1,0,0,0,0,0,0,1,1,1,0,1,1,0,0,1,0,0,0,0,0,1,1,0,0,1,1,0,0,0,0,0,1,1,0,1,0,1,1,1,0,0,0,1,0,0,1,0,1,1,1,0,1,0,0,1,0,0,1,0,1,0,0,0,1,0,0,0,0,0,0,1,1,0,0,0,1,1,1,0,0,0,0,1,1,1,0,1,0,0,1,1,0,1,1,1,1,1,0,0,0,1,1,0,1,1,1,1,0,1,0,0,1,0,0,1,1,1,1,1,0,1,1,1,0,1,1,0,0,1,0,0,0,0,1,1,0,1,1,1,0,1,0,1,0,1,0,0,1,1,1,1,0,1,1,0,1,1,1,0,0,0,0,1,0,0,1,0,1,1,0,1,0,1,0,1,0,1,1,1,0,1,1,0,1,1,1,0,1,0,1,1,0,1,1,0,0,0,0,1,1,1,0,1,1,0,1,1,1,0,1,0,1,1,1,0,1,1,0,0,1,1,0,1,1,0,1,1,0,1,1,1,0,1,1,1,0,0,1,1,1,0,1,0,0,1,0,1,0,1,1,0,0,1,1,0,0,0,0,1,1,0,1,1,1,1,1,0,0,0,0,0,0,1,1,1,1,0,0,0,0,1,1,0,1,1,0,1,0,0,1,0,1,1,0,0,0,0,0,0,0,1,1,1,1,0,1,1,0]",
                @"a: [1, 0, 1, 1, 1, 0, 0, 1, 1, 1, 1, 0, 0, 1, 1, 0, 1, 1, 1, 0, 1, 0, 1, 1, 0, 0, 1, 0, 1, 1, 1, 1, 1]
                Expected Output: [1, 1, 0, 1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 1, 0, 0, 1, 0, 1, 1, 0, 0, 1, 0, 0, 0, 1, 1, 0, 1, 0, 1, 0]",
                @"a: [0, 0, 0, 0, 0, 0]
                Expected Output: [0, 0, 0, 0, 0, 0]",
                @"a: [1, 1, 1, 1, 0, 0, 0, 0, 1, 1, 1, 1, 0, 1, 0, 0, 1, 0, 0, 0, 1]
                Expected Output: [0, 1, 0, 1, 1, 1, 1, 1, 0, 1, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0]"
            );
        }
        /*
            Imported: 2020-05-02 21:37
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/well-of-integration/QmK8kHTyKqh8xDoZk
        */
        [Test]
        public void threeSplit()
        {
            Test.Execute(typeof(threeSplitClass),
                @"a: [0, -1, 0, -1, 0, -1]
                Expected Output: 4",
                @"a: [-1, 0, -1, 0, -1, 0]
                Expected Output: 4",
                @"a: [-1, 1, -1, 1, -1, 1, -1, 1]
                Expected Output: 3",
                @"a: [7, 8, 2, 25, -9, 12, 12]
                Expected Output: 0",
                @"a: [184138,
                      -37745,82759,14851,79647,
                      -91351,
                      -9413,84612,
                      -101031,
                      -181203,
                      -162841,
                      -14357,
                      -122060,
                      -56837,
                      -59344,95670,19230,
                      -197053,
                      -151794,
                      -12451,1512,108952,
                      -155189,
                      -8121,43054,
                      -25951,125440,28768,
                      -42373,188365,150867,
                      -38140,61777,186009,93565,
                      -76218,
                      -133893,
                      -103795,
                      -187274,
                      -175627,
                      -170204,
                      -30250,151764,92036,9080,41271,
                      -34582,75906,
                      -176277,179547,152773,27776,
                      -70639,
                      -186460,134040,135416,196278,15198,
                      -167083,190726,175444,
                      -25970,
                      -37584,130247,163481,
                      -78746,123875,
                      -127859,63643,131400,177022,
                      -51120,
                      -33714,
                      -64067,
                      -153262,
                      -152369,
                      -51938,173432,
                      -101008,124992,
                      -151945,
                      -170175,182191,144348,
                      -43276,
                      -29398,143683,4763,164814,195818,28225,180864,
                      -127334,37600,184790,4152,199588,133654,
                      -18816,
                      -121196,
                      -67769,112234,57594,90858,199031,184334,112916,130951,
                      -181948,
                      -61114,74154,
                      -44010,164849,163083,
                      -165563,34566,
                      -103124,185075,28700,
                      -196978,
                      -192354,
                      -17883,
                      -142522,
                      -83792,43765,
                      -183610,44134,
                      -22779,192282,115221,12296,20731,98280,
                      -89394,72800,
                      -110352,
                      -6289,54054,151191,53169,12397,
                      -77496,76249,40497,8377,
                      -134898,1345,
                      -49669,72688,181648,113789,
                      -91593,
                      -85917,85401,76632,
                      -71710,106722,
                      -128521,
                      -119048,37976,
                      -72773,34432,40118,
                      -153781,163824,149927,
                      -83901,58599,114268,
                      -195468,101292,37934,163551,
                      -51514,93980,
                      -178182,
                      -152702,
                      -76796,
                      -114697,31344,
                      -51611,
                      -4632,
                      -85532,
                      -188408,163967,83255,34003,
                      -175284,
                      -60057,15142,175259,194554,
                      -115806,47879,6083,
                      -181421,31385,
                      -154069,
                      -280,187971]
                Expected Output: 0",
                @"a: [0, 0, 0, 0, 0]
                Expected Output: 6"
            );
        }
    }
}
