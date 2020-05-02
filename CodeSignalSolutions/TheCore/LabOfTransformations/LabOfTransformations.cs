/*
    Imported:   2020-05-02 12:52
    Created By: Casper
    Url:        https://app.codesignal.com/arcade/code-arcade
*/
using NUnit.Framework;
using CodeSignalSolutions;
using CodeSignalSolutions.TheCore.LabOfTransformations;

namespace TheCore
{
    public class LabOfTransformations
    {
        /*
            Imported: 2020-05-02 12:52
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/lab-of-transformations/QKnGhkoi4wKr6xY9b
        */
        [Test]
        public void characterParity()
        {
            Test.Execute(typeof(characterParityClass),
                @"symbol: ""5""
                Expected Output: ""odd""",
                @"symbol: ""8""
                Expected Output: ""even""",
                @"symbol: ""q""
                Expected Output: ""not a digit""",
                @"symbol: ""1""
                Expected Output: ""odd""",
                @"symbol: ""2""
                Expected Output: ""even""",
                @"symbol: ""7""
                Expected Output: ""odd""",
                @"symbol: ""9""
                Expected Output: ""odd"""
            );
        }
        /*
            Imported: 2020-05-02 12:53
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/lab-of-transformations/8nAgfjhDvKCpxwGWF
        */
        [Test]
        public void reflectString()
        {
            Test.Execute(typeof(reflectStringClass),
                @"inputString: ""name""
                Expected Output: ""mznv""",
                @"inputString: ""abyz""
                Expected Output: ""zyba""",
                @"inputString: ""nnnnn""
                Expected Output: ""mmmmm""",
                @"inputString: ""pqr""
                Expected Output: ""kji""",
                @"inputString: ""codesignal""
                Expected Output: ""xlwvhrtmzo"""
            );
        }
        /*
            Imported: 2020-05-02 12:53
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/lab-of-transformations/ngQTG9kra7GE9pnnK
        */
        [Test]
        public void newNumeralSystem()
        {
            Test.Execute(typeof(newNumeralSystemClass),
                @"number: ""G""
                Expected Output: [""A + G"",
                 ""B + F"",
                 ""C + E"",
                 ""D + D""]",
                @"number: ""A""
                Expected Output: [""A + A""]",
                @"number: ""D""
                Expected Output: [""A + D"",
                 ""B + C""]",
                @"number: ""E""
                Expected Output: [""A + E"",
                 ""B + D"",
                 ""C + C""]",
                @"number: ""F""
                Expected Output: [""A + F"",
                 ""B + E"",
                 ""C + D""]",
                @"number: ""I""
                Expected Output: [""A + I"",
                 ""B + H"",
                 ""C + G"",
                 ""D + F"",
                 ""E + E""]",
                @"number: ""K""
                Expected Output: [""A + K"",
                 ""B + J"",
                 ""C + I"",
                 ""D + H"",
                 ""E + G"",
                 ""F + F""]",
                @"number: ""L""
                Expected Output: [""A + L"",
                 ""B + K"",
                 ""C + J"",
                 ""D + I"",
                 ""E + H"",
                 ""F + G""]",
                @"number: ""O""
                Expected Output: [""A + O"",
                 ""B + N"",
                 ""C + M"",
                 ""D + L"",
                 ""E + K"",
                 ""F + J"",
                 ""G + I"",
                 ""H + H""]",
                @"number: ""P""
                Expected Output: [""A + P"",
                 ""B + O"",
                 ""C + N"",
                 ""D + M"",
                 ""E + L"",
                 ""F + K"",
                 ""G + J"",
                 ""H + I""]",
                @"number: ""S""
                Expected Output: [""A + S"",
                 ""B + R"",
                 ""C + Q"",
                 ""D + P"",
                 ""E + O"",
                 ""F + N"",
                 ""G + M"",
                 ""H + L"",
                 ""I + K"",
                 ""J + J""]",
                @"number: ""T""
                Expected Output: [""A + T"",
                 ""B + S"",
                 ""C + R"",
                 ""D + Q"",
                 ""E + P"",
                 ""F + O"",
                 ""G + N"",
                 ""H + M"",
                 ""I + L"",
                 ""J + K""]",
                @"number: ""W""
                Expected Output: [""A + W"",
                 ""B + V"",
                 ""C + U"",
                 ""D + T"",
                 ""E + S"",
                 ""F + R"",
                 ""G + Q"",
                 ""H + P"",
                 ""I + O"",
                 ""J + N"",
                 ""K + M"",
                 ""L + L""]"
            );
        }
        /*
            Imported: 2020-05-02 12:53
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/lab-of-transformations/JeDDnToFtitiiWDZn
        */
        [Test]
        public void cipher26()
        {
            Test.Execute(typeof(cipher26Class),
                @"message: ""taiaiaertkixquxjnfxxdh""
                Expected Output: ""thisisencryptedmessage""",
                @"message: ""ibttlprimfymqlpgeftwu""
                Expected Output: ""itsasecrettoeverybody""",
                @"message: ""ftnexvoky""
                Expected Output: ""fourtytwo""",
                @"message: ""taevzhzmashvjw""
                Expected Output: ""thereisnospoon""",
                @"message: ""abdgkpvcktdoanbqgxpicxtqon""
                Expected Output: ""abcdefghijklmnopqrstuvwxyz""",
                @"message: ""z""
                Expected Output: ""z"""
            );
        }
        /*
            Imported: 2020-05-02 12:53
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/lab-of-transformations/M97sbwRp3tGy8uAb8
        */
        [Test]
        public void stolenLunch()
        {
            Test.Execute(typeof(stolenLunchClass),
                @"note: ""you'll n4v4r 6u4ss 8t: cdja""
                Expected Output: ""you'll never guess it: 2390""",
                @"note: """"
                Expected Output: """"",
                @"note: ""0123456789""
                Expected Output: ""abcdefghij""",
                @"note: ""jihgfedcba""
                Expected Output: ""9876543210""",
                @"note: ""you won't know!!""
                Expected Output: ""you won't know!!""",
                @"note: ""just 63jd73 some random note jkhdf83 ds823 that you, dfj238 dsf38 little one?, will abjk38 s83    skdu3 29never get!""
                Expected Output: ""9ust gd93hd som4 r0n3om not4 9k735id 3sicd t70t you, 359cdi 3s5di l8ttl4 on4?, w8ll 019kdi sid    sk3ud cjn4v4r 64t!"""
            );
        }
        /*
            Imported: 2020-05-02 12:53
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/lab-of-transformations/vsKRjYKv4SCjzJc8r
        */
        [Test]
        public void higherVersion()
        {
            Test.Execute(typeof(higherVersionClass),
                @"ver1: ""1.2.2""
                ver2: ""1.2.0""
                Expected Output: true",
                @"ver1: ""1.0.5""
                ver2: ""1.1.0""
                Expected Output: false",
                @"ver1: ""1.1.0""
                ver2: ""1.1.5""
                Expected Output: false",
                @"ver1: ""10""
                ver2: ""9""
                Expected Output: true",
                @"ver1: ""1.0.10""
                ver2: ""1.1.5""
                Expected Output: false",
                @"ver1: ""5""
                ver2: ""1""
                Expected Output: true",
                @"ver1: ""1.1.10""
                ver2: ""1.2.0""
                Expected Output: false",
                @"ver1: ""1.2.2""
                ver2: ""1.2.10""
                Expected Output: false",
                @"ver1: ""1.10.2""
                ver2: ""1.2.10""
                Expected Output: true",
                @"ver1: ""0""
                ver2: ""0""
                Expected Output: false",
                @"ver1: ""4.3.22.1""
                ver2: ""4.3.22.1""
                Expected Output: false"
            );
        }
        /*
            Imported: 2020-05-02 12:53
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/lab-of-transformations/dB9drnfWzpiWznESA
        */
        [Test]
        public void decipher()
        {
            Test.Execute(typeof(decipherClass),
                @"cipher: ""10197115121""
                Expected Output: ""easy""",
                @"cipher: ""98""
                Expected Output: ""b""",
                @"cipher: ""122""
                Expected Output: ""z""",
                @"cipher: ""1229897""
                Expected Output: ""zba""",
                @"cipher: ""97989910010110210310410510610710810911011111211311411511611711811912012112297""
                Expected Output: ""abcdefghijklmnopqrstuvwxyza""",
                @"cipher: ""10297115106108102108971061151041029897107106115981001029710711510010298""
                Expected Output: ""fasjlflajshfbakjsbdfaksdfb""",
                @"cipher: ""11211111911310110810910097107108115111112119113101106107971101021101061021041149710511411497""
                Expected Output: ""powqelmdaklsopwqejkanfnjfhrairra"""
            );
        }
        /*
            Imported: 2020-05-02 12:54
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/lab-of-transformations/bBgu7NEfk2GoQuNzf
        */
        [Test]
        public void alphanumericLess()
        {
            Test.Execute(typeof(alphanumericLessClass),
                @"s1: ""a""
                s2: ""a1""
                Expected Output: true",
                @"s1: ""ab""
                s2: ""a1""
                Expected Output: false",
                @"s1: ""b""
                s2: ""a1""
                Expected Output: false",
                @"s1: ""x11y012""
                s2: ""x011y13""
                Expected Output: true",
                @"s1: ""ab123""
                s2: ""ab34z""
                Expected Output: false",
                @"s1: ""0000""
                s2: ""000""
                Expected Output: true",
                @"s1: ""10""
                s2: ""01""
                Expected Output: false",
                @"s1: ""ab000144""
                s2: ""ab144""
                Expected Output: true",
                @"s1: ""ab""
                s2: ""a""
                Expected Output: false",
                @"s1: ""000""
                s2: ""0000""
                Expected Output: false",
                @"s1: ""abc123""
                s2: ""abc123""
                Expected Output: false",
                @"s1: ""zza1233""
                s2: ""zza1234""
                Expected Output: true",
                @"s1: ""zzz1""
                s2: ""zzz1""
                Expected Output: false",
                @"s1: ""00""
                s2: ""a2""
                Expected Output: true"
            );
        }
    }
}
