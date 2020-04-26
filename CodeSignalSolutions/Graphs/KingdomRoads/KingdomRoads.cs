/*
    Imported:   2020-04-26 23:45
    Created By: Casper
    Url:        https://app.codesignal.com/arcade/graphs-arcade
*/
using NUnit.Framework;
using CodeSignalSolutions;
using CodeSignalSolutions.Graphs.KingdomRoads;

namespace Graphs
{
    public class KingdomRoads
    {
        /*
            Imported: 2020-04-26 23:45
            By:       Casper
            Url:      https://app.codesignal.com/arcade/graphs-arcade/kingdom-roads/nCMisf4ZKpDLdHevE
        */
        [Test]
        public void newRoadSystem()
        {
            Test.Execute(typeof(newRoadSystemClass),
                @"roadRegister:
                [[false,true,false,false], 
                 [false,false,true,false], 
                 [true,false,false,true], 
                 [false,false,true,false]]
                Expected Output: true",
                @"roadRegister:
                [[false,true,false,false,false,false,false], 
                 [true,false,false,false,false,false,false], 
                 [false,false,false,true,false,false,false], 
                 [false,false,true,false,false,false,false], 
                 [false,false,false,false,false,false,true], 
                 [false,false,false,false,true,false,false], 
                 [false,false,false,false,false,true,false]]
                Expected Output: true",
                @"roadRegister:
                [[false,true,false], 
                 [false,false,false], 
                 [true,false,false]]
                Expected Output: false",
                @"roadRegister:
                [[false,false,false,false], 
                 [false,false,false,false], 
                 [false,false,false,false], 
                 [false,false,false,false]]
                Expected Output: true",
                @"roadRegister: [[false]]
                Expected Output: true",
                @"roadRegister:
                [[false,true,true,true,false], 
                 [true,false,true,true,true], 
                 [true,true,false,true,false], 
                 [true,true,true,false,true], 
                 [true,true,true,true,false]]
                Expected Output: false",
                @"roadRegister:
                [[false,true,true,true,true], 
                 [true,false,true,true,true], 
                 [true,true,false,true,true], 
                 [true,true,true,false,true], 
                 [true,true,true,true,false]]
                Expected Output: true",
                @"roadRegister:
                [[false,true,false,true,true], 
                 [false,false,false,false,true], 
                 [true,false,false,true,true], 
                 [true,true,true,false,false], 
                 [true,true,true,false,false]]
                Expected Output: false",
                @"roadRegister:
                [[false,true,true,false,true], 
                 [true,false,false,true,false], 
                 [false,true,false,true,false], 
                 [true,true,true,false,true], 
                 [true,true,false,false,false]]
                Expected Output: false",
                @"roadRegister:
                [[false,true,false,true,true], 
                 [true,false,true,true,true], 
                 [false,false,false,false,true], 
                 [false,false,true,false,true], 
                 [true,false,true,true,false]]
                Expected Output: false",
                @"roadRegister:
                [[false,false,false,false,true,true,false,true,false,true], 
                 [false,false,true,false,false,false,true,false,false,true], 
                 [false,false,false,true,false,false,false,true,false,true], 
                 [false,true,false,false,true,false,false,true,false,false], 
                 [false,true,false,true,false,false,false,true,false,false], 
                 [true,true,true,true,true,false,true,false,true,true], 
                 [false,false,true,true,true,true,false,false,false,true], 
                 [true,true,true,false,false,false,false,false,false,false], 
                 [false,false,false,true,false,true,true,true,false,false], 
                 [false,true,true,true,true,false,true,false,true,false]]
                Expected Output: false",
                @"The test case is too large and is shown truncated
                roadRegister:
                [[false,false,false,false,true,true,true,true,true,true,false,true,true,true], 
                 [true,false,true,true,false,true,true,true,true,false,false,true,false,false], 
                 [false,false,false,true,false,false,true,true,false,true,false,true,true,false], 
                 [true,true,false,false,true,true,false,false,false,true,true,true,false,true], 
                 [false,true,true,true,false,true,true,true,false,false,true,false,true,false], 
                 [true,true,false,true,true,false,true,false,true,true,true,true,true,true], 
                 [true,false,true,true,false,true,false,false,false,false,true,true,true,true], 
                 [false,true]]
                Expected Output: true"
            );
        }
    }
}
