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
    }
}
