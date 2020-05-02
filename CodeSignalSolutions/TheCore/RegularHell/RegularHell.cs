/*
    Imported:   2020-05-02 13:11
    Created By: Casper
    Url:        https://app.codesignal.com/arcade/code-arcade
*/
using NUnit.Framework;
using CodeSignalSolutions;
using CodeSignalSolutions.TheCore.RegularHell;

namespace TheCore
{
    public class RegularHell
    {
        /*
            Imported: 2020-05-02 13:11
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/regular-hell/mj4qdJqZknbkHNzhK
        */
        [Test]
        public void isSentenceCorrect()
        {
            Test.Execute(typeof(isSentenceCorrectClass),
                @"sentence: ""This is an example of *correct* sentence.""
                Expected Output: true",
                @"sentence: ""!this sentence is TOTALLY incorrecT""
                Expected Output: false",
                @"sentence: ""Almost correct sentence""
                Expected Output: false",
                @"sentence: ""Something is !wrong! here.""
                Expected Output: false",
                @"sentence: ""Time to roll!!!""
                Expected Output: false",
                @"sentence: ""This one is okay though, isn't it?""
                Expected Output: true",
                @"sentence: ""this sentence, I'm afraid, is a bit incorrect.""
                Expected Output: false",
                @"sentence: ""I'm glad this sentence is correct, my friends.""
                Expected Output: true",
                @"sentence: ""CodeSignal is lame!!!""
                Expected Output: false",
                @"sentence: ""No way, CodeSignal is awesome!""
                Expected Output: true"
            );
        }
        /*
            Imported: 2020-05-02 13:11
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/regular-hell/YhqzFvdnHMffQA22q
        */
        [Test]
        public void replaceAllDigitsRegExp()
        {
            Test.Execute(typeof(replaceAllDigitsRegExpClass),
                @"input: ""There are 12 points""
                Expected Output: ""There are ## points""",
                @"input: ""012ss210""
                Expected Output: ""###ss###""",
                @"input: "" _Aas 23""
                Expected Output: "" _Aas ##""",
                @"input: ""no digits here""
                Expected Output: ""no digits here""",
                @"input: "" aa_0239mehce3d""
                Expected Output: "" aa_####mehce#d""",
                @"input: ""v z gv4zyx eu mu ""
                Expected Output: ""v z gv#zyx eu mu """
            );
        }
        /*
            Imported: 2020-05-02 13:11
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/regular-hell/AMx2WqCoq2PEcJTEp
        */
        [Test]
        public void swapAdjacentWords()
        {
            Test.Execute(typeof(swapAdjacentWordsClass),
                @"s: ""CodeFight On""
                Expected Output: ""On CodeFight""",
                @"s: ""How are you today guys""
                Expected Output: ""are How today you guys""",
                @"s: ""IAmALongStringWithNoWhiteSpaceCharacters""
                Expected Output: ""IAmALongStringWithNoWhiteSpaceCharacters""",
                @"s: ""A b C D e F g h I j""
                Expected Output: ""b A D C F e h g j I""",
                @"s: """"
                Expected Output: """""
            );
        }
        /*
            Imported: 2020-05-02 13:11
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/regular-hell/Rqtm4Yv8GhHYXJYPY
        */
        [Test]
        public void nthNumber()
        {
            Test.Execute(typeof(nthNumberClass),
                @"s: ""8one 003number 201numbers li-000233le number444""
                n: 4
                Expected Output: ""233""",
                @"s: ""some023020 num ber 033 02103 32 meh peh beh 4328 ""
                n: 5
                Expected Output: ""4328""",
                @"s: ""007 is an awesome agent""
                n: 1
                Expected Output: ""7""",
                @"s: ""Everyone hates error 404""
                n: 1
                Expected Output: ""404""",
                @"s: ""LaS003920tP3rEt4t04Yte0023s3t""
                n: 4
                Expected Output: ""4""",
                @"s: ""=_aaYiM*}&0077|D))ztIV00012432748730156644204805614898523099655216oio0854102350044141_|YDL0584511290939644184700867021026771007612398051168360441323oIc:G*0204864749576405915~wqgN0037594999439741539584332{F&wjxiLy-mE""
                n: 4
                Expected Output: ""584511290939644184700867021026771007612398051168360441323"""
            );
        }
        /*
            Imported: 2020-05-02 13:12
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/regular-hell/E6eYu8dsfwch2My27
        */
        [Test]
        public void isSubsequence()
        {
            Test.Execute(typeof(isSubsequenceClass),
                @"t: ""CodeSignal""
                s: ""CoSi""
                Expected Output: true",
                @"t: ""CodeSignal""
                s: ""cosi""
                Expected Output: false",
                @"t: ""somestring""
                s: """"
                Expected Output: true",
                @"t: ""penny""
                s: ""longsenselessstringwithpennyinside""
                Expected Output: false",
                @"t: ""parliament""
                s: ""partialmen""
                Expected Output: false",
                @"t: """"
                s: """"
                Expected Output: true",
                @"t: """"
                s: ""hoho""
                Expected Output: false",
                @"t: ""he sd.f dsk e8.sd??l**23, 23,f.s++83+""
                s: ""h  8.?*3+""
                Expected Output: true",
                @"t: ""abc""
                s: ""d""
                Expected Output: false",
                @"t: ""abcd""
                s: ""ad""
                Expected Output: true"
            );
        }
        /*
            Imported: 2020-05-02 13:12
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/regular-hell/tsMpGZTEgq6D6uvaA
        */
        [Test]
        public void eyeRhyme()
        {
            Test.Execute(typeof(eyeRhymeClass),
                @"pairOfLines: ""cough\tbough""
                Expected Output: true",
                @"pairOfLines: ""CodeFig!ht\tWith all your might""
                Expected Output: false",
                @"pairOfLines: ""quod erat demonstrandum\tand that, ladies and gentlemen, is the end of my memorandum""
                Expected Output: true",
                @"pairOfLines: ""yup\tyes""
                Expected Output: false",
                @"pairOfLines: ""hey\they""
                Expected Output: true",
                @"pairOfLines: ""E = MC<sup>2</sup>\twhich in turn equals sup""
                Expected Output: false",
                @"pairOfLines: ""Isn't it correct?!\tIt definitely is! Does it mean that we've just obtained a full set?!""
                Expected Output: true",
                @"pairOfLines: ""Nothing can go wrong here :)\tHehehehe:)""
                Expected Output: false",
                @"pairOfLines: ""!1?/\tsldkjfl3 sldjf 1?/""
                Expected Output: true",
                @"pairOfLines: ""simple\tpimple""
                Expected Output: true"
            );
        }
        /*
            Imported: 2020-05-02 13:12
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/regular-hell/WwsFwv42dzLJJFmAE
        */
        [Test]
        public void programTranslation()
        {
            Test.Execute(typeof(programTranslationClass),
                @"solution: ""function add($n, m) {\t  return n + $m;\t}""
                args:
                [""n"",
                 ""m""]
                Expected Output: ""function add($n, $m) {\t  return $n + $m;\t}""",
                @"solution: ""function findSum(a, $cnt) {\t  var a0 = $a;\t  for (var _cnt = 0, _cnt < cnt; _cnt++)\t    a0 += _cnt;\t  return a0;\t}""
                args:
                [""a"",
                 ""cnt""]
                Expected Output: ""function findSum($a, $cnt) {\t  var a0 = $a;\t  for (var _cnt = 0, _cnt < $cnt; _cnt++)\t    a0 += _cnt;\t  return a0;\t}""",
                @"solution: ""function doNothing($uselessVar) {\t  return $uselessVar;\t}""
                args: [""uselessVar""]
                Expected Output: ""function doNothing($uselessVar) {\t  return $uselessVar;\t}""",
                @"solution: ""function addToVariable(variable) {\t  variable_which_should_be_increased = 14;\t  variable_which_should_be_increased += variable;\t  return variable_which_should_be_increased;\t}""
                args: [""variable""]
                Expected Output: ""function addToVariable($variable) {\t  variable_which_should_be_increased = 14;\t  variable_which_should_be_increased += $variable;\t  return variable_which_should_be_increased;\t}""",
                @"solution: ""function replaceThemAll(rep, laceT, hemAll, ornot) {\t  var tmp = rep;\t  rep = laceT;\t  laceT = hemAll;\t  hemAll = tmp;\t  return [rep, laceT, hemAll]\t}""
                args:
                [""rep"",
                 ""laceT"",
                 ""hemAll""]
                Expected Output: ""function replaceThemAll($rep, $laceT, $hemAll, ornot) {\t  var tmp = $rep;\t  $rep = $laceT;\t  $laceT = $hemAll;\t  $hemAll = tmp;\t  return [$rep, $laceT, $hemAll]\t}""",
                @"solution: ""function returnSecond(fu_,_re5,NOO) {\t  return _re5;\t}""
                args:
                [""fu_"",
                 ""_re5"",
                 ""NOO""]
                Expected Output: ""function returnSecond($fu_,$_re5,$NOO) {\t  return $_re5;\t}""",
                @"solution: ""function getLength(k, m) {\t  return m.length;\t}""
                args: [""m""]
                Expected Output: ""function getLength(k, $m) {\t  return $m.length;\t}"""
            );
        }
        /*
            Imported: 2020-05-02 13:12
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/regular-hell/jyaMHzCG4SGoEjASE
        */
        [Test]
        public void repetitionEncryption()
        {
            Test.Execute(typeof(repetitionEncryptionClass),
                @"letter: ""Hi, hi Jane! I'm so. So glad to to finally be able to write - WRITE!! - to you!""
                Expected Output: 4",
                @"letter: ""Yo-yo, how's s it going going for ya? Ya is okay, okay'nt ya?""
                Expected Output: 5",
                @"letter: ""Hi Jane, how are you doing today?""
                Expected Output: 0",
                @"letter: ""My friend, friend of mine, I am really-really happy for you! You are amazing, please write me back when you can.""
                Expected Output: 3",
                @"letter: ""Everything is fine, fine perfectly here. Here I have fun (fun all the day!) days. Although I miss you, so please please, Jane, write, write me whenever you can! Can you do that? That is the only (!!ONLY!!) thing I ask from you, you sunshine.""
                Expected Output: 9",
                @"letter: ""Do not notify me about this in the future""
                Expected Output: 0",
                @"letter: ""ho-ho--he-he""
                Expected Output: 2",
                @"letter: ""WeLl wElL""
                Expected Output: 1"
            );
        }
        /*
            Imported: 2020-05-02 13:12
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/regular-hell/4GC4dP3gHRMcJDaRy
        */
        [Test]
        public void bugsAndBugfixes()
        {
            Test.Execute(typeof(bugsAndBugfixesClass),
                @"rules: ""Roll d6-3 and 4d4+3 to pick a weapon, and finish the boss with 3d7!""
                Expected Output: 43",
                @"rules: ""d6-almost 01d4+2 12d01-3 5d5-00 a valid formula""
                Expected Output: 46",
                @"rules: ""meh4d2-3D3""
                Expected Output: 5",
                @"rules: ""ad3+4, 44b-6, 5daa""
                Expected Output: 7",
                @"rules: ""4d6-L1d20-10 did4n't expect that""
                Expected Output: 38",
                @"rules: ""nothing here""
                Expected Output: 0"
            );
        }
    }
}
