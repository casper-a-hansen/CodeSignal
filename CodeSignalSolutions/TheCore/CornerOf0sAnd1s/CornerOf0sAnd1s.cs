/*
    Imported:   2020-04-26 13:17
    Created By: Casper
    Url:        https://app.codesignal.com/arcade/code-arcade
*/
using NUnit.Framework;
using CodeSignalSolutions;
using CodeSignalSolutions.TheCore.CornerOf0sAnd1s;

namespace TheCore
{
    public class CornerOf0sAnd1s
    {
    /*
        Imported: 2020-04-26 13:17
        By:       Casper
        Url:      https://app.codesignal.com/arcade/code-arcade/corner-of-0s-and-1s/b5z4P2r2CGCtf8HCR
    */
    [Test]
    public void killKThBit()
    {
        Test.Execute(typeof(killKthBitClass),
            @"n: 37
            k: 3
            Expected Output: 33",
            @"n: 37
            k: 4
            Expected Output: 37",
            @"n: 37
            k: 2
            Expected Output: 37",
            @"n: 0
            k: 4
            Expected Output: 0",
            @"n: 2147483647
            k: 16
            Expected Output: 2147450879",
            @"n: 374823748
            k: 13
            Expected Output: 374819652",
            @"n: 2734827
            k: 4
            Expected Output: 2734819",
            @"n: 1084197039
            k: 15
            Expected Output: 1084197039",
            @"n: 1160825071
            k: 3
            Expected Output: 1160825067",
            @"n: 2039063284
            k: 4
            Expected Output: 2039063284"
        );
    }
    /*
        Imported: 2020-04-26 13:17
        By:       Casper
        Url:      https://app.codesignal.com/arcade/code-arcade/corner-of-0s-and-1s/KeMqde6oqfF5wBXxf
    */
    [Test]
    public void arrayPacking()
    {
        Test.Execute(typeof(arrayPackingClass),
            @"a: [24, 85, 0]
            Expected Output: 21784",
            @"a: [23, 45, 39]
            Expected Output: 2567447",
            @"a: [1, 2, 4, 8]
            Expected Output: 134480385",
            @"a: [5]
            Expected Output: 5",
            @"a: [187, 99, 42, 43]
            Expected Output: 724198331"
        );
    }
    /*
        Imported: 2020-04-26 13:17
        By:       Casper
        Url:      https://app.codesignal.com/arcade/code-arcade/corner-of-0s-and-1s/eC2Zxu5H5SnuKxvPT
    */
    [Test]
    public void rangeBitCount()
    {
        Test.Execute(typeof(rangeBitCountClass),
            @"a: 2
            b: 7
            Expected Output: 11",
            @"a: 0
            b: 1
            Expected Output: 1",
            @"a: 1
            b: 10
            Expected Output: 17",
            @"a: 8
            b: 9
            Expected Output: 3",
            @"a: 9
            b: 10
            Expected Output: 4"
        );
    }
    /*
        Imported: 2020-04-26 13:17
        By:       Casper
        Url:      https://app.codesignal.com/arcade/code-arcade/corner-of-0s-and-1s/e3zfPNTwTa9qTQzcX
    */
    [Test]
    public void mirrorBits()
    {
        Test.Execute(typeof(mirrorBitsClass),
            @"a: 97
            Expected Output: 67",
            @"a: 8
            Expected Output: 1",
            @"a: 123
            Expected Output: 111",
            @"a: 86782
            Expected Output: 65173",
            @"a: 5
            Expected Output: 5"
        );
    }
    /*
        Imported: 2020-04-26 13:17
        By:       Casper
        Url:      https://app.codesignal.com/arcade/code-arcade/corner-of-0s-and-1s/9nSj6DgqLDsBePJha
    */
    [Test]
    public void secondRightmostZeroBit()
    {
        Test.Execute(typeof(secondRightmostZeroBitClass),
            @"n: 37
            Expected Output: 8",
            @"n: 1073741824
            Expected Output: 2",
            @"n: 83748
            Expected Output: 2",
            @"n: 4
            Expected Output: 2",
            @"n: 728782938
            Expected Output: 4"
        );
    }
    /*
        Imported: 2020-04-26 13:17
        By:       Casper
        Url:      https://app.codesignal.com/arcade/code-arcade/corner-of-0s-and-1s/dShYZZT4WmvpmfpgB
    */
    [Test]
    public void swapAdjacentBits()
    {
        Test.Execute(typeof(swapAdjacentBitsClass),
            @"n: 13
            Expected Output: 14",
            @"n: 74
            Expected Output: 133",
            @"n: 1073741823
            Expected Output: 1073741823",
            @"n: 0
            Expected Output: 0",
            @"n: 1
            Expected Output: 2",
            @"n: 83748
            Expected Output: 166680"
        );
    }
    /*
        Imported: 2020-04-26 13:18
        By:       Casper
        Url:      https://app.codesignal.com/arcade/code-arcade/corner-of-0s-and-1s/whz5JzszYTdXW6aNA
    */
    [Test]
    public void differentRightmostBit()
    {
        Test.Execute(typeof(differentRightmostBitClass),
            @"n: 11
            m: 13
            Expected Output: 2",
            @"n: 7
            m: 23
            Expected Output: 16",
            @"n: 1
            m: 0
            Expected Output: 1",
            @"n: 64
            m: 65
            Expected Output: 1",
            @"n: 1073741823
            m: 1071513599
            Expected Output: 131072",
            @"n: 42
            m: 22
            Expected Output: 4"
        );
    }
    /*
        Imported: 2020-04-26 13:18
        By:       Casper
        Url:      https://app.codesignal.com/arcade/code-arcade/corner-of-0s-and-1s/6SLJChm9N3fEgr2R7
    */
    [Test]
    public void equalPairOfBits()
    {
        Test.Execute(typeof(equalPairOfBitsClass),
            @"n: 10
            m: 11
            Expected Output: 2",
            @"n: 0
            m: 0
            Expected Output: 1",
            @"n: 28
            m: 27
            Expected Output: 8",
            @"n: 895
            m: 928
            Expected Output: 32",
            @"n: 1073741824
            m: 1006895103
            Expected Output: 262144"
        );
    }
    }
}
