/*
    Imported:   2020-05-02 12:05
    Created By: Casper
    Url:        https://app.codesignal.com/arcade/intro
*/
using NUnit.Framework;
using CodeSignalSolutions;
using CodeSignalSolutions.Intro.EruptionOfLight;

namespace Intro
{
    public class EruptionOfLight
    {
        /*
            Imported: 2020-05-02 12:05
            By:       Casper
            Url:      https://app.codesignal.com/arcade/intro/level-10/PHSQhLEw3K2CmhhXE
        */
        [Test]
        public void isBeautifulString()
        {
            Test.Execute(typeof(isBeautifulStringClass),
                @"inputString: ""bbbaacdafe""
                Expected Output: true",
                @"inputString: ""aabbb""
                Expected Output: false",
                @"inputString: ""bbc""
                Expected Output: false",
                @"inputString: ""bbbaa""
                Expected Output: false",
                @"inputString: ""abcdefghijklmnopqrstuvwxyzz""
                Expected Output: false",
                @"inputString: ""abcdefghijklmnopqrstuvwxyz""
                Expected Output: true",
                @"inputString: ""abcdefghijklmnopqrstuvwxyzqwertuiopasdfghjklxcvbnm""
                Expected Output: true",
                @"inputString: ""fyudhrygiuhdfeis""
                Expected Output: false",
                @"inputString: ""zaa""
                Expected Output: false",
                @"inputString: ""zyy""
                Expected Output: false"
            );
        }
        /*
            Imported: 2020-05-02 12:05
            By:       Casper
            Url:      https://app.codesignal.com/arcade/intro/level-10/TXFLopNcCNbJLQivP
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
            Imported: 2020-05-02 12:05
            By:       Casper
            Url:      https://app.codesignal.com/arcade/intro/level-10/ppZ9zSufpjyzAsSEx
        */
        [Test]
        public void buildPalindrome()
        {
            Test.Execute(typeof(buildPalindromeClass),
                @"st: ""abcdc""
                Expected Output: ""abcdcba""",
                @"st: ""ababab""
                Expected Output: ""abababa""",
                @"st: ""abba""
                Expected Output: ""abba""",
                @"st: ""abaa""
                Expected Output: ""abaaba""",
                @"st: ""aaaaba""
                Expected Output: ""aaaabaaaa""",
                @"st: ""abc""
                Expected Output: ""abcba""",
                @"st: ""kebab""
                Expected Output: ""kebabek""",
                @"st: ""abccba""
                Expected Output: ""abccba""",
                @"st: ""abcabc""
                Expected Output: ""abcabcbacba""",
                @"st: ""cbdbedffcg""
                Expected Output: ""cbdbedffcgcffdebdbc""",
                @"st: ""euotmn""
                Expected Output: ""euotmnmtoue"""
            );
        }
        /*
            Imported: 2020-05-02 12:05
            By:       Casper
            Url:      https://app.codesignal.com/arcade/intro/level-10/8RiRRM3yvbuAd3MNg
        */
        [Test]
        public void electionsWinners()
        {
            Test.Execute(typeof(electionsWinnersClass),
                @"votes: [2, 3, 5, 2]
                k: 3
                Expected Output: 2",
                @"votes: [1, 3, 3, 1, 1]
                k: 0
                Expected Output: 0",
                @"votes: [5, 1, 3, 4, 1]
                k: 0
                Expected Output: 1",
                @"votes: [1, 1, 1, 1]
                k: 1
                Expected Output: 4",
                @"votes: [1, 1, 1, 1]
                k: 0
                Expected Output: 0",
                @"votes: [3, 1, 1, 3, 1]
                k: 2
                Expected Output: 2"
            );
        }
        /*
            Imported: 2020-05-02 12:05
            By:       Casper
            Url:      https://app.codesignal.com/arcade/intro/level-10/HJ2thsvjL25iCvvdm
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
    }
}
