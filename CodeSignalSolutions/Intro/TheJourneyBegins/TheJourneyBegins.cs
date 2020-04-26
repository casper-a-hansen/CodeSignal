/*
    Imported:   2020-04-26 12:20
    Created By: Casper
    Url:        https://app.codesignal.com/arcade/intro
*/
using NUnit.Framework;
using CodeSignalSolutions;
using CodeSignalSolutions.Intro.TheJourneyBegins;

namespace Intro
{
    public class TheJourneyBegins
    {
    /*
        Imported: 2020-04-26 12:20
        By:       Casper
        Url:      https://app.codesignal.com/arcade/intro/level-1/jwr339Kq6e3LQTsfa
    */
    [Test]
    public void add()
    {
        Test.Execute(typeof(addClass),
            @"param1: 1
            param2: 2
            Expected Output: 3",
            @"param1: 0
            param2: 1000
            Expected Output: 1000",
            @"param1: 2
            param2: -39
            Expected Output: -37",
            @"param1: 99
            param2: 100
            Expected Output: 199",
            @"param1: -100
            param2: 100
            Expected Output: 0",
            @"param1: -1000
            param2: -1000
            Expected Output: -2000"
        );
    }
    /*
        Imported: 2020-04-26 12:21
        By:       Casper
        Url:      https://app.codesignal.com/arcade/intro/level-1/egbueTZRRL5Mm4TXN
    */
    [Test]
    public void centuryFromYear()
    {
        Test.Execute(typeof(centuryFromYearClass),
            @"year: 1905
            Expected Output: 20",
            @"year: 1700
            Expected Output: 17",
            @"year: 1988
            Expected Output: 20",
            @"year: 2000
            Expected Output: 20",
            @"year: 2001
            Expected Output: 21",
            @"year: 200
            Expected Output: 2",
            @"year: 374
            Expected Output: 4",
            @"year: 45
            Expected Output: 1",
            @"year: 8
            Expected Output: 1"
        );
    }
    /*
        Imported: 2020-04-26 12:21
        By:       Casper
        Url:      https://app.codesignal.com/arcade/intro/level-1/s5PbmwxfECC52PWyQ
    */
    [Test]
    public void checkPalindrome()
    {
        Test.Execute(typeof(checkPalindromeClass),
            @"inputString: ""aabaa""
            Expected Output: true",
            @"inputString: ""abac""
            Expected Output: false",
            @"inputString: ""a""
            Expected Output: true",
            @"inputString: ""az""
            Expected Output: false",
            @"inputString: ""abacaba""
            Expected Output: true",
            @"inputString: ""z""
            Expected Output: true",
            @"inputString: ""aaabaaaa""
            Expected Output: false",
            @"inputString: ""zzzazzazz""
            Expected Output: false",
            @"inputString: ""hlbeeykoqqqqokyeeblh""
            Expected Output: true",
            @"inputString: ""hlbeeykoqqqokyeeblh""
            Expected Output: true"
        );
    }
    }
}
