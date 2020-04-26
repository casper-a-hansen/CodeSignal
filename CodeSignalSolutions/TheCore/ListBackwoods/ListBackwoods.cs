/*
    Imported:   2020-04-26 13:28
    Created By: Casper
    Url:        https://app.codesignal.com/arcade/code-arcade
*/
using NUnit.Framework;
using CodeSignalSolutions;
using CodeSignalSolutions.TheCore.ListBackwoods;

namespace TheCore
{
    public class ListBackwoods
    {
    /*
        Imported: 2020-04-26 13:28
        By:       Casper
        Url:      https://app.codesignal.com/arcade/code-arcade/list-backwoods/zwXiykHLor6eKHaLY
    */
    [Test]
    public void extractMatrixColumn()
    {
        Test.Execute(typeof(extractMatrixColumnClass),
            @"matrix:
            [[1,1,1,2], 
             [0,5,0,4], 
             [2,1,3,6]]
            column: 2
            Expected Output: [1, 0, 3]",
            @"matrix:
            [[1,1,1], 
             [0,5,0], 
             [2,1,3]]
            column: 2
            Expected Output: [1, 0, 3]",
            @"matrix:
            [[1,1], 
             [5,0], 
             [2,3]]
            column: 0
            Expected Output: [1, 5, 2]",
            @"matrix:
            [[1,1,1], 
             [0,5,0], 
             [2,1,3], 
             [10,100,300]]
            column: 1
            Expected Output: [1, 5, 1, 100]",
            @"matrix:
            [[0,1,1,5], 
             [5,0,0,0], 
             [2,1,0,10]]
            column: 3
            Expected Output: [5, 0, 10]",
            @"matrix: [[0]]
            column: 0
            Expected Output: [0]"
        );
    }
    /*
        Imported: 2020-04-26 13:28
        By:       Casper
        Url:      https://app.codesignal.com/arcade/code-arcade/list-backwoods/xKYm98etd9JRsTcZY
    */
    [Test]
    public void areIsomorphic()
    {
        Test.Execute(typeof(areIsomorphicClass),
            @"array1:
            [[1,1,1], 
             [0,0]]
            array2:
            [[2,1,1], 
             [2,1]]
            Expected Output: true",
            @"array1:
            [[2], 
             []]
            array2: [[2]]
            Expected Output: false",
            @"array1:
            [[2], 
             [1], 
             [3,5]]
            array2:
            [[], 
             [1], 
             [1,6]]
            Expected Output: false",
            @"array1:
            [[1,1,1], 
             [0,0]]
            array2:
            [[2,1,3], 
             [2,0], 
             []]
            Expected Output: false",
            @"array1:
            [[], 
             [1]]
            array2:
            [[], 
             [6,2,5]]
            Expected Output: false",
            @"array1:
            [[1,3,4], 
             []]
            array2:
            [[2,1,2], 
             []]
            Expected Output: true",
            @"array1: [[]]
            array2: [[]]
            Expected Output: true",
            @"array1:
            [[2], 
             [1], 
             [3,50,33]]
            array2:
            [[], 
             [1], 
             [1,6,32]]
            Expected Output: false",
            @"array1:
            [[6], 
             [3,5,2,4]]
            array2:
            [[34], 
             [6,2,5]]
            Expected Output: false",
            @"array1:
            [[6], 
             [3,5,2,4]]
            array2:
            [[34], 
             [6,2,5,4], 
             [1,2,3]]
            Expected Output: false"
        );
    }
    /*
        Imported: 2020-04-26 13:28
        By:       Casper
        Url:      https://app.codesignal.com/arcade/code-arcade/list-backwoods/Akspcu9ewiYapWkrp
    */
    [Test]
    public void reverseOnDiagonals()
    {
        Test.Execute(typeof(reverseOnDiagonalsClass),
            @"matrix:
            [[1,2,3], 
             [4,5,6], 
             [7,8,9]]
            Expected Output: [[9,2,7], 
             [4,5,6], 
             [3,8,1]]",
            @"matrix: [[239]]
            Expected Output: [[239]]",
            @"matrix:
            [[1,10], 
             [100,1000]]
            Expected Output: [[1000,100], 
             [10,1]]",
            @"matrix:
            [[43,455,32,103], 
             [102,988,298,981], 
             [309,21,53,64], 
             [2,22,35,291]]
            Expected Output: [[291,455,32,2], 
             [102,53,21,981], 
             [309,298,988,64], 
             [103,22,35,43]]",
            @"matrix:
            [[34,1000,139,248,972,584], 
             [98,1,398,128,762,654], 
             [33,498,132,543,764,43], 
             [329,12,54,764,666,213], 
             [928,109,489,71,837,332], 
             [93,298,42,53,76,43]]
            Expected Output: [[43,1000,139,248,972,93], 
             [98,837,398,128,109,654], 
             [33,498,764,54,764,43], 
             [329,12,543,132,666,213], 
             [928,762,489,71,1,332], 
             [584,298,42,53,76,34]]",
            @"matrix:
            [[1,1], 
             [2,2]]
            Expected Output: [[2,2], 
             [1,1]]"
        );
    }
    /*
        Imported: 2020-04-26 13:28
        By:       Casper
        Url:      https://app.codesignal.com/arcade/code-arcade/list-backwoods/kfwTN8pdx9uP8bcHS
    */
    [Test]
    public void swapDiagonals()
    {
        Test.Execute(typeof(swapDiagonalsClass),
            @"matrix:
            [[1,2,3], 
             [4,5,6], 
             [7,8,9]]
            Expected Output: [[3,2,1], 
             [4,5,6], 
             [9,8,7]]",
            @"matrix: [[239]]
            Expected Output: [[239]]",
            @"matrix:
            [[1,10], 
             [100,1000]]
            Expected Output: [[10,1], 
             [1000,100]]",
            @"matrix:
            [[43,455,32,103], 
             [102,988,298,981], 
             [309,21,53,64], 
             [2,22,35,291]]
            Expected Output: [[103,455,32,43], 
             [102,298,988,981], 
             [309,53,21,64], 
             [291,22,35,2]]",
            @"matrix:
            [[34,1000,139,248,972,584], 
             [98,1,398,128,762,654], 
             [33,498,132,543,764,43], 
             [329,12,54,764,666,213], 
             [928,109,489,71,837,332], 
             [93,298,42,53,76,43]]
            Expected Output: [[584,1000,139,248,972,34], 
             [98,762,398,128,1,654], 
             [33,498,543,132,764,43], 
             [329,12,764,54,666,213], 
             [928,837,489,71,109,332], 
             [43,298,42,53,76,93]]",
            @"matrix:
            [[1,2], 
             [1,2]]
            Expected Output: [[2,1], 
             [2,1]]"
        );
    }
    /*
        Imported: 2020-04-26 13:28
        By:       Casper
        Url:      https://app.codesignal.com/arcade/code-arcade/list-backwoods/Nh48Nqxb2zGx2NvYK
    */
    [Test]
    public void crossingSum()
    {
        Test.Execute(typeof(crossingSumClass),
            @"matrix:
            [[1,1,1,1], 
             [2,2,2,2], 
             [3,3,3,3]]
            a: 1
            b: 3
            Expected Output: 12",
            @"matrix:
            [[1,1], 
             [1,1]]
            a: 0
            b: 0
            Expected Output: 3",
            @"matrix:
            [[1,1], 
             [3,3], 
             [1,1], 
             [2,2]]
            a: 3
            b: 0
            Expected Output: 9",
            @"matrix: [[100]]
            a: 0
            b: 0
            Expected Output: 100",
            @"matrix:
            [[1,2], 
             [3,4]]
            a: 1
            b: 1
            Expected Output: 9",
            @"matrix: [[1,2,3,4]]
            a: 0
            b: 3
            Expected Output: 10",
            @"matrix:
            [[1,2,3,4,5], 
             [1,2,2,2,2], 
             [1,2,2,2,2], 
             [1,2,2,2,2], 
             [1,2,2,2,2], 
             [1,2,2,2,2], 
             [1,2,2,2,2]]
            a: 1
            b: 1
            Expected Output: 21"
        );
    }
    /*
        Imported: 2020-04-26 13:29
        By:       Casper
        Url:      https://app.codesignal.com/arcade/code-arcade/list-backwoods/uFQEiM4trARdm2z46
    */
    [Test]
    public void drawRectangle()
    {
        Test.Execute(typeof(drawRectangleClass),
            @"canvas:
            [[""a"",""a"",""a"",""a"",""a"",""a"",""a"",""a""], 
             [""a"",""a"",""a"",""a"",""a"",""a"",""a"",""a""], 
             [""a"",""a"",""a"",""a"",""a"",""a"",""a"",""a""], 
             [""b"",""b"",""b"",""b"",""b"",""b"",""b"",""b""], 
             [""b"",""b"",""b"",""b"",""b"",""b"",""b"",""b""]]
            rectangle: [1, 1, 4, 3]
            Expected Output: [[""a"",""a"",""a"",""a"",""a"",""a"",""a"",""a""], 
             [""a"",""*"",""-"",""-"",""*"",""a"",""a"",""a""], 
             [""a"",""|"",""a"",""a"",""|"",""a"",""a"",""a""], 
             [""b"",""*"",""-"",""-"",""*"",""b"",""b"",""b""], 
             [""b"",""b"",""b"",""b"",""b"",""b"",""b"",""b""]]",
            @"canvas:
            [[""a"",""a"",""a"",""a"",""a"",""a"",""a"",""a""], 
             [""a"",""a"",""a"",""a"",""a"",""a"",""a"",""a""], 
             [""a"",""a"",""a"",""a"",""a"",""a"",""a"",""a""], 
             [""b"",""b"",""b"",""b"",""b"",""b"",""b"",""b""]]
            rectangle: [0, 0, 1, 1]
            Expected Output: [[""*"",""*"",""a"",""a"",""a"",""a"",""a"",""a""], 
             [""*"",""*"",""a"",""a"",""a"",""a"",""a"",""a""], 
             [""a"",""a"",""a"",""a"",""a"",""a"",""a"",""a""], 
             [""b"",""b"",""b"",""b"",""b"",""b"",""b"",""b""]]",
            @"canvas:
            [[""a"",""a"",""a"",""a"",""a"",""a"",""a"",""a""], 
             [""a"",""a"",""a"",""a"",""a"",""a"",""a"",""a""], 
             [""a"",""a"",""a"",""a"",""a"",""a"",""a"",""a""], 
             [""b"",""b"",""b"",""b"",""b"",""b"",""b"",""b""]]
            rectangle: [0, 2, 7, 3]
            Expected Output: [[""a"",""a"",""a"",""a"",""a"",""a"",""a"",""a""], 
             [""a"",""a"",""a"",""a"",""a"",""a"",""a"",""a""], 
             [""*"",""-"",""-"",""-"",""-"",""-"",""-"",""*""], 
             [""*"",""-"",""-"",""-"",""-"",""-"",""-"",""*""]]",
            @"canvas:
            [[""a"",""a"",""a""], 
             [""a"",""a"",""a""], 
             [""a"",""a"",""a""], 
             [""b"",""b"",""b""]]
            rectangle: [0, 0, 2, 3]
            Expected Output: [[""*"",""-"",""*""], 
             [""|"",""a"",""|""], 
             [""|"",""a"",""|""], 
             [""*"",""-"",""*""]]",
            @"canvas:
            [[""#"",""#""], 
             [""a"",""a""], 
             [""a"",""a""], 
             [""b"",""b""]]
            rectangle: [0, 1, 1, 2]
            Expected Output: [[""#"",""#""], 
             [""*"",""*""], 
             [""*"",""*""], 
             [""b"",""b""]]",
            @"canvas:
            [[""1"",""2""], 
             [""4"",""3""], 
             [""5"",""6""], 
             [""8"",""7""]]
            rectangle: [0, 0, 1, 3]
            Expected Output: [[""*"",""*""], 
             [""|"",""|""], 
             [""|"",""|""], 
             [""*"",""*""]]"
        );
    }
    /*
        Imported: 2020-04-26 13:29
        By:       Casper
        Url:      https://app.codesignal.com/arcade/code-arcade/list-backwoods/fmYdsYcGfaTu4yTQt
    */
    [Test]
    public void volleyballPositions()
    {
        Test.Execute(typeof(volleyballPositionsClass),
            @"formation:
            [[""empty"",""Player5"",""empty""], 
             [""Player4"",""empty"",""Player2""], 
             [""empty"",""Player3"",""empty""], 
             [""Player6"",""empty"",""Player1""]]
            k: 2
            Expected Output: [[""empty"",""Player1"",""empty""], 
             [""Player2"",""empty"",""Player3""], 
             [""empty"",""Player4"",""empty""], 
             [""Player5"",""empty"",""Player6""]]",
            @"formation:
            [[""empty"",""Alice"",""empty""], 
             [""Bob"",""empty"",""Charlie""], 
             [""empty"",""Dave"",""empty""], 
             [""Eve"",""empty"",""Frank""]]
            k: 6
            Expected Output: [[""empty"",""Alice"",""empty""], 
             [""Bob"",""empty"",""Charlie""], 
             [""empty"",""Dave"",""empty""], 
             [""Eve"",""empty"",""Frank""]]",
            @"formation:
            [[""empty"",""player 3"",""empty""], 
             [""player 3"",""empty"",""player""], 
             [""empty"",""4"",""empty""], 
             [""5"",""empty"",""42""]]
            k: 1000000
            Expected Output: [[""empty"",""5"",""empty""], 
             [""4"",""empty"",""player 3""], 
             [""empty"",""player"",""empty""], 
             [""42"",""empty"",""player 3""]]",
            @"formation:
            [[""empty"",""player 3"",""empty""], 
             [""player 8"",""empty"",""player""], 
             [""empty"",""4"",""empty""], 
             [""5"",""empty"",""42""]]
            k: 0
            Expected Output: [[""empty"",""player 3"",""empty""], 
             [""player 8"",""empty"",""player""], 
             [""empty"",""4"",""empty""], 
             [""5"",""empty"",""42""]]",
            @"formation:
            [[""empty"",""player 3"",""empty""], 
             [""player 8"",""empty"",""player""], 
             [""empty"",""4"",""empty""], 
             [""5"",""empty"",""42""]]
            k: 1000000000
            Expected Output: [[""empty"",""5"",""empty""], 
             [""4"",""empty"",""player 8""], 
             [""empty"",""player"",""empty""], 
             [""42"",""empty"",""player 3""]]",
            @"formation:
            [[""empty"",""Alice"",""empty""], 
             [""Bob"",""empty"",""Charlie""], 
             [""empty"",""Dave"",""empty""], 
             [""Eve"",""empty"",""Frank""]]
            k: 7
            Expected Output: [[""empty"",""Charlie"",""empty""], 
             [""Alice"",""empty"",""Frank""], 
             [""empty"",""Eve"",""empty""], 
             [""Bob"",""empty"",""Dave""]]",
            @"formation:
            [[""empty"",""1"",""empty""], 
             [""?"",""empty"",""!""], 
             [""empty"",""."",""empty""], 
             [""3"",""empty"",""2""]]
            k: 666
            Expected Output: [[""empty"",""1"",""empty""], 
             [""?"",""empty"",""!""], 
             [""empty"",""."",""empty""], 
             [""3"",""empty"",""2""]]",
            @"formation:
            [[""empty"","""",""empty""], 
             ["""",""empty"",""""], 
             [""empty"",""!!!"",""empty""], 
             ["""",""empty"",""""]]
            k: 541
            Expected Output: [[""empty"","""",""empty""], 
             ["""",""empty"",""""], 
             [""empty"","""",""empty""], 
             ["""",""empty"",""!!!""]]",
            @"formation:
            [[""empty"",""Alice"",""empty""], 
             [""Bob"",""empty"",""Charlie""], 
             [""empty"",""Dave"",""empty""], 
             [""Eve"",""empty"",""Frank""]]
            k: 0
            Expected Output: [[""empty"",""Alice"",""empty""], 
             [""Bob"",""empty"",""Charlie""], 
             [""empty"",""Dave"",""empty""], 
             [""Eve"",""empty"",""Frank""]]",
            @"formation:
            [[""empty"",""a"",""empty""], 
             [""b"",""empty"",""c""], 
             [""empty"",""d"",""empty""], 
             [""e"",""empty"",""f""]]
            k: 3220832
            Expected Output: [[""empty"",""f"",""empty""], 
             [""c"",""empty"",""d""], 
             [""empty"",""b"",""empty""], 
             [""a"",""empty"",""e""]]"
        );
    }
    /*
        Imported: 2020-04-26 13:29
        By:       Casper
        Url:      https://app.codesignal.com/arcade/code-arcade/list-backwoods/A5meC5REAcDfHeuFf
    */
    [Test]
    public void starRotation()
    {
        Test.Execute(typeof(starRotationClass),
            @"matrix:
            [[1,0,0,2,0,0,3], 
             [0,1,0,2,0,3,0], 
             [0,0,1,2,3,0,0], 
             [8,8,8,9,4,4,4], 
             [0,0,7,6,5,0,0], 
             [0,7,0,6,0,5,0], 
             [7,0,0,6,0,0,5]]
            width: 7
            center: [3, 3]
            t: 1
            Expected Output: [[8,0,0,1,0,0,2], 
             [0,8,0,1,0,2,0], 
             [0,0,8,1,2,0,0], 
             [7,7,7,9,3,3,3], 
             [0,0,6,5,4,0,0], 
             [0,6,0,5,0,4,0], 
             [6,0,0,5,0,0,4]]",
            @"matrix:
            [[1,0,0,2,0,0,3], 
             [0,1,0,2,0,3,0], 
             [0,0,1,2,3,0,0], 
             [8,8,8,9,4,4,4], 
             [0,0,7,6,5,0,0]]
            width: 3
            center: [1, 5]
            t: 81
            Expected Output: [[1,0,0,2,0,0,0], 
             [0,1,0,2,3,3,3], 
             [0,0,1,2,0,0,0], 
             [8,8,8,9,4,4,4], 
             [0,0,7,6,5,0,0]]",
            @"matrix:
            [[1,0,0,2,0,0,3], 
             [0,1,0,2,0,3,0], 
             [0,0,1,2,3,0,0], 
             [8,8,8,9,4,4,4], 
             [0,0,7,6,5,0,0], 
             [0,7,0,6,0,5,0], 
             [7,0,0,6,0,0,5]]
            width: 3
            center: [3, 3]
            t: 15
            Expected Output: [[1,0,0,2,0,0,3], 
             [0,1,0,2,0,3,0], 
             [0,0,2,3,4,0,0], 
             [8,8,1,9,5,4,4], 
             [0,0,8,7,6,0,0], 
             [0,7,0,6,0,5,0], 
             [7,0,0,6,0,0,5]]",
            @"matrix:
            [[1,0,3], 
             [3,4,5], 
             [8,99,0]]
            width: 3
            center: [1, 1]
            t: 4
            Expected Output: [[0,99,8], 
             [5,4,3], 
             [3,0,1]]",
            @"matrix:
            [[8,16,32], 
             [1,0,3], 
             [3,4,5], 
             [8,99,0], 
             [42,56,64]]
            width: 3
            center: [2, 1]
            t: 12
            Expected Output: [[8,16,32], 
             [0,99,8], 
             [5,4,3], 
             [3,0,1], 
             [42,56,64]]",
            @"The test case is too large and is shown truncated
            matrix:
            [[1,0,0,2,0,7,3,1,24,0,2,0,0,3,4], 
             [1,0,0,2,0,7,3,1,25,0,2,0,0,3,4], 
             [1,0,0,2,0,99,3,1,0,0,2,0,0,3,4], 
             [1,0,0,2,0,8,3,1,0,54,2,0,0,3,4], 
             [1,0,0,2,0,7,3,1,0,88,2,0,0,3,4], 
             [1,0,0,2,0,88,3,1,0,0,2,0,0,3,4], 
             [1,0,0,2,0,99,3,1,0,0]]
            width: 5
            center: [3, 4]
            t: 1
            Expected Output: [[1,0,0,2,0,7,3,1,24,0,2,0,0,3,4], 
             [1,0,0,2,0,7,0,1,25,0,2,0,0,3,4], 
             [1,0,0,2,2,0,3,1,0,0,2,0,0,3,4], 
             [1,0,0,2,0,99,3,1,0,54,2,0,0,3,4], 
             [1,0,0,0,7,8,3,1,0,88,2,0,0,3,4], 
             [1,0,0,2,3,88,3,1,0,0,2,0,0,3,4], 
             [1,0,0,2,0,99,3,1,0,0]]"
        );
    }
    }
}
