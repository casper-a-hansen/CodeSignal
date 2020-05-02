/*
    Imported:   2020-05-02 11:53
    Created By: Casper
    Url:        https://app.codesignal.com/arcade/intro
*/
using NUnit.Framework;
using CodeSignalSolutions;
using CodeSignalSolutions.Intro.EdgeOfTheOcean;

namespace Intro
{
    public class EdgeOfTheOcean
    {
        /*
            Imported: 2020-05-02 11:53
            By:       Casper
            Url:      https://app.codesignal.com/arcade/intro/level-2/xzKiBHjhoinnpdh6m
        */
        [Test]
        public void adjacentElementsProduct()
        {
            Test.Execute(typeof(adjacentElementsProductClass),
                @"inputArray: [3, 6, -2, -5, 7, 3]
                Expected Output: 21",
                @"inputArray: [-1, -2]
                Expected Output: 2",
                @"inputArray: [5, 1, 2, 3, 1, 4]
                Expected Output: 6",
                @"inputArray: [1, 2, 3, 0]
                Expected Output: 6",
                @"inputArray: [9, 5, 10, 2, 24, -1, -48]
                Expected Output: 50",
                @"inputArray: [5, 6, -4, 2, 3, 2, -23]
                Expected Output: 30",
                @"inputArray: [4, 1, 2, 3, 1, 5]
                Expected Output: 6",
                @"inputArray: [-23, 4, -3, 8, -12]
                Expected Output: -12",
                @"inputArray: [1, 0, 1, 0, 1000]
                Expected Output: 0"
            );
        }
        /*
            Imported: 2020-05-02 11:53
            By:       Casper
            Url:      https://app.codesignal.com/arcade/intro/level-2/yuGuHvcCaFCKk56rJ
        */
        [Test]
        public void shapeArea()
        {
            Test.Execute(typeof(shapeAreaClass),
                @"n: 2
                Expected Output: 5",
                @"n: 3
                Expected Output: 13",
                @"n: 1
                Expected Output: 1",
                @"n: 5
                Expected Output: 41",
                @"n: 7000
                Expected Output: 97986001",
                @"n: 8000
                Expected Output: 127984001",
                @"n: 9999
                Expected Output: 199940005",
                @"n: 9998
                Expected Output: 199900013",
                @"n: 8999
                Expected Output: 161946005",
                @"n: 100
                Expected Output: 19801"
            );
        }
        /*
            Imported: 2020-05-02 11:53
            By:       Casper
            Url:      https://app.codesignal.com/arcade/intro/level-2/bq2XnSr5kbHqpHGJC
        */
        [Test]
        public void makeArrayConsecutive2()
        {
            Test.Execute(typeof(makeArrayConsecutive2Class),
                @"statues: [6, 2, 3, 8]
                Expected Output: 3",
                @"statues: [0, 3]
                Expected Output: 2",
                @"statues: [5, 4, 6]
                Expected Output: 0",
                @"statues: [6, 3]
                Expected Output: 2",
                @"statues: [1]
                Expected Output: 0"
            );
        }
        /*
            Imported: 2020-05-02 11:53
            By:       Casper
            Url:      https://app.codesignal.com/arcade/intro/level-2/2mxbGwLzvkTCKAJMG
        */
        [Test]
        public void almostIncreasingSequence()
        {
            Test.Execute(typeof(almostIncreasingSequenceClass),
                @"sequence: [1, 3, 2, 1]
                Expected Output: false",
                @"sequence: [1, 3, 2]
                Expected Output: true",
                @"sequence: [1, 2, 1, 2]
                Expected Output: false",
                @"sequence: [3, 6, 5, 8, 10, 20, 15]
                Expected Output: false",
                @"sequence: [1, 1, 2, 3, 4, 4]
                Expected Output: false",
                @"sequence: [1, 4, 10, 4, 2]
                Expected Output: false",
                @"sequence: [10, 1, 2, 3, 4, 5]
                Expected Output: true",
                @"sequence: [1, 1, 1, 2, 3]
                Expected Output: false",
                @"sequence: [0, -2, 5, 6]
                Expected Output: true",
                @"sequence: [1, 2, 3, 4, 5, 3, 5, 6]
                Expected Output: false",
                @"sequence: [40, 50, 60, 10, 20, 30]
                Expected Output: false",
                @"sequence: [1, 1]
                Expected Output: true",
                @"sequence: [1, 2, 5, 3, 5]
                Expected Output: true",
                @"sequence: [1, 2, 5, 5, 5]
                Expected Output: false",
                @"sequence: [10, 1, 2, 3, 4, 5, 6, 1]
                Expected Output: false",
                @"sequence: [1, 2, 3, 4, 3, 6]
                Expected Output: true",
                @"sequence: [1, 2, 3, 4, 99, 5, 6]
                Expected Output: true",
                @"sequence: [123, -17, -5, 1, 2, 3, 12, 43, 45]
                Expected Output: true",
                @"sequence: [3, 5, 67, 98, 3]
                Expected Output: true"
            );
        }
        /*
            Imported: 2020-05-02 11:53
            By:       Casper
            Url:      https://app.codesignal.com/arcade/intro/level-2/xskq4ZxLyqQMCLshr
        */
        [Test]
        public void matrixElementsSum()
        {
            Test.Execute(typeof(matrixElementsSumClass),
                @"matrix:
                [[0,1,1,2],
                 [0,5,0,0],
                 [2,0,3,3]]
                Expected Output: 9",
                @"matrix:
                [[1,1,1,0],
                 [0,5,0,1],
                 [2,1,3,10]]
                Expected Output: 9",
                @"matrix:
                [[1,1,1],
                 [2,2,2],
                 [3,3,3]]
                Expected Output: 18",
                @"matrix: [[0]]
                Expected Output: 0",
                @"matrix:
                [[1,0,3],
                 [0,2,1],
                 [1,2,0]]
                Expected Output: 5",
                @"matrix:
                [[1],
                 [5],
                 [0],
                 [2]]
                Expected Output: 6",
                @"matrix: [[1,2,3,4,5]]
                Expected Output: 15",
                @"matrix:
                [[2],
                 [5],
                 [10]]
                Expected Output: 17",
                @"matrix:
                [[4,0,1],
                 [10,7,0],
                 [0,0,0],
                 [9,1,2]]
                Expected Output: 15",
                @"matrix: [[1]]
                Expected Output: 1"
            );
        }
    }
}
