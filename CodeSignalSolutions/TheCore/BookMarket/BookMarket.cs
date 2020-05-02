/*
    Imported:   2020-05-02 12:47
    Created By: Casper
    Url:        https://app.codesignal.com/arcade/code-arcade
*/
using NUnit.Framework;
using CodeSignalSolutions;
using CodeSignalSolutions.TheCore.BookMarket;

namespace TheCore
{
    public class BookMarket
    {
        /*
            Imported: 2020-05-02 12:47
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/book-market/K2ieDm98sPDzzMepz
        */
        [Test]
        public void encloseInBrackets()
        {
            Test.Execute(typeof(encloseInBracketsClass),
                @"inputString: ""abacaba""
                Expected Output: ""(abacaba)""",
                @"inputString: ""abcdef""
                Expected Output: ""(abcdef)""",
                @"inputString: ""aaad""
                Expected Output: ""(aaad)""",
                @"inputString: ""if""
                Expected Output: ""(if)""",
                @"inputString: ""it""
                Expected Output: ""(it)""",
                @"inputString: ""doesnt""
                Expected Output: ""(doesnt)""",
                @"inputString: ""challenge""
                Expected Output: ""(challenge)""",
                @"inputString: ""you""
                Expected Output: ""(you)""",
                @"inputString: ""itt""
                Expected Output: ""(itt)""",
                @"inputString: ""wont""
                Expected Output: ""(wont)"""
            );
        }
        /*
            Imported: 2020-05-02 12:47
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/book-market/2nSEQ8CGoddTJtnbo
        */
        [Test]
        public void properNounCorrection()
        {
            Test.Execute(typeof(properNounCorrectionClass),
                @"noun: ""pARiS""
                Expected Output: ""Paris""",
                @"noun: ""John""
                Expected Output: ""John""",
                @"noun: ""mary""
                Expected Output: ""Mary""",
                @"noun: ""a""
                Expected Output: ""A""",
                @"noun: ""B""
                Expected Output: ""B""",
                @"noun: ""yFZMlGvUQP""
                Expected Output: ""Yfzmlgvuqp""",
                @"noun: ""HQQrrDxuqe""
                Expected Output: ""Hqqrrdxuqe""",
                @"noun: ""atDh""
                Expected Output: ""Atdh""",
                @"noun: ""pJHSYVAZB""
                Expected Output: ""Pjhsyvazb""",
                @"noun: ""dKrqO""
                Expected Output: ""Dkrqo"""
            );
        }
        /*
            Imported: 2020-05-02 12:47
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/book-market/2SDWWyHY9Xw5CpphY
        */
        [Test]
        public void isTandemRepeat()
        {
            Test.Execute(typeof(isTandemRepeatClass),
                @"inputString: ""tandemtandem""
                Expected Output: true",
                @"inputString: ""qqq""
                Expected Output: false",
                @"inputString: ""2w2ww""
                Expected Output: false",
                @"inputString: ""hophey""
                Expected Output: false",
                @"inputString: ""CodeSignalCodeSignal""
                Expected Output: true",
                @"inputString: ""interestinterest""
                Expected Output: true",
                @"inputString: ""aa""
                Expected Output: true",
                @"inputString: ""ab""
                Expected Output: false",
                @"inputString: ""stringString""
                Expected Output: false",
                @"inputString: ""truetruetrue""
                Expected Output: false"
            );
        }
        /*
            Imported: 2020-05-02 12:47
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/book-market/G9wj2j6zaWwFWsise
        */
        [Test]
        public void isCaseInsensitivePalindrome()
        {
            Test.Execute(typeof(isCaseInsensitivePalindromeClass),
                @"inputString: ""AaBaa""
                Expected Output: true",
                @"inputString: ""abac""
                Expected Output: false",
                @"inputString: ""aBACaba""
                Expected Output: true",
                @"inputString: ""opOP""
                Expected Output: false",
                @"inputString: ""ZZzzazZzz""
                Expected Output: true",
                @"inputString: ""zzzzazzzz""
                Expected Output: true",
                @"inputString: ""ZZzzabzZzz""
                Expected Output: false",
                @"inputString: ""abcdcbA""
                Expected Output: true",
                @"inputString: ""abracabra""
                Expected Output: false",
                @"inputString: ""abcd""
                Expected Output: false"
            );
        }
        /*
            Imported: 2020-05-02 12:48
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/book-market/TXFLopNcCNbJLQivP
        */
        [Test]
        public void findEmailDomain()
        {
            Test.Execute(typeof(findEmailDomainClass),
                @"address: ""prettyandsimple@example.com""
                Expected Output: ""example.com""",
                @"address: ""fully-qualified-domain@codesignal.com""
                Expected Output: ""codesignal.com""",
                @"address: ""\"" \""@space.com""
                Expected Output: ""space.com""",
                @"address: ""someaddress@yandex.ru""
                Expected Output: ""yandex.ru""",
                @"address: ""\"" \""@xample.org""
                Expected Output: ""xample.org""",
                @"address: ""\""much.more unusual\""@yahoo.com""
                Expected Output: ""yahoo.com""",
                @"address: ""\""very.unusual.@.unusual.com\""@usual.com""
                Expected Output: ""usual.com""",
                @"address: ""admin@mailserver2.ru""
                Expected Output: ""mailserver2.ru""",
                @"address: ""example-indeed@strange-example.com""
                Expected Output: ""strange-example.com""",
                @"address: ""very.common@gmail.com""
                Expected Output: ""gmail.com"""
            );
        }
        /*
            Imported: 2020-05-02 12:48
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/book-market/MX94DWTrwQw2gLrTi
        */
        [Test]
        public void htmlEndTagByStartTag()
        {
            Test.Execute(typeof(htmlEndTagByStartTagClass),
                @"startTag: ""<button type='button' disabled>""
                Expected Output: ""</button>""",
                @"startTag: ""<i>""
                Expected Output: ""</i>""",
                @"startTag: ""<div id='my_area' class='data' title='This is a test for title on Div tag'>""
                Expected Output: ""</div>""",
                @"startTag: ""<html>""
                Expected Output: ""</html>""",
                @"startTag: ""<TABLE border='1'>""
                Expected Output: ""</TABLE>""",
                @"startTag: ""<li class='test'>""
                Expected Output: ""</li>"""
            );
        }
        /*
            Imported: 2020-05-02 12:48
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/book-market/HJ2thsvjL25iCvvdm
        */
        [Test]
        public void isMAC48Address()
        {
            Test.Execute(typeof(isMAC48AddressClass),
                @"inputString: ""00-1B-63-84-45-E6""
                Expected Output: true",
                @"inputString: ""Z1-1B-63-84-45-E6""
                Expected Output: false",
                @"inputString: ""not a MAC-48 address""
                Expected Output: false",
                @"inputString: ""FF-FF-FF-FF-FF-FF""
                Expected Output: true",
                @"inputString: ""00-00-00-00-00-00""
                Expected Output: true",
                @"inputString: ""G0-00-00-00-00-00""
                Expected Output: false",
                @"inputString: ""02-03-04-05-06-07-""
                Expected Output: false",
                @"inputString: ""12-34-56-78-9A-BC""
                Expected Output: true",
                @"inputString: ""FF-FF-AB-CD-EA-BC""
                Expected Output: true",
                @"inputString: ""12-34-56-78-9A-BG""
                Expected Output: false"
            );
        }
        /*
            Imported: 2020-05-02 12:48
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/book-market/Ky2mjgmxnWLi6KNPp
        */
        [Test]
        public void isUnstablePair()
        {
            Test.Execute(typeof(isUnstablePairClass),
                @"filename1: ""aa""
                filename2: ""AAB""
                Expected Output: true",
                @"filename1: ""A""
                filename2: ""z""
                Expected Output: false",
                @"filename1: ""yyyyyy""
                filename2: ""Azzzzzzzzz""
                Expected Output: false",
                @"filename1: ""mehOu""
                filename2: ""mehau""
                Expected Output: true",
                @"filename1: ""aaZ""
                filename2: ""AAzz""
                Expected Output: true",
                @"filename1: ""fdsAs""
                filename2: ""dzdw""
                Expected Output: false",
                @"filename1: ""aaad""
                filename2: ""aaAdd""
                Expected Output: true",
                @"filename1: ""zzzzzAa123""
                filename2: ""zzzzza""
                Expected Output: true",
                @"filename1: ""123za""
                filename2: ""123Z""
                Expected Output: false",
                @"filename1: ""qwerTyu123""
                filename2: ""qwertyu""
                Expected Output: true"
            );
        }
    }
}
