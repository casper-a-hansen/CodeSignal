/*
    Imported:   2020-04-26 13:16
    Created By: Casper
    Url:        https://app.codesignal.com/arcade/code-arcade
*/
using NUnit.Framework;
using CodeSignalSolutions;
using CodeSignalSolutions.TheCore.AtTheCrossroads;

namespace TheCore
{
    public class AtTheCrossroads
    {
    /*
        Imported: 2020-04-26 13:16
        By:       Casper
        Url:      https://app.codesignal.com/arcade/code-arcade/at-the-crossroads/m9wjpkCjgofg7gs8N
    */
    [Test]
    public void reachNextLevel()
    {
        Test.Execute(typeof(reachNextLevelClass),
            @"experience: 10
            threshold: 15
            reward: 5
            Expected Output: true",
            @"experience: 10
            threshold: 15
            reward: 4
            Expected Output: false",
            @"experience: 3
            threshold: 6
            reward: 4
            Expected Output: true",
            @"experience: 84
            threshold: 135
            reward: 36
            Expected Output: false",
            @"experience: 74
            threshold: 170
            reward: 58
            Expected Output: false",
            @"experience: 80
            threshold: 199
            reward: 15
            Expected Output: false",
            @"experience: 97
            threshold: 57
            reward: 7
            Expected Output: true",
            @"experience: 235
            threshold: 293
            reward: 4
            Expected Output: false",
            @"experience: 222
            threshold: 137
            reward: 58
            Expected Output: true",
            @"experience: 16
            threshold: 23
            reward: 16
            Expected Output: true"
        );
    }
    /*
        Imported: 2020-04-26 13:16
        By:       Casper
        Url:      https://app.codesignal.com/arcade/code-arcade/at-the-crossroads/r9azLYp2BDZPyzaG2
    */
    [Test]
    public void knapsackLight()
    {
        Test.Execute(typeof(knapsackLightClass),
            @"value1: 10
            weight1: 5
            value2: 6
            weight2: 4
            maxW: 8
            Expected Output: 10",
            @"value1: 10
            weight1: 5
            value2: 6
            weight2: 4
            maxW: 9
            Expected Output: 16",
            @"value1: 5
            weight1: 3
            value2: 7
            weight2: 4
            maxW: 6
            Expected Output: 7",
            @"value1: 10
            weight1: 2
            value2: 11
            weight2: 3
            maxW: 1
            Expected Output: 0",
            @"value1: 15
            weight1: 2
            value2: 20
            weight2: 3
            maxW: 2
            Expected Output: 15",
            @"value1: 2
            weight1: 5
            value2: 3
            weight2: 4
            maxW: 5
            Expected Output: 3",
            @"value1: 4
            weight1: 3
            value2: 3
            weight2: 4
            maxW: 4
            Expected Output: 4",
            @"value1: 3
            weight1: 5
            value2: 3
            weight2: 8
            maxW: 10
            Expected Output: 3"
        );
    }
    /*
        Imported: 2020-04-26 13:16
        By:       Casper
        Url:      https://app.codesignal.com/arcade/code-arcade/at-the-crossroads/sgDWKCFQHHi5D3Szj
    */
    [Test]
    public void extraNumber()
    {
        Test.Execute(typeof(extraNumberClass),
            @"a: 2
            b: 7
            c: 2
            Expected Output: 7",
            @"a: 3
            b: 2
            c: 2
            Expected Output: 3",
            @"a: 5
            b: 5
            c: 1
            Expected Output: 1",
            @"a: 500000000
            b: 3
            c: 500000000
            Expected Output: 3",
            @"a: 1
            b: 5
            c: 1
            Expected Output: 5",
            @"a: 5
            b: 5
            c: 3
            Expected Output: 3",
            @"a: 5
            b: 1
            c: 1
            Expected Output: 5",
            @"a: 4000000
            b: 3000000
            c: 4000000
            Expected Output: 3000000",
            @"a: 548442737
            b: 82231042
            c: 548442737
            Expected Output: 82231042",
            @"a: 469992838
            b: 66019520
            c: 66019520
            Expected Output: 469992838"
        );
    }
    /*
        Imported: 2020-04-26 13:16
        By:       Casper
        Url:      https://app.codesignal.com/arcade/code-arcade/at-the-crossroads/aFF9HDm2Rsti9j5kc
    */
    [Test]
    public void isInfiniteProcess()
    {
        Test.Execute(typeof(isInfiniteProcessClass),
            @"a: 2
            b: 6
            Expected Output: false",
            @"a: 2
            b: 3
            Expected Output: true",
            @"a: 2
            b: 10
            Expected Output: false",
            @"a: 0
            b: 1
            Expected Output: true",
            @"a: 3
            b: 1
            Expected Output: true",
            @"a: 10
            b: 10
            Expected Output: false",
            @"a: 5
            b: 10
            Expected Output: true",
            @"a: 6
            b: 10
            Expected Output: false",
            @"a: 10
            b: 0
            Expected Output: true",
            @"a: 5
            b: 5
            Expected Output: false"
        );
    }
    /*
        Imported: 2020-04-26 13:16
        By:       Casper
        Url:      https://app.codesignal.com/arcade/code-arcade/at-the-crossroads/QrCSNQWhnQoaK9KgK
    */
    [Test]
    public void arithmeticExpression()
    {
        Test.Execute(typeof(arithmeticExpressionClass),
            @"a: 2
            b: 3
            c: 5
            Expected Output: true",
            @"a: 8
            b: 2
            c: 4
            Expected Output: true",
            @"a: 8
            b: 3
            c: 2
            Expected Output: false",
            @"a: 6
            b: 3
            c: 3
            Expected Output: true",
            @"a: 18
            b: 2
            c: 9
            Expected Output: true",
            @"a: 2
            b: 3
            c: 6
            Expected Output: true",
            @"a: 5
            b: 2
            c: 0
            Expected Output: false",
            @"a: 10
            b: 2
            c: 2
            Expected Output: false",
            @"a: 5
            b: 2
            c: 2
            Expected Output: false",
            @"a: 1
            b: 2
            c: 1
            Expected Output: false",
            @"a: 1
            b: 2
            c: 2
            Expected Output: true"
        );
    }
    /*
        Imported: 2020-04-26 13:16
        By:       Casper
        Url:      https://app.codesignal.com/arcade/code-arcade/at-the-crossroads/7jaup9HprdJno2diw
    */
    [Test]
    public void tennisSet()
    {
        Test.Execute(typeof(tennisSetClass),
            @"score1: 3
            score2: 6
            Expected Output: true",
            @"score1: 8
            score2: 5
            Expected Output: false",
            @"score1: 6
            score2: 5
            Expected Output: false",
            @"score1: 7
            score2: 7
            Expected Output: false",
            @"score1: 6
            score2: 4
            Expected Output: true",
            @"score1: 7
            score2: 5
            Expected Output: true",
            @"score1: 7
            score2: 2
            Expected Output: false",
            @"score1: 7
            score2: 6
            Expected Output: true",
            @"score1: 4
            score2: 10
            Expected Output: false",
            @"score1: 0
            score2: 0
            Expected Output: false"
        );
    }
    /*
        Imported: 2020-04-26 13:16
        By:       Casper
        Url:      https://app.codesignal.com/arcade/code-arcade/at-the-crossroads/jZ4ZSiGohzFTeg4yb
    */
    [Test]
    public void willYou()
    {
        Test.Execute(typeof(willYouClass),
            @"young: true
            beautiful: true
            loved: true
            Expected Output: false",
            @"young: true
            beautiful: false
            loved: true
            Expected Output: true",
            @"young: false
            beautiful: false
            loved: false
            Expected Output: false",
            @"young: false
            beautiful: false
            loved: true
            Expected Output: true"
        );
    }
    /*
        Imported: 2020-04-26 13:17
        By:       Casper
        Url:      https://app.codesignal.com/arcade/code-arcade/at-the-crossroads/J7PQDxpWqhx7HrvBZ
    */
    [Test]
    public void metroCard()
    {
        Test.Execute(typeof(metroCardClass),
            @"lastNumberOfDays: 30
            Expected Output: [31]",
            @"lastNumberOfDays: 31
            Expected Output: [28, 30, 31]"
        );
    }
    }
}
