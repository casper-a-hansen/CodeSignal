/*
    Imported:   2020-05-02 13:07
    Created By: Casper
    Url:        https://app.codesignal.com/arcade/code-arcade
*/
using NUnit.Framework;
using CodeSignalSolutions;
using CodeSignalSolutions.TheCore.SortingOutpost;

namespace TheCore
{
    public class SortingOutpost
    {
        /*
            Imported: 2020-05-02 13:07
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/sorting-outpost/s4BEFMcpLdGbjX9KX
        */
        [Test]
        public void shuffledArray()
        {
            Test.Execute(typeof(shuffledArrayClass),
                @"shuffled: [1, 12, 3, 6, 2]
                Expected Output: [1, 2, 3, 6]",
                @"shuffled: [1, -3, -5, 7, 2]
                Expected Output: [-5, -3, 2, 7]",
                @"shuffled: [2, -1, 2, 2, -1]
                Expected Output: [-1, -1, 2, 2]",
                @"shuffled: [-3, -3]
                Expected Output: [-3]",
                @"shuffled: [37, 11, -37, -85, -67, 32, 90, -90, 56, 80, 37]
                Expected Output: [-90, -85, -67, -37, 11, 37, 37, 56, 80, 90]",
                @"shuffled: [18, -73, -39, 65, -65, -52]
                Expected Output: [-65, -52, -39, 18, 65]"
            );
        }
        /*
            Imported: 2020-05-02 13:08
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/sorting-outpost/D6qmdBL2NYz49XHwM
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
            Imported: 2020-05-02 13:08
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/sorting-outpost/QQB7f8ouAqY6jf7xi
        */
        [Test]
        public void sortByLength()
        {
            Test.Execute(typeof(sortByLengthClass),
                @"inputArray:
                [""abc"",
                 """",
                 ""aaa"",
                 ""a"",
                 ""zz""]
                Expected Output: ["""", ""a"", ""zz"", ""abc"", ""aaa""]",
                @"inputArray:
                [""zz"",
                 """",
                 ""bb"",
                 ""ccc"",
                 ""cc""]
                Expected Output: ["""", ""zz"", ""bb"", ""cc"", ""ccc""]",
                @"inputArray:
                [""abc"",
                 ""e"",
                 ""abcd""]
                Expected Output: [""e"",
                 ""abc"",
                 ""abcd""]",
                @"inputArray:
                [""a"",
                 ""c"",
                 ""a"",
                 ""a""]
                Expected Output: [""a"",
                 ""c"",
                 ""a"",
                 ""a""]",
                @"inputArray:
                [""thitl"",
                 """",
                 ""sadhxirg"",
                 ""hx"",
                 ""ondyxds"",
                 ""kncor"",
                 ""sqrg"",
                 ""hqtchyxku"",
                 ""rl"",
                 ""wd""]
                Expected Output: ["""", ""hx"", ""rl"", ""wd"", ""sqrg"", ""thitl"", ""kncor"", ""ondyxds"", ""sadhxirg"", ""hqtchyxku""]"
            );
        }
        /*
            Imported: 2020-05-02 13:08
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/sorting-outpost/9y4wLpcqnNozn92tG
        */
        [Test]
        public void boxesPacking()
        {
            Test.Execute(typeof(boxesPackingClass),
                @"length: [1, 3, 2]
                width: [1, 3, 2]
                height: [1, 3, 2]
                Expected Output: true",
                @"length: [1, 1]
                width: [1, 1]
                height: [1, 1]
                Expected Output: false",
                @"length: [3, 1, 2]
                width: [3, 1, 2]
                height: [3, 2, 1]
                Expected Output: false",
                @"length: [2]
                width: [3]
                height: [4]
                Expected Output: true",
                @"length: [5, 7, 4, 1, 2]
                width: [4, 10, 3, 1, 4]
                height: [6, 5, 5, 1, 2]
                Expected Output: true",
                @"length: [6, 4]
                width: [5, 3]
                height: [4, 5]
                Expected Output: true",
                @"length: [6, 3]
                width: [5, 4]
                height: [4, 5]
                Expected Output: true",
                @"length: [6, 3]
                width: [5, 5]
                height: [4, 4]
                Expected Output: true",
                @"length: [883, 807]
                width: [772, 887]
                height: [950, 957]
                Expected Output: true",
                @"length: [6, 5]
                width: [5, 3]
                height: [4, 4]
                Expected Output: true",
                @"length: [4, 10, 3, 1, 4]
                width: [5, 7, 4, 1, 2]
                height: [6, 5, 5, 1, 2]
                Expected Output: true",
                @"length: [10, 8, 6, 4, 1]
                width: [7, 7, 6, 3, 2]
                height: [9, 6, 3, 2, 1]
                Expected Output: true",
                @"length: [9980, 9984, 9981]
                width: [9980, 9984, 9983]
                height: [9981, 9984, 9982]
                Expected Output: true"
            );
        }
        /*
            Imported: 2020-05-02 13:08
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/sorting-outpost/64koZSDqndwYxFZj6
        */
        [Test]
        public void maximumSum()
        {
            Test.Execute(typeof(maximumSumClass),
                @"a: [9, 7, 2, 4, 4]
                q:
                [[1,3],
                 [1,4],
                 [0,2]]
                Expected Output: 62",
                @"a: [2, 1, 2]
                q: [[0,1]]
                Expected Output: 4",
                @"a: [5, 3, 2]
                q:
                [[0,0],
                 [0,1],
                 [1,2],
                 [0,2]]
                Expected Output: 28",
                @"a: [5, 2, 4, 1, 3]
                q:
                [[0,4],
                 [1,2],
                 [1,2]]
                Expected Output: 33",
                @"a: [4, 2, 1, 6, 5, 7, 2, 4]
                q:
                [[1,6],
                 [2,4],
                 [3,6],
                 [0,7],
                 [3,6],
                 [4,4],
                 [5,6],
                 [5,6],
                 [0,1],
                 [3,4]]
                Expected Output: 162"
            );
        }
        /*
            Imported: 2020-05-02 13:08
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/sorting-outpost/vuXQuYFReJPe6hHAf
        */
        [Test]
        public void rowsRearranging()
        {
            Test.Execute(typeof(rowsRearrangingClass),
                @"matrix:
                [[2,7,1],
                 [0,2,0],
                 [1,3,1]]
                Expected Output: false",
                @"matrix:
                [[6,4],
                 [2,2],
                 [4,3]]
                Expected Output: true",
                @"matrix:
                [[0,1],
                 [1,2],
                 [2,3],
                 [-1,4]]
                Expected Output: false",
                @"matrix:
                [[2,2,2],
                 [1,1,1]]
                Expected Output: true",
                @"matrix:
                [[1,3,1],
                 [0,2,0],
                 [1,7,2]]
                Expected Output: false",
                @"matrix:
                [[3,34,2,5,2],
                 [2,34,5,2,1]]
                Expected Output: false",
                @"matrix:
                [[0],
                 [1],
                 [2],
                 [-1]]
                Expected Output: true",
                @"matrix:
                [[293,-294,-108,284,-127,133,93],
                 [-247,-45,33,-51,12,-85,-295],
                 [-272,275,285,157,175,261,163],
                 [74,-89,-67,106,-207,47,147],
                 [-5,-56,-248,166,-55,166,212],
                 [-50,-63,155,-217,230,-298,-61],
                 [-66,181,233,-175,64,-69,-76]]
                Expected Output: false",
                @"matrix:
                [[-186,169,47,28,275,67,-118,-9,162],
                 [-296,269,-261,54,253,213,300,-52,-124],
                 [175,-205,-217,-114,-170,266,230,-38,-138],
                 [-298,295,124,-277,-279,-243,-218,-206,148],
                 [12,8,-221,-190,-175,-299,244,-169,-66],
                 [36,294,229,-144,218,19,-166,169,264]]
                Expected Output: false",
                @"matrix: [[22,149,-107,159,-158,295]]
                Expected Output: true"
            );
        }
        /*
            Imported: 2020-05-02 13:08
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/sorting-outpost/2SFFWqkhkqC7mMBse
        */
        [Test]
        public void digitDifferenceSort()
        {
            Test.Execute(typeof(digitDifferenceSortClass),
                @"a: [152, 23, 7, 887, 243]
                Expected Output: [7, 887, 23, 243, 152]",
                @"a: []
                Expected Output: []",
                @"a: [561, 798, 132, 339, 218, 724, 462, 332, 9, 343, 592, 34, 95, 292, 626, 970]
                Expected Output: [9, 34, 343, 332, 132, 798, 626, 95, 462, 724, 561, 339, 292, 592, 218, 970]",
                @"a: [8, 76, 7, 26, 7, 60, 87, 77, 72, 61, 13, 60, 8, 32, 48, 63, 82, 56, 17, 18, 28, 85, 95, 69, 95]
                Expected Output: [8, 77, 7, 7, 8, 56, 32, 87, 76, 13, 69, 85, 63, 95, 95, 48, 26, 61, 72, 28, 17, 82, 60, 60, 18]",
                @"a: [714, 13, 804, 419, 97, 850, 440, 215, 836, 408, 743, 131, 364, 846, 80, 403, 720, 618, 118, 892, 711, 682, 427, 949, 624]
                Expected Output: [131, 97, 13, 364, 624, 403, 846, 743, 215, 440, 949, 427, 836, 682, 711, 714, 892, 118, 618, 720, 80, 408, 850, 419, 804]",
                @"a: [13098, 1308, 12398, 52433, 213, 424, 213, 243, 12213, 54234, 99487, 81892, 1, 97897]
                Expected Output: [1, 97897, 12213, 243, 213, 424, 213, 54234, 52433, 99487, 81892, 12398, 1308, 13098]"
            );
        }
        /*
            Imported: 2020-05-02 13:08
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/sorting-outpost/oY6FASrCMEqkxwcAC
        */
        [Test]
        public void uniqueDigitProducts()
        {
            Test.Execute(typeof(uniqueDigitProductsClass),
                @"a: [2, 8, 121, 42, 222, 23]
                Expected Output: 3",
                @"a: [239]
                Expected Output: 1",
                @"a: [100, 101, 111]
                Expected Output: 2",
                @"a: [100, 23, 42, 239, 22339, 9999999, 456, 78, 228, 1488]
                Expected Output: 10",
                @"a: [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20]
                Expected Output: 10"
            );
        }
    }
}
