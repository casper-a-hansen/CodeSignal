/*
    Imported:   2020-04-26 12:22
    Created By: Casper
    Url:        https://app.codesignal.com/arcade/intro
*/
using NUnit.Framework;
using CodeSignalSolutions;
using CodeSignalSolutions.Intro.SmoothSailing;

namespace Intro
{
    public class SmoothSailing
    {
    /*
        Imported: 2020-04-26 12:22
        By:       Casper
        Url:      https://app.codesignal.com/arcade/intro/level-3/fzsCQGYbxaEcTr2bL
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
        Imported: 2020-04-26 12:22
        By:       Casper
        Url:      https://app.codesignal.com/arcade/intro/level-3/JKKuHJknZNj4YGL32
    */
    [Test]
    public void commonCharacterCount()
    {
        Test.Execute(typeof(commonCharacterCountClass),
            @"s1: ""aabcc""
            s2: ""adcaa""
            Expected Output: 3",
            @"s1: ""zzzz""
            s2: ""zzzzzzz""
            Expected Output: 4",
            @"s1: ""abca""
            s2: ""xyzbac""
            Expected Output: 3",
            @"s1: ""a""
            s2: ""b""
            Expected Output: 0",
            @"s1: ""a""
            s2: ""aaa""
            Expected Output: 1"
        );
    }
    /*
        Imported: 2020-04-26 12:22
        By:       Casper
        Url:      https://app.codesignal.com/arcade/intro/level-3/3AdBC97QNuhF6RwsQ
    */
    [Test]
    public void isLucky()
    {
        Test.Execute(typeof(isLuckyClass),
            @"n: 1230
            Expected Output: true",
            @"n: 239017
            Expected Output: false",
            @"n: 134008
            Expected Output: true",
            @"n: 10
            Expected Output: false",
            @"n: 11
            Expected Output: true",
            @"n: 1010
            Expected Output: true",
            @"n: 261534
            Expected Output: false",
            @"n: 100000
            Expected Output: false",
            @"n: 999999
            Expected Output: true",
            @"n: 123321
            Expected Output: true"
        );
    }
    /*
        Imported: 2020-04-26 12:22
        By:       Casper
        Url:      https://app.codesignal.com/arcade/intro/level-3/D6qmdBL2NYz49XHwM
    */
    [Test]
    public void sortByHeight()
    {
        Test.Execute(typeof(sortByHeightClass),
            @"a: [-1, 150, 190, 170, -1, -1, 160, 180]
            Expected Output: [-1, 150, 160, 170, -1, -1, 180, 190]",
            @"a: [-1, -1, -1, -1, -1]
            Expected Output: [-1, -1, -1, -1, -1]",
            @"a: [-1]
            Expected Output: [-1]",
            @"a: [4, 2, 9, 11, 2, 16]
            Expected Output: [2, 2, 4, 9, 11, 16]",
            @"a: [2, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1]
            Expected Output: [1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 2]",
            @"a: [23, 54, -1, 43, 1, -1, -1, 77, -1, -1, -1, 3]
            Expected Output: [1, 3, -1, 23, 43, -1, -1, 54, -1, -1, -1, 77]"
        );
    }
    /*
        Imported: 2020-04-26 12:22
        By:       Casper
        Url:      https://app.codesignal.com/arcade/intro/level-3/9DgaPsE2a7M6M2Hu6
    */
    [Test]
    public void reverseInParentheses()
    {
        Test.Execute(typeof(reverseInParenthesesClass),
            @"inputString: ""(bar)""
            Expected Output: ""rab""",
            @"inputString: ""foo(bar)baz""
            Expected Output: ""foorabbaz""",
            @"inputString: ""foo(bar)baz(blim)""
            Expected Output: ""foorabbazmilb""",
            @"inputString: ""foo(bar(baz))blim""
            Expected Output: ""foobazrabblim""",
            @"inputString: """"
            Expected Output: """"",
            @"inputString: ""()""
            Expected Output: """"",
            @"inputString: ""(abc)d(efg)""
            Expected Output: ""cbadgfe"""
        );
    }
    }
}
