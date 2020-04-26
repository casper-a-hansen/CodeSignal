/*
    Imported:   2020-04-26 13:20
    Created By: Casper
    Url:        https://app.codesignal.com/arcade/code-arcade
*/
using NUnit.Framework;
using CodeSignalSolutions;
using CodeSignalSolutions.TheCore.LabyrinthOfNestedLoops;

namespace TheCore
{
    public class LabyrinthOfNestedLoops
    {
    /*
        Imported: 2020-04-26 13:20
        By:       Casper
        Url:      https://app.codesignal.com/arcade/code-arcade/labyrinth-of-nested-loops/yBFfNv5fTqhcacZ7w
    */
    [Test]
    public void isPower()
    {
        Test.Execute(typeof(isPowerClass),
            @"n: 125
            Expected Output: true",
            @"n: 72
            Expected Output: false",
            @"n: 100
            Expected Output: true",
            @"n: 11
            Expected Output: false",
            @"n: 324
            Expected Output: true",
            @"n: 256
            Expected Output: true",
            @"n: 119
            Expected Output: false",
            @"n: 400
            Expected Output: true",
            @"n: 350
            Expected Output: false",
            @"n: 361
            Expected Output: true"
        );
    }
    /*
        Imported: 2020-04-26 13:20
        By:       Casper
        Url:      https://app.codesignal.com/arcade/code-arcade/labyrinth-of-nested-loops/EQSjA5PRfyHueeNkj
    */
    [Test]
    public void isSumOfConsecutive2()
    {
        Test.Execute(typeof(isSumOfConsecutive2Class),
            @"n: 9
            Expected Output: 2",
            @"n: 8
            Expected Output: 0",
            @"n: 15
            Expected Output: 3",
            @"n: 24
            Expected Output: 1",
            @"n: 13
            Expected Output: 1",
            @"n: 25
            Expected Output: 2",
            @"n: 99
            Expected Output: 5"
        );
    }
    /*
        Imported: 2020-04-26 13:21
        By:       Casper
        Url:      https://app.codesignal.com/arcade/code-arcade/labyrinth-of-nested-loops/MvX84CA5HN6GKqv7R
    */
    [Test]
    public void squareDigitsSequence()
    {
        Test.Execute(typeof(squareDigitsSequenceClass),
            @"a0: 16
            Expected Output: 9",
            @"a0: 103
            Expected Output: 4",
            @"a0: 1
            Expected Output: 2",
            @"a0: 13
            Expected Output: 4",
            @"a0: 89
            Expected Output: 9",
            @"a0: 612
            Expected Output: 16"
        );
    }
    /*
        Imported: 2020-04-26 13:21
        By:       Casper
        Url:      https://app.codesignal.com/arcade/code-arcade/labyrinth-of-nested-loops/pdw3izd7SpMTBJqSy
    */
    [Test]
    public void pagesNumberingWithInk()
    {
        Test.Execute(typeof(pagesNumberingWithInkClass),
            @"current: 1
            numberOfDigits: 5
            Expected Output: 5",
            @"current: 21
            numberOfDigits: 5
            Expected Output: 22",
            @"current: 8
            numberOfDigits: 4
            Expected Output: 10",
            @"current: 21
            numberOfDigits: 6
            Expected Output: 23",
            @"current: 10
            numberOfDigits: 3
            Expected Output: 10",
            @"current: 76
            numberOfDigits: 250
            Expected Output: 166",
            @"current: 80
            numberOfDigits: 1000
            Expected Output: 419"
        );
    }
    /*
        Imported: 2020-04-26 13:21
        By:       Casper
        Url:      https://app.codesignal.com/arcade/code-arcade/labyrinth-of-nested-loops/pNfGgNk46YZ4c4RW5
    */
    [Test]
    public void comfortableNumbers()
    {
        Test.Execute(typeof(comfortableNumbersClass),
            @"l: 10
            r: 12
            Expected Output: 2",
            @"l: 1
            r: 9
            Expected Output: 20",
            @"l: 13
            r: 13
            Expected Output: 0",
            @"l: 12
            r: 108
            Expected Output: 707",
            @"l: 239
            r: 777
            Expected Output: 6166",
            @"l: 1
            r: 1000
            Expected Output: 11435"
        );
    }
    /*
        Imported: 2020-04-26 13:21
        By:       Casper
        Url:      https://app.codesignal.com/arcade/code-arcade/labyrinth-of-nested-loops/oL7YuygJKtMSNLeJn
    */
    [Test]
    public void weakNumbers()
    {
        Test.Execute(typeof(weakNumbersClass),
            @"n: 9
            Expected Output: [2, 2]",
            @"n: 1
            Expected Output: [0, 1]",
            @"n: 2
            Expected Output: [0, 2]",
            @"n: 7
            Expected Output: [2, 1]",
            @"n: 500
            Expected Output: [403, 1]",
            @"n: 4
            Expected Output: [0, 4]"
        );
    }
    /*
        Imported: 2020-04-26 13:21
        By:       Casper
        Url:      https://app.codesignal.com/arcade/code-arcade/labyrinth-of-nested-loops/tuKA5f3zpzkKKejJx
    */
    [Test]
    public void rectangleRotation()
    {
        Test.Execute(typeof(rectangleRotationClass),
            @"a: 6
            b: 4
            Expected Output: 23",
            @"a: 30
            b: 2
            Expected Output: 65",
            @"a: 8
            b: 6
            Expected Output: 49",
            @"a: 16
            b: 20
            Expected Output: 333",
            @"a: 20
            b: 32
            Expected Output: 653",
            @"a: 30
            b: 26
            Expected Output: 795",
            @"a: 50
            b: 4
            Expected Output: 177",
            @"a: 2
            b: 2
            Expected Output: 5",
            @"a: 50
            b: 50
            Expected Output: 2521",
            @"a: 38
            b: 42
            Expected Output: 1563"
        );
    }
    /*
        Imported: 2020-04-26 13:21
        By:       Casper
        Url:      https://app.codesignal.com/arcade/code-arcade/labyrinth-of-nested-loops/W5Sq7taLSzNHh8GiF
    */
    [Test]
    public void crosswordFormation()
    {
        Test.Execute(typeof(crosswordFormationClass),
            @"words:
            [""crossword"", 
             ""square"", 
             ""formation"", 
             ""something""]
            Expected Output: 6",
            @"words:
            [""anaesthetist"", 
             ""thatch"", 
             ""ethnics"", 
             ""sabulous""]
            Expected Output: 0",
            @"words:
            [""eternal"", 
             ""texas"", 
             ""chainsaw"", 
             ""massacre""]
            Expected Output: 4",
            @"words:
            [""africa"", 
             ""america"", 
             ""australia"", 
             ""antarctica""]
            Expected Output: 62",
            @"words:
            [""phenomenon"", 
             ""remuneration"", 
             ""particularly"", 
             ""pronunciation""]
            Expected Output: 62",
            @"words:
            [""onomatopoeia"", 
             ""philosophical"", 
             ""provocatively"", 
             ""thesaurus""]
            Expected Output: 20"
        );
    }
    }
}
