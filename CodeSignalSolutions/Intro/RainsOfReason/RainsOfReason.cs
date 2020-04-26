/*
    Imported:   2020-04-26 13:10
    Created By: Casper
    Url:        https://app.codesignal.com/arcade/intro
*/
using NUnit.Framework;
using CodeSignalSolutions;
using CodeSignalSolutions.Intro.RainsOfReason;

namespace Intro
{
    public class RainsOfReason
    {
    /*
        Imported: 2020-04-26 13:10
        By:       Casper
        Url:      https://app.codesignal.com/arcade/intro/level-6/mCkmbxdMsMTjBc3Bm
    */
    [Test]
    public void arrayReplace()
    {
        Test.Execute(typeof(arrayReplaceClass),
            @"inputArray: [1, 2, 1]
            elemToReplace: 1
            substitutionElem: 3
            Expected Output: [3, 2, 3]",
            @"inputArray: [1, 2, 3, 4, 5]
            elemToReplace: 3
            substitutionElem: 0
            Expected Output: [1, 2, 0, 4, 5]",
            @"inputArray: [1, 1, 1]
            elemToReplace: 1
            substitutionElem: 10
            Expected Output: [10, 10, 10]",
            @"inputArray: [1, 2, 1, 2, 1]
            elemToReplace: 2
            substitutionElem: 1
            Expected Output: [1, 1, 1, 1, 1]",
            @"inputArray: [1, 2, 1, 2, 1]
            elemToReplace: 2
            substitutionElem: 2
            Expected Output: [1, 2, 1, 2, 1]",
            @"inputArray: [3, 1]
            elemToReplace: 3
            substitutionElem: 9
            Expected Output: [9, 1]",
            @"inputArray: [10, 10]
            elemToReplace: 0
            substitutionElem: 9
            Expected Output: [10, 10]",
            @"inputArray: [2, 1]
            elemToReplace: 3
            substitutionElem: 9
            Expected Output: [2, 1]"
        );
    }
    /*
        Imported: 2020-04-26 13:10
        By:       Casper
        Url:      https://app.codesignal.com/arcade/intro/level-6/6cmcmszJQr6GQzRwW
    */
    [Test]
    public void evenDigitsOnly()
    {
        Test.Execute(typeof(evenDigitsOnlyClass),
            @"n: 248622
            Expected Output: true",
            @"n: 642386
            Expected Output: false",
            @"n: 248842
            Expected Output: true",
            @"n: 1
            Expected Output: false",
            @"n: 8
            Expected Output: true",
            @"n: 2462487
            Expected Output: false",
            @"n: 468402800
            Expected Output: true",
            @"n: 2468428
            Expected Output: true",
            @"n: 5468428
            Expected Output: false",
            @"n: 7468428
            Expected Output: false"
        );
    }
    /*
        Imported: 2020-04-26 13:10
        By:       Casper
        Url:      https://app.codesignal.com/arcade/intro/level-6/6Wv4WsrsMJ8Y2Fwno
    */
    [Test]
    public void variableName()
    {
        Test.Execute(typeof(variableNameClass),
            @"name: ""var_1__Int""
            Expected Output: true",
            @"name: ""qq-q""
            Expected Output: false",
            @"name: ""2w2""
            Expected Output: false",
            @"name: "" variable""
            Expected Output: false",
            @"name: ""va[riable0""
            Expected Output: false",
            @"name: ""variable0""
            Expected Output: true",
            @"name: ""a""
            Expected Output: true",
            @"name: ""_Aas_23""
            Expected Output: true",
            @"name: ""a a_2""
            Expected Output: false",
            @"name: ""0ss""
            Expected Output: false"
        );
    }
    /*
        Imported: 2020-04-26 13:10
        By:       Casper
        Url:      https://app.codesignal.com/arcade/intro/level-6/PWLT8GBrv9xXy4Dui
    */
    [Test]
    public void alphabeticShift()
    {
        Test.Execute(typeof(alphabeticShiftClass),
            @"inputString: ""crazy""
            Expected Output: ""dsbaz""",
            @"inputString: ""z""
            Expected Output: ""a""",
            @"inputString: ""aaaabbbccd""
            Expected Output: ""bbbbcccdde""",
            @"inputString: ""fuzzy""
            Expected Output: ""gvaaz""",
            @"inputString: ""codesignal""
            Expected Output: ""dpeftjhobm"""
        );
    }
    /*
        Imported: 2020-04-26 13:10
        By:       Casper
        Url:      https://app.codesignal.com/arcade/intro/level-6/t97bpjfrMDZH8GJhi
    */
    [Test]
    public void chessBoardCellColor()
    {
        Test.Execute(typeof(chessBoardCellColorClass),
            @"cell1: ""A1""
            cell2: ""C3""
            Expected Output: true",
            @"cell1: ""A1""
            cell2: ""H3""
            Expected Output: false",
            @"cell1: ""A1""
            cell2: ""A2""
            Expected Output: false",
            @"cell1: ""A1""
            cell2: ""B2""
            Expected Output: true",
            @"cell1: ""B3""
            cell2: ""H8""
            Expected Output: false",
            @"cell1: ""C3""
            cell2: ""B5""
            Expected Output: false",
            @"cell1: ""G5""
            cell2: ""E7""
            Expected Output: true",
            @"cell1: ""C8""
            cell2: ""H8""
            Expected Output: false",
            @"cell1: ""D2""
            cell2: ""D2""
            Expected Output: true",
            @"cell1: ""A2""
            cell2: ""A5""
            Expected Output: false"
        );
    }
    }
}
