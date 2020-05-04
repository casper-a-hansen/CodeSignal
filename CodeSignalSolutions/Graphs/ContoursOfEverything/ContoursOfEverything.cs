/*
    Imported:   2020-05-04 22:59
    Created By: Casper
    Url:        https://app.codesignal.com/arcade/graphs-arcade
*/
using NUnit.Framework;
using CodeSignalSolutions;
using CodeSignalSolutions.Graphs.ContoursOfEverything;

namespace Graphs
{
    public class ContoursOfEverything
    {
        /*
            Imported: 2020-05-04 22:59
            By:       Casper
            Url:      https://app.codesignal.com/arcade/graphs-arcade/contours-of-everything/shHv7RjLBCrDFN3np
        */
        [Test]
        public void isButterfly()
        {
            Test.Execute(typeof(isButterflyClass),
                @"adj:
                [[false,true,true,false,false],
                 [true,false,true,false,false],
                 [true,true,false,true,true],
                 [false,false,true,false,true],
                 [false,false,true,true,false]]
                Expected Output: true",
                @"adj:
                [[false,true,true,true,true],
                 [true,false,true,false,false],
                 [true,true,false,false,false],
                 [true,false,false,false,true],
                 [true,false,false,true,false]]
                Expected Output: true",
                @"adj:
                [[false,false,false,false,false],
                 [false,false,true,true,false],
                 [false,true,false,false,true],
                 [false,true,false,false,true],
                 [false,false,true,true,false]]
                Expected Output: false",
                @"adj:
                [[false,true,true,false,false],
                 [true,false,true,false,false],
                 [true,true,true,true,false],
                 [false,false,true,false,true],
                 [false,false,false,true,true]]
                Expected Output: false",
                @"adj:
                [[false,true,true,false,false],
                 [true,false,true,false,false],
                 [true,true,false,false,false],
                 [false,false,false,true,true],
                 [false,false,false,true,true]]
                Expected Output: false",
                @"adj:
                [[false,true,true,true,true],
                 [true,false,true,false,false],
                 [true,true,false,false,false],
                 [true,false,false,true,true],
                 [true,false,false,true,true]]
                Expected Output: false",
                @"adj:
                [[false,true,true,true,true],
                 [true,false,true,true,true],
                 [true,true,false,true,true],
                 [true,true,true,false,true],
                 [true,true,true,true,false]]
                Expected Output: false",
                @"adj:
                [[false,false,false,false,false],
                 [false,false,false,false,false],
                 [false,false,false,false,false],
                 [false,false,false,false,false],
                 [false,false,false,false,false]]
                Expected Output: false",
                @"adj:
                [[false,true,true,false,false],
                 [true,false,false,false,true],
                 [true,false,false,true,false],
                 [false,false,true,false,true],
                 [false,true,false,true,false]]
                Expected Output: false",
                @"adj:
                [[false,true,true,true,true],
                 [true,false,false,true,false],
                 [true,false,false,false,true],
                 [true,true,false,false,false],
                 [true,false,true,false,false]]
                Expected Output: true"
            );
        }
    }
}
