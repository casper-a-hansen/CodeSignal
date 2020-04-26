/*
    Imported:   2020-04-26 12:23
    Created By: Casper
    Url:        https://app.codesignal.com/arcade/intro
*/
using NUnit.Framework;
using CodeSignalSolutions;
using CodeSignalSolutions.Intro.IslandOfKnowledge;

namespace Intro
{
    public class IslandOfKnowledge
    {
    /*
        Imported: 2020-04-26 12:23
        By:       Casper
        Url:      https://app.codesignal.com/arcade/intro/level-5/g6dc9KJyxmFjB98dL
    */
    [Test]
    public void areEquallyStrong()
    {
        Test.Execute(typeof(areEquallyStrongClass),
            @"yourLeft: 10
            yourRight: 15
            friendsLeft: 15
            friendsRight: 10
            Expected Output: true",
            @"yourLeft: 15
            yourRight: 10
            friendsLeft: 15
            friendsRight: 10
            Expected Output: true",
            @"yourLeft: 15
            yourRight: 10
            friendsLeft: 15
            friendsRight: 9
            Expected Output: false",
            @"yourLeft: 10
            yourRight: 5
            friendsLeft: 5
            friendsRight: 10
            Expected Output: true",
            @"yourLeft: 10
            yourRight: 15
            friendsLeft: 5
            friendsRight: 20
            Expected Output: false",
            @"yourLeft: 10
            yourRight: 20
            friendsLeft: 10
            friendsRight: 20
            Expected Output: true",
            @"yourLeft: 5
            yourRight: 20
            friendsLeft: 20
            friendsRight: 5
            Expected Output: true",
            @"yourLeft: 20
            yourRight: 15
            friendsLeft: 5
            friendsRight: 20
            Expected Output: false",
            @"yourLeft: 5
            yourRight: 10
            friendsLeft: 5
            friendsRight: 10
            Expected Output: true",
            @"yourLeft: 1
            yourRight: 10
            friendsLeft: 10
            friendsRight: 0
            Expected Output: false",
            @"yourLeft: 5
            yourRight: 5
            friendsLeft: 10
            friendsRight: 10
            Expected Output: false",
            @"yourLeft: 10
            yourRight: 5
            friendsLeft: 10
            friendsRight: 6
            Expected Output: false",
            @"yourLeft: 1
            yourRight: 1
            friendsLeft: 1
            friendsRight: 1
            Expected Output: true",
            @"yourLeft: 0
            yourRight: 10
            friendsLeft: 10
            friendsRight: 0
            Expected Output: true"
        );
    }
    /*
        Imported: 2020-04-26 12:23
        By:       Casper
        Url:      https://app.codesignal.com/arcade/intro/level-5/EEJxjQ7oo7C5wAGjE
    */
    [Test]
    public void arrayMaximalAdjacentDifference()
    {
        Test.Execute(typeof(arrayMaximalAdjacentDifferenceClass),
            @"inputArray: [2, 4, 1, 0]
            Expected Output: 3",
            @"inputArray: [1, 1, 1, 1]
            Expected Output: 0",
            @"inputArray: [-1, 4, 10, 3, -2]
            Expected Output: 7",
            @"inputArray: [10, 11, 13]
            Expected Output: 2",
            @"inputArray: [-2, -2, -2, -2, -2]
            Expected Output: 0",
            @"inputArray: [-1, 1, -3, -4]
            Expected Output: 4",
            @"inputArray: [-14, 15, -15]
            Expected Output: 30"
        );
    }
    /*
        Imported: 2020-04-26 13:09
        By:       Casper
        Url:      https://app.codesignal.com/arcade/intro/level-5/veW5xJednTy4qcjso
    */
    [Test]
    public void isIPv4Address()
    {
        Test.Execute(typeof(isIPv4AddressClass),
            @"inputString: ""172.16.254.1""
            Expected Output: true",
            @"inputString: ""172.316.254.1""
            Expected Output: false",
            @"inputString: "".254.255.0""
            Expected Output: false",
            @"inputString: ""1.1.1.1a""
            Expected Output: false",
            @"inputString: ""1""
            Expected Output: false",
            @"inputString: ""0.254.255.0""
            Expected Output: true",
            @"inputString: ""1.23.256.255.""
            Expected Output: false",
            @"inputString: ""1.23.256..""
            Expected Output: false",
            @"inputString: ""0..1.0""
            Expected Output: false",
            @"inputString: ""64.233.161.00""
            Expected Output: false",
            @"inputString: ""64.00.161.131""
            Expected Output: false",
            @"inputString: ""01.233.161.131""
            Expected Output: false",
            @"inputString: ""35..36.9.9.0""
            Expected Output: false",
            @"inputString: ""1.1.1.1.1""
            Expected Output: false",
            @"inputString: ""1.256.1.1""
            Expected Output: false",
            @"inputString: ""a0.1.1.1""
            Expected Output: false",
            @"inputString: ""0.1.1.256""
            Expected Output: false",
            @"inputString: ""129380129831213981.255.255.255""
            Expected Output: false",
            @"inputString: ""255.255.255.255abcdekjhf""
            Expected Output: false",
            @"inputString: ""7283728""
            Expected Output: false",
            @"inputString: ""0..1.0.0""
            Expected Output: false"
        );
    }
    /*
        Imported: 2020-04-26 13:09
        By:       Casper
        Url:      https://app.codesignal.com/arcade/intro/level-5/XC9Q2DhRRKQrfLhb5
    */
    [Test]
    public void avoidObstacles()
    {
        Test.Execute(typeof(avoidObstaclesClass),
            @"inputArray: [5, 3, 6, 7, 9]
            Expected Output: 4",
            @"inputArray: [2, 3]
            Expected Output: 4",
            @"inputArray: [1, 4, 10, 6, 2]
            Expected Output: 7",
            @"inputArray: [1000, 999]
            Expected Output: 6",
            @"inputArray: [19, 32, 11, 23]
            Expected Output: 3",
            @"inputArray: [5, 8, 9, 13, 14]
            Expected Output: 6"
        );
    }
    /*
        Imported: 2020-04-26 13:09
        By:       Casper
        Url:      https://app.codesignal.com/arcade/intro/level-5/5xPitc3yT3dqS7XkP
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
        Imported: 2020-04-26 13:09
        By:       Casper
        Url:      https://app.codesignal.com/arcade/intro/level-5/ZMR5n7vJbexnLrgaM
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
    }
}
