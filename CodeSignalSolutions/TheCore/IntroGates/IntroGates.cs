/*
    Imported:   2020-05-02 12:07
    Created By: Casper
    Url:        https://app.codesignal.com/arcade/code-arcade
*/
using NUnit.Framework;
using CodeSignalSolutions;
using CodeSignalSolutions.TheCore.IntroGates;

namespace TheCore
{
    public class IntroGates
    {
        /*
            Imported: 2020-05-02 12:07
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/intro-gates/wAGdN6FMPkx7WBq66
        */
        [Test]
        public void addTwoDigits()
        {
            Test.Execute(typeof(addTwoDigitsClass),
                @"n: 29
                Expected Output: 11",
                @"n: 48
                Expected Output: 12",
                @"n: 10
                Expected Output: 1",
                @"n: 25
                Expected Output: 7",
                @"n: 52
                Expected Output: 7",
                @"n: 99
                Expected Output: 18",
                @"n: 44
                Expected Output: 8",
                @"n: 50
                Expected Output: 5",
                @"n: 39
                Expected Output: 12",
                @"n: 26
                Expected Output: 8"
            );
        }
        /*
            Imported: 2020-05-02 12:07
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/intro-gates/SZB5XypsMokGusDhX
        */
        [Test]
        public void largestNumber()
        {
            Test.Execute(typeof(largestNumberClass),
                @"n: 2
                Expected Output: 99",
                @"n: 1
                Expected Output: 9",
                @"n: 7
                Expected Output: 9999999",
                @"n: 4
                Expected Output: 9999",
                @"n: 3
                Expected Output: 999"
            );
        }
        /*
            Imported: 2020-05-02 12:07
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/intro-gates/DdNKFA3XCX6XN7bNz
        */
        [Test]
        public void candies()
        {
            Test.Execute(typeof(candiesClass),
                @"n: 3
                m: 10
                Expected Output: 9",
                @"n: 1
                m: 2
                Expected Output: 2",
                @"n: 10
                m: 5
                Expected Output: 0",
                @"n: 4
                m: 4
                Expected Output: 4",
                @"n: 4
                m: 15
                Expected Output: 12",
                @"n: 9
                m: 100
                Expected Output: 99",
                @"n: 8
                m: 2
                Expected Output: 0",
                @"n: 3
                m: 3
                Expected Output: 3",
                @"n: 7
                m: 10
                Expected Output: 7",
                @"n: 3
                m: 23
                Expected Output: 21"
            );
        }
        /*
            Imported: 2020-05-02 12:07
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/intro-gates/bszFiQAog96G9CXKg
        */
        [Test]
        public void seatsInTheater()
        {
            Test.Execute(typeof(seatsInTheaterClass),
                @"nCols: 16
                nRows: 11
                col: 5
                row: 3
                Expected Output: 96",
                @"nCols: 1
                nRows: 1
                col: 1
                row: 1
                Expected Output: 0",
                @"nCols: 13
                nRows: 6
                col: 8
                row: 3
                Expected Output: 18",
                @"nCols: 60
                nRows: 100
                col: 60
                row: 1
                Expected Output: 99",
                @"nCols: 1000
                nRows: 1000
                col: 1000
                row: 1000
                Expected Output: 0"
            );
        }
        /*
            Imported: 2020-05-02 12:08
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/intro-gates/HEsmEacHr2s9wahjr
        */
        [Test]
        public void maxMultiple()
        {
            Test.Execute(typeof(maxMultipleClass),
                @"divisor: 3
                bound: 10
                Expected Output: 9",
                @"divisor: 2
                bound: 7
                Expected Output: 6",
                @"divisor: 10
                bound: 50
                Expected Output: 50",
                @"divisor: 7
                bound: 100
                Expected Output: 98",
                @"divisor: 7
                bound: 20
                Expected Output: 14",
                @"divisor: 5
                bound: 13
                Expected Output: 10",
                @"divisor: 8
                bound: 88
                Expected Output: 88",
                @"divisor: 10
                bound: 100
                Expected Output: 100",
                @"divisor: 2
                bound: 5
                Expected Output: 4",
                @"divisor: 3
                bound: 5
                Expected Output: 3",
                @"divisor: 9
                bound: 11
                Expected Output: 9",
                @"divisor: 8
                bound: 15
                Expected Output: 8",
                @"divisor: 9
                bound: 60
                Expected Output: 54"
            );
        }
        /*
            Imported: 2020-05-02 12:08
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/intro-gates/vExYvcGnFsEYSt8nQ
        */
        [Test]
        public void circleOfNumbers()
        {
            Test.Execute(typeof(circleOfNumbersClass),
                @"n: 10
                firstNumber: 2
                Expected Output: 7",
                @"n: 10
                firstNumber: 7
                Expected Output: 2",
                @"n: 4
                firstNumber: 1
                Expected Output: 3",
                @"n: 6
                firstNumber: 3
                Expected Output: 0",
                @"n: 18
                firstNumber: 6
                Expected Output: 15",
                @"n: 12
                firstNumber: 10
                Expected Output: 4",
                @"n: 18
                firstNumber: 5
                Expected Output: 14"
            );
        }
        /*
            Imported: 2020-05-02 12:08
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/intro-gates/aiKck9MwwAKyF8D4L
        */
        [Test]
        public void lateRide()
        {
            Test.Execute(typeof(lateRideClass),
                @"n: 240
                Expected Output: 4",
                @"n: 808
                Expected Output: 14",
                @"n: 1439
                Expected Output: 19",
                @"n: 0
                Expected Output: 0",
                @"n: 23
                Expected Output: 5",
                @"n: 8
                Expected Output: 8"
            );
        }
        /*
            Imported: 2020-05-02 12:08
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/intro-gates/mZAucMXhNMmT7JWta
        */
        [Test]
        public void phoneCall()
        {
            Test.Execute(typeof(phoneCallClass),
                @"min1: 3
                min2_10: 1
                min11: 2
                s: 20
                Expected Output: 14",
                @"min1: 2
                min2_10: 2
                min11: 1
                s: 2
                Expected Output: 1",
                @"min1: 10
                min2_10: 1
                min11: 2
                s: 22
                Expected Output: 11",
                @"min1: 2
                min2_10: 2
                min11: 1
                s: 24
                Expected Output: 14",
                @"min1: 1
                min2_10: 2
                min11: 1
                s: 6
                Expected Output: 3",
                @"min1: 10
                min2_10: 10
                min11: 10
                s: 8
                Expected Output: 0"
            );
        }
    }
}
