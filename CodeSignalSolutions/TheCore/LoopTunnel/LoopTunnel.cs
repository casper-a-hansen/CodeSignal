/*
    Imported:   2020-05-02 12:11
    Created By: Casper
    Url:        https://app.codesignal.com/arcade/code-arcade
*/
using NUnit.Framework;
using CodeSignalSolutions;
using CodeSignalSolutions.TheCore.LoopTunnel;

namespace TheCore
{
    public class LoopTunnel
    {
        /*
            Imported: 2020-05-02 12:11
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/loop-tunnel/7BFPq6TpsNjzgcpXy
        */
        [Test]
        public void leastFactorial()
        {
            Test.Execute(typeof(leastFactorialClass),
                @"n: 17
                Expected Output: 24",
                @"n: 1
                Expected Output: 1",
                @"n: 5
                Expected Output: 6",
                @"n: 25
                Expected Output: 120",
                @"n: 18
                Expected Output: 24",
                @"n: 109
                Expected Output: 120",
                @"n: 106
                Expected Output: 120",
                @"n: 11
                Expected Output: 24",
                @"n: 55
                Expected Output: 120",
                @"n: 24
                Expected Output: 24"
            );
        }
        /*
            Imported: 2020-05-02 12:11
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/loop-tunnel/hBw5BJiZ4LmXcy92u
        */
        [Test]
        public void countSumOfTwoRepresentations2()
        {
            Test.Execute(typeof(countSumOfTwoRepresentations2Class),
                @"n: 6
                l: 2
                r: 4
                Expected Output: 2",
                @"n: 6
                l: 3
                r: 3
                Expected Output: 1",
                @"n: 10
                l: 9
                r: 11
                Expected Output: 0",
                @"n: 24
                l: 8
                r: 16
                Expected Output: 5",
                @"n: 24
                l: 12
                r: 12
                Expected Output: 1",
                @"n: 93
                l: 24
                r: 58
                Expected Output: 12"
            );
        }
        /*
            Imported: 2020-05-02 12:11
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/loop-tunnel/LbuWRHnMoJH9SAo4o
        */
        [Test]
        public void magicalWell()
        {
            Test.Execute(typeof(magicalWellClass),
                @"a: 1
                b: 2
                n: 2
                Expected Output: 8",
                @"a: 1
                b: 1
                n: 1
                Expected Output: 1",
                @"a: 6
                b: 5
                n: 3
                Expected Output: 128",
                @"a: 1601
                b: 337
                n: 0
                Expected Output: 0",
                @"a: 1891
                b: 352
                n: 0
                Expected Output: 0",
                @"a: 1936
                b: 1835
                n: 5
                Expected Output: 17800540",
                @"a: 957
                b: 57
                n: 2
                Expected Output: 110113",
                @"a: 687
                b: 1337
                n: 0
                Expected Output: 0",
                @"a: 491
                b: 1552
                n: 4
                Expected Output: 3060400",
                @"a: 1275
                b: 362
                n: 2
                Expected Output: 924738"
            );
        }
        /*
            Imported: 2020-05-02 12:11
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/loop-tunnel/8rqs3BLpdKePhouQM
        */
        [Test]
        public void lineUp()
        {
            Test.Execute(typeof(lineUpClass),
                @"commands: ""LLARL""
                Expected Output: 3",
                @"commands: ""RLR""
                Expected Output: 1",
                @"commands: """"
                Expected Output: 0",
                @"commands: ""L""
                Expected Output: 0",
                @"commands: ""A""
                Expected Output: 1",
                @"commands: ""AAAAAAAAAAAAAAA""
                Expected Output: 15",
                @"commands: ""RRRRRRRRRRLLLLLLLLLRRRRLLLLLLLLLL""
                Expected Output: 16",
                @"commands: ""AALAAALARAR""
                Expected Output: 5"
            );
        }
        /*
            Imported: 2020-05-02 12:11
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/loop-tunnel/xzeZqCQjpfDJuN72S
        */
        [Test]
        public void additionWithoutCarrying()
        {
            Test.Execute(typeof(additionWithoutCarryingClass),
                @"param1: 456
                param2: 1734
                Expected Output: 1180",
                @"param1: 99999
                param2: 0
                Expected Output: 99999",
                @"param1: 999
                param2: 999
                Expected Output: 888",
                @"param1: 0
                param2: 0
                Expected Output: 0",
                @"param1: 54321
                param2: 54321
                Expected Output: 8642",
                @"param1: 54321
                param2: 56789
                Expected Output: 0"
            );
        }
        /*
            Imported: 2020-05-02 12:11
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/loop-tunnel/scG8AFsPuqQGx8Qjf
        */
        [Test]
        public void appleBoxes()
        {
            Test.Execute(typeof(appleBoxesClass),
                @"k: 5
                Expected Output: -15",
                @"k: 15
                Expected Output: -120",
                @"k: 36
                Expected Output: 666",
                @"k: 1
                Expected Output: -1",
                @"k: 14
                Expected Output: 105",
                @"k: 12
                Expected Output: 78",
                @"k: 9
                Expected Output: -45",
                @"k: 40
                Expected Output: 820",
                @"k: 37
                Expected Output: -703"
            );
        }
        /*
            Imported: 2020-05-02 12:11
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/loop-tunnel/KLbRMcWhaZi3dvYH5
        */
        [Test]
        public void increaseNumberRoundness()
        {
            Test.Execute(typeof(increaseNumberRoundnessClass),
                @"n: 902200100
                Expected Output: true",
                @"n: 11000
                Expected Output: false",
                @"n: 99080
                Expected Output: true",
                @"n: 1022220
                Expected Output: true",
                @"n: 106611
                Expected Output: true",
                @"n: 234230
                Expected Output: false",
                @"n: 888
                Expected Output: false",
                @"n: 100
                Expected Output: false",
                @"n: 1000000000
                Expected Output: false",
                @"n: 103456789
                Expected Output: true"
            );
        }
        /*
            Imported: 2020-05-02 12:12
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/loop-tunnel/H5PP5MXvYvWXxTytH
        */
        [Test]
        public void rounders()
        {
            Test.Execute(typeof(roundersClass),
                @"n: 15
                Expected Output: 20",
                @"n: 1234
                Expected Output: 1000",
                @"n: 1445
                Expected Output: 2000",
                @"n: 14
                Expected Output: 10",
                @"n: 10
                Expected Output: 10",
                @"n: 7001
                Expected Output: 7000",
                @"n: 99
                Expected Output: 100"
            );
        }
        /*
            Imported: 2020-05-02 12:12
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/loop-tunnel/LAKReA3CR9EwkZGSz
        */
        [Test]
        public void candles()
        {
            Test.Execute(typeof(candlesClass),
                @"candlesNumber: 5
                makeNew: 2
                Expected Output: 9",
                @"candlesNumber: 1
                makeNew: 2
                Expected Output: 1",
                @"candlesNumber: 3
                makeNew: 3
                Expected Output: 4",
                @"candlesNumber: 11
                makeNew: 3
                Expected Output: 16",
                @"candlesNumber: 15
                makeNew: 5
                Expected Output: 18",
                @"candlesNumber: 14
                makeNew: 3
                Expected Output: 20",
                @"candlesNumber: 12
                makeNew: 2
                Expected Output: 23",
                @"candlesNumber: 6
                makeNew: 4
                Expected Output: 7",
                @"candlesNumber: 13
                makeNew: 5
                Expected Output: 16",
                @"candlesNumber: 2
                makeNew: 3
                Expected Output: 2"
            );
        }
        /*
            Imported: 2020-05-02 20:41
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/loop-tunnel/RcK4vupi8sFhakjnh
        */
        [Test]
        public void countBlackCells()
        {
            Test.Execute(typeof(countBlackCellsClass),
                @"n: 3
                m: 4
                Expected Output: 6",
                @"n: 3
                m: 3
                Expected Output: 7",
                @"n: 2
                m: 5
                Expected Output: 6",
                @"n: 1
                m: 1
                Expected Output: 1",
                @"n: 1
                m: 2
                Expected Output: 2",
                @"n: 1
                m: 3
                Expected Output: 3",
                @"n: 1
                m: 239
                Expected Output: 239",
                @"n: 33
                m: 44
                Expected Output: 86",
                @"n: 16
                m: 8
                Expected Output: 30",
                @"n: 66666
                m: 88888
                Expected Output: 177774"
            );
        }
    }
}
