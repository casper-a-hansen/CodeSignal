/*
    Imported:   2020-04-26 13:29
    Created By: Casper
    Url:        https://app.codesignal.com/arcade/code-arcade
*/
using NUnit.Framework;
using CodeSignalSolutions;
using CodeSignalSolutions.TheCore.WaterfallOfIntegration;

namespace TheCore
{
    public class WaterfallOfIntegration
    {
    /*
        Imported: 2020-04-26 13:29
        By:       Casper
        Url:      https://app.codesignal.com/arcade/code-arcade/waterfall-of-integration/tQgasP8b62JBeirMS
    */
    [Test]
    public void sudoku()
    {
        Test.Execute(typeof(sudokuClass),
            @"grid:
            [[1,3,2,5,4,6,9,8,7], 
             [4,6,5,8,7,9,3,2,1], 
             [7,9,8,2,1,3,6,5,4], 
             [9,2,1,4,3,5,8,7,6], 
             [3,5,4,7,6,8,2,1,9], 
             [6,8,7,1,9,2,5,4,3], 
             [5,7,6,9,8,1,4,3,2], 
             [2,4,3,6,5,7,1,9,8], 
             [8,1,9,3,2,4,7,6,5]]
            Expected Output: true",
            @"grid:
            [[1,3,2,5,4,6,9,2,7], 
             [4,6,5,8,7,9,3,8,1], 
             [7,9,8,2,1,3,6,5,4], 
             [9,2,1,4,3,5,8,7,6], 
             [3,5,4,7,6,8,2,1,9], 
             [6,8,7,1,9,2,5,4,3], 
             [5,7,6,9,8,1,4,3,2], 
             [2,4,3,6,5,7,1,9,8], 
             [8,1,9,3,2,4,7,6,5]]
            Expected Output: false",
            @"grid:
            [[1,2,3,4,5,6,7,8,9], 
             [1,2,3,4,5,6,7,8,9], 
             [1,2,3,4,5,6,7,8,9], 
             [1,2,3,4,5,6,7,8,9], 
             [1,2,3,4,5,6,7,8,9], 
             [1,2,3,4,5,6,7,8,9], 
             [1,2,3,4,5,6,7,8,9], 
             [1,2,3,4,5,6,7,8,9], 
             [1,2,3,4,5,6,7,8,9]]
            Expected Output: false",
            @"grid:
            [[1,3,4,2,5,6,9,8,7], 
             [4,6,8,5,7,9,3,2,1], 
             [7,9,2,8,1,3,6,5,4], 
             [9,2,3,1,4,5,8,7,6], 
             [3,5,7,4,6,8,2,1,9], 
             [6,8,1,7,9,2,5,4,3], 
             [5,7,6,9,8,1,4,3,2], 
             [2,4,5,6,3,7,1,9,8], 
             [8,1,9,3,2,4,7,6,5]]
            Expected Output: false",
            @"grid:
            [[1,3,2,5,4,6,9,8,7], 
             [4,6,5,8,7,9,3,2,1], 
             [7,9,8,2,1,3,6,5,4], 
             [9,2,1,4,3,5,8,7,6], 
             [3,5,4,7,6,8,2,1,9], 
             [6,8,7,1,9,2,5,4,3], 
             [5,4,6,9,8,1,4,3,2], 
             [2,7,3,6,5,7,1,9,8], 
             [8,1,9,3,2,4,7,6,5]]
            Expected Output: false",
            @"grid:
            [[1,2,3,4,5,6,7,8,9], 
             [4,6,5,8,7,9,3,2,1], 
             [7,9,8,2,1,3,6,5,4], 
             [1,2,3,4,5,6,7,8,9], 
             [4,6,5,8,7,9,3,2,1], 
             [7,9,8,2,1,3,6,5,4], 
             [1,2,3,4,5,6,7,8,9], 
             [4,6,5,8,7,9,3,2,1], 
             [7,9,8,2,1,3,6,5,4]]
            Expected Output: false",
            @"grid:
            [[5,3,4,6,7,8,9,1,2], 
             [6,7,2,1,9,5,3,4,8], 
             [1,9,8,3,4,2,5,6,7], 
             [8,5,9,9,6,1,4,2,3], 
             [4,2,6,8,5,3,7,9,1], 
             [7,1,3,7,2,4,8,5,6], 
             [9,6,1,5,3,7,2,8,4], 
             [2,8,7,4,1,9,6,3,5], 
             [3,4,5,2,8,6,1,7,9]]
            Expected Output: false",
            @"grid:
            [[5,5,5,5,5,5,5,5,5], 
             [5,5,5,5,5,5,5,5,5], 
             [5,5,5,5,5,5,5,5,5], 
             [5,5,5,5,5,5,5,5,5], 
             [5,5,5,5,5,5,5,5,5], 
             [5,5,5,5,5,5,5,5,5], 
             [5,5,5,5,5,5,5,5,5], 
             [5,5,5,5,5,5,5,5,5], 
             [5,5,5,5,5,5,5,5,5]]
            Expected Output: false",
            @"grid:
            [[5,3,4,6,7,8,9,1,2], 
             [6,7,2,3,9,5,3,4,8], 
             [1,9,8,1,4,2,5,6,7], 
             [8,5,9,7,6,1,4,2,3], 
             [4,2,6,8,5,3,7,9,1], 
             [7,1,3,9,2,4,8,5,6], 
             [9,6,1,5,3,7,2,8,4], 
             [2,8,7,4,1,9,6,3,5], 
             [3,4,5,2,8,6,1,7,9]]
            Expected Output: false",
            @"grid:
            [[5,3,4,6,7,8,9,1,2], 
             [6,7,2,1,9,5,3,4,8], 
             [1,9,8,3,4,2,5,6,7], 
             [8,5,9,7,6,1,4,2,3], 
             [4,2,6,8,5,3,7,9,1], 
             [7,1,3,9,2,4,8,5,6], 
             [9,6,1,5,3,7,2,8,4], 
             [2,5,7,4,1,9,6,3,5], 
             [3,4,5,2,8,6,1,7,9]]
            Expected Output: false",
            @"grid:
            [[1,2,3,4,5,6,7,8,9], 
             [4,5,6,7,8,9,1,2,3], 
             [7,8,9,1,2,3,4,5,6], 
             [2,3,4,5,6,7,8,9,1], 
             [3,4,5,6,7,8,9,1,2], 
             [5,6,7,8,9,1,2,3,4], 
             [6,7,8,9,1,2,3,4,5], 
             [8,9,1,2,3,4,5,6,7], 
             [9,1,2,3,4,5,6,7,8]]
            Expected Output: false"
        );
    }
    /*
        Imported: 2020-04-26 13:29
        By:       Casper
        Url:      https://app.codesignal.com/arcade/code-arcade/waterfall-of-integration/ZMR5n7vJbexnLrgaM
    */
    [Test]
    public void minesweeper()
    {
        Test.Execute(typeof(minesweeperClass),
            @"matrix:
            [[true,false,false], 
             [false,true,false], 
             [false,false,false]]
            Expected Output: [[1,2,1], 
             [2,1,1], 
             [1,1,1]]",
            @"matrix:
            [[false,false,false], 
             [false,false,false]]
            Expected Output: [[0,0,0], 
             [0,0,0]]",
            @"matrix:
            [[true,false,false,true], 
             [false,false,true,false], 
             [true,true,false,true]]
            Expected Output: [[0,2,2,1], 
             [3,4,3,3], 
             [1,2,3,1]]",
            @"matrix:
            [[true,true,true], 
             [true,true,true], 
             [true,true,true]]
            Expected Output: [[3,5,3], 
             [5,8,5], 
             [3,5,3]]",
            @"matrix:
            [[false,true,true,false], 
             [true,true,false,true], 
             [false,false,true,false]]
            Expected Output: [[3,3,3,2], 
             [2,4,5,2], 
             [2,3,2,2]]",
            @"matrix:
            [[true,false], 
             [true,false], 
             [false,true], 
             [false,false], 
             [false,false]]
            Expected Output: [[1,2], 
             [2,3], 
             [2,1], 
             [1,1], 
             [0,0]]"
        );
    }
    /*
        Imported: 2020-04-26 13:29
        By:       Casper
        Url:      https://app.codesignal.com/arcade/code-arcade/waterfall-of-integration/5xPitc3yT3dqS7XkP
    */
    [Test]
    public void boxBlur()
    {
        Test.Execute(typeof(boxBlurClass),
            @"image:
            [[1,1,1], 
             [1,7,1], 
             [1,1,1]]
            Expected Output: [[1]]",
            @"image:
            [[0,18,9], 
             [27,9,0], 
             [81,63,45]]
            Expected Output: [[28]]",
            @"image:
            [[36,0,18,9], 
             [27,54,9,0], 
             [81,63,72,45]]
            Expected Output: [[40,30]]",
            @"image:
            [[7,4,0,1], 
             [5,6,2,2], 
             [6,10,7,8], 
             [1,4,2,0]]
            Expected Output: [[5,4], 
             [4,4]]",
            @"image:
            [[36,0,18,9,9,45,27], 
             [27,0,54,9,0,63,90], 
             [81,63,72,45,18,27,0], 
             [0,0,9,81,27,18,45], 
             [45,45,27,27,90,81,72], 
             [45,18,9,0,9,18,45], 
             [27,81,36,63,63,72,81]]
            Expected Output: [[39,30,26,25,31], 
             [34,37,35,32,32], 
             [38,41,44,46,42], 
             [22,24,31,39,45], 
             [37,34,36,47,59]]",
            @"image:
            [[36,0,18,9,9,45,27], 
             [27,0,254,9,0,63,90], 
             [81,255,72,45,18,27,0], 
             [0,0,9,81,27,18,45], 
             [45,45,227,227,90,81,72], 
             [45,18,9,255,9,18,45], 
             [27,81,36,127,255,72,81]]
            Expected Output: [[82,73,48,25,31], 
             [77,80,57,32,32], 
             [81,106,88,68,42], 
             [44,96,103,89,45], 
             [59,113,137,126,80]]"
        );
    }
    /*
        Imported: 2020-04-26 13:29
        By:       Casper
        Url:      https://app.codesignal.com/arcade/code-arcade/waterfall-of-integration/LfP67YRDw2rxoLmeP
    */
    [Test]
    public void contoursShifting()
    {
        Test.Execute(typeof(contoursShiftingClass),
            @"matrix:
            [[1,2,3,4], 
             [5,6,7,8], 
             [9,10,11,12], 
             [13,14,15,16], 
             [17,18,19,20]]
            Expected Output: [[5,1,2,3], 
             [9,7,11,4], 
             [13,6,15,8], 
             [17,10,14,12], 
             [18,19,20,16]]",
            @"matrix: [[238,239,240,241,242,243,244,245]]
            Expected Output: [[245,238,239,240,241,242,243,244]]",
            @"matrix:
            [[238], 
             [239], 
             [240], 
             [241], 
             [242], 
             [243], 
             [244], 
             [245]]
            Expected Output: [[245], 
             [238], 
             [239], 
             [240], 
             [241], 
             [242], 
             [243], 
             [244]]",
            @"matrix:
            [[1,2,3], 
             [4,5,6], 
             [7,8,9], 
             [10,11,12]]
            Expected Output: [[4,1,2], 
             [7,8,3], 
             [10,5,6], 
             [11,12,9]]",
            @"matrix:
            [[1,2,3,4,5], 
             [6,7,8,9,10], 
             [11,12,13,14,15], 
             [16,17,18,19,20]]
            Expected Output: [[6,1,2,3,4], 
             [11,8,9,14,5], 
             [16,7,12,13,10], 
             [17,18,19,20,15]]",
            @"matrix:
            [[1,2,3,4,5], 
             [6,7,8,9,10], 
             [11,12,13,14,15]]
            Expected Output: [[6,1,2,3,4], 
             [11,8,9,7,5], 
             [12,13,14,15,10]]",
            @"matrix:
            [[1,2,3], 
             [6,7,8], 
             [11,12,13], 
             [16,17,18], 
             [21,22,23], 
             [24,25,26]]
            Expected Output: [[6,1,2], 
             [11,12,3], 
             [16,17,8], 
             [21,22,13], 
             [24,7,18], 
             [25,26,23]]",
            @"matrix: [[239]]
            Expected Output: [[239]]"
        );
    }
    /*
        Imported: 2020-04-26 13:30
        By:       Casper
        Url:      https://app.codesignal.com/arcade/code-arcade/waterfall-of-integration/L7KWEYbPoornGyf7K
    */
    [Test]
    public void polygonPerimeter()
    {
        Test.Execute(typeof(polygonPerimeterClass),
            @"matrix:
            [[false,true,true], 
             [true,true,false], 
             [true,false,false]]
            Expected Output: 12",
            @"matrix:
            [[true,true,true], 
             [true,false,true], 
             [true,true,true]]
            Expected Output: 16",
            @"matrix:
            [[true,true,true,true,true], 
             [true,true,true,true,true]]
            Expected Output: 14",
            @"matrix:
            [[false,true,true], 
             [true,true,false], 
             [true,true,false]]
            Expected Output: 12",
            @"matrix:
            [[false,false,true,false], 
             [false,true,true,true], 
             [true,true,false,true], 
             [true,false,true,true]]
            Expected Output: 22",
            @"matrix:
            [[false,false,true,false,false], 
             [false,true,true,true,true], 
             [true,true,false,true,true], 
             [true,false,true,true,true]]
            Expected Output: 24",
            @"matrix:
            [[false,false,false,false,false], 
             [false,true,true,true,true], 
             [true,true,false,false,true], 
             [true,false,true,true,true]]
            Expected Output: 24",
            @"matrix:
            [[false,false,true,false,false], 
             [false,true,true,true,false], 
             [true,true,false,true,true], 
             [false,false,true,true,false]]
            Expected Output: 22",
            @"matrix:
            [[false,false,true,true,true], 
             [false,true,true,false,true], 
             [false,true,false,true,true], 
             [true,true,false,true,false], 
             [true,false,true,true,false]]
            Expected Output: 32",
            @"matrix:
            [[false,false,false], 
             [false,true,false], 
             [false,false,false]]
            Expected Output: 4"
        );
    }
    /*
        Imported: 2020-04-26 13:30
        By:       Casper
        Url:      https://app.codesignal.com/arcade/code-arcade/waterfall-of-integration/hqrYesGKEaKQnv7Sv
    */
    [Test]
    public void gravitation()
    {
        Test.Execute(typeof(gravitationClass),
            @"rows:
            [""#..##"", 
             "".##.#"", 
             "".#.##"", 
             "".....""]
            Expected Output: [1, 4]",
            @"rows:
            [""#..##"", 
             "".##.#"", 
             "".#.##"", 
             ""..##.""]
            Expected Output: [1, 2, 3, 4]",
            @"rows:
            [""##"", 
             "".."", 
             "".."", 
             ""..""]
            Expected Output: [0, 1]",
            @"rows:
            [""#..#."", 
             "".##.."", 
             "".#..."", 
             "".#...""]
            Expected Output: [1, 4]",
            @"rows:
            [""#...."", 
             "".#..#"", 
             ""..#.."", 
             ""...#.""]
            Expected Output: [3]",
            @"rows:
            [""#.#.."", 
             "".####"", 
             ""#.#.."", 
             "".....""]
            Expected Output: [2]",
            @"rows:
            [""######"", 
             ""......"", 
             ""......"", 
             "".....#""]
            Expected Output: [5]"
        );
    }
    /*
        Imported: 2020-04-26 13:30
        By:       Casper
        Url:      https://app.codesignal.com/arcade/code-arcade/waterfall-of-integration/jkuhbNn7AdeCC7z7R
    */
    [Test]
    public void isInformationConsistent()
    {
        Test.Execute(typeof(isInformationConsistentClass),
            @"evidences:
            [[0,1,0,1], 
             [-1,1,0,0], 
             [-1,0,0,1]]
            Expected Output: true",
            @"evidences:
            [[1,0], 
             [-1,0], 
             [1,1], 
             [1,1]]
            Expected Output: false",
            @"evidences:
            [[1,-1,0,1], 
             [1,-1,0,-1]]
            Expected Output: false",
            @"evidences:
            [[0,0,-1], 
             [-1,1,-1], 
             [-1,1,0], 
             [0,1,0]]
            Expected Output: true",
            @"evidences:
            [[0,0,-1,1,1,0,0,1,-1,0], 
             [-1,1,-1,1,0,1,-1,1,1,0]]
            Expected Output: false",
            @"evidences:
            [[0,0], 
             [-1,1]]
            Expected Output: true",
            @"evidences:
            [[0,0,-1,0], 
             [-1,1,1,-1], 
             [-1,0,0,0], 
             [0,1,0,-1]]
            Expected Output: false",
            @"evidences:
            [[0,0], 
             [0,0]]
            Expected Output: true",
            @"evidences:
            [[-1,-1], 
             [-1,1]]
            Expected Output: false",
            @"evidences:
            [[0,0,-1], 
             [-1,1,1], 
             [0,1,0], 
             [0,1,0]]
            Expected Output: false"
        );
    }
    /*
        Imported: 2020-04-26 13:30
        By:       Casper
        Url:      https://app.codesignal.com/arcade/code-arcade/waterfall-of-integration/TTsQFn3ppXCk9uTXs
    */
    [Test]
    public void correctNonogram()
    {
        Test.Execute(typeof(correctNonogramClass),
            @"size: 5
            nonogramField:
            [[""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-""], 
             [""-"",""-"",""-"",""2"",""2"",""1"",""-"",""1""], 
             [""-"",""-"",""-"",""2"",""1"",""1"",""3"",""3""], 
             [""-"",""3"",""1"",""#"",""#"",""#"",""."",""#""], 
             [""-"",""-"",""2"",""#"",""#"",""."",""."","".""], 
             [""-"",""-"",""2"",""."",""."",""."",""#"",""#""], 
             [""-"",""1"",""2"",""#"",""."",""."",""#"",""#""], 
             [""-"",""-"",""5"",""#"",""#"",""#"",""#"",""#""]]
            Expected Output: true",
            @"size: 5
            nonogramField:
            [[""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-""], 
             [""-"",""-"",""-"",""-"",""-"",""1"",""-"",""-""], 
             [""-"",""-"",""-"",""3"",""3"",""2"",""5"",""5""], 
             [""-"",""-"",""3"",""."",""."",""."",""#"",""#""], 
             [""-"",""2"",""2"",""#"",""#"",""#"",""#"",""#""], 
             [""-"",""-"",""5"",""#"",""#"",""#"",""#"",""#""], 
             [""-"",""-"",""5"",""#"",""#"",""#"",""#"",""#""], 
             [""-"",""-"",""2"",""."",""."",""."",""#"",""#""]]
            Expected Output: false",
            @"size: 5
            nonogramField:
            [[""-"",""-"",""-"",""-"",""-"",""1"",""-"",""-""], 
             [""-"",""-"",""-"",""-"",""-"",""1"",""-"",""1""], 
             [""-"",""-"",""-"",""1"",""2"",""1"",""5"",""1""], 
             [""-"",""-"",""3"",""#"",""#"",""#"",""."","".""], 
             [""-"",""2"",""1"",""."",""#"",""#"",""."",""#""], 
             [""-"",""-"",""3"",""."",""."",""#"",""#"",""#""], 
             [""-"",""-"",""2"",""."",""."",""#"",""#"","".""], 
             [""-"",""-"",""2"",""."",""."",""#"",""#"","".""]]
            Expected Output: false",
            @"size: 5
            nonogramField:
            [[""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-""], 
             [""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-""], 
             [""-"",""-"",""-"",""5"",""4"",""5"",""4"",""5""], 
             [""-"",""1"",""3"",""#"",""#"",""#"",""."",""#""], 
             [""-"",""-"",""5"",""#"",""#"",""#"",""#"",""#""], 
             [""-"",""-"",""5"",""#"",""#"",""#"",""#"",""#""], 
             [""-"",""-"",""5"",""#"",""#"",""#"",""#"",""#""], 
             [""-"",""3"",""1"",""#"",""."",""#"",""#"",""#""]]
            Expected Output: false",
            @"size: 5
            nonogramField:
            [[""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-""], 
             [""-"",""-"",""-"",""-"",""-"",""-"",""-"",""2""], 
             [""-"",""-"",""-"",""2"",""2"",""2"",""4"",""1""], 
             [""-"",""-"",""-"",""."",""."",""."",""."","".""], 
             [""-"",""-"",""2"",""."",""."",""."",""#"",""#""], 
             [""-"",""-"",""3"",""."",""."",""#"",""#"",""#""], 
             [""-"",""-"",""4"",""#"",""#"",""#"",""#"","".""], 
             [""-"",""2"",""2"",""."",""#"",""#"",""#"",""#""]]
            Expected Output: false",
            @"size: 5
            nonogramField:
            [[""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-""], 
             [""-"",""-"",""-"",""-"",""1"",""-"",""-"",""-""], 
             [""-"",""-"",""-"",""1"",""3"",""1"",""2"",""1""], 
             [""-"",""-"",""1"",""."",""#"",""."",""."","".""], 
             [""-"",""-"",""-"",""."",""."",""."",""."","".""], 
             [""-"",""-"",""1"",""."",""#"",""."",""."","".""], 
             [""-"",""1"",""2"",""."",""#"",""."",""#"",""#""], 
             [""-"",""-"",""4"",""#"",""#"",""#"",""#"","".""]]
            Expected Output: true",
            @"Fixed The test case is too large and is shown truncated
            size: 9
            nonogramField:
            [[""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-""], 
             [""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-""], 
             [""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-""], 
             [""-"",""-"",""-"",""-"",""-"",""-"",""-"",""4"",""3"",""-"",""-"",""-"",""-"",""-""], 
             [""-"",""-"",""-"",""-"",""-"",""2"",""2"",""2"",""1"",""10"",""3"",""4"",""2"",""2""], 
             [""-"",""-"",""-"",""-"",""1"",""."",""."",""."",""."",""#"",""."",""."",""."","".""], 
             [""-"",""-"",""-"",""-"",""5"",""."",""."",""#"",""#"",""#"",""#"",""#"",""."","".""], 
             [""-"",""-"",""-"",""-"",""7"",""."",""#"",""#"",""#"",""#"",""#"",""#"",""#"","".""],
             [""-"",""-"",""-"",""-"",""9"",""#"",""#"",""#"",""#"",""#"",""#"",""#"",""#"",""#""],
             [""1"",""1"",""1"",""1"",""1"",""#"",""."",""#"",""."",""#"",""."",""#"",""."",""#""],
             [""-"",""-"",""-"",""-"",""1"",""."",""."",""."",""."",""#"",""."",""."",""."","".""],
             [""-"",""-"",""-"",""-"",""1"",""."",""."",""."",""."",""#"",""."",""."",""."","".""],
             [""-"",""-"",""-"",""1"",""1"",""."",""."",""#"",""."",""#"",""."",""."",""."","".""],
             [""-"",""-"",""-"",""-"",""3"",""."",""."",""#"",""#"",""#"",""."",""."",""."","".""]]            
            Expected Output: false",
            @"Fixed The test case is too large and is shown truncated
            size: 9
            nonogramField:
            [[""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-""], 
             [""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-""], 
             [""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-""], 
             [""-"",""-"",""-"",""-"",""-"",""-"",""-"",""4"",""3"",""-"",""-"",""-"",""-"",""-""], 
             [""-"",""-"",""-"",""-"",""-"",""2"",""2"",""2"",""1"",""9"",""3"",""4"",""2"",""2""], 
             [""-"",""-"",""-"",""-"",""1"",""."",""."",""."",""."",""#"",""."",""."",""."","".""], 
             [""-"",""-"",""-"",""-"",""5"",""."",""."",""#"",""#"",""#"",""#"",""#"",""."","".""], 
             [""-"",""-"",""-"",""-"",""7"",""."",""#"",""#"",""#"",""#"",""#"",""#"",""#"","".""],
             [""-"",""-"",""-"",""-"",""9"",""#"",""#"",""#"",""#"",""#"",""#"",""#"",""#"",""#""],
             [""1"",""1"",""1"",""1"",""1"",""#"",""."",""#"",""."",""#"",""."",""#"",""."",""#""],
             [""-"",""-"",""-"",""-"",""1"",""."",""."",""."",""."",""#"",""."",""."",""."","".""],
             [""-"",""-"",""-"",""-"",""1"",""."",""."",""."",""."",""#"",""."",""."",""."","".""],
             [""-"",""-"",""-"",""1"",""1"",""."",""."",""#"",""."",""#"",""."",""."",""."","".""],
             [""-"",""-"",""-"",""-"",""3"",""."",""."",""#"",""#"",""#"",""."",""."",""."","".""]]
            Expected Output: true",
            @"fixed! The test case is too large and is shown truncated
            size: 9
            nonogramField:
            [[""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-""], 
             [""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-""], 
             [""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-""], 
             [""-"",""-"",""-"",""-"",""-"",""-"",""-"",""4"",""3"",""-"",""-"",""-"",""-"",""-""], 
             [""-"",""-"",""-"",""-"",""-"",""2"",""2"",""2"",""1"",""9"",""3"",""4"",""2"",""2""], 
             [""-"",""-"",""-"",""-"",""1"",""."",""."",""."",""."",""#"",""."",""."",""."","".""], 
             [""-"",""-"",""-"",""-"",""5"",""."",""."",""#"",""#"",""#"",""#"",""#"",""."","".""], 
             [""-"",""-"",""-"",""-"",""7"",""."",""#"",""#"",""#"",""#"",""#"",""#"",""#"","".""],
             [""-"",""-"",""-"",""-"",""9"",""#"",""#"",""#"",""#"",""#"",""#"",""#"",""#"",""#""],
             [""1"",""1"",""1"",""1"",""1"",""#"",""."",""#"",""."",""#"",""."",""#"",""."",""#""],
             [""-"",""-"",""-"",""-"",""1"",""."",""."",""."",""."",""#"",""."",""."",""."","".""],
             [""-"",""-"",""-"",""-"",""1"",""."",""."",""#"",""."",""#"",""."",""."",""."","".""],
             [""-"",""-"",""-"",""1"",""1"",""."",""."",""#"",""."",""#"",""."",""."",""."","".""],
             [""-"",""-"",""-"",""-"",""3"",""."",""."",""#"",""#"",""#"",""."",""."",""."","".""]]
            Expected Output: false",
            @"Fixed! The test case is too large and is shown truncated
            size: 10
            nonogramField:
            [[""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-""], 
             [""-"",""-"",""-"",""-"",""-"",""-"",""1"",""-"",""-"",""-"",""-"",""-"",""-"",""-"",""-""], 
             [""-"",""-"",""-"",""-"",""-"",""1"",""2"",""1"",""-"",""-"",""1"",""1"",""-"",""-"",""-""], 
             [""-"",""-"",""-"",""-"",""-"",""4"",""2"",""1"",""7"",""1"",""6"",""4"",""-"",""-"",""-""], 
             [""-"",""-"",""-"",""-"",""-"",""2"",""1"",""4"",""1"",""8"",""1"",""1"",""2"",""1"",""3""], 
             [""-"",""-"",""-"",""3"",""3"",""#"",""#"",""#"",""."",""#"",""#"",""#"",""."",""."","".""], 
             [""-"",""-"",""-"",""-"",""1"",""."",""."",""."",""#"",""."",""."",""."",""."",""."","".""],
             [""-"",""-"",""-"",""-"",""5"",""."",""#"",""#"",""#"",""#"",""#"",""."",""."",""."","".""],
             [""-"",""-"",""2"",""4"",""1"",""#"",""#"",""."",""#"",""#"",""#"",""#"",""."",""."",""#""],
             [""-"",""-"",""-"",""1"",""7"",""#"",""."",""."",""#"",""#"",""#"",""#"",""#"",""#"",""#""],
             [""-"",""-"",""1"",""5"",""1"",""#"",""."",""."",""#"",""#"",""#"",""#"",""#"",""."",""#""],
             [""-"",""-"",""-"",""-"",""7"",""#"",""#"",""#"",""#"",""#"",""#"",""#"",""."",""."","".""],
             [""-"",""-"",""-"",""-"",""5"",""."",""#"",""#"",""#"",""#"",""#"",""."",""."",""."","".""],
             [""-"",""-"",""1"",""1"",""1"",""#"",""."",""#"",""."",""#"",""."",""."",""."",""."","".""],
             [""-"",""-"",""-"",""-"",""7"",""#"",""#"",""#"",""#"",""#"",""#"",""#"",""."",""."","".""]]
            Expected Output: true"
        );
    }
    }
}
