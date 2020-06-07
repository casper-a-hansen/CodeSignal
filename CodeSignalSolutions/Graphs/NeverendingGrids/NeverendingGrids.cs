/*
    Imported:   2020-05-23 21:03
    Created By: Casper
    Url:        https://app.codesignal.com/arcade/graphs-arcade
*/
using NUnit.Framework;
using CodeSignalSolutions;
using CodeSignalSolutions.Graphs.NeverendingGrids;

namespace Graphs
{
    public class NeverendingGrids
    {
        /*
            Imported: 2020-05-23 21:03
            By:       Casper
            Url:      https://app.codesignal.com/arcade/graphs-arcade/neverending-grids/HY68Gv9BWPLefQ7CT
        */
        [Test]
        public void digitJumping()
        {
            Test.Execute(typeof(digitJumpingClass),
                @"grid:
                [[0,1,4,2,3],
                 [1,4,2,8,2],
                 [2,2,3,4,9],
                 [8,7,2,2,3]]
                start: [0, 0]
                finish: [3, 4]
                Expected Output: 4",
                @"grid: [[5,3,6]]
                start: [0, 1]
                finish: [0, 1]
                Expected Output: 0",
                @"grid:
                [[1],
                 [2],
                 [3],
                 [4],
                 [5],
                 [6],
                 [7],
                 [8],
                 [9],
                 [0]]
                start: [9, 0]
                finish: [0, 0]
                Expected Output: 9",
                @"grid:
                [[1,2,3,0,4,3],
                 [5,6,2,3,9,5],
                 [5,3,2,5,6,7],
                 [0,2,5,6,3,1]]
                start: [0, 0]
                finish: [3, 5]
                Expected Output: 1",
                @"grid: [[9]]
                start: [0, 0]
                finish: [0, 0]
                Expected Output: 0",
                @"grid: [[0]]
                start: [0, 0]
                finish: [0, 0]
                Expected Output: 0",
                @"grid:
                [[7,3,1,0,9,5],
                 [5,8,9,8,1,9],
                 [6,7,3,3,7,3],
                 [5,7,7,3,9,5],
                 [3,6,8,0,2,6],
                 [5,9,0,9,6,1],
                 [5,2,6,3,7,8],
                 [1,9,9,0,6,8],
                 [3,3,2,9,2,5]]
                start: [6, 3]
                finish: [6, 1]
                Expected Output: 2",
                @"grid: [[3,2,9,3,9,3,7,6,6,5,0,9,8,2,9],
                [6,2,9,2,8,0,4,7,7,3,2,4,8,1,2],
                [9,3,0,5,4,7,1,6,2,2,8,7,4,1,2],
                [3,4,2,9,6,9,9,5,9,9,3,2,5,7,2],
                [3,8,8,0,3,9,1,0,9,0,7,6,0,2,2],
                [8,2,7,0,2,8,3,1,2,3,2,9,5,0,4],
                [4,1,4,5,1,9,6,3,2,9,3,2,5,9,3],
                [1,3,0,1,5,5,0,6,2,7,5,2,4,8,8],
                [7,8,7,1,4,3,4,0,4,2,4,6,2,9,0],
                [5,9,9,9,0,1,5,5,3,2,4,9,9,3,0],
                [1,9,5,7,2,7,0,9,0,1,4,8,3,2,8],
                [0,3,5,3,0,1,7,7,0,3,4,3,0,1,3],
                [2,7,0,4,0,6,2,4,8,3,7,3,1,2,7],
                [3,0,0,9,1,6,4,7,5,0,1,7,9,4,4],
                [7,7,6,8,1,2,8,8,5,8,4,5,1,2,5]]
                start: [11,13]
                finish: [11,6]
                Expected Output: 2",
                @"grid:
                [[7,2,5,0,7,0,3,8,6,8],
                 [1,4,8,1,3,0,4,0,5,4],
                 [5,7,7,0,6,9,0,4,2,6],
                 [3,9,1,6,9,6,8,9,1,3],
                 [7,5,2,1,2,2,8,3,0,3],
                 [2,9,5,7,6,1,2,3,6,6],
                 [6,4,7,9,1,5,1,8,9,2],
                 [1,1,8,9,6,1,7,3,5,8],
                 [5,8,5,2,3,2,7,9,7,5]]
                start: [7, 1]
                finish: [7, 7]
                Expected Output: 3",
                @"grid: [[5,6,9,0,7,1,2,8,3,5],
                [7,6,2,0,5,8,4,5,7,2],
                [6,3,8,5,2,1,7,3,8,4],
                [1,2,2,0,2,9,4,5,5,2],
                [4,6,6,0,2,4,4,2,4,0],
                [0,5,6,6,3,9,1,3,0,9],
                [4,5,5,0,6,8,2,9,9,5],
                [2,1,5,3,8,7,2,4,7,1],
                [2,8,9,8,1,2,9,6,8,5],
                [3,2,1,7,2,7,6,7,4,7],
                [2,0,8,2,4,0,2,1,0,0],
                [6,3,2,3,3,8,4,4,4,9],
                [5,7,1,3,9,9,6,1,0,0]]
                start: [7,3]
                finish: [3,5]
                Expected Output: 3"
            );
        }
        /*
            Imported: 2020-05-29 07:39
            By:       Casper
            Url:      https://app.codesignal.com/arcade/graphs-arcade/neverending-grids/DAgKs7P6tw5CrYnkG
        */
        [Test]
        public void painterBot()
        {
            Test.Execute(typeof(painterBotClass),
                @"canvas:
                [[0,1,5,2,4,2,6],
                 [5,2,4,6,2,0,0],
                 [3,3,3,7,8,3,2],
                 [2,1,1,0,0,0,0]]
                operations:
                [[0,0,10],
                 [1,3,3]]
                d: 3
                Expected Output: [[10,10,3,2,4,10,6],
                 [5,10,3,3,10,10,10],
                 [10,10,10,3,3,10,10],
                 [10,10,10,10,10,10,10]]",
                @"canvas: [[5]]
                operations: []
                d: 10
                Expected Output: [[5]]",
                @"canvas:
                [[0,20,0,7,1,3,12,0],
                 [3,20,15,7,4,3,6,11],
                 [1,9,11,6,2,13,2,11],
                 [15,17,15,10,7,9,16,9]]
                operations:
                [[0,5,6],
                 [3,6,19],
                 [0,1,13],
                 [0,5,1],
                 [2,2,16],
                 [0,6,13],
                 [0,0,17],
                 [1,1,15],
                 [2,2,13],
                 [2,1,17]]
                d: 3
                Expected Output: [[17,17,0,1,1,1,13,0],
                 [17,17,17,1,1,1,1,11],
                 [17,17,17,1,1,13,1,11],
                 [17,17,17,17,1,1,19,9]]",
                @"canvas:
                [[24,0,20,33,2],
                 [10,49,31,4,19],
                 [49,19,18,43,38],
                 [17,45,19,49,18],
                 [50,40,25,1,1],
                 [21,34,8,42,33],
                 [37,28,31,14,4],
                 [16,17,15,44,6],
                 [10,42,37,15,46],
                 [12,47,10,11,38]]
                operations:
                [[7,3,35],
                 [0,3,39],
                 [2,1,21],
                 [2,4,28],
                 [8,1,46],
                 [8,3,44],
                 [9,3,1],
                 [1,1,13],
                 [8,0,8],
                 [9,4,18]]
                d: 5
                Expected Output: [[24,0,20,39,2],
                 [10,13,31,4,19],
                 [49,21,21,28,28],
                 [17,45,21,49,18],
                 [50,40,25,1,1],
                 [21,34,8,42,33],
                 [37,28,31,14,4],
                 [16,17,15,35,6],
                 [8,1,1,1,1],
                 [8,1,1,1,18]]",
                @"canvas:
                [[45,29,32,10,23],
                 [39,44,20,40,21],
                 [35,6,42,0,43],
                 [24,26,46,37,2],
                 [25,6,17,43,36],
                 [27,13,33,41,44],
                 [46,1,18,2,3],
                 [28,35,24,24,43],
                 [21,9,9,22,31],
                 [12,47,38,30,29],
                 [47,38,25,10,20],
                 [23,7,42,26,30],
                 [9,20,20,50,9],
                 [20,21,48,25,28],
                 [26,40,14,39,47]]
                operations:
                [[11,3,48],
                 [3,1,50],
                 [5,4,24],
                 [14,2,5],
                 [13,2,46],
                 [9,4,13],
                 [8,1,33],
                 [14,4,35],
                 [8,4,15],
                 [13,0,47],
                 [1,1,36],
                 [14,2,50],
                 [10,2,1],
                 [12,4,21],
                 [7,0,49],
                 [12,3,31],
                 [6,1,32],
                 [12,1,7],
                 [9,3,5],
                 [14,0,40]]
                d: 10
                Expected Output: [[40,40,40,40,40],
                 [40,40,40,40,40],
                 [40,40,40,40,40],
                 [40,40,40,40,40],
                 [40,40,40,40,40],
                 [40,40,40,40,40],
                 [40,40,40,40,40],
                 [40,40,40,40,40],
                 [40,40,40,40,40],
                 [40,40,40,40,40],
                 [40,40,40,40,40],
                 [40,40,40,40,40],
                 [40,40,40,40,40],
                 [40,40,40,40,40],
                 [40,40,40,40,40]]",
                @"canvas:
                [[1,33,50,32,12,28,10,44,0,10,7,31,19,9,25,32,2,12,15,6],
                 [43,14,6,34,50,7,31,48,22,19,4,1,39,33,36,7,42,2,15,9]]
                operations:
                [[0,16,7],
                 [1,5,47],
                 [0,16,30],
                 [1,17,0],
                 [1,7,11],
                 [1,14,5],
                 [0,4,8],
                 [0,10,23],
                 [1,15,38],
                 [1,12,5]]
                d: 8
                Expected Output: [[1,33,50,32,8,28,23,23,23,23,23,31,19,5,5,5,5,5,5,5],
                 [43,14,6,34,50,47,31,23,22,19,23,23,5,5,5,5,5,5,5,5]]",
                @"canvas: [[111,149,168,21,113,122,141,143,254,8,56,156,11,67,140,219,224,250,54,131],
                [252,251,27,218,187,227,222,58,215,137,109,153,204,182,52,58,174,188,226,224],
                [227,151,110,183,105,64,20,235,212,255,1,198,93,159,204,234,42,9,139,67],
                [135,250,100,200,66,92,8,144,208,239,71,170,251,193,57,148,197,111,85,25],
                [149,32,237,7,235,127,177,205,60,165,18,219,104,15,71,17,70,246,12,223],
                [145,150,36,49,145,107,232,33,173,47,161,128,215,134,180,117,42,139,17,194],
                [138,196,158,72,90,106,22,190,143,102,185,190,26,79,128,231,244,24,85,30],
                [60,100,3,158,85,233,172,27,57,168,210,249,82,49,100,195,126,95,169,154],
                [97,203,108,49,34,65,225,128,142,246,96,46,220,166,75,0,26,39,14,34],
                [203,203,234,47,171,173,12,67,130,220,205,43,102,4,244,127,237,208,81,112],
                [186,251,231,1,79,10,134,183,85,79,19,58,226,102,212,232,219,77,114,38],
                [4,95,246,219,148,56,82,131,255,70,245,255,55,69,238,177,167,210,0,226],
                [80,94,52,113,14,119,62,201,67,100,60,170,47,197,181,123,95,231,25,166],
                [4,114,69,58,179,34,123,244,28,165,171,147,6,139,189,189,57,175,44,55],
                [151,135,234,125,97,88,156,50,220,33,70,32,17,116,16,175,15,196,76,195],
                [71,9,120,91,92,35,156,32,162,226,75,146,199,55,178,138,149,82,244,44],
                [113,228,197,158,53,136,167,248,59,28,25,145,178,97,233,120,35,159,54,165],
                [15,84,149,167,145,200,8,25,95,124,19,1,10,139,90,253,227,141,57,39],
                [84,17,131,238,98,205,114,224,15,89,33,213,150,65,205,236,169,242,244,236],
                [188,57,15,229,239,244,4,183,1,231,74,130,191,189,42,150,13,72,177,174]]
                operations: [[10,1,96],[7,4,3],[1,7,205],[12,11,179],[11,2,228],[5,4,107],[19,3,251],[3,6,196],[10,1,175],[11,6,41],[9,17,80],[16,2,92],[15,16,51],[18,10,39],[11,3,88],[10,0,201],[0,1,248],[19,3,1],[17,17,220],[7,10,177]]
                d: 20
                Expected Output: [[111,248,248,21,113,122,141,143,254,8,56,156,11,67,140,219,224,250,54,131],
                [252,251,27,218,187,227,222,205,215,137,109,153,204,182,52,58,174,188,226,224],
                [227,151,110,183,105,64,196,235,212,255,1,198,93,159,204,234,42,9,139,67],
                [135,250,100,200,66,92,196,144,208,239,71,170,251,193,57,148,197,111,85,25],
                [149,32,237,7,235,127,177,205,60,165,18,219,104,15,71,17,70,246,12,223],
                [145,150,36,49,107,107,232,33,173,47,161,128,215,134,180,117,42,139,17,194],
                [138,196,158,3,3,106,22,190,143,102,185,190,26,79,128,231,244,24,85,30],
                [60,100,3,158,3,233,172,27,57,168,177,249,82,49,100,195,126,95,169,154],
                [97,203,201,49,34,65,225,128,142,246,96,46,220,166,75,0,26,39,14,34],
                [203,203,201,47,171,173,12,67,130,220,205,43,102,4,244,127,237,80,81,112],
                [201,201,201,1,79,10,134,183,85,79,19,58,226,102,212,232,219,77,114,38],
                [4,201,201,201,148,56,41,131,255,70,245,255,55,69,238,177,167,210,0,226],
                [201,201,52,113,14,119,41,201,67,100,60,179,47,197,181,123,95,231,25,166],
                [4,201,201,58,179,34,123,244,28,165,171,147,6,139,189,189,57,175,44,55],
                [151,135,234,125,97,88,156,50,220,33,70,32,17,116,16,175,15,196,76,195],
                [71,9,120,91,92,35,156,32,162,226,75,146,199,55,178,51,51,82,244,44],
                [113,228,92,158,53,136,167,248,59,39,39,145,178,97,233,120,35,220,54,165],
                [15,84,149,167,145,200,8,25,95,124,39,1,10,139,90,253,227,220,57,39],
                [84,17,131,1,98,205,114,224,15,89,39,213,150,65,205,236,169,242,244,236],
                [188,57,15,1,1,1,4,183,1,231,74,130,191,189,42,150,13,72,177,174]]"
            );
        }
        /*
            Imported: 2020-05-29 21:22
            By:       Casper
            Url:      https://app.codesignal.com/arcade/graphs-arcade/neverending-grids/ASAZNscPBXpRNrvkL
        */
        [Test]
        public void horsebot()
        {
            Test.Execute(typeof(horsebotClass),
                @"n: 3
                m: 3
                Expected Output: 3",
                @"n: 7
                m: 2
                Expected Output: 2",
                @"n: 8
                m: 7
                Expected Output: 8",
                @"n: 4
                m: 4
                Expected Output: 4",
                @"n: 4
                m: 3
                Expected Output: 2",
                @"n: 7
                m: 4
                Expected Output: 4"
            );
        }
        /*
            Imported: 2020-05-30 09:44
            By:       Casper
            Url:      https://app.codesignal.com/arcade/graphs-arcade/neverending-grids/HPiABBdPjKW8JvLAy
        */
        [Test]
        public void sabotage()
        {
            Test.Execute(typeof(sabotageClass),
                @"hangar:
                [[""U"",""L""],
                 [""R"",""L""]]
                Expected Output: 2",
                @"hangar:
                [[""U"",""L"",""D""],
                 [""L"",""U"",""D""],
                 [""L"",""R"",""L""]]
                Expected Output: 4",
                @"hangar:
                [[""D"",""D"",""L"",""L""],
                 [""R"",""R"",""D"",""L""],
                 [""D"",""U"",""R"",""U""],
                 [""R"",""L"",""L"",""L""],
                 [""D"",""L"",""R"",""U""],
                 [""D"",""D"",""R"",""D""],
                 [""L"",""U"",""R"",""D""],
                 [""D"",""L"",""R"",""R""],
                 [""D"",""U"",""D"",""L""]]
                Expected Output: 20",
                @"hangar:
                [[""D"",""U""],
                 [""U"",""R""],
                 [""L"",""L""],
                 [""R"",""U""]]
                Expected Output: 2",
                @"hangar: [[""R"",""L"",""R"",""U"",""R""]]
                Expected Output: 2",
                @"hangar:
                [[""U""],
                 [""L""],
                 [""L""],
                 [""D""],
                 [""U""]]
                Expected Output: 2"
            );
        }
        /*
            Imported: 2020-05-30 16:09
            By:       Casper
            Url:      https://app.codesignal.com/arcade/graphs-arcade/neverending-grids/7NJiCELH4yxhc8hpJ
        */
        [Test]
        public void electricField()
        {
            Test.Execute(typeof(electricFieldClass),
                @"grid: [4, 8]
                wires:
                [[1,0,1,3],
                 [3,1,3,2],
                 [4,1,4,3],
                 [4,2,4,4],
                 [1,3,3,3],
                 [2,1,7,1],
                 [2,2,7,2],
                 [5,3,8,3]]
                Expected Output: 26",
                @"grid: [5, 3]
                wires:
                [[1,0,1,3],
                 [2,2,2,4]]
                Expected Output: 6",
                @"grid: [1, 1]
                wires: []
                Expected Output: 0",
                @"grid: [2, 4]
                wires: [[2,0,2,2]]
                Expected Output: -1",
                @"grid: [10, 10]
                wires:
                [[2,8,2,0],
                 [6,7,1,7],
                 [8,10,8,5],
                 [9,6,3,6],
                 [5,1,5,6],
                 [6,4,10,4],
                 [7,2,7,5],
                 [3,2,6,2],
                 [1,9,7,9],
                 [7,6,7,10],
                 [9,7,9,9],
                 [9,7,10,7],
                 [9,9,10,9]]
                Expected Output: 48",
                @"grid: [12, 13]
                wires:
                [[0,2,8,2],
                 [5,1,5,5],
                 [6,1,6,5],
                 [6,1,9,1],
                 [10,1,10,9],
                 [7,3,12,3],
                 [3,3,3,11],
                 [1,6,7,6],
                 [3,7,13,7],
                 [0,8,2,8],
                 [1,10,13,10],
                 [1,10,1,11],
                 [5,11,5,12],
                 [7,11,7,12],
                 [9,11,13,11]]
                Expected Output: 53",
                @"grid: [20,10]
                wires: [[1,0,1,19],[1,19,2,19],[2,19,2,0],[3,20,3,1],[3,1,4,1],[4,1,4,20],[5,0,5,19],[5,19,6,19],[6,19,6,0],[7,20,7,1],[7,1,8,1],[8,1,8,20],[8,1,9,1],[9,3,10,3],[9,2,10,2],[9,6,10,6],[9,7,10,7],[9,10,10,10],[9,11,10,11],[9,15,10,15],[9,14,10,14],[9,19,10,19],[9,18,10,18],[8,4,9,4],[8,5,9,5],[8,8,9,8],[8,9,9,9],[8,12,9,12],[8,13,9,13],[8,16,9,16],[8,17,9,17],[9,2,9,3],[9,6,9,7],[9,10,9,11],[9,14,9,15],[9,18,9,19],[9,4,9,5],[9,8,9,9],[9,12,9,13],[9,16,9,17]]
                Expected Output: 114"
            );
        }
        /*
            Imported: 2020-06-01 20:14
            By:       Casper
            Url:      https://app.codesignal.com/arcade/graphs-arcade/neverending-grids/hvJfAuqSX3HDjDZ6P
        */
        [Test]
        public void mobiusConquer()
        {
            Test.Execute(typeof(mobiusConquerClass),
                @"field: [4, 3]
                ratiorg: [0, 0, 0]
                enemy: [1, 3, 2]
                impassableCells:
                [[0,0,1],
                 [0,1,1],
                 [0,2,1],
                 [0,2,2],
                 [1,1,0],
                 [1,2,1],
                 [1,3,0]]
                Expected Output: [7, 6]",
                @"field: [1, 1]
                ratiorg: [0, 0, 0]
                enemy: [1, 0, 0]
                impassableCells: []
                Expected Output: [1, 1]",
                @"field: [2, 2]
                ratiorg: [1, 1, 1]
                enemy: [1, 0, 0]
                impassableCells:
                [[0,0,0],
                 [0,1,0],
                 [0,0,1],
                 [0,1,1],
                 [1,0,1],
                 [1,1,0]]
                Expected Output: [1, 1]",
                @"field: [3, 5]
                ratiorg: [1, 0, 0]
                enemy: [1, 1, 3]
                impassableCells:
                [[0,0,3],
                 [0,0,4],
                 [0,1,2],
                 [0,2,0],
                 [1,2,1],
                 [1,0,2],
                 [1,2,4]]
                Expected Output: [8, 13]",
                @"field: [8, 2]
                ratiorg: [1, 3, 1]
                enemy: [1, 6, 1]
                impassableCells:
                [[1,3,0],
                 [0,1,1],
                 [0,2,0],
                 [0,0,0]]
                Expected Output: [16, 12]",
                @"field: [8, 4]
                ratiorg: [1, 4, 0]
                enemy: [1, 3, 2]
                impassableCells:
                [[0,2,1],
                 [1,0,3],
                 [0,6,3],
                 [1,3,0],
                 [0,5,3],
                 [1,0,2],
                 [0,1,1],
                 [1,0,1]]
                Expected Output: [26, 30]",
                @"field: [5, 5]
                ratiorg: [1, 3, 3]
                enemy: [0, 0, 0]
                impassableCells:
                [[1,3,1],
                 [1,2,2],
                 [0,1,1],
                 [1,1,0],
                 [0,0,4],
                 [1,2,3],
                 [1,2,1],
                 [0,3,1]]
                Expected Output: [18, 24]",
                @"field: [7, 9]
                ratiorg: [1, 2, 7]
                enemy: [0, 2, 3]
                impassableCells:
                [[0,2,7],
                 [1,3,4],
                 [1,5,7],
                 [0,4,6],
                 [0,6,6],
                 [0,0,1],
                 [0,1,7],
                 [0,1,8],
                 [1,4,3],
                 [1,4,6],
                 [0,0,4],
                 [1,6,5],
                 [1,6,7],
                 [1,2,4],
                 [0,2,1],
                 [1,6,1],
                 [1,6,8],
                 [1,0,8],
                 [1,4,7]]
                Expected Output: [51, 56]",
                @"field: [1, 5]
                ratiorg: [0, 0, 3]
                enemy: [1, 0, 1]
                impassableCells: []
                Expected Output: [5, 5]",
                @"field: [8, 6]
                ratiorg: [1, 0, 0]
                enemy: [1, 5, 4]
                impassableCells:
                [[0,6,0],
                 [0,7,2],
                 [1,6,5],
                 [0,7,5],
                 [0,3,1],
                 [1,4,0],
                 [0,0,0],
                 [1,1,2],
                 [1,6,4],
                 [1,2,3],
                 [0,2,2],
                 [0,3,4],
                 [0,5,2],
                 [0,3,2],
                 [0,7,1],
                 [0,0,4]]
                Expected Output: [30, 50]"
            );
        }
        /*
            Imported: 2020-06-05 07:23
            By:       Casper
            Url:      https://app.codesignal.com/arcade/graphs-arcade/neverending-grids/kpp94L9QXMdaHrQ5X
        */
        [Test]
        public void cuboidPlanet()
        {
            Test.Execute(typeof(cuboidPlanetClass),
                /*@"cuboid: [6, 4, 8]
                impassableCells: []
                Expected Output: 0"/*,*/
                @"cuboid: [1, 2, 3]
                impassableCells:
                [[1,0,0],
                 [3,0,1],
                 [3,2,0],
                 [4,0,1],
                 [5,1,0]]
                Expected Output: 106",
                @"cuboid: [2, 2, 2]
                impassableCells:
                [[1,0,1],
                 [1,1,0],
                 [3,1,0],
                 [3,1,1]]
                Expected Output: 131",
                @"cuboid: [5, 2, 7]
                impassableCells: []
                Expected Output: 0",
                @"cuboid: [1, 1, 1]
                impassableCells: [[3,0,0]]
                Expected Output: 6",
                @"cuboid: [1, 2, 3]
                impassableCells:
                [[3,1,0],
                 [3,1,1]]
                Expected Output: 100",
                @"cuboid: [8,5,8]
                impassableCells: [[1,0,3],[1,4,2],[4,7,1],[1,2,1],[5,2,0],[3,3,1],[5,6,3],[3,4,1],[0,5,0],[5,3,2],[4,1,2],[3,7,4],[3,1,4],[5,2,2],[1,4,3],[3,3,0],[0,6,4],[3,4,3],[1,0,4],[2,0,7],[2,6,6],[2,3,3],[3,7,1],[0,2,2],[3,0,1],[3,2,2],[5,5,4],[4,5,2],[1,6,4],[0,6,7],[3,7,3],[0,2,4],[0,0,3],[5,1,0],[5,0,4],[0,7,7],[3,1,0],[5,7,1],[1,1,0],[1,7,4],[4,1,0],[2,1,7],[4,6,1],[0,0,0],[3,6,3],[0,7,2],[5,6,1],[0,1,5],[4,2,4],[1,1,1],[5,0,0],[2,5,2],[3,5,1],[2,2,2],[5,0,1],[1,6,2],[5,1,3],[2,5,5],[2,4,0],[1,1,2],[1,7,1],[1,5,1],[4,7,3],[2,3,4],[4,6,3]]
                Expected Output: 5790",
                @"cuboid: [2,10,9]
                impassableCells: [[5,0,4],[1,0,5],[2,0,8],[4,1,8],[5,2,7],[1,0,0],[0,0,8],[4,1,9],[3,4,0],[3,4,1],[0,1,4],[3,1,7],[3,0,6],[0,1,5],[4,0,1],[5,2,3],[0,1,6],[3,1,3],[4,0,0],[1,0,3],[0,0,6],[0,1,7],[2,1,8],[2,0,6],[0,0,5],[5,0,6],[4,0,6],[2,0,1],[0,0,4],[3,7,3],[5,7,2],[0,0,3],[3,8,3],[4,1,6],[2,1,7],[4,0,4],[3,1,1],[0,0,2],[2,0,2],[2,1,5],[0,0,0],[5,4,7],[4,0,9],[3,5,2],[1,1,1],[4,1,2],[3,5,0],[4,0,5],[5,8,6],[5,1,6],[3,5,7],[1,1,5],[1,1,4]]
                Expected Output: 1772",
                @"cuboid: [4, 2, 5]
                impassableCells:
                [[5,4,0],
                 [2,2,2],
                 [0,3,0],
                 [1,1,0],
                 [0,1,2],
                 [2,1,1],
                 [1,3,1],
                 [2,2,0],
                 [2,1,4],
                 [3,0,0],
                 [4,1,1],
                 [3,1,1],
                 [1,2,0],
                 [2,3,1],
                 [3,4,1]]
                Expected Output: 793",
                @"cuboid: [6,9,10]
                impassableCells: [[1,4,4],[0,0,8],[1,4,2],[2,0,7],[3,8,0],[3,1,4],[0,4,8],[5,0,4],[2,0,3],[3,1,0],[3,0,4],[0,4,2],[1,2,6],[1,5,7],[2,5,5],[4,3,6],[5,3,6],[0,1,0],[0,4,6],[1,3,3],[3,4,7],[2,3,6],[2,3,0],[1,0,7],[2,3,2],[4,0,0],[1,1,8],[5,4,3],[3,3,7],[2,4,4],[2,1,7],[0,2,0],[2,4,6],[0,3,1],[4,2,5],[4,5,6],[0,3,7],[5,9,6],[1,1,0],[3,5,0],[2,1,1],[4,2,1],[4,2,3],[3,5,4],[2,3,5],[1,1,6],[5,2,0],[5,2,2],[3,7,7],[2,0,4],[5,5,2],[2,0,6],[5,5,4],[1,2,1],[3,2,1],[2,5,0],[4,1,0],[1,2,3],[2,5,6],[4,1,2],[3,2,5],[2,3,9],[3,9,4],[1,3,6],[1,5,6],[0,4,7],[5,8,4],[5,6,5],[0,1,1],[5,6,3],[2,3,7],[0,3,8],[1,3,0],[4,3,3],[1,0,6],[2,4,1],[0,1,7],[5,1,0],[4,0,5],[0,3,0],[5,7,0],[3,5,3],[0,3,6],[3,5,1],[1,1,3],[3,8,8],[3,0,1],[1,4,6],[3,5,5],[2,0,9]]
                Expected Output: 0",
                @"cuboid: [10,4,8]
                impassableCells: [[2,7,1],[1,5,3],[1,3,2],[5,6,3],[1,5,2],[1,3,1],[4,0,0],[5,2,0],[2,7,3],[2,4,4],[5,5,1],[2,8,2],[3,4,1],[1,4,2],[2,9,5],[4,0,2],[2,0,5],[4,9,3],[5,2,2],[2,2,3],[3,2,3],[3,3,3],[2,0,4],[4,3,1],[2,7,6],[5,5,2],[2,9,0],[3,2,2],[5,1,1],[1,7,0],[0,0,5],[5,4,2],[4,1,3],[5,7,3],[0,0,4],[5,4,3],[2,5,2],[0,6,0],[0,6,3],[1,2,1],[4,5,0],[1,8,3],[3,1,0],[2,6,1],[3,0,0],[3,6,2],[0,9,2],[3,6,1],[3,4,0],[4,5,1],[0,4,3],[0,5,7],[1,0,1],[1,6,1],[5,0,1],[1,6,2],[5,3,0],[1,1,3],[2,1,1],[1,1,2],[0,1,1],[5,6,0],[3,1,2],[2,6,5],[4,7,3],[1,3,3]]
                Expected Output: 1397",
                @"cuboid: [10,9,4]
                impassableCells: [[5,2,6],[1,4,7],[5,0,5],[4,2,2],[0,2,2],[0,1,1],[5,2,7],[1,6,1],[1,1,6],[0,8,2],[4,3,2],[1,4,5],[3,3,1],[0,8,1],[5,2,1],[5,3,2],[3,0,3],[1,7,7],[0,8,0],[2,3,1],[2,6,2],[0,2,0],[3,3,2],[1,0,5],[3,3,5],[3,1,4],[1,9,3],[2,9,1],[5,1,0],[2,0,1],[4,5,1],[5,1,3],[0,6,0],[0,0,3],[5,3,1],[0,9,0],[5,1,2],[2,0,3],[3,1,3],[2,2,2],[0,5,1],[2,0,2],[2,6,1],[5,0,2],[4,2,5],[2,6,0],[3,0,4],[2,1,2],[4,8,1],[2,1,0],[2,2,3],[4,1,2],[0,7,3],[5,1,1],[4,6,3],[0,7,0],[1,3,7],[0,5,3],[1,2,6],[4,8,7],[4,0,5],[1,2,7],[1,4,8],[4,0,3],[5,3,7],[2,2,0],[1,8,5],[5,3,6],[1,5,8],[4,7,3],[1,9,6]]
                Expected Output: 770"
            );
        }
        /*
            Imported: 2020-06-06 16:54
            By:       Casper
            Url:      https://app.codesignal.com/arcade/graphs-arcade/neverending-grids/sPEWN2g9LDk87RYpm
        */
        [Test]
        public void tankbot()
        {
            Test.Execute(typeof(tankbotClass),
                @"forest:
                [[true,true,true,true],
                 [true,true,false,true],
                 [true,true,true,true],
                 [true,true,true,true]]
                Expected Output: 2",
                @"forest:
                [[false,true,true],
                 [true,true,true]]
                Expected Output: 0",
                @"forest:
                [[true,true,false,true,true],
                 [true,true,true,true,true],
                 [true,true,true,true,true]]
                Expected Output: 2",
                @"forest:
                [[true,true,true,true,true,true],
                 [true,true,true,true,true,false],
                 [true,true,true,true,true,true],
                 [true,true,true,true,true,true]]
                Expected Output: 2",
                @"forest:
                [[true,true,true],
                 [true,true,true],
                 [true,true,true]]
                Expected Output: 3",
                @"forest:
                [[true,false,true,true,true],
                 [true,false,true,false,true],
                 [true,true,true,false,true]]
                Expected Output: 1",
                @"forest:
                [[true,true,true,true,true],
                 [true,true,true,true,true],
                 [true,true,true,true,false]]
                Expected Output: 0",
                @"forest:
                [[true,true,true,true,true,true,true],
                 [true,true,true,true,true,true,false],
                 [true,true,true,true,true,true,true],
                 [true,true,true,true,true,true,true],
                 [true,true,true,true,true,true,true]]
                Expected Output: 3",
                @"forest:
                [[true,true,false,true,false],
                 [true,true,true,false,false],
                 [true,true,true,true,true],
                 [false,true,true,true,true]]
                Expected Output: 2"
            );
        }
        /*
            Imported: 2020-06-07 10:18
            By:       Casper
            Url:      https://app.codesignal.com/arcade/graphs-arcade/neverending-grids/9dANZWyT332KTyJCw
        */
        [Test]
        public void portals()
        {
            Test.Execute(typeof(portalsClass),
                @"maxTime: 4
                manacost:
                [[1,-1,-1],
                 [5,-1,-1],
                 [4,6,8]]
                Expected Output: 0",
                @"maxTime: 3
                manacost:
                [[1,-1,-1],
                 [5,-1,-1],
                 [4,6,8]]
                Expected Output: 5",
                @"maxTime: 0
                manacost: [[20]]
                Expected Output: 0",
                @"maxTime: 3
                manacost:
                [[3,2,-1,4,5],
                 [5,-1,1,-1,-1],
                 [5,5,-1,-1,1]]
                Expected Output: 3",
                @"maxTime: 50
                manacost:
                [[2,2,-1,4,5],
                 [5,-1,1,-1,-1],
                 [5,5,-1,-1,1]]
                Expected Output: 3",
                @"maxTime: 4
                manacost:
                [[1,-1,9,10,11],
                 [2,-1,8,-1,12],
                 [3,-1,7,-1,13],
                 [4,5,6,-1,14]]
                Expected Output: 11",
                @"maxTime: 15
                manacost:
                [[50,30,66,36,-1,44,-1,-1,33,47],
                 [13,-1,42,-1,53,-1,19,-1,-1,2],
                 [39,95,40,1,-1,-1,-1,30,46,23],
                 [17,-1,-1,78,-1,20,27,36,-1,70],
                 [11,44,42,73,-1,-1,31,45,45,65],
                 [-1,62,-1,3,64,22,79,-1,60,26],
                 [-1,-1,95,-1,92,38,26,-1,24,25],
                 [-1,87,-1,79,16,90,11,-1,26,27],
                 [67,1,10,-1,45,39,82,77,48,65],
                 [20,80,54,20,-1,-1,83,-1,44,27]]
                Expected Output: 3"
            );
        }
    }
}
