/*
    Imported:   2020-04-26 13:19
    Created By: Casper
    Url:        https://app.codesignal.com/arcade/code-arcade
*/
using NUnit.Framework;
using CodeSignalSolutions;
using CodeSignalSolutions.TheCore.ListForestEdge;

namespace TheCore
{
    public class ListForestEdge
    {
    /*
        Imported: 2020-04-26 13:19
        By:       Casper
        Url:      https://app.codesignal.com/arcade/code-arcade/list-forest-edge/gmZFbpR9cirL3Jpf2
    */
    [Test]
    public void createArray()
    {
        Test.Execute(typeof(createArrayClass),
            @"size: 4
            Expected Output: [1, 1, 1, 1]",
            @"size: 2
            Expected Output: [1, 1]",
            @"size: 1
            Expected Output: [1]",
            @"size: 5
            Expected Output: [1, 1, 1, 1, 1]",
            @"size: 49
            Expected Output: [1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1]"
        );
    }
    /*
        Imported: 2020-04-26 13:19
        By:       Casper
        Url:      https://app.codesignal.com/arcade/code-arcade/list-forest-edge/mCkmbxdMsMTjBc3Bm
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
        Imported: 2020-04-26 13:19
        By:       Casper
        Url:      https://app.codesignal.com/arcade/code-arcade/list-forest-edge/ND8nghbndTNKPP4Tb
    */
    [Test]
    public void firstReverseTry()
    {
        Test.Execute(typeof(firstReverseTryClass),
            @"arr: [1, 2, 3, 4, 5]
            Expected Output: [5, 2, 3, 4, 1]",
            @"arr: []
            Expected Output: []",
            @"arr: [239]
            Expected Output: [239]",
            @"arr: [23, 54, 12, 3, 4, 56, 23, 12, 5, 324]
            Expected Output: [324, 54, 12, 3, 4, 56, 23, 12, 5, 23]",
            @"arr: [-1, 1]
            Expected Output: [1, -1]",
            @"arr: [88, -101, -310, 818, 747, -888, -183, -687, -723, 188, -611, 677, -597, 293, -295, -162, -265, 368, 346, 81, -831, 198, -94, 685, -434, -241, -566, -397, 501, -183, 366, -669, 96, -592, 358, 598, 444, -929, 769, -361, -754, 218, -464, 332, 893, 422, -192, -287, -850, 543]
            Expected Output: [543, -101, -310, 818, 747, -888, -183, -687, -723, 188, -611, 677, -597, 293, -295, -162, -265, 368, 346, 81, -831, 198, -94, 685, -434, -241, -566, -397, 501, -183, 366, -669, 96, -592, 358, 598, 444, -929, 769, -361, -754, 218, -464, 332, 893, 422, -192, -287, -850, 88]"
        );
    }
    /*
        Imported: 2020-04-26 13:20
        By:       Casper
        Url:      https://app.codesignal.com/arcade/code-arcade/list-forest-edge/GeqSK26bvdrarkGH9
    */
    [Test]
    public void concatenateArrays()
    {
        Test.Execute(typeof(concatenateArraysClass),
            @"a: [2, 2, 1]
            b: [10, 11]
            Expected Output: [2, 2, 1, 10, 11]",
            @"a: [1, 2]
            b: [3, 1, 2]
            Expected Output: [1, 2, 3, 1, 2]",
            @"a: [1]
            b: []
            Expected Output: [1]",
            @"a: [2, 10, 3, 9, 5, 11, 11]
            b: [4, 8, 1, 13, 3, 1, 14]
            Expected Output: [2, 10, 3, 9, 5, 11, 11, 4, 8, 1, 13, 3, 1, 14]",
            @"a: [9, 6, 6, 9, 8, 14]
            b: [3, 2, 2, 5, 3, 11, 12, 9, 7, 7]
            Expected Output: [9, 6, 6, 9, 8, 14, 3, 2, 2, 5, 3, 11, 12, 9, 7, 7]"
        );
    }
    /*
        Imported: 2020-04-26 13:20
        By:       Casper
        Url:      https://app.codesignal.com/arcade/code-arcade/list-forest-edge/vPJB7T28fyCeh2Ljn
    */
    [Test]
    public void removeArrayPart()
    {
        Test.Execute(typeof(removeArrayPartClass),
            @"inputArray: [2, 3, 2, 3, 4, 5]
            l: 2
            r: 4
            Expected Output: [2, 3, 5]",
            @"inputArray: [2, 4, 10, 1]
            l: 0
            r: 2
            Expected Output: [1]",
            @"inputArray: [5, 3, 2, 3, 4]
            l: 1
            r: 1
            Expected Output: [5, 2, 3, 4]",
            @"inputArray: [1, 1]
            l: 0
            r: 1
            Expected Output: []",
            @"inputArray: [0, -2, 5, 6]
            l: 3
            r: 3
            Expected Output: [0, -2, 5]",
            @"inputArray: [4, 3, 2, 1, 3, 4, 5]
            l: 1
            r: 3
            Expected Output: [4, 3, 4, 5]",
            @"inputArray: [24, -40, -30, 30, 80, -94, 18, -56, -31, -68, -94, 67, -28, -2, -10, -83, -41, 43, -27, 0, -39, -83, -76, -59, -32, 87, -31, -55, -35, 20, 67, -78, -32, -90, 72, 15, -59, 4, 69, -82, 2, 96, -99, -78, 93, -68, -39, 68, 49, -9, -49, 77, 81, -55, -16, -9, -11, 80, 29, -6, 90, 83, 16, 68, -62, -73, -5, -86, 0, -48, 88, -35, 87, 12, 92, 12, 46, 57, 71, 91, -55, -62, -24, -78, -40, 30, -97, 64, -9, 40, 93, -67, -26, 53, -81, -7, -16, 14, -70, 88]
            l: 19
            r: 98
            Expected Output: [24, -40, -30, 30, 80, -94, 18, -56, -31, -68, -94, 67, -28, -2, -10, -83, -41, 43, -27, 88]",
            @"inputArray: [66, -94, -83, -39, -27, 50, 58, 58, -68, -85, 55, -21, 83, -89, 52, -80, 17, -89, -56, 90, 75, 23, -74, -91, 93, -36, 90, 97, 52, 8, 0, -88, -5, -34, 55, 88, 96, -29, 30, -51, -69, 57, 85, -86, -47, 85, 77, 62, 55, 11, -4, 85, 32, 96, 69, 80, 78, -79, 70, 79, 77, 98, 85, 94, -34, 21, 5, 19, 85, 54, 50, 6, 31, -100, 74, -32, 35, 38, 59, 43, 89, 89, -60, 36, 46, 78, 43, 53, 84, -76, -24, -53, -5, 91, 100, 65, 23, 87, 20, 5]
            l: 0
            r: 99
            Expected Output: []"
        );
    }
    /*
        Imported: 2020-04-26 13:20
        By:       Casper
        Url:      https://app.codesignal.com/arcade/code-arcade/list-forest-edge/3LmZafR9wMCWpdgra
    */
    [Test]
    public void isSmooth()
    {
        Test.Execute(typeof(isSmoothClass),
            @"arr: [7, 2, 2, 5, 10, 7]
            Expected Output: true",
            @"arr: [-5, -5, 10]
            Expected Output: false",
            @"arr: [4, 2]
            Expected Output: false",
            @"arr: [45, 23, 12, 33, 12, 453, -234, -45]
            Expected Output: false",
            @"arr: [-12, 34, 40, -5, -12, 4, 0, 0, -12]
            Expected Output: true",
            @"arr: [9, 0, 15, 9]
            Expected Output: false",
            @"arr: [-6, 6, -6]
            Expected Output: false",
            @"arr: [26, 26, -17]
            Expected Output: false",
            @"arr: [-7, 5, 5, 10]
            Expected Output: false",
            @"arr: [3, 4, 5]
            Expected Output: false",
            @"arr: [-5, 3, -1, 9]
            Expected Output: false"
        );
    }
    /*
        Imported: 2020-04-26 13:20
        By:       Casper
        Url:      https://app.codesignal.com/arcade/code-arcade/list-forest-edge/APD5T5CybxTtfkdjL
    */
    [Test]
    public void replaceMiddle()
    {
        Test.Execute(typeof(replaceMiddleClass),
            @"arr: [7, 2, 2, 5, 10, 7]
            Expected Output: [7, 2, 7, 10, 7]",
            @"arr: [-5, -5, 10]
            Expected Output: [-5, -5, 10]",
            @"arr: [45, 23, 12, 33, 12, 453, -234, -45]
            Expected Output: [45, 23, 12, 45, 453, -234, -45]",
            @"arr: [2, 8]
            Expected Output: [10]",
            @"arr: [-12, 34, 40, -5, -12, 4, 0, 0, -12]
            Expected Output: [-12, 34, 40, -5, -12, 4, 0, 0, -12]",
            @"arr: [9, 0, 15, 9]
            Expected Output: [9, 15, 9]",
            @"arr: [-6, 6, -6]
            Expected Output: [-6, 6, -6]",
            @"arr: [26, 26, -17]
            Expected Output: [26, 26, -17]",
            @"arr: [-7, 5, 5, 10]
            Expected Output: [-7, 10, 10]"
        );
    }
    /*
        Imported: 2020-04-26 13:20
        By:       Casper
        Url:      https://app.codesignal.com/arcade/code-arcade/list-forest-edge/bq2XnSr5kbHqpHGJC
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
    }
}
