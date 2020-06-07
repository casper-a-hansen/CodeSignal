/*
    Imported:   2020-06-07 11:38
    Created By: Casper
    Url:        https://app.codesignal.com/arcade/graphs-arcade
*/
using NUnit.Framework;
using CodeSignalSolutions;
using CodeSignalSolutions.Graphs.Orienteering;

namespace Graphs
{
    public class Orienteering
    {
        /*
            Imported: 2020-06-07 11:38
            By:       Casper
            Url:      https://app.codesignal.com/arcade/graphs-arcade/orienteering/TYt5rotw5phqWRuTF
        */
        [Test]
        public void orienteeringBeginner()
        {
            Test.Execute(typeof(orienteeringBeginnerClass),
                @"n: 6
                roads:
                [[[1,3]],
                 [[4,1],[3,2]],
                 [[1,0]],
                 [[5,3]],
                 [[5,5]],
                 []]
                Expected Output: 8",
                @"n: 5
                roads:
                [[[1,50],[3,10]],
                 [[2,15]],
                 [[4,55]],
                 [[1,5]],
                 []]
                Expected Output: 85",
                @"n: 5
                roads:
                [[[3,53],[2,59],[1,17]],
                 [[4,30]],
                 [[4,5]],
                 [[4,4]],
                 []]
                Expected Output: 47",
                @"n: 6
                roads:
                [[[4,3],[3,5]],
                 [[2,0],[5,1]],
                 [[5,0]],
                 [[1,6],[4,2]],
                 [[5,2],[2,4]],
                 []]
                Expected Output: 5",
                @"n: 10
                roads:
                [[[3,220],[8,971]],
                 [],
                 [],
                 [[8,455],[2,915],[9,743]],
                 [],
                 [[8,616]],
                 [[8,857],[4,480],[9,62]],
                 [[3,274],[8,319],[2,390]],
                 [],
                 []]
                Expected Output: 963",
                @"n: 6
                roads:
                [[[1,5],[2,3]],
                 [[3,6],[2,2]],
                 [[4,4],[5,2],[3,7]],
                 [[4,0]],
                 [[5,0]],
                 []]
                Expected Output: 5",
                @"n: 14
                roads:
                [[[12,75],[7,33],[8,93]],
                 [[10,84],[4,49]],
                 [[13,32]],
                 [[10,97],[8,100]],
                 [[13,73]],
                 [[9,54],[2,8],[4,6]],
                 [[5,66],[2,85],[4,2],[13,52]],
                 [[8,75]],
                 [],
                 [],
                 [],
                 [[5,42],[12,79],[9,15],[2,6]],
                 [[10,46],[2,25],[8,81],[4,54]],
                 []]
                Expected Output: 132",
                @"n: 10
                roads:
                [[[3,12],[8,70],[6,35],[1,72],[7,78],[2,94],[5,95],[4,22],[9,57]],
                 [[7,34],[2,21],[5,69],[4,78],[9,69]],
                 [[5,96],[4,93],[9,4]],
                 [[8,2],[6,20],[1,26],[7,30],[2,60],[5,38],[4,20],[9,85]],
                 [[9,97]],
                 [[4,80],[9,34]],
                 [[1,39],[7,52],[2,60],[5,87],[4,52],[9,85]],
                 [[2,3],[5,41],[4,13],[9,47]],
                 [[6,10],[1,73],[7,35],[2,93],[5,59],[4,41],[9,66]],
                 []]
                Expected Output: 49"
            );
        }
    }
}
