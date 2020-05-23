/*
    Imported:   2020-05-11 19:58
    Created By: Casper
    Url:        https://app.codesignal.com/arcade/graphs-arcade
*/
using NUnit.Framework;
using CodeSignalSolutions;
using CodeSignalSolutions.Graphs.InThePseudoforest;
using System.Collections.Generic;
using System;
using System.Linq;

namespace Graphs
{
    public class InThePseudoforest
    {
        /*
            Imported: 2020-05-11 19:58
            By:       Casper
            Url:      https://app.codesignal.com/arcade/graphs-arcade/in-the-pseudoforest/kqiRXc3R35xPfZyCf
        */
        [Test]
        public void isWoodMagical()
        {
            Test.Execute(typeof(isWoodMagicalClass),
                @"n: 5
                wmap:
                [[1,2],
                 [1,3],
                 [1,4],
                 [0,2],
                 [4,0]]
                Expected Output: true",
                @"n: 5
                wmap:
                [[1,2],
                 [1,3],
                 [1,4],
                 [0,2],
                 [4,0],
                 [1,0]]
                Expected Output: false",
                @"n: 1
                wmap: []
                Expected Output: true",
                @"n: 1
                wmap: [[0,0]]
                Expected Output: false",
                @"n: 2
                wmap: [[0,0]]
                Expected Output: false",
                @"n: 2
                wmap: [[0,1]]
                Expected Output: true",
                @"n: 3
                wmap:
                [[0,1],
                 [2,1]]
                Expected Output: true",
                @"n: 3
                wmap:
                [[2,1],
                 [0,1],
                 [2,0]]
                Expected Output: false",
                @"n: 10
                wmap:
                [[2,1],
                 [0,1],
                 [2,4]]
                Expected Output: true",
                @"n: 6
                wmap:
                [[2,1],
                 [0,1],
                 [2,4],
                 [4,5],
                 [5,3],
                 [3,0]]
                Expected Output: true"
            );
        }
        /*
            Imported: 2020-05-14 23:37
            By:       Casper
            Url:      https://app.codesignal.com/arcade/graphs-arcade/in-the-pseudoforest/PfY5xCr3SYfSmAgar
        */
        [Test]
        public void walkingInTheWoods()
        {
            Test.Execute(typeof(walkingInTheWoodsClass),
                @"n: 5
                wmap:
                [[0,1],
                 [2,1],
                 [0,2],
                 [3,4]]
                Expected Output: 1",
                @"n: 6
                wmap:
                [[0,1],
                 [2,1],
                 [0,2],
                 [3,4]]
                Expected Output: 2",
                @"n: 1
                wmap: []
                Expected Output: 0",
                @"n: 2
                wmap: []
                Expected Output: 1",
                @"n: 2
                wmap:
                [[0,1],
                 [0,0]]
                Expected Output: 0",
                @"n: 3
                wmap:
                [[0,0],
                 [2,2],
                 [1,1]]
                Expected Output: 2",
                @"n: 11
                wmap:
                [[1,7],
                 [1,5],
                 [1,9],
                 [5,4],
                 [4,8],
                 [7,0],
                 [3,2],
                 [3,6],
                 [6,10],
                 [2,6]]
                Expected Output: 1",
                @"n: 11
                wmap: []
                Expected Output: 10"
            );
        }
        /*
            Imported: 2020-05-14 23:38
            By:       Casper
            Url:      https://app.codesignal.com/arcade/graphs-arcade/in-the-pseudoforest/4neXxESSsRy92ghTD
        */
        [Test]
        public void isPseudoforest()
        {
            Test.Execute(typeof(isPseudoforestClass),
                @"n: 7
                wmap:
                [[0,1],
                 [1,2],
                 [2,3],
                 [3,1],
                 [3,4],
                 [5,6]]
                Expected Output: true",
                @"n: 7
                wmap:
                [[0,1],
                 [1,2],
                 [2,3],
                 [3,1],
                 [3,4],
                 [4,0],
                 [5,6]]
                Expected Output: false",
                @"n: 1
                wmap: []
                Expected Output: true",
                @"n: 2
                wmap: [[0,1]]
                Expected Output: true",
                @"n: 3
                wmap:
                [[0,1],
                 [1,2],
                 [2,0]]
                Expected Output: true",
                @"n: 13
                wmap:
                [[4,8],
                 [1,5],
                 [10,12],
                 [9,3],
                 [3,4],
                 [12,11],
                 [8,2],
                 [2,6],
                 [0,1],
                 [11,10],
                 [7,6],
                 [5,7],
                 [6,0],
                 [7,9]]
                Expected Output: false",
                @"n: 5
                wmap:
                [[1,3],
                 [3,2],
                 [2,1],
                 [3,4],
                 [4,1]]
                Expected Output: false",
                @"n: 6
                wmap:
                [[1,3],
                 [3,2],
                 [2,1],
                 [4,5],
                 [4,0],
                 [5,0]]
                Expected Output: true",
                @"n: 100000
                wmap: []
                Expected Output: true",
                @"n: 4
                wmap:
                [[0,1],
                 [1,2],
                 [2,0],
                 [0,3],
                 [3,1],
                 [3,2]]
                Expected Output: false"
            );
        }
        /*
            Imported: 2020-05-14 23:38
            By:       Casper
            Url:      https://app.codesignal.com/arcade/graphs-arcade/in-the-pseudoforest/GeaKuCxLvje3bfsBx
        */
        [Test]
        public void burningTheWood()
        {
            Test.Execute(typeof(burningTheWoodClass),
                @"n: 5
                wmap:
                [[0,1],
                 [1,2],
                 [2,3],
                 [3,4],
                 [4,0]]
                start: 0
                k: 1
                Expected Output: [0, 1, 4]",
                @"n: 7
                wmap:
                [[0,1],
                 [1,2],
                 [2,3],
                 [3,4],
                 [4,5],
                 [5,6],
                 [6,0],
                 [4,1]]
                start: 0
                k: 2
                Expected Output: [0, 1, 2, 4, 5, 6]",
                @"n: 1
                wmap: [[0,0]]
                start: 0
                k: 2
                Expected Output: [0]",
                @"n: 2
                wmap: [[0,0]]
                start: 1
                k: 1000
                Expected Output: [1]",
                @"n: 5
                wmap:
                [[1,3],
                 [3,4]]
                start: 3
                k: 1
                Expected Output: [1, 3, 4]",
                @"n: 100
                wmap: [[30,58],[1,48],[85,73],[73,51],[81,79],[95,44],[75,79],[19,3],[79,93],[49,11],[87,36],[33,38],[73,13],[45,11],[64,48],[2,61],[44,77],[47,56],[45,51],[33,23],[4,78],[64,3],[73,77],[39,46],[64,54],[53,62],[41,28],[68,94],[97,32],[14,6],[95,14],[72,51],[29,2],[91,50],[1,15],[24,14],[10,70],[7,72],[32,55],[0,51],[40,69],[45,91],[17,96],[95,64],[82,60],[80,46],[77,61],[35,85],[23,62],[36,13],[56,98],[8,48],[72,67],[95,26],[12,68],[31,91],[9,80],[72,94],[50,5],[39,34],[9,90],[89,90],[14,59],[89,96],[43,23],[24,94],[70,96],[94,53],[57,25],[61,16],[42,53],[74,63],[52,63],[42,92],[25,24],[94,65],[97,66],[67,86],[22,18],[96,38],[15,61],[58,66],[13,50],[90,64],[18,64],[15,25],[75,16],[66,70],[77,65],[54,38],[81,23],[75,19],[86,96],[77,76],[0,83],[44,59],[67,31],[5,31],[68,48],[50,51],[4,43],[5,66],[31,57],[4,81],[95,71],[89,20],[32,75],[31,14],[72,19],[4,99],[72,49],[53,37],[23,77],[58,2],[44,20],[13,89],[6,39],[4,89],[62,31],[67,97],[24,97],[37,45],[89,31],[43,11],[74,34],[77,30],[18,59],[35,54],[79,97],[84,80],[93,76],[68,13],[69,2],[97,61],[38,34],[90,75],[23,90],[76,83],[38,95],[61,21],[81,18],[7,51],[59,35],[91,63],[89,43],[45,25],[41,93],[82,73],[69,76],[11,94],[72,22],[80,61],[68,91],[50,4],[18,30],[52,89],[18,23],[39,8],[70,17],[23,57],[66,14],[60,72],[59,78],[35,33],[34,87],[74,33],[40,30],[5,38],[7,58],[40,91],[83,74],[57,18],[40,89],[24,0],[1,5],[6,29],[9,21],[31,39],[96,69],[4,24],[55,6],[1,10],[98,94],[86,46],[13,98],[61,74],[99,48],[74,49],[38,46],[83,34],[68,59],[20,22],[99,74],[65,90],[45,32],[62,40],[7,23],[44,51]]
                start: 29
                k: 1
                Expected Output: [2,6,29]"
            );
        }
        /*
            Imported: 2020-05-17 19:24
            By:       Casper
            Url:      https://app.codesignal.com/arcade/graphs-arcade/in-the-pseudoforest/EywKKTcqGrfbavDrw
        */
        [Test]
        public void caterpillarTrees()
        {
            Test.Execute(typeof(caterpillarTreesClass),
                @"n: 21
                edges:
                [[0,1],
                 [1,2],
                 [2,3],
                 [2,4],
                 [4,5],
                 [4,6],
                 [4,7],
                 [4,8],
                 [4,9],
                 [4,10],
                 [10,11],
                 [11,12],
                 [11,13],
                 [11,14],
                 [14,15],
                 [14,16],
                 [14,17],
                 [14,18],
                 [14,19]]
                Expected Output: [2, 2]",
                @"n: 22
                edges:
                [[0,1],
                 [1,2],
                 [2,3],
                 [2,4],
                 [4,5],
                 [4,6],
                 [4,7],
                 [4,8],
                 [4,9],
                 [4,10],
                 [10,11],
                 [11,12],
                 [11,13],
                 [11,14],
                 [14,15],
                 [14,16],
                 [14,17],
                 [14,18],
                 [14,19],
                 [13,20]]
                Expected Output: [2, 1]",
                @"n: 1
                edges: []
                Expected Output: [1, 1]",
                @"n: 2
                edges:
                [[0,1],
                 [1,1]]
                Expected Output: [0, 0]",
                @"n: 4
                edges:
                [[2,0],
                 [0,1],
                 [3,1]]
                Expected Output: [1, 1]",
                @"n: 10
                edges:
                [[0,3],
                 [0,2],
                 [3,1],
                 [3,4],
                 [3,5],
                 [3,6],
                 [7,8]]
                Expected Output: [3, 3]"
            );
        }
        /*
            Imported: 2020-05-18 20:35
            By:       Casper
            Url:      https://app.codesignal.com/arcade/graphs-arcade/in-the-pseudoforest/9MPHNYoJQeviGsBEf
        */
        [Test]
        public void isMobiusLadder()
        {
            Test.Execute(typeof(isMobiusLadderClass),
                @"n: 6
                ladder:
                [[0,1],
                 [1,2],
                 [2,3],
                 [3,4],
                 [4,5],
                 [5,0]]
                Expected Output: false",
                @"n: 8
                ladder:
                [[0,1],
                 [0,2],
                 [0,7],
                 [1,3],
                 [1,6],
                 [2,3],
                 [2,4],
                 [3,5],
                 [4,5],
                 [4,6],
                 [5,7],
                 [6,7]]
                Expected Output: true",
                @"n: 10
                ladder:
                [[0,1],
                 [0,3],
                 [0,7],
                 [0,9],
                 [1,2],
                 [1,4],
                 [1,8],
                 [2,3],
                 [2,5],
                 [2,9],
                 [3,4],
                 [3,6],
                 [4,5],
                 [4,7],
                 [5,6],
                 [5,8],
                 [6,7],
                 [6,9],
                 [7,8],
                 [8,9]]
                Expected Output: false",
                @"n: 2
                ladder: []
                Expected Output: false",
                @"n: 4
                ladder:
                [[0,1],
                 [2,3],
                 [0,2],
                 [1,3],
                 [0,3],
                 [2,1]]
                Expected Output: true",
                @"n: 6
                ladder:
                [[0,1],
                 [2,5],
                 [4,3],
                 [0,2],
                 [2,4],
                 [1,3],
                 [3,5],
                 [1,4],
                 [0,5]]
                Expected Output: false",
                @"n: 4
                ladder:
                [[0,1],
                 [2,3],
                 [0,2],
                 [0,3],
                 [2,1]]
                Expected Output: false",
                @"n: 20
                ladder:
                [[7,5],
                 [12,11],
                 [7,12],
                 [5,6],
                 [11,14],
                 [5,11],
                 [6,3],
                 [14,17],
                 [6,14],
                 [3,1],
                 [17,10],
                 [3,17],
                 [1,0],
                 [10,16],
                 [1,10],
                 [0,8],
                 [16,15],
                 [0,16],
                 [8,9],
                 [15,13],
                 [8,15],
                 [9,2],
                 [13,19],
                 [9,13],
                 [2,4],
                 [19,18],
                 [2,19],
                 [4,18],
                 [7,18],
                 [12,4]]
                Expected Output: true",
                @"n: 6
                ladder:
                [[0,1],
                 [2,3],
                 [0,3],
                 [2,1],
                 [1,4],
                 [2,5],
                 [4,5],
                 [4,3],
                 [5,0]]
                Expected Output: true",
                @"n: 6
                ladder:
                [[0,1],
                 [2,3],
                 [0,3],
                 [2,1],
                 [1,4],
                 [2,5],
                 [4,3]]
                Expected Output: false"
            );
        }
        /*
            Imported: 2020-05-19 20:49
            By:       Casper
            Url:      https://app.codesignal.com/arcade/graphs-arcade/in-the-pseudoforest/Sby2j4SHqDncwyQjh
        */
        [Test]
        public void treeDiameter()
        {
            Test.Execute(typeof(treeDiameterClass),
                @"n:10
                tree:[[0,1],[1,2],[2,3],[3,4],[4,5],[4,6],[2,7],[7,8],[7,9]]
                Expected Output: 5",
                @"n: 10
                tree:
                [[2,5],
                 [5,7],
                 [5,1],
                 [1,9],
                 [1,0],
                 [7,6],
                 [6,3],
                 [3,8],
                 [8,4]]
                Expected Output: 7",
                @"n: 1
                tree: []
                Expected Output: 0",
                @"n: 2
                tree: [[1,0]]
                Expected Output: 1",
                @"n: 3
                tree:
                [[1,2],
                 [2,0]]
                Expected Output: 2",
                @"n: 5
                tree:
                [[3,0],
                 [3,4],
                 [2,3],
                 [3,1]]
                Expected Output: 2",
                @"n: 40
                tree:
                [[28,26],
                 [26,18],
                 [18,10],
                 [10,3],
                 [3,32],
                 [32,22],
                 [22,14],
                 [14,38],
                 [38,13],
                 [13,25],
                 [25,19],
                 [19,12],
                 [12,6],
                 [6,34],
                 [34,23],
                 [23,1],
                 [1,20],
                 [20,9],
                 [9,36],
                 [36,17],
                 [17,16],
                 [16,5],
                 [5,2],
                 [2,39],
                 [39,30],
                 [30,0],
                 [0,21],
                 [21,24],
                 [24,8],
                 [8,27],
                 [27,33],
                 [33,15],
                 [15,7],
                 [7,37],
                 [37,31],
                 [31,29],
                 [29,4],
                 [4,35],
                 [35,11]]
                Expected Output: 39"
            );
        }
        /*
            Imported: 2020-05-22 20:47
            By:       Casper
            Url:      https://app.codesignal.com/arcade/graphs-arcade/in-the-pseudoforest/HNjswnTuPkYkmDavw
        */
        [Test]
        public void squirrelAndNut()
        {
            Test.Execute(typeof(squirrelAndNutClass),
                @"tree: [1, 2, 1, 3, 2, 4, 3, 5, 3, 6]
                triples:
                [[4,6,3],
                 [1,4,2],
                 [5,6,1]]
                Expected Output: [true, true, false]",
                @"tree: [1, 2, 1, 3, 1, 4, 2, 5, 2, 7, 5, 6, 4, 8, 4, 9, 9, 10]
                triples:
                [[6,7,2],
                 [6,7,5],
                 [2,10,1],
                 [7,2,1],
                 [10,8,4],
                 [8,10,3],
                 [7,8,1]]
                Expected Output: [true, true, true, false, true, false, true]",
                @"tree: [9, 1, 7, 3, 2, 4, 9, 5, 4, 6, 2, 7, 10, 8, 3, 9, 3, 10]
                triples:
                [[4,3,7],
                 [7,6,9],
                 [8,7,5],
                 [2,9,3],
                 [3,10,7]]
                Expected Output: [true, false, false, true, false]",
                @"tree: [11, 1, 7, 2, 1, 3, 8, 4, 12, 5, 12, 6, 6, 7, 9, 8, 13, 9, 8, 10, 13, 11, 11, 12, 6, 14, 8, 15]
                triples:
                [[2,4,1],
                 [4,8,2],
                 [8,10,12],
                 [7,4,10],
                 [6,10,4],
                 [2,8,9],
                 [6,3,2],
                 [3,4,10],
                 [4,6,10],
                 [2,10,3],
                 [7,10,12],
                 [9,8,7],
                 [4,7,10],
                 [7,1,6],
                 [8,4,9],
                 [9,7,5],
                 [6,10,7],
                 [6,2,3],
                 [5,8,4],
                 [1,4,3],
                 [10,2,8],
                 [2,10,5],
                 [1,3,10],
                 [6,9,8],
                 [1,3,6],
                 [8,9,5],
                 [9,6,5],
                 [5,6,10],
                 [5,8,10],
                 [7,3,5]]
                Expected Output: [false, false, false, false, false, true, false, false, false, false, true, false, false, true, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false]",
                @"tree: [10, 1, 5, 3, 5, 4, 2, 5, 5, 6, 2, 7, 5, 8, 6, 9, 6, 10]
                triples:
                [[9,1,10],
                 [7,2,8],
                 [5,3,2],
                 [6,1,4],
                 [6,2,1],
                 [6,9,1],
                 [6,1,7],
                 [10,2,9],
                 [1,2,5],
                 [3,5,9],
                 [1,7,3],
                 [2,6,7],
                 [8,7,6],
                 [5,6,1],
                 [9,6,1],
                 [10,8,1],
                 [3,9,4],
                 [8,4,9],
                 [7,5,8],
                 [10,1,4],
                 [2,4,6],
                 [9,4,10],
                 [10,8,6],
                 [1,6,5],
                 [8,6,5],
                 [5,6,10],
                 [10,2,1],
                 [3,9,4],
                 [4,9,6],
                 [6,10,1]]
                Expected Output: [true, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, true, false, false, false, true, false]",
                @"tree: [1,2,1,3,3,4,1,5,5,6,2,7,2,8,5,9,8,10,10,11,11,12,10,13,12,14,3,15,1,16,14,17,8,18,12,19,6,20,15,21,7,22,1,23,18,24,20,25,23,26,20,27,19,28,28,29,22,30,29,31]
                triples: [[27,19,11],[16,12,8],[31,13,12],[29,16,2],[27,18,3],[9,4,2],[24,7,1],[16,8,1],[19,2,1],[26,5,3],[30,16,13],[31,28,13],[15,10,2],[16,14,5],[29,16,10],[10,3,1],[16,4,2],[29,11,8],[30,4,1],[20,18,4],[6,3,1],[23,15,13],[30,8,7],[28,16,3],[21,11,9],[22,11,8],[8,4,1],[3,2,1],[6,4,1],[7,6,3],[4,2,1],[21,12,6],[6,2,1],[14,4,3],[23,8,6],[16,12,7],[30,21,6],[16,6,2],[31,14,9],[14,11,9],[3,2,1],[31,6,2],[26,3,2],[6,4,3],[8,6,3],[21,5,4],[19,12,7],[22,12,7],[26,15,6],[20,5,2],[14,12,7]]
                Expected Output: [true,true,true,true,false,false,false,true,false,false,false,false,true,false,true,true,false,false,true,false,true,false,true,false,false,true,true,true,true,false,true,false,true,true,false,false,false,false,false,false,true,true,false,true,false,false,false,true,false,false,false]",
                @"tree: [1, 2, 1, 3, 2, 4, 2, 5, 3, 6, 1, 7, 6, 8, 8, 9, 5, 10, 9, 11, 6, 12, 4, 13, 4, 14, 6, 15, 6, 16, 1, 17, 15, 18, 14, 19, 17, 20, 7, 21, 3, 22, 7, 23, 12, 24, 4, 25, 15, 26, 14, 27]
                triples:
                [[24,2,1],
                 [6,2,1],
                 [24,9,8],
                 [4,2,1],
                 [21,8,6],
                 [13,4,1],
                 [26,18,7],
                 [19,6,2],
                 [21,7,1],
                 [27,9,2],
                 [16,3,1],
                 [17,12,7],
                 [3,2,1],
                 [26,18,11],
                 [20,9,5],
                 [19,18,2],
                 [5,2,1],
                 [22,3,2]]
                Expected Output: [true, true, true, false, true, false, false, true, false, true, false, false, true, false, false, true, false, false]",
                @"tree: [1,2,1,3,3,4,3,5,1,6,5,7,5,8,3,9,3,10,9,11,9,12,4,13,11,14,1,15,6,16,16,17,3,18,13,19,9,20,10,21,10,22,13,23,5,24,16,25,24,26,1,27,24,28,1,29,1,30,25,31,8,32,17,33,14,34,3,35,8,36,31,37,36,38,10,39,27,40,40,41,16,42,38,43,28,44,22,45,10,46,2,47,18,48,9,49,27,50,34,51,11,52,15,53,44,54,37,55,35,56,41,57,18,58,16,59,9,60,9,61,49,62,29,63,46,64,56,65]
                triples: [[39,29,17],[65,14,2],[11,3,1],[28,11,6],[37,30,3],[41,14,9],[8,2,1],[14,4,1],[10,9,7],[56,21,8],[47,43,28],[6,4,2],[49,40,9],[5,4,1],[29,8,1],[13,10,1],[30,27,14],[24,6,3],[35,16,14],[65,20,4],[45,15,4],[44,11,2],[32,28,24],[24,17,7],[56,53,49],[51,44,24],[29,9,8],[14,5,1],[62,47,13],[60,24,6],[5,4,1],[46,43,14],[24,9,1],[50,42,31],[62,6,5],[18,13,11],[46,7,4],[24,17,8],[59,58,7],[23,7,1],[22,20,14],[44,16,9],[36,6,1],[40,15,13],[6,3,2],[46,13,12],[39,24,6],[47,37,24],[13,8,5],[31,24,22],[14,11,9],[43,38,12],[40,12,1],[35,3,1],[4,2,1],[30,22,12],[20,2,1],[19,17,7],[13,11,9],[49,47,8]]
                Expected Output: [false,false,false,false,false,true,true,false,false,false,false,false,true,false,true,false,false,true,false,false,false,false,true,false,false,true,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,true,false,false,false,false,false,true,false,false,false,true,false,true,false,true,false,true,false]",
                @"tree: [1,2,2,3,3,4,3,5,2,6,6,7,7,8,1,9,6,10,1,11,7,12,4,13,5,14,12,15,10,16,15,17,16,18,16,19,1,20,19,21,11,22,15,23,12,24,7,25,4,26,3,27,4,28,4,29,20,30,9,31,6,32,10,33,20,34,6,35,16,36,11,37,5,38,13,39]
                triples: [[31,12,3],[20,3,2],[15,6,1],[8,4,2],[39,27,14],[3,2,1],[23,3,1],[38,34,20],[37,21,16],[14,9,2],[23,8,4],[22,14,2],[33,6,3],[25,16,5],[14,10,5],[20,2,1],[23,2,1],[6,3,2],[13,5,3],[19,7,3],[7,2,1],[33,5,2],[13,9,2],[18,14,8],[23,11,2],[10,3,1],[16,15,7],[35,5,1],[15,8,7],[24,21,10],[19,7,1],[30,18,14],[11,10,2],[7,2,1]]
                Expected Output: [false,true,false,true,false,false,false,true,true,true,false,true,false,false,true,true,false,true,true,false,false,true,true,false,true,false,true,false,true,true,false,false,true,false]",
                @"tree: [1,2,1,3,2,4,2,5,1,6,4,7,1,8,6,9,3,10,5,11,4,12,2,13,11,14,10,15,1,16,1,17,17,18,8,19,15,20,2,21,15,22,20,23,21,24,17,25,2,26,21,27,24,28,21,29,18,30,24,31,21,32,5,33,3,34,20,35]
                triples: [[28,17,7],[23,7,1],[17,3,1],[6,3,1],[11,4,1],[32,11,2],[29,28,20],[14,10,5],[31,10,8],[19,14,4],[35,4,2],[26,20,15],[19,4,3],[28,10,8],[13,10,4],[32,10,6],[26,9,8],[16,9,3],[18,11,6],[16,10,9],[9,3,1],[33,16,6],[25,16,8],[25,11,8],[24,17,14],[9,5,2],[33,26,8],[34,13,6],[32,5,4],[14,6,5],[8,3,2],[3,2,1],[22,14,10],[11,6,1],[25,7,4],[26,6,2],[15,11,6],[5,3,1],[28,23,7],[32,31,16],[33,24,23],[17,9,5],[17,4,2],[22,15,13],[16,2,1],[22,16,6],[20,2,1],[29,4,3],[31,30,11],[18,11,3],[5,2,1],[19,3,2],[33,28,2],[31,2,1],[28,12,6],[31,9,5],[24,18,3],[25,11,10],[9,8,5],[6,3,2],[5,3,2],[19,3,2]]
                Expected Output: [false,true,true,true,false,true,false,true,false,false,true,true,false,false,false,false,false,false,false,false,true,false,false,false,false,true,false,false,false,true,false,true,true,true,true,true,false,true,false,false,false,false,true,false,true,false,true,false,false,false,false,false,true,false,false,false,false,false,false,false,true,false]"
            );
        }
    }
}
