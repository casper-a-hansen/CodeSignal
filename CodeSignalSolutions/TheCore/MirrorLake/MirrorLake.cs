/*
    Imported:   2020-05-02 12:48
    Created By: Casper
    Url:        https://app.codesignal.com/arcade/code-arcade
*/
using NUnit.Framework;
using CodeSignalSolutions;
using CodeSignalSolutions.TheCore.MirrorLake;

namespace TheCore
{
    public class MirrorLake
    {
        /*
            Imported: 2020-05-02 12:48
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/mirror-lake/chW9F8bCgxYJBcgj3
        */
        [Test]
        public void stringsConstruction()
        {
            Test.Execute(typeof(stringsConstructionClass),
                @"a: ""abc""
                b: ""abccba""
                Expected Output: 2",
                @"a: ""ab""
                b: ""abcbcb""
                Expected Output: 1",
                @"a: ""ab""
                b: ""abccba""
                Expected Output: 2",
                @"a: ""b""
                b: ""abccba""
                Expected Output: 2",
                @"a: ""c""
                b: ""abccbac""
                Expected Output: 3",
                @"a: ""z""
                b: ""z""
                Expected Output: 1",
                @"a: ""z""
                b: ""y""
                Expected Output: 0",
                @"a: ""za""
                b: ""bzc""
                Expected Output: 0",
                @"a: ""hnccv""
                b: ""hncvohcjhdfnhonxddcocjncchnvohchnjohcvnhjdhihsn""
                Expected Output: 3",
                @"a: ""abc""
                b: ""def""
                Expected Output: 0",
                @"a: ""zzz""
                b: ""zzzzzzzzzzz""
                Expected Output: 3",
                @"a: ""abcabcabc""
                b: ""aaaaaaaaaaabbbbbbbbbbcccccccccc""
                Expected Output: 3",
                @"a: ""abc""
                b: ""xyz""
                Expected Output: 0",
                @"a: ""zbc""
                b: ""ydlblksdjccdddb""
                Expected Output: 0",
                @"a: ""abdd""
                b: ""adadapqrtsmnckgljj""
                Expected Output: 0",
                @"a: ""abcde""
                b: ""edbcaacbdebcedaadbecadbceecabddbaecabecdcdabeabcde""
                Expected Output: 10",
                @"a: ""abcde""
                b: ""edbcaaclpebcekbadbecadbcefcabddbaecaaaaacdakrabcde""
                Expected Output: 7",
                @"a: ""zkz""
                b: ""zpaskazgazkazggaaksiokkzzzzaaazzpkuazzzgzkzabrgzzq""
                Expected Output: 7",
                @"a: ""ggagagagga""
                b: ""gga""
                Expected Output: 0",
                @"a: ""pqrsttt""
                b: ""parfkajfraqrakjssattertjeqsqaptatdptdstasreraqprtt""
                Expected Output: 3",
                @"a: ""azgtpzzgab""
                b: ""taagzajfrqrakjzztgzgzazstppatdptdblgaasreraqprtt""
                Expected Output: 1"
            );
        }
        /*
            Imported: 2020-05-02 12:48
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/mirror-lake/rNrF4v5etMdFNKD3s
        */
        [Test]
        public void isSubstitutionCipher()
        {
            Test.Execute(typeof(isSubstitutionCipherClass),
                @"string1: ""aacb""
                string2: ""aabc""
                Expected Output: true",
                @"string1: ""aa""
                string2: ""bc""
                Expected Output: false",
                @"string1: ""aaxxaaz""
                string2: ""aazzaay""
                Expected Output: true",
                @"string1: ""aaxyaa""
                string2: ""aazzaa""
                Expected Output: false",
                @"string1: ""aabc""
                string2: ""aacb""
                Expected Output: true",
                @"string1: ""dccd""
                string2: ""zzxx""
                Expected Output: false",
                @"string1: ""ddcc""
                string2: ""zzxx""
                Expected Output: true",
                @"string1: ""aaaabbbbcc""
                string2: ""cccccccccc""
                Expected Output: false",
                @"string1: ""abcdefg""
                string2: ""hijklmn""
                Expected Output: true",
                @"string1: ""aaabbbccc""
                string2: ""aaabbbccc""
                Expected Output: true"
            );
        }
        /*
            Imported: 2020-05-02 12:49
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/mirror-lake/BsShkFDfbkWxozmMN
        */
        [Test]
        public void createAnagram()
        {
            Test.Execute(typeof(createAnagramClass),
                @"s: ""AABAA""
                t: ""BBAAA""
                Expected Output: 1",
                @"s: ""OVGHK""
                t: ""RPGUC""
                Expected Output: 4",
                @"s: ""AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAB""
                t: ""AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAC""
                Expected Output: 1",
                @"s: ""HDFFVR""
                t: ""FEDDEE""
                Expected Output: 4",
                @"s: ""AABCDS""
                t: ""BASEAE""
                Expected Output: 2",
                @"s: ""ZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZY""
                t: ""YYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYZ""
                Expected Output: 31",
                @"s: ""AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA""
                t: ""AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA""
                Expected Output: 0",
                @"s: ""AAAAAA""
                t: ""AAAAAA""
                Expected Output: 0",
                @"s: ""KJDMDLEEKALIJB""
                t: ""AFDJGDCGHMIGHB""
                Expected Output: 7",
                @"s: ""BBAAABCBCAABB""
                t: ""BBBCCCBABBACA""
                Expected Output: 2"
            );
        }
        /*
            Imported: 2020-05-02 12:49
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/mirror-lake/EeKpdMQXpBkgWjcvt
        */
        [Test]
        public void constructSquare()
        {
            Test.Execute(typeof(constructSquareClass),
                @"s: ""ab""
                Expected Output: 81",
                @"s: ""zzz""
                Expected Output: -1",
                @"s: ""aba""
                Expected Output: 900",
                @"s: ""abcbbb""
                Expected Output: 810000",
                @"s: ""abc""
                Expected Output: 961",
                @"s: ""aaaabbcde""
                Expected Output: 999950884"
            );
        }
        /*
            Imported: 2020-05-02 12:49
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/mirror-lake/kGeuCkJNbqczCCqgg
        */
        [Test]
        public void numbersGrouping()
        {
            Test.Execute(typeof(numbersGroupingClass),
                @"a: [20000, 239, 10001, 999999, 10000, 20566, 29999]
                Expected Output: 11",
                @"a: [10000, 20000, 30000, 40000, 50000, 60000, 10000, 120000, 150000, 200000, 300000, 1000000, 10000000, 100000000, 10000000]
                Expected Output: 28",
                @"a: [10000]
                Expected Output: 2",
                @"a: [10000, 1]
                Expected Output: 3",
                @"a: [685400881, 696804468, 696804942, 803902442, 976412678, 976414920, 47763597, 803900633, 233144924, 47764349, 233149077, 214990733, 214994039, 280528089, 280524347, 685401797]
                Expected Output: 24",
                @"a: [598589004, 92986320, 520103781, 808743817, 635098665, 95244159, 808747008, 867017063, 635092226, 867013865, 92989995, 520100093, 95245838, 84897101, 598583113, 84893918]
                Expected Output: 24",
                @"a: [1000000000, 999990000, 999980000, 999970000, 999960000, 999950000, 999940000, 999930000, 999920000, 999910000]
                Expected Output: 20",
                @"a: [102382103, 21039898, 39823, 433, 30928398, 40283209, 23234, 342534, 98473483, 498398424, 9384984, 9839239]
                Expected Output: 24"
            );
        }
        /*
            Imported: 2020-05-02 12:49
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/mirror-lake/fQpfgxiY6aGiGHLtv
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
            Imported: 2020-05-02 12:49
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/mirror-lake/RpoP4Aqa5mbmC8koC
        */
        [Test]
        public void mostFrequentDigitSum()
        {
            Test.Execute(typeof(mostFrequentDigitSumClass),
                @"n: 88
                Expected Output: 9",
                @"n: 8
                Expected Output: 8",
                @"n: 1
                Expected Output: 1",
                @"n: 17
                Expected Output: 9",
                @"n: 239
                Expected Output: 9",
                @"n: 994
                Expected Output: 9",
                @"n: 99999
                Expected Output: 18"
            );
        }
        /*
            Imported: 2020-05-02 12:49
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/mirror-lake/BLbGNY3kEcvKjBCFC
        */
        [Test]
        public void numberOfClans()
        {
            Test.Execute(typeof(numberOfClansClass),
                @"divisors: [2, 3]
                k: 6
                Expected Output: 4",
                @"divisors: [2, 3, 4]
                k: 6
                Expected Output: 5",
                @"divisors: [1, 3]
                k: 10
                Expected Output: 2",
                @"divisors: [6, 2, 2, 8, 9, 2, 2, 2, 2]
                k: 10
                Expected Output: 5",
                @"divisors: [2, 5]
                k: 9
                Expected Output: 3",
                @"divisors: [1, 2, 3]
                k: 8
                Expected Output: 4",
                @"divisors: [5, 6]
                k: 5
                Expected Output: 2",
                @"divisors: [7, 1, 3, 4, 4]
                k: 5
                Expected Output: 3"
            );
        }
    }
}
