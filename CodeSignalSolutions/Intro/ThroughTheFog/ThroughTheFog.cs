/*
    Imported:   2020-05-02 12:01
    Created By: Casper
    Url:        https://app.codesignal.com/arcade/intro
*/
using NUnit.Framework;
using CodeSignalSolutions;
using CodeSignalSolutions.Intro.ThroughTheFog;

namespace Intro
{
    public class ThroughTheFog
    {
        /*
            Imported: 2020-05-02 12:01
            By:       Casper
            Url:      https://app.codesignal.com/arcade/intro/level-7/vExYvcGnFsEYSt8nQ
        */
        [Test]
        public void circleOfNumbers()
        {
            Test.Execute(typeof(circleOfNumbersClass),
                @"n: 10
                firstNumber: 2
                Expected Output: 7",
                @"n: 10
                firstNumber: 7
                Expected Output: 2",
                @"n: 4
                firstNumber: 1
                Expected Output: 3",
                @"n: 6
                firstNumber: 3
                Expected Output: 0",
                @"n: 18
                firstNumber: 6
                Expected Output: 15",
                @"n: 12
                firstNumber: 10
                Expected Output: 4",
                @"n: 18
                firstNumber: 5
                Expected Output: 14"
            );
        }
        /*
            Imported: 2020-05-02 12:01
            By:       Casper
            Url:      https://app.codesignal.com/arcade/intro/level-7/8PxjMSncp9ApA4DAb
        */
        [Test]
        public void depositProfit()
        {
            Test.Execute(typeof(depositProfitClass),
                @"deposit: 100
                rate: 20
                threshold: 170
                Expected Output: 3",
                @"deposit: 100
                rate: 1
                threshold: 101
                Expected Output: 1",
                @"deposit: 1
                rate: 100
                threshold: 64
                Expected Output: 6",
                @"deposit: 20
                rate: 20
                threshold: 50
                Expected Output: 6",
                @"deposit: 50
                rate: 25
                threshold: 100
                Expected Output: 4"
            );
        }
        /*
            Imported: 2020-05-02 12:02
            By:       Casper
            Url:      https://app.codesignal.com/arcade/intro/level-7/PTWhv2oWqd6p4AHB9
        */
        [Test]
        public void stringsRearrangement()
        {
            Test.Execute(typeof(stringsRearrangementClass),
                @"inputArray:
                [""aba"",
                 ""bbb"",
                 ""bab""]
                Expected Output: false",
                @"inputArray:
                [""ab"",
                 ""bb"",
                 ""aa""]
                Expected Output: true",
                @"inputArray:
                [""q"",
                 ""q""]
                Expected Output: false",
                @"inputArray:
                [""zzzzab"",
                 ""zzzzbb"",
                 ""zzzzaa""]
                Expected Output: true",
                @"inputArray:
                [""ab"",
                 ""ad"",
                 ""ef"",
                 ""eg""]
                Expected Output: false",
                @"inputArray:
                [""abc"",
                 ""bef"",
                 ""bcc"",
                 ""bec"",
                 ""bbc"",
                 ""bdc""]
                Expected Output: true",
                @"inputArray:
                [""abc"",
                 ""abx"",
                 ""axx"",
                 ""abc""]
                Expected Output: false",
                @"inputArray:
                [""abc"",
                 ""abx"",
                 ""axx"",
                 ""abx"",
                 ""abc""]
                Expected Output: true",
                @"inputArray:
                [""f"",
                 ""g"",
                 ""a"",
                 ""h""]
                Expected Output: true",
                @"inputArray:
                [""ff"",
                 ""gf"",
                 ""af"",
                 ""ar"",
                 ""hf""]
                Expected Output: true",
                @"inputArray:
                [""a"",
                 ""b"",
                 ""c""]
                Expected Output: true"
            );
        }
        /*
            Imported: 2020-05-02 21:36
            By:       Casper
            Url:      https://app.codesignal.com/arcade/intro/level-7/ZFnQkq9RmMiyE6qtq
        */
        [Test]
        public void absoluteValuesSumMinimization()
        {
            Test.Execute(typeof(absoluteValuesSumMinimizationClass),
                @"a: [2, 4, 7]
                Expected Output: 4",
                @"a: [2, 3]
                Expected Output: 2",
                @"a: [1, 1, 3, 4]
                Expected Output: 1",
                @"a: [23]
                Expected Output: 23",
                @"a: [-10, -10, -10, -10, -10, -9, -9, -9, -8, -8, -7, -6, -5, -4, -3, -2, -1, 0, 0, 0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50]
                Expected Output: 15",
                @"a: [-4, -1]
                Expected Output: -4",
                @"a: [0, 7, 9]
                Expected Output: 7",
                @"a: [-1000000, -10000, -10000, -1000, -100, -10, -1, 0, 1, 10, 100, 1000, 10000, 100000, 1000000]
                Expected Output: 0",
                @"a: [
                      -10,
                      -9,
                      -8,
                      -7,
                      -6,
                      -5,
                      -4,
                      -3,
                      -2,
                      -1,0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,98,99,100,110,111,112,113,114,115,116,117,118,119,120,121,122,123,124,125,126,127,128,129,130,131,132,133,134,135,136,137,138,139,140,141,142,143,144,145,146,147,148,149,150]
                Expected Output: 65",
                @"a: [
                      -10,100,200,300,400,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500,500]
                Expected Output: 500"
            );
        }
    }
}
