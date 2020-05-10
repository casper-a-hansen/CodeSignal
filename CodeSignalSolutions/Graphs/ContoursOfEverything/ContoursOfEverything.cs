/*
    Imported:   2020-05-04 22:59
    Created By: Casper
    Url:        https://app.codesignal.com/arcade/graphs-arcade
*/
using NUnit.Framework;
using CodeSignalSolutions;
using CodeSignalSolutions.Graphs.ContoursOfEverything;

namespace Graphs
{
    public class ContoursOfEverything
    {
        /*
            Imported: 2020-05-04 22:59
            By:       Casper
            Url:      https://app.codesignal.com/arcade/graphs-arcade/contours-of-everything/shHv7RjLBCrDFN3np
        */
        [Test]
        public void isButterfly()
        {
            Test.Execute(typeof(isButterflyClass),
                @"adj:
                [[false,true,true,false,false],
                 [true,false,true,false,false],
                 [true,true,false,true,true],
                 [false,false,true,false,true],
                 [false,false,true,true,false]]
                Expected Output: true",
                @"adj:
                [[false,true,true,true,true],
                 [true,false,true,false,false],
                 [true,true,false,false,false],
                 [true,false,false,false,true],
                 [true,false,false,true,false]]
                Expected Output: true",
                @"adj:
                [[false,false,false,false,false],
                 [false,false,true,true,false],
                 [false,true,false,false,true],
                 [false,true,false,false,true],
                 [false,false,true,true,false]]
                Expected Output: false",
                @"adj:
                [[false,true,true,false,false],
                 [true,false,true,false,false],
                 [true,true,true,true,false],
                 [false,false,true,false,true],
                 [false,false,false,true,true]]
                Expected Output: false",
                @"adj:
                [[false,true,true,false,false],
                 [true,false,true,false,false],
                 [true,true,false,false,false],
                 [false,false,false,true,true],
                 [false,false,false,true,true]]
                Expected Output: false",
                @"adj:
                [[false,true,true,true,true],
                 [true,false,true,false,false],
                 [true,true,false,false,false],
                 [true,false,false,true,true],
                 [true,false,false,true,true]]
                Expected Output: false",
                @"adj:
                [[false,true,true,true,true],
                 [true,false,true,true,true],
                 [true,true,false,true,true],
                 [true,true,true,false,true],
                 [true,true,true,true,false]]
                Expected Output: false",
                @"adj:
                [[false,false,false,false,false],
                 [false,false,false,false,false],
                 [false,false,false,false,false],
                 [false,false,false,false,false],
                 [false,false,false,false,false]]
                Expected Output: false",
                @"adj:
                [[false,true,true,false,false],
                 [true,false,false,false,true],
                 [true,false,false,true,false],
                 [false,false,true,false,true],
                 [false,true,false,true,false]]
                Expected Output: false",
                @"adj:
                [[false,true,true,true,true],
                 [true,false,false,true,false],
                 [true,false,false,false,true],
                 [true,true,false,false,false],
                 [true,false,true,false,false]]
                Expected Output: true"
            );
        }
        /*
            Imported: 2020-05-10 12:52
            By:       Casper
            Url:      https://app.codesignal.com/arcade/graphs-arcade/contours-of-everything/3QCs2Td5vzj8sorAR
        */
        [Test]
        public void countStars()
        {
            Test.Execute(typeof(countStarsClass),
                @"adj:
                [[false,true,false,false,false],
                 [true,false,false,false,false],
                 [false,false,false,true,false],
                 [false,false,true,false,false],
                 [false,false,false,false,false]]
                Expected Output: 2",
                @"adj:
                [[false,true,false,false,false],
                 [true,false,false,false,false],
                 [false,false,false,true,false],
                 [false,false,true,false,false],
                 [false,false,false,false,true]]
                Expected Output: 2",
                @"adj:
                [[false,false,false,false,false],
                 [false,false,false,false,false],
                 [false,false,false,false,false],
                 [false,false,false,false,false],
                 [false,false,false,false,false]]
                Expected Output: 0",
                @"adj:
                [[false,true,true,true,true,true,true,true],
                 [true,false,false,false,false,false,false,false],
                 [true,false,false,false,false,false,false,false],
                 [true,false,false,false,false,false,false,false],
                 [true,false,false,false,false,false,false,false],
                 [true,false,false,false,false,false,false,false],
                 [true,false,false,false,false,false,false,false],
                 [true,false,false,false,false,false,false,false]]
                Expected Output: 1",
                @"adj:
                [[false,false,false,false,false,true,false,true,false],
                 [false,false,false,false,false,false,false,false,true],
                 [false,false,false,true,false,false,true,false,false],
                 [false,false,true,false,false,false,false,false,false],
                 [false,false,false,false,false,false,false,false,true],
                 [true,false,false,false,false,false,false,false,false],
                 [false,false,true,false,false,false,false,false,false],
                 [true,false,false,false,false,false,false,false,false],
                 [false,true,false,false,true,false,false,false,false]]
                Expected Output: 3",
                @"adj: [[false,true,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false],
                [true,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false],
                [false,false,false,true,true,false,false,false,false,false,false,false,false,false,false,false,false,false,false],
                [false,false,true,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false],
                [false,false,true,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false],
                [false,false,false,false,false,false,true,true,true,false,false,false,false,false,false,false,false,false,false],
                [false,false,false,false,false,true,false,false,false,false,false,false,false,false,false,false,false,false,false],
                [false,false,false,false,false,true,false,false,false,false,false,false,false,false,false,false,false,false,false],
                [false,false,false,false,false,true,false,false,false,false,false,false,false,false,false,false,false,false,false],
                [false,false,false,false,false,false,false,false,false,false,true,false,false,false,false,false,false,false,false],
                [false,false,false,false,false,false,false,false,false,true,false,false,false,false,false,false,false,false,false],
                [false,false,false,false,false,false,false,false,false,false,false,false,true,true,false,false,false,false,false],
                [false,false,false,false,false,false,false,false,false,false,false,true,false,true,false,false,false,false,false],
                [false,false,false,false,false,false,false,false,false,false,false,true,true,false,false,false,false,false,false],
                [false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,true,true,true,true],
                [false,false,false,false,false,false,false,false,false,false,false,false,false,false,true,false,true,false,true],
                [false,false,false,false,false,false,false,false,false,false,false,false,false,false,true,true,false,true,false],
                [false,false,false,false,false,false,false,false,false,false,false,false,false,false,true,false,true,false,true],
                [false,false,false,false,false,false,false,false,false,false,false,false,false,false,true,true,false,true,false]]
                Expected Output: 4",
                @"adj:
                [[false,true,false,false,false,false,false,false],
                 [true,false,true,true,true,true,true,true],
                 [false,true,false,false,false,false,false,false],
                 [false,true,false,false,false,false,false,false],
                 [false,true,false,false,false,false,false,false],
                 [false,true,false,false,false,false,false,false],
                 [false,true,false,false,false,false,false,true],
                 [false,true,false,false,false,false,true,false]]
                Expected Output: 0",
                @"adj: [[false,false,false,true,false,false,false,false,false,false,false,false,false],
                [false,false,false,false,false,false,false,false,false,false,false,false,false],
                [false,false,false,false,false,true,false,false,false,false,false,false,false],
                [true,false,false,false,false,false,false,false,false,false,false,false,false],
                [false,false,false,false,false,true,false,false,false,false,false,false,false],
                [false,false,true,false,true,false,true,false,false,false,true,false,false],
                [false,false,false,false,false,true,false,false,false,false,false,false,false],
                [false,false,false,false,false,false,false,false,false,true,false,false,false],
                [false,false,false,false,false,false,false,false,false,false,false,false,false],
                [false,false,false,false,false,false,false,true,false,false,false,false,false],
                [false,false,false,false,false,true,false,false,false,false,false,false,false],
                [false,false,false,false,false,false,false,false,false,false,false,false,false],
                [false,false,false,false,false,false,false,false,false,false,false,false,false]]
                Expected Output: 3",
                @"adj: [[false,false,false,false,false,false,false,false,false,false,false,false,false],
                [false,false,false,false,false,false,false,false,false,false,false,false,false],
                [false,false,false,true,true,true,false,false,false,false,false,false,false],
                [false,false,true,false,true,true,false,false,false,false,false,false,false],
                [false,false,true,true,false,true,false,false,false,false,false,false,false],
                [false,false,true,true,true,false,false,false,false,false,false,false,false],
                [false,false,false,false,false,false,false,true,false,false,false,false,false],
                [false,false,false,false,false,false,true,false,true,false,false,false,false],
                [false,false,false,false,false,false,false,true,false,true,false,false,false],
                [false,false,false,false,false,false,false,false,true,false,true,true,false],
                [false,false,false,false,false,false,false,false,false,true,false,true,false],
                [false,false,false,false,false,false,false,false,false,true,true,false,false],
                [false,false,false,false,false,false,false,false,false,false,false,false,false]]
                Expected Output: 0",
                @"adj:
                [[false,true,false,false,false,false,false,false],
                 [true,false,true,true,true,true,true,true],
                 [false,true,false,false,false,false,false,false],
                 [false,true,false,false,false,false,false,false],
                 [false,true,false,false,false,false,false,false],
                 [false,true,false,false,false,false,false,false],
                 [false,true,false,false,false,false,false,false],
                 [false,true,false,false,false,false,false,false]]
                Expected Output: 1",
                @"adj:
                [[false,true,true,false,false,false,false,false,false],
                 [true,false,false,false,false,false,false,false,false],
                 [true,false,false,false,false,false,false,false,false],
                 [false,false,false,false,true,true,false,false,false],
                 [false,false,false,true,false,false,false,false,false],
                 [false,false,false,true,false,false,false,false,false],
                 [false,false,false,false,false,false,false,true,true],
                 [false,false,false,false,false,false,true,false,false],
                 [false,false,false,false,false,false,true,false,false]]
                Expected Output: 3",
                @"adj:
                [[false,false,false,true,true,false,false,false,true,false],
                 [false,false,true,false,true,false,false,true,false,false],
                 [false,true,false,false,true,false,false,false,false,true],
                 [true,false,false,false,true,false,true,false,false,false],
                 [true,true,true,true,false,true,true,true,true,true],
                 [false,false,false,false,true,false,false,false,true,true],
                 [false,false,false,true,true,false,false,true,false,false],
                 [false,true,false,false,true,false,true,false,false,false],
                 [true,false,false,false,true,true,false,false,false,false],
                 [false,false,true,false,true,true,false,false,false,false]]
                Expected Output: 0",
                @"adj:
                [[false,false,false,true,false,false],
                 [false,false,true,false,false,true],
                 [false,true,false,false,false,true],
                 [true,false,false,false,false,false],
                 [false,false,false,false,false,true],
                 [false,true,true,false,true,false]]
                Expected Output: 1"
            );
        }
        /*
            Imported: 2020-05-10 12:52
            By:       Casper
            Url:      https://app.codesignal.com/arcade/graphs-arcade/contours-of-everything/ZCzzBYpY8W5BPnNyb
        */
        [Test]
        public void isWheel()
        {
            Test.Execute(typeof(isWheelClass),
                @"adj:
                [[false,true,true,true,true],
                 [true,false,true,false,true],
                 [true,true,false,true,false],
                 [true,false,true,false,true],
                 [true,true,false,true,false]]
                Expected Output: true",
                @"adj:
                [[false,true,true,true],
                 [true,false,true,true],
                 [true,true,false,true],
                 [true,true,true,false]]
                Expected Output: true",
                @"adj:
                [[false,true,true,true,true],
                 [true,false,true,true,true],
                 [true,true,false,true,true],
                 [true,true,true,false,true],
                 [true,true,true,true,false]]
                Expected Output: false",
                @"adj:
                [[false,true,true,true,true,true],
                 [true,false,true,false,false,true],
                 [true,true,false,true,false,false],
                 [true,false,true,false,true,false],
                 [true,false,false,true,true,false],
                 [true,true,false,false,false,true]]
                Expected Output: false",
                @"adj:
                [[false,true,true,false,true],
                 [true,false,true,true,true],
                 [true,true,false,true,false],
                 [false,true,true,false,true],
                 [true,true,false,true,false]]
                Expected Output: true",
                @"adj:
                [[false,true,true,true,false,false,false,false],
                 [true,false,true,true,false,false,false,false],
                 [true,true,false,true,false,false,false,false],
                 [true,true,true,false,false,false,false,false],
                 [false,false,false,false,false,true,true,false],
                 [false,false,false,false,true,false,true,true],
                 [false,false,false,false,true,true,false,true],
                 [false,false,false,false,false,true,true,false]]
                Expected Output: false",
                @"adj:
                [[false,true,true,true,true,true,true,true,true,true],
                 [true,false,true,false,false,false,false,false,false,true],
                 [true,true,false,true,false,false,false,false,false,false],
                 [true,false,true,false,true,false,false,false,false,false],
                 [true,false,false,true,false,true,false,false,false,false],
                 [true,false,false,false,true,false,true,false,false,false],
                 [true,false,false,false,false,true,false,true,false,false],
                 [true,false,false,false,false,false,true,false,true,false],
                 [true,false,false,false,false,false,false,true,false,true],
                 [true,true,false,false,false,false,false,false,true,false]]
                Expected Output: true",
                @"adj:
                [[false,true,true,true,true,true,true],
                 [true,false,true,false,false,false,true],
                 [true,true,false,true,false,false,false],
                 [true,false,true,false,true,false,false],
                 [true,false,false,true,false,true,false],
                 [true,false,false,false,true,false,true],
                 [true,true,false,false,false,true,true]]
                Expected Output: false",
                @"adj:
                [[false,true,true,true,false,false,false,false],
                 [true,false,true,false,false,false,false,true],
                 [true,true,false,true,true,true,true,true],
                 [true,false,true,false,false,false,true,false],
                 [false,false,true,false,false,true,false,true],
                 [false,false,true,false,true,false,true,false],
                 [false,false,true,true,false,true,false,false],
                 [false,true,true,false,true,false,false,false]]
                Expected Output: true",
                @"adj:
                [[false,true,true,true,true],
                 [true,false,true,true,false],
                 [true,true,false,true,false],
                 [true,true,true,false,false],
                 [true,false,false,false,false]]
                Expected Output: false",
                @"adj:
                [[false,true,false,true,true,false],
                 [true,false,true,false,false,true],
                 [false,true,false,true,false,true],
                 [true,false,true,false,true,false],
                 [true,false,false,true,false,true],
                 [false,true,true,false,true,false]]
                Expected Output: false"
            );
        }
        /*
            Imported: 2020-05-10 12:52
            By:       Casper
            Url:      https://app.codesignal.com/arcade/graphs-arcade/contours-of-everything/5DmC8isJ3GBRcMJo2
        */
        [Test]
        public void isBook()
        {
            Test.Execute(typeof(isBookClass),
                @"adj:
                [[false,true,true,true],
                 [true,false,true,true],
                 [true,true,false,false],
                 [true,true,false,false]]
                Expected Output: true",
                @"adj:
                [[false,true],
                 [true,false]]
                Expected Output: true",
                @"adj:
                [[false,false,true,true,true],
                 [false,false,false,true,true],
                 [true,false,false,true,true],
                 [true,true,true,false,true],
                 [true,true,true,true,false]]
                Expected Output: false",
                @"adj:
                [[false,true,false,false,false,false,true,false,false,false],
                 [true,false,true,true,true,true,true,true,true,true],
                 [false,true,false,false,false,false,true,false,false,false],
                 [false,true,false,false,false,false,true,false,false,false],
                 [false,true,false,false,false,false,true,false,false,false],
                 [false,true,false,false,false,false,true,false,false,false],
                 [true,true,true,true,true,true,false,true,true,true],
                 [false,true,false,false,false,false,true,false,false,false],
                 [false,true,false,false,false,false,true,false,false,false],
                 [false,true,false,false,false,false,true,false,false,false]]
                Expected Output: true",
                @"adj:
                [[false,false,false,true,true],
                 [false,false,false,true,true],
                 [false,false,false,true,true],
                 [true,true,true,false,true],
                 [true,true,true,true,true]]
                Expected Output: false",
                @"adj:
                [[false,true,true,true,true,true],
                 [true,false,false,false,true,false],
                 [true,false,false,false,true,false],
                 [true,false,false,false,true,false],
                 [true,true,true,true,false,true],
                 [true,false,false,false,true,false]]
                Expected Output: true",
                @"adj:
                [[false,true,true,false],
                 [true,false,false,true],
                 [true,false,false,true],
                 [false,true,true,false]]
                Expected Output: false",
                @"adj:
                [[false,false,false,true,true],
                 [false,false,false,true,true],
                 [false,false,false,true,true],
                 [true,true,true,false,true],
                 [true,true,true,true,false]]
                Expected Output: true",
                @"adj:
                [[false,false],
                 [false,false]]
                Expected Output: false",
                @"adj:
                [[false,false,true],
                 [false,false,true],
                 [true,true,false]]
                Expected Output: false",
                @"adj:
                [[false,true,true],
                 [true,false,true],
                 [true,true,false]]
                Expected Output: true"
            );
        }
        /*
            Imported: 2020-05-10 12:53
            By:       Casper
            Url:      https://app.codesignal.com/arcade/graphs-arcade/contours-of-everything/PmSaQEhfNqCPFfGrW
        */
        [Test]
        public void isBull()
        {
            Test.Execute(typeof(isBullClass),
                @"adj:
                [[false,true,false,false,false],
                 [true,false,true,true,false],
                 [false,true,false,true,false],
                 [false,true,true,false,true],
                 [false,false,false,true,false]]
                Expected Output: true",
                @"adj:
                [[false,true,true,true,false],
                 [true,false,true,false,false],
                 [true,true,false,false,false],
                 [true,false,false,false,true],
                 [false,false,false,true,false]]
                Expected Output: true",
                @"adj:
                [[false,true,true,false,false],
                 [true,false,true,true,true],
                 [true,true,false,false,false],
                 [false,true,false,false,true],
                 [false,true,false,true,false]]
                Expected Output: false",
                @"adj:
                [[false,true,true,false,false],
                 [true,true,false,true,false],
                 [true,false,false,false,false],
                 [false,true,false,false,true],
                 [false,false,false,true,false]]
                Expected Output: false",
                @"adj:
                [[false,false,true,false,false],
                 [false,false,true,false,false],
                 [true,true,false,true,true],
                 [false,false,true,false,true],
                 [false,false,true,true,false]]
                Expected Output: true",
                @"adj:
                [[false,true,false,false,false],
                 [true,false,true,false,false],
                 [false,true,false,true,false],
                 [false,false,true,false,true],
                 [false,false,false,true,false]]
                Expected Output: false",
                @"adj:
                [[false,true,false,false,false],
                 [true,false,false,false,false],
                 [false,false,false,true,false],
                 [false,false,true,false,true],
                 [false,false,false,true,false]]
                Expected Output: false",
                @"adj:
                [[false,true,true,false,false],
                 [true,false,true,true,false],
                 [true,true,false,false,true],
                 [false,true,false,false,false],
                 [false,false,true,false,false]]
                Expected Output: true",
                @"adj:
                [[false,false,false,false,false],
                 [false,false,false,false,false],
                 [false,false,false,false,false],
                 [false,false,false,false,false],
                 [false,false,false,false,false]]
                Expected Output: false",
                @"adj:
                [[false,false,false,false,true],
                 [false,false,true,true,true],
                 [false,true,false,false,false],
                 [false,true,false,false,true],
                 [true,true,false,true,false]]
                Expected Output: true",
                @"adj:
                [[false,false,true,true,false],
                 [false,false,false,true,true],
                 [true,false,false,false,false],
                 [true,true,false,false,true],
                 [false,true,false,true,false]]
                Expected Output: true",
                @"adj:
                [[false,true,true,false,true],
                 [true,false,false,true,true],
                 [true,false,false,false,false],
                 [false,true,false,false,false],
                 [true,true,false,false,false]]
                Expected Output: true",
                @"adj:
                [[false,true,true,false,true],
                 [true,false,true,true,true],
                 [true,true,false,false,false],
                 [false,true,false,false,false],
                 [true,true,false,false,false]]
                Expected Output: false",
                @"adj:
                [[false,true,false,true,false],
                 [true,false,false,true,false],
                 [false,false,false,true,false],
                 [true,true,true,false,true],
                 [false,false,false,true,false]]
                Expected Output: true",
                @"adj:
                [[false,true,true,true,true],
                 [true,false,false,false,false],
                 [true,false,false,true,false],
                 [true,false,true,false,false],
                 [true,false,false,false,false]]
                Expected Output: true",
                @"adj:
                [[false,true,true,false,false],
                 [true,false,true,true,true],
                 [true,true,false,false,false],
                 [false,true,false,false,false],
                 [false,true,false,false,false]]
                Expected Output: true"
            );
        }
        /*
            Imported: 2020-05-10 12:53
            By:       Casper
            Url:      https://app.codesignal.com/arcade/graphs-arcade/contours-of-everything/jDf7ARdM9wYZLB28w
        */
        [Test]
        public void isTadpole()
        {
            Test.Execute(typeof(isTadpoleClass),
                @"adj:
                [[false,true,true,false,false],
                 [true,false,false,true,false],
                 [true,false,false,true,false],
                 [false,true,true,false,true],
                 [false,false,false,true,false]]
                Expected Output: true",
                @"adj:
                [[false,true,false,false],
                 [true,false,true,true],
                 [false,true,false,true],
                 [false,true,true,false]]
                Expected Output: true",
                @"adj:
                [[false,true,true,false,false],
                 [true,false,false,true,false],
                 [true,false,false,true,false],
                 [false,true,true,false,true],
                 [false,false,false,true,true]]
                Expected Output: false",
                @"adj:
                [[false,false,true,false,false,false],
                 [false,false,true,false,true,false],
                 [true,true,false,false,false,true],
                 [false,false,false,false,true,true],
                 [false,true,false,true,false,false],
                 [false,false,true,true,false,false]]
                Expected Output: true",
                @"adj:
                [[false,true,false,true,true,true],
                 [true,false,true,false,false,false],
                 [false,true,false,true,false,false],
                 [true,false,true,false,true,false],
                 [true,false,false,true,false,false],
                 [true,false,false,false,false,false]]
                Expected Output: false",
                @"adj: [[false,true,false,false,false,false,false,false,false,false,false,false,false],
                [true,false,true,false,false,false,false,false,false,false,false,false,false],
                [false,true,false,true,false,false,false,false,false,false,false,false,false],
                [false,false,true,false,true,false,false,false,false,false,false,false,false],
                [false,false,false,true,false,true,false,false,false,false,false,false,false],
                [false,false,false,false,true,false,true,false,false,false,false,false,false],
                [false,false,false,false,false,true,false,true,false,false,false,false,false],
                [false,false,false,false,false,false,true,false,true,false,false,false,false],
                [false,false,false,false,false,false,false,true,false,true,true,false,false],
                [false,false,false,false,false,false,false,false,true,false,false,true,false],
                [false,false,false,false,false,false,false,false,true,false,false,false,true],
                [false,false,false,false,false,false,false,false,false,true,false,false,true],
                [false,false,false,false,false,false,false,false,false,false,true,true,false]]
                Expected Output: true",
                @"adj:
                [[false,true,false,false],
                 [true,false,true,false],
                 [false,true,false,true],
                 [false,false,true,false]]
                Expected Output: false",
                @"adj:
                [[false,true,false,false,true],
                 [true,false,true,false,false],
                 [false,true,false,true,false],
                 [false,false,true,false,true],
                 [true,false,false,true,false]]
                Expected Output: false",
                @"adj:
                [[false,true,false,false,true,true],
                 [true,false,true,false,false,false],
                 [false,true,false,true,false,false],
                 [false,false,true,false,true,false],
                 [true,false,false,true,false,false],
                 [true,false,false,false,false,false]]
                Expected Output: true",
                @"adj:
                [[false,true,true,false,false,false,false,false],
                 [true,false,true,false,false,false,false,false],
                 [true,true,false,false,false,false,false,false],
                 [false,false,false,false,true,true,false,false],
                 [false,false,false,true,false,true,false,false],
                 [false,false,false,true,true,false,true,false],
                 [false,false,false,false,false,true,false,true],
                 [false,false,false,false,false,false,true,false]]
                Expected Output: false"
            );
        }
        /*
            Imported: 2020-05-10 12:53
            By:       Casper
            Url:      https://app.codesignal.com/arcade/graphs-arcade/contours-of-everything/gLs2qAzAGivaxYSAq
        */
        [Test]
        public void isFlower()
        {
            Test.Execute(typeof(isFlowerClass),
                @"adj:
                [[false,true,true,true,true],
                 [true,false,true,false,false],
                 [true,true,false,false,false],
                 [true,false,false,false,true],
                 [true,false,false,true,false]]
                Expected Output: true",
                @"adj:
                [[false,true,true],
                 [true,false,true],
                 [true,true,false]]
                Expected Output: true",
                @"adj:
                [[false,true,true,true,true],
                 [true,false,true,true,true],
                 [true,true,false,true,true],
                 [true,true,true,false,true],
                 [true,true,true,true,false]]
                Expected Output: true",
                @"adj:
                [[false,true,true,true,true,true],
                 [true,false,true,false,false,true],
                 [true,true,false,true,false,false],
                 [true,false,true,false,true,false],
                 [true,false,false,true,true,false],
                 [true,true,false,false,false,true]]
                Expected Output: false",
                @"adj:
                [[false,true,true,true,true,true],
                 [true,false,true,false,false,true],
                 [true,true,false,false,false,true],
                 [true,false,false,false,true,false],
                 [true,false,false,true,false,false],
                 [true,true,true,false,false,false]]
                Expected Output: false",
                @"adj:
                [[false,false,false,false,false],
                 [false,false,false,false,false],
                 [false,false,false,false,false],
                 [false,false,false,false,false],
                 [false,false,false,false,false]]
                Expected Output: false",
                @"adj:
                [[false,true,true,true,true,true,true],
                 [true,false,true,false,false,false,false],
                 [true,true,false,false,false,false,false],
                 [true,false,false,false,true,false,false],
                 [true,false,false,true,false,false,false],
                 [true,false,false,false,false,false,true],
                 [true,false,false,false,false,true,false]]
                Expected Output: true",
                @"adj:
                [[false,false,false,true,true,false,false],
                 [false,false,true,false,true,false,false],
                 [false,true,false,false,true,false,false],
                 [true,false,false,false,true,false,false],
                 [true,true,true,true,false,true,true],
                 [false,false,false,false,true,false,true],
                 [false,false,false,false,true,true,false]]
                Expected Output: true",
                @"adj:
                [[false,false,true,false,false,false,false,true,false,false],
                 [false,false,false,false,false,false,false,false,false,false],
                 [true,false,false,false,false,false,false,true,false,false],
                 [false,false,false,false,false,false,false,false,false,false],
                 [false,false,false,false,false,false,false,true,true,true],
                 [false,false,false,false,false,false,false,false,false,false],
                 [false,false,false,false,false,false,false,false,false,false],
                 [true,false,true,false,true,false,false,false,true,false],
                 [false,false,false,false,true,false,false,true,false,true],
                 [false,false,false,false,true,false,false,false,true,false]]
                Expected Output: false",
                @"adj:
                [[false,true,true,true,true,true,true,true,true,true],
                 [true,false,true,true,false,false,false,false,false,false],
                 [true,true,false,true,false,false,false,false,false,false],
                 [true,true,true,false,false,false,false,false,false,false],
                 [true,false,false,false,false,true,true,false,false,false],
                 [true,false,false,false,true,false,true,false,false,false],
                 [true,false,false,false,true,true,false,false,false,false],
                 [true,false,false,false,false,false,false,false,true,true],
                 [true,false,false,false,false,false,false,true,false,true],
                 [true,false,false,false,false,false,false,true,true,false]]
                Expected Output: true",
                @"adj:
                [[false,true,true,true],
                 [true,false,true,true],
                 [true,true,false,false],
                 [true,true,false,false]]
                Expected Output: false",
                @"adj:
                [[false,true,true,true,true,true,true],
                 [true,false,false,false,false,true,true],
                 [true,false,false,true,true,false,false],
                 [true,false,true,false,false,true,false],
                 [true,false,true,false,false,false,true],
                 [true,true,false,true,false,false,false],
                 [true,true,false,false,true,false,false]]
                Expected Output: false",
                @"adj:
                [[false,true,true,false,false,false],
                 [true,false,true,true,false,false],
                 [true,true,false,true,false,false],
                 [false,true,true,false,true,true],
                 [false,false,false,true,false,true],
                 [false,false,false,true,true,false]]
                Expected Output: false",
                @"adj:
                [[false,true,true,false],
                 [true,false,false,true],
                 [true,false,false,true],
                 [false,true,true,false]]
                Expected Output: false",
                @"adj:
                [[false,false,false,true,false,true,true,false,false,false],
                 [false,false,false,false,false,false,true,true,true,false],
                 [false,false,false,false,true,false,true,false,false,true],
                 [true,false,false,false,false,true,true,false,false,false],
                 [false,false,true,false,false,false,true,false,false,true],
                 [true,false,false,true,false,false,true,false,false,false],
                 [true,true,true,true,true,true,false,true,true,true],
                 [false,true,false,false,false,false,true,false,true,false],
                 [false,true,false,false,false,false,true,true,false,false],
                 [false,false,true,false,true,false,true,false,false,false]]
                Expected Output: true",
                @"adj:
                [[false,true,true,true,true,true,true],
                 [true,false,true,false,false,false,false],
                 [true,true,false,false,false,false,false],
                 [true,false,false,false,true,true,true],
                 [true,false,false,true,false,true,true],
                 [true,false,false,true,true,false,true],
                 [true,false,false,true,true,true,false]]
                Expected Output: false",
                @"adj:
                [[false,true,false,true],
                 [true,false,true,false],
                 [false,true,false,true],
                 [true,false,true,false]]
                Expected Output: false",
                @"adj:
                [[false,false,true,false,false,false,false,false,false,false],
                 [false,false,true,true,false,false,false,false,false,false],
                 [true,true,false,true,false,false,false,false,false,false],
                 [false,true,true,false,true,true,false,false,false,false],
                 [false,false,false,true,false,true,false,false,false,false],
                 [false,false,false,true,true,false,false,false,false,false],
                 [false,false,false,false,false,false,false,false,false,false],
                 [false,false,false,false,false,false,false,false,false,false],
                 [false,false,false,false,false,false,false,false,false,false],
                 [false,false,false,false,false,false,false,false,false,false]]
                Expected Output: false"
            );
        }
        /*
            Imported: 2020-05-10 12:53
            By:       Casper
            Url:      https://app.codesignal.com/arcade/graphs-arcade/contours-of-everything/p7YetaqMPd8RSmSff
        */
        [Test]
        public void isCorrectlyCut()
        {
            Test.Execute(typeof(isCorrectlyCutClass),
                @"adj:
                [[false,true,false,false,false,true],
                 [true,false,true,false,false,false],
                 [false,true,false,true,false,false],
                 [false,false,true,false,true,false],
                 [false,false,false,true,false,true],
                 [true,false,false,false,true,false]]
                Expected Output: true",
                @"adj:
                [[false,true,true,false,false,false],
                 [true,false,true,false,false,false],
                 [true,true,false,false,false,false],
                 [false,false,false,false,true,true],
                 [false,false,false,true,false,true],
                 [false,false,false,true,true,false]]
                Expected Output: false",
                @"adj:
                [[false,true,true,false,false,true],
                 [true,false,false,true,true,false],
                 [true,false,false,true,true,false],
                 [false,true,true,false,false,true],
                 [false,true,true,false,false,true],
                 [true,false,false,true,true,false]]
                Expected Output: false",
                @"adj:
                [[false,true,false,false,false,true],
                 [true,false,true,false,true,false],
                 [false,true,false,false,false,true],
                 [false,false,false,false,false,true],
                 [false,true,false,false,false,true],
                 [true,false,true,true,true,false]]
                Expected Output: false",
                @"adj:
                [[false,true,false,true,false,false,false,true],
                 [true,false,true,false,false,false,true,false],
                 [false,true,false,true,false,true,false,false],
                 [true,false,true,false,true,false,false,false],
                 [false,false,false,true,false,true,false,true],
                 [false,false,true,false,true,false,true,false],
                 [false,true,false,false,false,true,false,true],
                 [true,false,false,false,true,false,true,false]]
                Expected Output: true",
                @"adj:
                [[false,false,false,false,false,false],
                 [false,false,false,false,false,false],
                 [false,false,false,false,false,false],
                 [false,false,false,false,false,false],
                 [false,false,false,false,false,false],
                 [false,false,false,false,false,false]]
                Expected Output: false",
                @"adj: [[false,true,false,false,false,true,false,false,false,false,false,false],
                [true,false,true,false,false,false,false,false,false,false,false,false],
                [false,true,false,true,false,false,false,false,false,false,false,false],
                [false,false,true,false,true,false,false,false,false,false,false,false],
                [false,false,false,true,false,true,false,false,false,false,false,false],
                [true,false,false,false,true,false,false,false,false,false,false,false],
                [false,false,false,false,false,false,false,true,false,false,false,true],
                [false,false,false,false,false,false,true,false,true,false,false,false],
                [false,false,false,false,false,false,false,true,false,true,false,false],
                [false,false,false,false,false,false,false,false,true,false,true,false],
                [false,false,false,false,false,false,false,false,false,true,false,true],
                [false,false,false,false,false,false,true,false,false,false,true,false]]
                Expected Output: false",
                @"adj: [[false,false,false,true,false,true,true,true,false,true,true,false,false,false],
                [false,false,false,false,false,true,true,true,false,true,true,false,true,false],
                [false,false,false,true,false,true,true,false,false,true,true,false,true,false],
                [true,false,true,false,true,false,false,false,true,false,false,true,false,true],
                [false,false,false,true,false,false,true,true,false,true,true,false,true,false],
                [true,true,true,false,false,false,false,false,true,false,false,true,false,true],
                [true,true,true,false,true,false,false,false,true,false,false,true,false,false],
                [true,true,false,false,true,false,false,false,true,false,false,true,false,true],
                [false,false,false,true,false,true,true,true,false,true,false,false,true,false],
                [true,true,true,false,true,false,false,false,true,false,false,false,false,true],
                [true,true,true,false,true,false,false,false,false,false,false,true,false,true],
                [false,false,false,true,false,true,true,true,false,false,true,false,true,false],
                [false,true,true,false,true,false,false,false,true,false,false,true,false,true],
                [false,false,false,true,false,true,false,true,false,true,true,false,true,false]]
                Expected Output: true",
                @"adj:
                [[false,false,false,false,false,false,true,true,true,true],
                 [false,false,false,false,false,true,false,true,true,true],
                 [false,false,false,false,false,true,true,false,true,true],
                 [false,false,false,false,false,true,true,true,false,true],
                 [false,false,false,false,false,true,true,true,true,false],
                 [false,true,true,true,true,false,false,false,false,false],
                 [true,false,true,true,true,false,false,false,false,false],
                 [true,true,false,true,true,false,false,false,false,false],
                 [true,true,true,false,true,false,false,false,false,false],
                 [true,true,true,true,false,false,false,false,false,false]]
                Expected Output: true",
                @"adj: [[false,false,false,false,false,false,false,false,false,false,true,true,true,true,true,true,true,true,true,true],
                [false,false,false,false,false,false,false,false,false,false,true,true,true,true,true,true,true,true,true,true],
                [false,false,false,false,false,false,false,false,false,false,true,true,true,true,true,true,true,true,true,true],
                [false,false,false,false,false,false,false,false,false,false,true,true,true,true,true,true,true,true,true,true],
                [false,false,false,false,false,false,false,false,false,false,true,true,true,true,true,true,true,true,true,true],
                [false,false,false,false,false,false,false,false,false,false,true,true,true,true,true,true,true,true,true,true],
                [false,false,false,false,false,false,false,false,false,false,true,true,true,true,true,true,true,true,true,true],
                [false,false,false,false,false,false,false,false,false,false,true,true,true,true,true,true,true,true,true,true],
                [false,false,false,false,false,false,false,false,false,false,true,true,true,true,true,true,true,true,true,true],
                [false,false,false,false,false,false,false,false,false,false,true,true,true,true,true,true,true,true,true,true],
                [true,true,true,true,true,true,true,true,true,true,false,false,false,false,false,false,false,false,false,false],
                [true,true,true,true,true,true,true,true,true,true,false,false,false,false,false,false,false,false,false,false],
                [true,true,true,true,true,true,true,true,true,true,false,false,false,false,false,false,false,false,false,false],
                [true,true,true,true,true,true,true,true,true,true,false,false,false,false,false,false,false,false,false,false],
                [true,true,true,true,true,true,true,true,true,true,false,false,false,false,false,false,false,false,false,false],
                [true,true,true,true,true,true,true,true,true,true,false,false,false,false,false,false,false,false,false,false],
                [true,true,true,true,true,true,true,true,true,true,false,false,false,false,false,false,false,false,false,false],
                [true,true,true,true,true,true,true,true,true,true,false,false,false,false,false,false,false,false,false,false],
                [true,true,true,true,true,true,true,true,true,true,false,false,false,false,false,false,false,false,false,false],
                [true,true,true,true,true,true,true,true,true,true,false,false,false,false,false,false,false,false,false,false]]
                Expected Output: false",
                @"adj: [[false,false,false,false,false,false,false,true,true,true,true,true],
                [false,false,false,false,false,false,true,false,true,true,true,true],
                [false,false,false,false,false,false,true,true,false,true,true,true],
                [false,false,false,false,false,false,true,true,true,false,true,true],
                [false,false,false,false,false,false,true,true,true,true,false,true],
                [false,false,false,false,false,false,true,true,true,true,true,false],
                [false,true,true,true,true,true,false,false,false,false,false,false],
                [true,false,true,true,true,true,false,false,false,false,false,false],
                [true,true,false,true,true,true,false,false,false,false,false,false],
                [true,true,true,false,true,true,false,false,false,false,false,false],
                [true,true,true,true,false,true,false,false,false,false,false,false],
                [true,true,true,true,true,false,false,false,false,false,false,false]]
                Expected Output: true",
                @"adj:
                [[true,true,false,false,false,false],
                 [true,false,true,false,false,false],
                 [false,true,false,true,false,false],
                 [false,false,true,false,true,false],
                 [false,false,false,true,false,true],
                 [false,false,false,false,true,true]]
                Expected Output: false",
                @"adj:
                [[false,false,false,false,true,true],
                 [false,false,false,true,false,true],
                 [false,false,false,true,true,false],
                 [false,true,true,false,false,false],
                 [true,false,true,false,false,false],
                 [true,true,false,false,false,false]]
                Expected Output: true",
                @"adj:
                [[false,false,false,true,true,true],
                 [false,false,false,true,true,true],
                 [false,false,false,true,true,true],
                 [true,true,true,false,false,false],
                 [true,true,true,false,false,false],
                 [true,true,true,false,false,false]]
                Expected Output: false",
                @"adj: [[false,true,false,false,true,true,false,true,false,false,true,false],
                [true,false,false,false,false,false,true,false,true,true,false,true],
                [false,false,false,true,true,true,false,true,false,false,true,false],
                [false,false,true,false,false,false,true,false,true,true,false,true],
                [true,false,true,false,false,false,true,false,false,true,false,true],
                [true,false,true,false,false,false,false,false,true,true,false,true],
                [false,true,false,true,true,false,false,true,false,false,true,false],
                [true,false,true,false,false,false,true,false,true,false,false,true],
                [false,true,false,true,false,true,false,true,false,false,true,false],
                [false,true,false,true,true,true,false,false,false,false,true,false],
                [true,false,true,false,false,false,true,false,true,true,false,false],
                [false,true,false,true,true,true,false,true,false,false,false,false]]
                Expected Output: true"
            );
        }
    }
}
