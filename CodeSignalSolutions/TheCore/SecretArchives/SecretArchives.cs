/*
    Imported:   2020-05-02 13:13
    Created By: Casper
    Url:        https://app.codesignal.com/arcade/code-arcade
*/
using NUnit.Framework;
using CodeSignalSolutions;
using CodeSignalSolutions.TheCore.SecretArchives;

namespace TheCore
{
    public class SecretArchives
    {
        /*
            Imported: 2020-05-02 13:13
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/secret-archives/qSvgj5FdyeuxTN9qJ
        */
        [Test]
        public void chessNotation()
        {
            Test.Execute(typeof(chessNotationClass),
                @"notation: ""rnbqkbnr/pppppppp/8/8/4P3/8/PPPP1PPP/RNBQKBNR""
                Expected Output: ""RP4pr/NP4pn/BP4pb/QP4pq/K2P2pk/BP4pb/NP4pn/RP4pr""",
                @"notation: ""rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR""
                Expected Output: ""RP4pr/NP4pn/BP4pb/QP4pq/KP4pk/BP4pb/NP4pn/RP4pr""",
                @"notation: ""2kr3r/pp1nbppp/3p1n2/q1pPp1B1/4P1b1/2N2N2/PPP1BPPP/R2Q2RK""
                Expected Output: ""RP2q1p1/1P4p1/1PN1p2k/Q3Ppnr/1B1Pp1b1/1PN2np1/RP1bB1p1/KP4pr""",
                @"notation: ""rNBNn1nR/RN2BNbp/BN3Br1/B1BBp1Kb/npRrBrpb/QB2k1QR/q1nrn2r/bbNBN3""
                Expected Output: ""bqQnBBRr/b1Bp1NNN/Nn1RB2B/Br1rB2N/NnkBp1Bn/3r1BN1/2QpKrbn/1rRbb1pR""",
                @"notation: ""bN2nrp1/n1nQn1n1/p1bPRPrb/n2Q1Nrb/Bn1nBRnB/Q1n1N1b1/qk1n1R2/Q1n2n1Q""
                Expected Output: ""QqQBnpnb/1k1n3N/n1n2bn1/1n1nQPQ1/2NB1Rnn/nR1RNP1r/2bnrrnp/Q2Bbb2""",
                @"notation: ""PkpRnNnB/bqBkbb1k/K2n4/N1BbkP2/QB2kNQk/q1nRNnBB/pbp1RbN1/P1PR1Np1""
                Expected Output: ""PpqQNKbP/1b1B2qk/Ppn1B1Bp/R1R1bnkR/1RNkk1bn/NbnNP1bN/pNBQ3n/2Bk2kB""",
                @"notation: ""N3rrB1/B4NR1/q1pNPb2/k1p1PQQK/nNb1bbr1/n2NP1K1/rb1bRn2/rp1B3p""
                Expected Output: ""rrnnkqBN/pb1N4/3bpp2/BbN2N2/1RPbPP1r/1n1bQbNr/2KrQ1RB/p3K3""",
                @"notation: ""K1Rnrk11/n7/NKb1r1Qq/r1Q2b2/bKBrNBr1/BnpKKr1B/NB1RnNN1/r1RKQ1N1""
                Expected Output: ""rNBbrNnK/1BnK1K2/R1pBQb1R/KRKr3n/QnKN1r1r/1NrBb2k/NN1r1Q2/2B2q2""",
                @"notation: ""p1rKBRkK/P2qqr1p/nbKnb12/RnrrBkbK/NPn1BN2/kb2B1BB/QQ1ppn2/r1Pn1nB1""
                Expected Output: ""rQkNRnPp/1QbPnb2/P2nrK1r/np2rnqK/1pBBBbqB/nn1Nk1rR/B1B1b2k/2B1K1pK""",
                @"notation: ""k3KRBk/PNkqN12/pqNB1Qp1/N1nbrk1q/n2nK1Bp/BrRBN1Pk/K1pBKRRR/bP2R21""
                Expected Output: ""bKBnNpPk/P1r2qN1/1pR1nNk1/1BBnbBq1/RKNKr1NK/1R2kQ1R/1RPB1p1B/1Rkpq2k"""
            );
        }
        /*
            Imported: 2020-05-02 13:13
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/secret-archives/n6KRaxBdcFv5JjQgM
        */
        [Test]
        public void cellsJoining()
        {
            Test.Execute(typeof(cellsJoiningClass),
                @"table:
                [""+----+--+-----+----+"",
                 ""|abcd|56|!@#$%|qwer|"",
                 ""|1234|78|^&=()|tyui|"",
                 ""+----+--+-----+----+"",
                 ""|zxcv|90|77777|stop|"",
                 ""+----+--+-----+----+"",
                 ""|asdf|~~|ghjkl|100$|"",
                 ""+----+--+-----+----+""]
                coords:
                [[2,0],
                 [1,1]]
                Expected Output: [""+----+--+-----+----+"",
                 ""|abcd|56|!@#$%|qwer|"",
                 ""|1234|78|^&=()|tyui|"",
                 ""+----+--+-----+----+"",
                 ""|zxcv 90|77777|stop|"",
                 ""|       +-----+----+"",
                 ""|asdf ~~|ghjkl|100$|"",
                 ""+-------+-----+----+""]",
                @"table:
                [""+-----+-----+--------+-----------+--------+"",
                 ""|fwdaw|dddd |42      |pretty long|table   |"",
                 ""+-----+-----+--------+-----------+--------+"",
                 ""|is   |long |ffffffff|ff         |border  |"",
                 ""+-----+-----+--------+-----------+--------+"",
                 ""|     |     |        |           |        |"",
                 ""|     |     |        |           |        |"",
                 ""+-----+-----+--------+-----------+--------+"",
                 ""|empty|cells|are     |best       |there is|"",
                 ""+-----+-----+--------+-----------+--------+""]
                coords:
                [[3,0],
                 [3,4]]
                Expected Output: [""+-----+-----+--------+-----------+--------+"",
                 ""|fwdaw|dddd |42      |pretty long|table   |"",
                 ""+-----+-----+--------+-----------+--------+"",
                 ""|is   |long |ffffffff|ff         |border  |"",
                 ""+-----+-----+--------+-----------+--------+"",
                 ""|     |     |        |           |        |"",
                 ""|     |     |        |           |        |"",
                 ""+-----+-----+--------+-----------+--------+"",
                 ""|empty cells are      best        there is|"",
                 ""+-----------------------------------------+""]",
                @"table:
                [""+-+-+--+--+--+-+-----+-+---+----+-+-------------------------------------------+"",
                 ""|1|1|  |  |  |3|     |4|   |    |5|ggg                                        |"",
                 ""+-+-+--+--+--+-+-----+-+---+----+-+-------------------------------------------+"",
                 ""| | |11|23|44| |55555| |abc|defg| |                                           |"",
                 ""+-+-+--+--+--+-+-----+-+---+----+-+-------------------------------------------+"",
                 ""| | |  |  |  | |     | |   |    | |#$%#                                       |"",
                 ""+-+-+--+--+--+-+-----+-+---+----+-+-------------------------------------------+"",
                 ""| | |  |  |  | |     | |   |    | |!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!|"",
                 ""+-+-+--+--+--+-+-----+-+---+----+-+-------------------------------------------+"",
                 ""|*|*|42|  |  | |     |0|=) |    | |                                           |"",
                 ""+-+-+--+--+--+-+-----+-+---+----+-+-------------------------------------------+""]
                coords:
                [[4,0],
                 [0,11]]
                Expected Output: [""+-----------------------------------------------------------------------------+"",
                 ""|1 1          3       4          5 ggg                                        |"",
                 ""|                                                                             |"",
                 ""|    11 23 44   55555   abc defg                                              |"",
                 ""|                                                                             |"",
                 ""|                                  #$%#                                       |"",
                 ""|                                                                             |"",
                 ""|                                  !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!|"",
                 ""|                                                                             |"",
                 ""|* * 42               0 =)                                                    |"",
                 ""+-----------------------------------------------------------------------------+""]",
                @"table:
                [""+-+-+--+--+--+-+-----+-+---+----+-+-------------------------------------------+"",
                 ""|1|1|  |  |  |3|     |4|   |    |5|ggg                                        |"",
                 ""+-+-+--+--+--+-+-----+-+---+----+-+-------------------------------------------+"",
                 ""| | |11|23|44| |55555| |abc|defg| |                                           |"",
                 ""+-+-+--+--+--+-+-----+-+---+----+-+-------------------------------------------+"",
                 ""| | |  |  |  | |     | |   |    | |#$%#                                       |"",
                 ""+-+-+--+--+--+-+-----+-+---+----+-+-------------------------------------------+"",
                 ""| | |  |  |  | |     | |   |    | |!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!|"",
                 ""+-+-+--+--+--+-+-----+-+---+----+-+-------------------------------------------+"",
                 ""|*|*|42|  |  | |     |0|=) |    | |                                           |"",
                 ""+-+-+--+--+--+-+-----+-+---+----+-+-------------------------------------------+"",
                 ""| | |  |  |  | |     | |   |    | |#$%#                                       |"",
                 ""| | |  |  |  | |  *  | |   | dd | |#$%#                                       |"",
                 ""| | |  |  |  | |     | |   |    | |#$%#                                       |"",
                 ""+-+-+--+--+--+-+-----+-+---+----+-+-------------------------------------------+"",
                 ""|1|1|  |  |  |3|     |4|   |    |5|ggg                                        |"",
                 ""+-+-+--+--+--+-+-----+-+---+----+-+-------------------------------------------+"",
                 ""| | |11|23|44| |55555| |abc|defg| |                                           |"",
                 ""+-+-+--+--+--+-+-----+-+---+----+-+-------------------------------------------+"",
                 ""| | |  |  |  | |     | |   |    | |#$%#                                       |"",
                 ""+-+-+--+--+--+-+-----+-+---+----+-+-------------------------------------------+"",
                 ""| | |  |  |  | |     | |   |    | |!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!|"",
                 ""+-+-+--+--+--+-+-----+-+---+----+-+-------------------------------------------+"",
                 ""|*|*|42|  |  | |     |0|=) |    | |                                           |"",
                 ""+-+-+--+--+--+-+-----+-+---+----+-+-------------------------------------------+""]
                coords:
                [[5,6],
                 [4,9]]
                Expected Output: [""+-+-+--+--+--+-+-----+-+---+----+-+-------------------------------------------+"",
                 ""|1|1|  |  |  |3|     |4|   |    |5|ggg                                        |"",
                 ""+-+-+--+--+--+-+-----+-+---+----+-+-------------------------------------------+"",
                 ""| | |11|23|44| |55555| |abc|defg| |                                           |"",
                 ""+-+-+--+--+--+-+-----+-+---+----+-+-------------------------------------------+"",
                 ""| | |  |  |  | |     | |   |    | |#$%#                                       |"",
                 ""+-+-+--+--+--+-+-----+-+---+----+-+-------------------------------------------+"",
                 ""| | |  |  |  | |     | |   |    | |!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!|"",
                 ""+-+-+--+--+--+-+-----+-+---+----+-+-------------------------------------------+"",
                 ""|*|*|42|  |  | |      0 =)      | |                                           |"",
                 ""+-+-+--+--+--+-+                +-+-------------------------------------------+"",
                 ""| | |  |  |  | |                | |#$%#                                       |"",
                 ""| | |  |  |  | |  *          dd | |#$%#                                       |"",
                 ""| | |  |  |  | |                | |#$%#                                       |"",
                 ""+-+-+--+--+--+-+-----+-+---+----+-+-------------------------------------------+"",
                 ""|1|1|  |  |  |3|     |4|   |    |5|ggg                                        |"",
                 ""+-+-+--+--+--+-+-----+-+---+----+-+-------------------------------------------+"",
                 ""| | |11|23|44| |55555| |abc|defg| |                                           |"",
                 ""+-+-+--+--+--+-+-----+-+---+----+-+-------------------------------------------+"",
                 ""| | |  |  |  | |     | |   |    | |#$%#                                       |"",
                 ""+-+-+--+--+--+-+-----+-+---+----+-+-------------------------------------------+"",
                 ""| | |  |  |  | |     | |   |    | |!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!|"",
                 ""+-+-+--+--+--+-+-----+-+---+----+-+-------------------------------------------+"",
                 ""|*|*|42|  |  | |     |0|=) |    | |                                           |"",
                 ""+-+-+--+--+--+-+-----+-+---+----+-+-------------------------------------------+""]",
                @"table:
                [""+-+-+--+--+--+-+-----+-+---+----+-+-------------------------------------------+"",
                 ""|1|1|  |  |  |3|     |4|   |    |5|ggg                                        |"",
                 ""+-+-+--+--+--+-+-----+-+---+----+-+-------------------------------------------+""]
                coords:
                [[0,1],
                 [0,10]]
                Expected Output: [""+-+-------------------------------+-------------------------------------------+"",
                 ""|1|1          3       4          5|ggg                                        |"",
                 ""+-+-------------------------------+-------------------------------------------+""]"
            );
        }
        /*
            Imported: 2020-05-02 13:14
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/secret-archives/r8LM3RsxeGFXpr8Bj
        */
        [Test]
        public void firstOperationCharacter()
        {
            Test.Execute(typeof(firstOperationCharacterClass),
                @"expr: ""(2 + 2) * 2""
                Expected Output: 3",
                @"expr: ""2 + 2 * 2""
                Expected Output: 6",
                @"expr: ""((2 + 2) * 2) * 3 + (2 + (2 * 2))""
                Expected Output: 28",
                @"expr: ""2+((22+2222)+(2222+222))""
                Expected Output: 6",
                @"expr: ""2 + 3 * 45 * 56 + 198 + 10938 * 102938 + 5""
                Expected Output: 6",
                @"expr: ""1022224552222222 * 3""
                Expected Output: 17",
                @"expr: ""4 * 3 + 2""
                Expected Output: 2"
            );
        }
        /*
            Imported: 2020-05-02 13:14
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/secret-archives/SFmoZujtxtwzqJhuB
        */
        [Test]
        public void countElements()
        {
            Test.Execute(typeof(countElementsClass),
                @"inputString: ""[[0, 20], [33, 99]]""
                Expected Output: 4",
                @"inputString: ""[ \""one\"", 2, \""three\"" ]""
                Expected Output: 3",
                @"inputString: ""true""
                Expected Output: 1",
                @"inputString: ""[[1, 2, [3]], 4]""
                Expected Output: 4",
                @"inputString: ""[\""oh, no! kind, of, tricky\"", \""test, case\""]""
                Expected Output: 2",
                @"inputString: ""\""try this!, [1, 2, 3, 32], false\""""
                Expected Output: 1",
                @"inputString: ""\""a,,,,,,,,,,,,,,asdf\""""
                Expected Output: 1",
                @"inputString: ""1023456789""
                Expected Output: 1",
                @"inputString: ""[\""ZZZ]zero\""]""
                Expected Output: 1",
                @"inputString: ""[true,\""false\"", true, [2], false, false]""
                Expected Output: 6",
                @"inputString: ""[]""
                Expected Output: 0",
                @"inputString: ""[\""[   -45,   95]   \"", [ 87,  -655]]""
                Expected Output: 3",
                @"inputString: ""111""
                Expected Output: 1"
            );
        }
        /*
            Imported: 2020-05-02 13:14
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/secret-archives/ptyXoxtZfrPSNRe5m
        */
        [Test]
        public void treeBottom()
        {
            Test.Execute(typeof(treeBottomClass),
                @"tree: ""(2 (7 (2 () ()) (6 (5 () ()) (11 () ()))) (5 () (9 (4 () ()) ())))""
                Expected Output: [5, 11, 4]",
                @"tree: ""(1 () ())""
                Expected Output: [1]",
                @"tree: ""(1000 () ())""
                Expected Output: [1000]",
                @"tree: ""(413 (683 () ()) (355 (913 (985 () ()) ()) ()))""
                Expected Output: [985]",
                @"tree: ""(65 (88 (45 (4 () ()) ()) ()) (1000000000 () ()))""
                Expected Output: [4]",
                @"tree: ""(1 (2 (4 (8 () ()) (9 () ())) (5 (10 () ()) (11 () ()))) (3 (6 (12 () ()) (13 () ())) (7 (14 () ()) (15 () ()))))""
                Expected Output: [8, 9, 10, 11, 12, 13, 14, 15]",
                @"tree: ""(1 () (2 () (3 () (5 () (8 () (13 () (21 () (34 () ()))))))))""
                Expected Output: [34]"
            );
        }
        /*
            Imported: 2020-05-02 13:14
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/secret-archives/W59RqZTbGo2vwNSsc
        */
        [Test]
        public void befunge93()
        {
            Test.Execute(typeof(befunge93Class),
                @"program:
                [""               v"",
                 ""v  ,,,,,\""Hello\""<"",
                 "">48*,          v"",
                 ""\""!dlroW\"",,,,,,v>"",
                 ""25*,@         > ""]
                Expected Output: ""Hello World!\n""",
                @"program:
                ["">25*\""!dlrow ,olleH\"":v "",
                 ""                 v:,_@"",
                 ""                 >  ^ ""]
                Expected Output: ""Hello, world!\n""",
                @"program: [""1+:::*.9`#@_""]
                Expected Output: ""1 4 9 16 25 36 49 64 81 100 """,
                @"program:
                [""\""^a&EPm=kY}t/qYC+i9wHye$m N@~x+\""v"",
                 ""\""|DsY<\""-\""z6n<[Yo2x|UP5VD:\"">:#v_@>"",
                 ""-:19+/\""0\""+,19+%\""0\""+,      ^  >39*""]
                Expected Output: ""3141592653589793238462643383279502884197169399375105820974944592307816406286208998628034825342117067""",
                @"program: [""@""]
                Expected Output: """"",
                @"program:
                ["">!|"",
                 "" @<"",
                 ""  ."",
                 ""  /"",
                 ""  1"",
                 ""  ."",
                 ""  `""]
                Expected Output: ""0 0 """,
                @"program: [""\"">:#,_66*2-,@This prints itself out backwards......  but it has to be 80x1 cell""]
                Expected Output: ""llec 1x08 eb ot sah ti tub  ......sdrawkcab tuo flesti stnirp sihT@,-2*66_,#:>\""""",
                @"program:
                [""v>v>"",
                 ""v^v^"",
                 ""v^v^"",
                 ""v^v^"",
                 "">^>^""]
                Expected Output: """"",
                @"program: [""94/.@""]
                Expected Output: ""2 """,
                @"program:
                [""92+9*                           :. v  <      "",
                 "">v\""bottles of beer on the wall\""+910<         "",
                 "",:                                           "",
                 ""^_ $                             :.v         "",
                 ""            >v\""bottles of beer\""+910<         "",
                 ""            ,:                               "",
                 ""            ^_ $                     v       "",
                 "">v\""Take one down, pass it around\""+910<       "",
                 "",:                                           "",
                 ""^_ $                           1-v           "",
                 ""                                 :           "",
                 ""        >v\""bottles of beer\""+910.:_          v"",
                 ""        ,:                                   "",
                 ""        ^_ $                          ^      "",
                 ""                    >v\"" no more beer...\""+910<"",
                 ""                    ,:                       "",
                 ""                    ^_ $$ @                  ""]
                Expected Output: ""99 bottles of beer on the wall\n99 bottles of beer\nTake one down, pass it around\n98 bottles of beer\nb""",
                @"program:
                [""<>: #+1 #:+ 3 : *6+ $#2 9v#"",
                 ""v 7 :   +   8 \\ + + 5   <  "",
                 "">-  :2  -:  \"" \"" 1 + \\ v ^< "",
                 ""2 + :   7   + : 7 + v > :  "",
                 "":1- :3- >   :#, _ @ >:3 5*-""]
                Expected Output: ""BEFUNGE!EGNUFEB""",
                @"program:
                [""25*3*4+>:.\""=\"",:,\""   \""v"",
                 ""       |-*2*88:+1,,, <"",
                 ""       @              ""]
                Expected Output: ""34 =\""   35 =#   36 =$   37 =%   38 =&   39 ='   40 =(   41 =)   42 =*   43 =+   44 =,   45 =-   46 =""",
                @"program:
                [""vv    <>v *<"",
                 ""9>:1-:|$>\\:|"",
                 "">^    >^@.$<""]
                Expected Output: ""362880 """
            );
        }
        /*
            Imported: 2020-05-03 00:00
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/secret-archives/mnELCFheQvkbcytcz
        */
        [Test]
        public void htmlTable()
        {
            Test.Execute(typeof(htmlTableClass),
                @"table: ""<table><tr><td>1</td><td>TWO</td></tr><tr><td>three</td><td>FoUr4</td></tr></table>""
                row: 0
                column: 1
                Expected Output: ""TWO""",
                @"table: ""<table><tr><td>1</td><td>TWO</td></tr></table>""
                row: 1
                column: 0
                Expected Output: ""No such cell""",
                @"table: ""<table><tr><td>7BusWMJ</td><td>D</td><td>5QPh9o</td></tr><tr><td>4Z</td><td>9Z</td><td>okc3</td></tr><tr><td>7mV88j</td><td>K358zV8</td><td>Y2vE</td></tr></table>""
                row: 1
                column: 1
                Expected Output: ""9Z""",
                @"table: ""<table><tr><td>mhPuzp82Mm</td><td>dQijA9O</td><td>x</td><td>2p1GX2lTrM</td></tr><tr><td>4hcQ</td><td>a046</td><td>8bQ7</td><td>Nmdt</td></tr><tr><td>jjC</td><td>zJ5SY05n</td><td>XQxJ</td><td>4yIXC8</td></tr></table>""
                row: 0
                column: 0
                Expected Output: ""mhPuzp82Mm""",
                @"table: ""<table><tr><td>jQu9ABs8l</td><td>9alQS</td><td>6j</td><td>x0C</td><td>VJwINu0wjE</td></tr><tr><td>52K</td><td>w5P</td><td>K0HTHBB</td><td>76H</td><td>2Up4kl</td></tr><tr><td>d7J9bn7lx</td><td>unJT</td><td>mdICgjl</td><td>v0</td><td>LKvS1LbYBo</td></tr><tr><td>eld9</td><td>O</td><td>Yqe184E9</td><td>b45QX0313A</td><td>4M02</td></tr><tr><td>6XKiOf96</td><td>wb7</td><td>HW5535kri</td><td>81U</td><td>V64O2502a</td></tr><tr><td>o8</td><td>col7G7g</td><td>y92s3R</td><td>q1</td><td>zl0LizILrm</td></tr></table>""
                row: 5
                column: 4
                Expected Output: ""zl0LizILrm""",
                @"table: ""<table><tr><td>1</td><td>040S713</td><td>2974b</td><td>Pp4Y9</td><td>UWvp2Sq6Sd</td><td>997r6De</td><td>Bh</td><td>TBy</td><td>Ss6C</td><td>8c</td></tr><tr><td>2</td><td>R81hX704</td><td>89b6a6</td><td>jwk0b</td><td>JC80xBvW</td><td>Ka</td><td>7</td><td>E3Lx</td><td>0wg1</td><td>4HCs</td></tr><tr><td>C6d2</td><td>o2N9Twup6</td><td>Pa42t</td><td>88T0itrA</td><td>DtAmM23</td><td>09Fseat</td><td>Qd5j8Cg</td><td>N20GvC8sk2</td><td>Eqq</td><td>Dq2XnGa0</td></tr><tr><td>Kd</td><td>SO4cZHM</td><td>x</td><td>ie3lbmsvx</td><td>23jWU</td><td>3UjEeT9h</td><td>Es9K7q5</td><td>ij58GnGEuk</td><td>5</td><td>bx0</td></tr><tr><td>aNXo91iG78</td><td>6M</td><td>6J9Lf8b5</td><td>MbQ1HRGtDH</td><td>5skjIH</td><td>P7z2SQnlX2</td><td>6ng</td><td>gAvz4dtCH</td><td>78NN98d</td><td>F8zy4SHXA1</td></tr><tr><td>khAM1</td><td>TIJ</td><td>gA034V</td><td>Cg95</td><td>62</td><td>6N371</td><td>1IN1I</td><td>b</td><td>PafB8Bnf</td><td>6jah</td></tr><tr><td>A4q</td><td>KWvhoy76Z</td><td>WLRK</td><td>0u</td><td>AC6H</td><td>JXM8WxO</td><td>0riDU6</td><td>1</td><td>BX327aD0</td><td>j2WDGTiIL</td></tr><tr><td>eCfoZ7</td><td>h96JOr3</td><td>93gC</td><td>jZT1ZShL3</td><td>NP3</td><td>T6a3KG</td><td>pN</td><td>3jVF</td><td>PZ4P</td><td>3bQk4TKe</td></tr><tr><td>6</td><td>z</td><td>VN</td><td>1PlI5T5</td><td>m5P</td><td>N</td><td>6Rz4CAC31r</td><td>7A732yr74</td><td>60</td><td>669N5t</td></tr><tr><td>ugT9</td><td>BM9</td><td>x6wi</td><td>NLMrzA9</td><td>Y61Dd8MF</td><td>45G9Nq15uS</td><td>VcDP</td><td>A</td><td>z</td><td>08HL8EXL5S</td></tr></table>""
                row: 9
                column: 10
                Expected Output: ""No such cell""",
                @"table: ""<table><tr><th>CIRCUMFERENCE</th><th>1</th><th>2</th><th>3</th><th>4</th><th>5</th><th>6</th></tr><tr><td>BITS</td><td>3</td><td>4</td><td>8</td><td>10</td><td>12</td><td>15</td></tr></table>""
                row: 0
                column: 6
                Expected Output: ""No such cell"""
            );
        }
        /*
            Imported: 2020-05-03 00:06
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/secret-archives/oAwCH6ecrzA4ARb6d
        */
        [Test]
        public void lrc2subRip()
        {
            Test.Execute(typeof(lrc2subRipClass),
                @"lrcLyrics:
                [""[00:12.00] Happy birthday dear coder,"",
                 ""[00:17.20] Happy birthday to you!""]
                songLength: ""00:00:20""
                Expected Output: [""1"",
                 ""00:00:12,000 --> 00:00:17,200"",
                 ""Happy birthday dear coder,"",
                 """",
                 ""2"",
                 ""00:00:17,200 --> 00:00:20,000"",
                 ""Happy birthday to you!""]",
                @"lrcLyrics:
                [""[00:04.42] jingle bells, jingle bells, jingle all the way!"",
                 ""[00:08.46] Oh what fun it is to ride in a one horse open sleigh."",
                 ""[00:12.83] jingle bells, jingle bells, jingle all the way!"",
                 ""[00:17.45] Oh what fun it is to ride in a one horse open sleigh."",
                 ""[00:21.89] jingle bells, jingle bells, jingle all the way!""]
                songLength: ""00:24:00""
                Expected Output: [""1"",
                 ""00:00:04,420 --> 00:00:08,460"",
                 ""jingle bells, jingle bells, jingle all the way!"",
                 """",
                 ""2"",
                 ""00:00:08,460 --> 00:00:12,830"",
                 ""Oh what fun it is to ride in a one horse open sleigh."",
                 """",
                 ""3"",
                 ""00:00:12,830 --> 00:00:17,450"",
                 ""jingle bells, jingle bells, jingle all the way!"",
                 """",
                 ""4"",
                 ""00:00:17,450 --> 00:00:21,890"",
                 ""Oh what fun it is to ride in a one horse open sleigh."",
                 """",
                 ""5"",
                 ""00:00:21,890 --> 00:24:00,000"",
                 ""jingle bells, jingle bells, jingle all the way!""]",
                @"lrcLyrics:
                [""[95:19.55] i hear babies cryin,"",
                 ""[95:23.31] i watch them grow"",
                 ""[95:26.05] theyll learn much more"",
                 ""[95:29.18] than ill ever know"",
                 ""[95:33.10] and i think to myself,"",
                 ""[95:38.44] what a wonderful world""]
                songLength: ""02:23:44""
                Expected Output: [""1"",
                 ""01:35:19,550 --> 01:35:23,310"",
                 ""i hear babies cryin,"",
                 """",
                 ""2"",
                 ""01:35:23,310 --> 01:35:26,050"",
                 ""i watch them grow"",
                 """",
                 ""3"",
                 ""01:35:26,050 --> 01:35:29,180"",
                 ""theyll learn much more"",
                 """",
                 ""4"",
                 ""01:35:29,180 --> 01:35:33,100"",
                 ""than ill ever know"",
                 """",
                 ""5"",
                 ""01:35:33,100 --> 01:35:38,440"",
                 ""and i think to myself,"",
                 """",
                 ""6"",
                 ""01:35:38,440 --> 02:23:44,000"",
                 ""what a wonderful world""]",
                @"lrcLyrics:
                [""[12:24.80] make it the cutest"",
                 ""[14:26.46] that ive ever seen"",
                 ""[17:28.96] give hm the lips"",
                 ""[21:30.36] like roses in clover"",
                 ""[35:33.03] then tell him that"",
                 ""[46:34.42] his lone some nights are over"",
                 ""[57:36.68] Mr.sandman"",
                 ""[67:38.71] i am so along"",
                 ""[97:40.99] dont have nobody"",
                 ""[99:42.63] to call my own""]
                songLength: ""02:59:59""
                Expected Output: [""1"",
                 ""00:12:24,800 --> 00:14:26,460"",
                 ""make it the cutest"",
                 """",
                 ""2"",
                 ""00:14:26,460 --> 00:17:28,960"",
                 ""that ive ever seen"",
                 """",
                 ""3"",
                 ""00:17:28,960 --> 00:21:30,360"",
                 ""give hm the lips"",
                 """",
                 ""4"",
                 ""00:21:30,360 --> 00:35:33,030"",
                 ""like roses in clover"",
                 """",
                 ""5"",
                 ""00:35:33,030 --> 00:46:34,420"",
                 ""then tell him that"",
                 """",
                 ""6"",
                 ""00:46:34,420 --> 00:57:36,680"",
                 ""his lone some nights are over"",
                 """",
                 ""7"",
                 ""00:57:36,680 --> 01:07:38,710"",
                 ""Mr.sandman"",
                 """",
                 ""8"",
                 ""01:07:38,710 --> 01:37:40,990"",
                 ""i am so along"",
                 """",
                 ""9"",
                 ""01:37:40,990 --> 01:39:42,630"",
                 ""dont have nobody"",
                 """",
                 ""10"",
                 ""01:39:42,630 --> 02:59:59,000"",
                 ""to call my own""]",
                @"lrcLyrics:
                [""[12:51.10] Hello tacher tell me whats my lesson"",
                 ""[16:57.10] Look right through me,"",
                 ""[24:00.36] look right through me"",
                 ""[27:04.57] And I find it kind of funny"",
                 ""[34:08.16] I find it kind of sad"",
                 ""[46:10.42] The dream in which Im dying"",
                 ""[57:13.70] Are the best Ive ever had"",
                 ""[68:16.47] I find it hard to tell you"",
                 ""[73:19.47] Cos I find it hard to take"",
                 ""[86:22.56] When people run in circles"",
                 ""[92:25.91] Its a very very""]
                songLength: ""02:34:36""
                Expected Output: [""1"",
                 ""00:12:51,100 --> 00:16:57,100"",
                 ""Hello tacher tell me whats my lesson"",
                 """",
                 ""2"",
                 ""00:16:57,100 --> 00:24:00,360"",
                 ""Look right through me,"",
                 """",
                 ""3"",
                 ""00:24:00,360 --> 00:27:04,570"",
                 ""look right through me"",
                 """",
                 ""4"",
                 ""00:27:04,570 --> 00:34:08,160"",
                 ""And I find it kind of funny"",
                 """",
                 ""5"",
                 ""00:34:08,160 --> 00:46:10,420"",
                 ""I find it kind of sad"",
                 """",
                 ""6"",
                 ""00:46:10,420 --> 00:57:13,700"",
                 ""The dream in which Im dying"",
                 """",
                 ""7"",
                 ""00:57:13,700 --> 01:08:16,470"",
                 ""Are the best Ive ever had"",
                 """",
                 ""8"",
                 ""01:08:16,470 --> 01:13:19,470"",
                 ""I find it hard to tell you"",
                 """",
                 ""9"",
                 ""01:13:19,470 --> 01:26:22,560"",
                 ""Cos I find it hard to take"",
                 """",
                 ""10"",
                 ""01:26:22,560 --> 01:32:25,910"",
                 ""When people run in circles"",
                 """",
                 ""11"",
                 ""01:32:25,910 --> 02:34:36,000"",
                 ""Its a very very""]",
                @"lrcLyrics: [""[00:09.01]"",""[00:10.01] Sweetdreamsaremadeofthis"",""[00:13.26] WhoamItodisagree?"",""[00:17.01] Traveltheworldandthesevenseas"",""[00:20.95] Everybodyslookingforsomething"",""[00:24.57]"",""[00:24.82] Someofthemwanttouseyou"",""[00:28.64] Someofthemwanttogetusedbyyou"",""[00:32.45] Someofthemwanttoabuseyou"",""[00:36.32] Someofthemwanttobeabused"",""[00:40.32]"",""[00:52.00] Sweetdreamsaremadeofthis"",""[00:55.37] WhoamItodisagree?"",""[00:59.18] Traveltheworldandthesevenseas"",""[01:03.00] Everybodyslookingforsomething"",""[01:48.34] Someofthemwanttouseyou"",""[01:52.16] Someofthemwanttogetusedbyyou"",""[01:55.97] Someofthemwanttoabuseyou"",""[01:59.72] Someofthemwanttobeabused"",""[02:03.58]"",""[01:18.17]"",""[01:29.17] Holdyourheadup,movinon"",""[01:19.18] Holdyourheadup"",""[01:31.11] Keepyourheadup"",""[01:19.92] Keepyourheadup,movinon"",""[01:21.86] Holdyourheadup,movinon"",""[01:23.74] Keepyourheadup,movinon"",""[01:25.67] Holdyourheadup,movinon"",""[01:27.55] Keepyourheadup,movinon""]
                songLength: ""00:09:32""
                Expected Output: [""1"",""00:00:09,010 --> 00:00:10,010"","""","""",""2"",""00:00:10,010 --> 00:00:13,260"",""Sweetdreamsaremadeofthis"","""",""3"",""00:00:13,260 --> 00:00:17,010"",""WhoamItodisagree?"","""",""4"",""00:00:17,010 --> 00:00:20,950"",""Traveltheworldandthesevenseas"","""",""5"",""00:00:20,950 --> 00:00:24,570"",""Everybodyslookingforsomething"","""",""6"",""00:00:24,570 --> 00:00:24,820"","""","""",""7"",""00:00:24,820 --> 00:00:28,640"",""Someofthemwanttouseyou"","""",""8"",""00:00:28,640 --> 00:00:32,450"",""Someofthemwanttogetusedbyyou"","""",""9"",""00:00:32,450 --> 00:00:36,320"",""Someofthemwanttoabuseyou"","""",""10"",""00:00:36,320 --> 00:00:40,320"",""Someofthemwanttobeabused"","""",""11"",""00:00:40,320 --> 00:00:52,000"","""","""",""12"",""00:00:52,000 --> 00:00:55,370"",""Sweetdreamsaremadeofthis"","""",""13"",""00:00:55,370 --> 00:00:59,180"",""WhoamItodisagree?"","""",""14"",""00:00:59,180 --> 00:01:03,000"",""Traveltheworldandthesevenseas"","""",""15"",""00:01:03,000 --> 00:01:48,340"",""Everybodyslookingforsomething"","""",""16"",""00:01:48,340 --> 00:01:52,160"",""Someofthemwanttouseyou"","""",""17"",""00:01:52,160 --> 00:01:55,970"",""Someofthemwanttogetusedbyyou"","""",""18"",""00:01:55,970 --> 00:01:59,720"",""Someofthemwanttoabuseyou"","""",""19"",""00:01:59,720 --> 00:02:03,580"",""Someofthemwanttobeabused"","""",""20"",""00:02:03,580 --> 00:01:18,170"","""","""",""21"",""00:01:18,170 --> 00:01:29,170"","""","""",""22"",""00:01:29,170 --> 00:01:19,180"",""Holdyourheadup,movinon"","""",""23"",""00:01:19,180 --> 00:01:31,110"",""Holdyourheadup"","""",""24"",""00:01:31,110 --> 00:01:19,920"",""Keepyourheadup"","""",""25"",""00:01:19,920 --> 00:01:21,860"",""Keepyourheadup,movinon"","""",""26"",""00:01:21,860 --> 00:01:23,740"",""Holdyourheadup,movinon"","""",""27"",""00:01:23,740 --> 00:01:25,670"",""Keepyourheadup,movinon"","""",""28"",""00:01:25,670 --> 00:01:27,550"",""Holdyourheadup,movinon"","""",""29"",""00:01:27,550 --> 00:09:32,000"",""Keepyourheadup,movinon""]"
            );
        }
    }
}
