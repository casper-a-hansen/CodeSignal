/*
    Imported:   2020-04-26 13:13
    Created By: Casper
    Url:        https://app.codesignal.com/arcade/intro
*/
using NUnit.Framework;
using CodeSignalSolutions;
using CodeSignalSolutions.Intro.LandOfLogic;

namespace Intro
{
    public class LandOfLogic
    {
    /*
        Imported: 2020-04-26 13:13
        By:       Casper
        Url:      https://app.codesignal.com/arcade/intro/level-12/s9qvXv4yTaWg8g4ma
    */
    [Test]
    public void longestWord()
    {
        Test.Execute(typeof(longestWordClass),
            @"text: ""Ready, steady, go!""
            Expected Output: ""steady""",
            @"text: ""Ready[[[, steady, go!""
            Expected Output: ""steady""",
            @"text: ""ABCd""
            Expected Output: ""ABCd""",
            @"text: ""To be or not to be""
            Expected Output: ""not""",
            @"text: ""You are the best!!!!!!!!!!!! CodeFighter ever!""
            Expected Output: ""CodeFighter"""
        );
    }
    /*
        Imported: 2020-04-26 13:13
        By:       Casper
        Url:      https://app.codesignal.com/arcade/intro/level-12/ywMyCTspqGXPWRZx5
    */
    [Test]
    public void validTime()
    {
        Test.Execute(typeof(validTimeClass),
            @"time: ""13:58""
            Expected Output: true",
            @"time: ""25:51""
            Expected Output: false",
            @"time: ""02:76""
            Expected Output: false",
            @"time: ""24:00""
            Expected Output: false",
            @"time: ""02:61""
            Expected Output: false",
            @"time: ""27:00""
            Expected Output: false",
            @"time: ""19:66""
            Expected Output: false",
            @"time: ""12:31""
            Expected Output: true",
            @"time: ""25:73""
            Expected Output: false",
            @"time: ""09:56""
            Expected Output: true",
            @"time: ""03:29""
            Expected Output: true"
        );
    }
    /*
        Imported: 2020-04-26 13:13
        By:       Casper
        Url:      https://app.codesignal.com/arcade/intro/level-12/YqZwMJguZBY7Hz84T
    */
    [Test]
    public void sumUpNumbers()
    {
        Test.Execute(typeof(sumUpNumbersClass),
            @"inputString: ""2 apples, 12 oranges""
            Expected Output: 14",
            @"inputString: ""123450""
            Expected Output: 123450",
            @"inputString: ""Your payment method is invalid""
            Expected Output: 0",
            @"inputString: ""no digits at all""
            Expected Output: 0",
            @"inputString: ""there are some (12) digits 5566 in this 770 string 239""
            Expected Output: 6587",
            @"inputString: ""42+781""
            Expected Output: 823",
            @"inputString: ""abc abc 4 abc 0 abc""
            Expected Output: 4",
            @"inputString: ""abcdefghijklmnopqrstuvwxyz1AbCdEfGhIjKlMnOpqrstuvwxyz23,74 -""
            Expected Output: 98"
        );
    }
    /*
        Imported: 2020-04-26 13:14
        By:       Casper
        Url:      https://app.codesignal.com/arcade/intro/level-12/fQpfgxiY6aGiGHLtv
    */
    [Test]
    public void differentSquares()
    {
        Test.Execute(typeof(differentSquaresClass),
            @"matrix:
            [[1,2,1], 
             [2,2,2], 
             [2,2,2], 
             [1,2,3], 
             [2,2,1]]
            Expected Output: 6",
            @"matrix:
            [[9,9,9,9,9], 
             [9,9,9,9,9], 
             [9,9,9,9,9], 
             [9,9,9,9,9], 
             [9,9,9,9,9], 
             [9,9,9,9,9]]
            Expected Output: 1",
            @"matrix: [[3]]
            Expected Output: 0",
            @"matrix: [[3,4,5,6,7,8,9]]
            Expected Output: 0",
            @"matrix:
            [[3], 
             [4], 
             [5], 
             [6], 
             [7]]
            Expected Output: 0",
            @"matrix:
            [[2,5,3,4,3,1,3,2], 
             [4,5,4,1,2,4,1,3], 
             [1,1,2,1,4,1,1,5], 
             [1,3,4,2,3,4,2,4], 
             [1,5,5,2,1,3,1,1], 
             [1,2,3,3,5,1,2,4], 
             [3,1,4,4,4,1,5,5], 
             [5,1,3,3,1,5,3,5], 
             [5,4,4,3,5,4,4,4]]
            Expected Output: 54",
            @"matrix: [[1,1,1,1,1,1,2,2,2,3,3,3,9,9,9,2,3,9]]
            Expected Output: 0"
        );
    }
    /*
        Imported: 2020-04-26 13:14
        By:       Casper
        Url:      https://app.codesignal.com/arcade/intro/level-12/NJJhENpgheFRQbPRA
    */
    [Test]
    public void digitsProduct()
    {
        Test.Execute(typeof(digitsProductClass),
            @"product: 12
            Expected Output: 26",
            @"product: 19
            Expected Output: -1",
            @"product: 450
            Expected Output: 2559",
            @"product: 0
            Expected Output: 10",
            @"product: 13
            Expected Output: -1",
            @"product: 1
            Expected Output: 1",
            @"product: 243
            Expected Output: 399",
            @"product: 576
            Expected Output: 889",
            @"product: 360
            Expected Output: 589"
        );
    }
    /*
        Imported: 2020-04-26 13:14
        By:       Casper
        Url:      https://app.codesignal.com/arcade/intro/level-12/sqZ9qDTFHXBNrQeLC
    */
    [Test]
    public void fileNaming()
    {
        Test.Execute(typeof(fileNamingClass),
            @"names:
            [""doc"", 
             ""doc"", 
             ""image"", 
             ""doc(1)"", 
             ""doc""]
            Expected Output: [""doc"", 
             ""doc(1)"", 
             ""image"", 
             ""doc(1)(1)"", 
             ""doc(2)""]",
            @"names:
            [""a(1)"", 
             ""a(6)"", 
             ""a"", 
             ""a"", 
             ""a"", 
             ""a"", 
             ""a"", 
             ""a"", 
             ""a"", 
             ""a"", 
             ""a"", 
             ""a""]
            Expected Output: [""a(1)"", 
             ""a(6)"", 
             ""a"", 
             ""a(2)"", 
             ""a(3)"", 
             ""a(4)"", 
             ""a(5)"", 
             ""a(7)"", 
             ""a(8)"", 
             ""a(9)"", 
             ""a(10)"", 
             ""a(11)""]",
            @"names:
            [""dd"", 
             ""dd(1)"", 
             ""dd(2)"", 
             ""dd"", 
             ""dd(1)"", 
             ""dd(1)(2)"", 
             ""dd(1)(1)"", 
             ""dd"", 
             ""dd(1)""]
            Expected Output: [""dd"", 
             ""dd(1)"", 
             ""dd(2)"", 
             ""dd(3)"", 
             ""dd(1)(1)"", 
             ""dd(1)(2)"", 
             ""dd(1)(1)(1)"", 
             ""dd(4)"", 
             ""dd(1)(3)""]",
            @"names:
            [""a"", 
             ""b"", 
             ""cd"", 
             ""b "", 
             ""a(3)""]
            Expected Output: [""a"", 
             ""b"", 
             ""cd"", 
             ""b "", 
             ""a(3)""]",
            @"names:
            [""name"", 
             ""name"", 
             ""name(1)"", 
             ""name(3)"", 
             ""name(2)"", 
             ""name(2)""]
            Expected Output: [""name"", 
             ""name(1)"", 
             ""name(1)(1)"", 
             ""name(3)"", 
             ""name(2)"", 
             ""name(2)(1)""]",
            @"names: []
            Expected Output: []"
        );
    }
    /*
        Imported: 2020-04-26 13:14
        By:       Casper
        Url:      https://app.codesignal.com/arcade/intro/level-12/sCpwzJCyBy2tDSxKW
    */
    [Test]
    public void messageFromBinaryCode()
    {
        Test.Execute(typeof(messageFromBinaryCodeClass),
            @"code: ""010010000110010101101100011011000110111100100001""
            Expected Output: ""Hello!""",
            @"code: ""01001101011000010111100100100000011101000110100001100101001000000100011001101111011100100110001101100101001000000110001001100101001000000111011101101001011101000110100000100000011110010110111101110101""
            Expected Output: ""May the Force be with you""",
            @"code: ""010110010110111101110101001000000110100001100001011001000010000001101101011001010010000001100001011101000010000001100000011010000110010101101100011011000110111100101110""
            Expected Output: ""You had me at `hello.""",
            @"code: ""010001010110110001100101011011010110010101101110011101000110000101110010011110010010110000100000011011010111100100100000011001000110010101100001011100100010000001010111011000010111010001110011011011110110111000100001""
            Expected Output: ""Elementary, my dear Watson!""",
            @"code: ""010011000110111101110110011001010010000001000110011011110111001000100000010000010110110001101100001011000010000001001000011000010111010001110010011001010110010000100000010001100110111101110010001000000100111001101111011011100110010100101110""
            Expected Output: ""Love For All, Hatred For None.""",
            @"code: ""0100001101101000011000010110111001100111011001010010000001110100011010000110010100100000011101110110111101110010011011000110010000100000011000100111100100100000011000100110010101101001011011100110011100100000011110010110111101110101011100100111001101100101011011000110011000101110""
            Expected Output: ""Change the world by being yourself.""",
            @"code: ""01000101011101100110010101110010011110010010000001101101011011110110110101100101011011100111010000100000011010010111001100100000011000010010000001100110011100100110010101110011011010000010000001100010011001010110011101101001011011100110111001101001011011100110011100101110""
            Expected Output: ""Every moment is a fresh beginning.""",
            @"code: ""010011100110010101110110011001010111001000100000011100100110010101100111011100100110010101110100001000000110000101101110011110010111010001101000011010010110111001100111001000000111010001101000011000010111010000100000011011010110000101100100011001010010000001111001011011110111010100100000011100110110110101101001011011000110010100101110""
            Expected Output: ""Never regret anything that made you smile.""",
            @"code: ""010001000110100101100101001000000111011101101001011101000110100000100000011011010110010101101101011011110111001001101001011001010111001100101100001000000110111001101111011101000010000001100100011100100110010101100001011011010111001100101110""
            Expected Output: ""Die with memories, not dreams.""",
            @"code: ""0100000101110011011100000110100101110010011001010010000001110100011011110010000001101001011011100111001101110000011010010111001001100101001000000110001001100101011001100110111101110010011001010010000001110111011001010010000001100101011110000111000001101001011100100110010100101110""
            Expected Output: ""Aspire to inspire before we expire."""
        );
    }
    /*
        Imported: 2020-04-26 13:14
        By:       Casper
        Url:      https://app.codesignal.com/arcade/intro/level-12/uRWu6K8E7uLi3Qtvx
    */
    [Test]
    public void spiralNumbers()
    {
        Test.Execute(typeof(spiralNumbersClass),
            @"n: 3
            Expected Output: [[1,2,3], 
             [8,9,4], 
             [7,6,5]]",
            @"n: 5
            Expected Output: [[1,2,3,4,5], 
             [16,17,18,19,6], 
             [15,24,25,20,7], 
             [14,23,22,21,8], 
             [13,12,11,10,9]]",
            @"n: 6
            Expected Output: [[1,2,3,4,5,6], 
             [20,21,22,23,24,7], 
             [19,32,33,34,25,8], 
             [18,31,36,35,26,9], 
             [17,30,29,28,27,10], 
             [16,15,14,13,12,11]]",
            @"n: 7
            Expected Output: [[1,2,3,4,5,6,7], 
             [24,25,26,27,28,29,8], 
             [23,40,41,42,43,30,9], 
             [22,39,48,49,44,31,10], 
             [21,38,47,46,45,32,11], 
             [20,37,36,35,34,33,12], 
             [19,18,17,16,15,14,13]]",
            @"n: 10
            Expected Output: [[1,2,3,4,5,6,7,8,9,10], 
             [36,37,38,39,40,41,42,43,44,11], 
             [35,64,65,66,67,68,69,70,45,12], 
             [34,63,84,85,86,87,88,71,46,13], 
             [33,62,83,96,97,98,89,72,47,14], 
             [32,61,82,95,100,99,90,73,48,15], 
             [31,60,81,94,93,92,91,74,49,16], 
             [30,59,80,79,78,77,76,75,50,17], 
             [29,58,57,56,55,54,53,52,51,18], 
             [28,27,26,25,24,23,22,21,20,19]]"
        );
    }
    /*
        Imported: 2020-04-26 13:14
        By:       Casper
        Url:      https://app.codesignal.com/arcade/intro/level-12/tQgasP8b62JBeirMS
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
    }
}
