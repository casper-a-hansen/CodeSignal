/*
    Imported:   2020-05-02 11:54
    Created By: Casper
    Url:        https://app.codesignal.com/arcade/intro
*/
using NUnit.Framework;
using CodeSignalSolutions;
using CodeSignalSolutions.Intro.ExploringTheWaters;

namespace Intro
{
    public class ExploringTheWaters
    {
        /*
            Imported: 2020-05-02 11:54
            By:       Casper
            Url:      https://app.codesignal.com/arcade/intro/level-4/cC5QuL9fqvZjXJsW9
        */
        [Test]
        public void alternatingSums()
        {
            Test.Execute(typeof(alternatingSumsClass),
                @"a: [50, 60, 60, 45, 70]
                Expected Output: [180, 105]",
                @"a: [100, 50]
                Expected Output: [100, 50]",
                @"a: [80]
                Expected Output: [80, 0]",
                @"a: [100, 50, 50, 100]
                Expected Output: [150, 150]",
                @"a: [100, 51, 50, 100]
                Expected Output: [150, 151]"
            );
        }
        /*
            Imported: 2020-05-02 11:54
            By:       Casper
            Url:      https://app.codesignal.com/arcade/intro/level-4/ZCD7NQnED724bJtjN
        */
        [Test]
        public void addBorder()
        {
            Test.Execute(typeof(addBorderClass),
                @"picture:
                [""abc"",
                 ""ded""]
                Expected Output: [""*****"",
                 ""*abc*"",
                 ""*ded*"",
                 ""*****""]",
                @"picture: [""a""]
                Expected Output: [""***"",
                 ""*a*"",
                 ""***""]",
                @"picture:
                [""aa"",
                 ""**"",
                 ""zz""]
                Expected Output: [""****"",
                 ""*aa*"",
                 ""****"",
                 ""*zz*"",
                 ""****""]",
                @"picture:
                [""abcde"",
                 ""fghij"",
                 ""klmno"",
                 ""pqrst"",
                 ""uvwxy""]
                Expected Output: [""*******"",
                 ""*abcde*"",
                 ""*fghij*"",
                 ""*klmno*"",
                 ""*pqrst*"",
                 ""*uvwxy*"",
                 ""*******""]",
                @"picture: [""wzy**""]
                Expected Output: [""*******"",
                 ""*wzy***"",
                 ""*******""]"
            );
        }
        /*
            Imported: 2020-05-02 11:54
            By:       Casper
            Url:      https://app.codesignal.com/arcade/intro/level-4/xYXfzQmnhBvEKJwXP
        */
        [Test]
        public void areSimilar()
        {
            Test.Execute(typeof(areSimilarClass),
                @"a: [1, 2, 3]
                b: [1, 2, 3]
                Expected Output: true",
                @"a: [1, 2, 3]
                b: [2, 1, 3]
                Expected Output: true",
                @"a: [1, 2, 2]
                b: [2, 1, 1]
                Expected Output: false",
                @"a: [1, 1, 4]
                b: [1, 2, 3]
                Expected Output: false",
                @"a: [1, 2, 3]
                b: [1, 10, 2]
                Expected Output: false",
                @"a: [2, 3, 1]
                b: [1, 3, 2]
                Expected Output: true",
                @"a: [2, 3, 9]
                b: [10, 3, 2]
                Expected Output: false",
                @"a: [4, 6, 3]
                b: [3, 4, 6]
                Expected Output: false",
                @"a: [832, 998, 148, 570, 533, 561, 894, 147, 455, 279]
                b: [832, 998, 148, 570, 533, 561, 455, 147, 894, 279]
                Expected Output: true",
                @"a: [832, 998, 148, 570, 533, 561, 894, 147, 455, 279]
                b: [832, 570, 148, 998, 533, 561, 455, 147, 894, 279]
                Expected Output: false"
            );
        }

        /*
            Imported: 2020-05-02 11:59
            By:       Casper
            Url:      https://app.codesignal.com/arcade/intro/level-4/Xfeo7r9SBSpo3Wico
        */
        [Test]
        public void palindromeRearranging()
        {
            Test.Execute(typeof(palindromeRearrangingClass),
                @"inputString: ""aabb""
                Expected Output: true",
                @"inputString: ""aaaaaaaaaaaaaaaaaaaaaaaaaaaaaabc""
                Expected Output: false",
                @"inputString: ""abbcabb""
                Expected Output: true",
                @"inputString: ""zyyzzzzz""
                Expected Output: true",
                @"inputString: ""z""
                Expected Output: true",
                @"inputString: ""zaa""
                Expected Output: true",
                @"inputString: ""abca""
                Expected Output: false",
                @"inputString: ""abcad""
                Expected Output: false",
                @"inputString: ""aaaaaaaaaaaaaaaaaaaaaaaaaaaaaabbbccccaaaaaaaaaaaaa""
                Expected Output: false",
                @"inputString: ""abdhuierf""
                Expected Output: false"
            );
        }
        /*
            Imported: 2020-05-02 21:36
            By:       Casper
            Url:      https://app.codesignal.com/arcade/intro/level-4/xvkRbxYkdHdHNCKjg
        */
        [Test]
        public void arrayChange()
        {
            Test.Execute(typeof(arrayChangeClass),
                @"inputArray: [1, 1, 1]
                Expected Output: 3",
                @"inputArray: [-1000, 0, -2, 0]
                Expected Output: 5",
                @"inputArray: [2, 1, 10, 1]
                Expected Output: 12",
                @"inputArray: [2, 3, 3, 5, 5, 5, 4, 12, 12, 10, 15]
                Expected Output: 13",
                @"inputArray: [3122, -645, 2616, 13213, -8069]
                Expected Output: 25559",
                @"inputArray: [-787, -773, -93, 867, -28, 118, 372, 255, 355, 598, -179, -752, 794, 961, -84, 296, -714, 14, 666, -265, -905, 942, -691, -379, -698, -650, 637, 523, 709, -674, 574, -239, 805, -434, 597, -677, 664, 384, 726, -389, -387, 772, -603, 685, 249, 446, -631, 454, 983, 867, -158, 932, -440, 891, -12, 400, -916, 503, 185, -802, -255, 207, -952, -506, -689, 425, 747, -907, -30, 102, 553, 981, -664, 75, -957, -42, 99, -750, -277, 686, -884, -972, 470, 32, 439, 163, 887, 895, -555, -654, 793, 333, 143, 73, 181, -512, -915, -68, 542, 799]
                Expected Output: 89510",
                @"inputArray: [-28943, -29728, -24726, -15090, -2555, -9551, -11025, 36442, -23240, -46093, 48516, 44580, -21573, 39172, -38017, -19354, -13460, 38212, -35646, -22288, 36832, -33115, 39055, -15935, -19300, -10419, -18548, 21742, -32032, 27988, -45323, 27454, -5683, -14209, -4168, 51188, 45552, 9899, 49241, -25939, -8344, -25788, 6808, 6931, 6145, -30802, -518, -42362]
                Expected Output: 2020705",
                @"inputArray: [9796, 1283, -2825, 3870, -6727, -8616, -10191, -7727, 7074, 1580, -4583, 162, 2980, -3861, 9452, 8145, 1222, -1125, 5142, -5657, -974, -986, -9627, 5244, 8866, 3336, -9946, -5271, 10582, 3013, 8030, 4471, -3420, 9496, -3533, -8030, 10007, 2549, -8195, 7119, 302, -5322, -3537, 209, -8134, -9176, 6336, -1771, 9851, 3644, 9629, -2603, 3988, 10579, 2221, 1101, 1465, 5002, -6203, -8864, 596, 6005, 4554, 8526, 2178, -5447, -232, -9734, 7402, -3984, -7161, -2139, -3181, 10445, 4535, 6926, 7156]
                Expected Output: 737073",
                @"inputArray: [-24875, -6401, 58256, 44456, 2244, -25333, -42389, -5975, 7650, -46343, -62011, -55366, 7802, -37699, 15461, 13309, -58664, 54557, 56324, -34397, -33024, -21934, -18861, -23196, 56542, -63986, 59833, -45610, -16948, 399, -7405, 54701, -57348, -32627, 65534, 615]
                Expected Output: 2199614",
                @"inputArray: [22121,42080,
                      -51776,
                      -28528,39895,
                      -50842,25463,46187,
                      -29518,42293,
                      -25615,
                      -47412,24945,
                      -2630,
                      -12717,
                      -23773,
                      -47824,
                      -7768,
                      -23620,
                      -30270,
                      -51644,42829,27609,
                      -40734,2142,20285,29665,
                      -36557,
                      -24074,
                      -11996,30511,17104,4360,
                      -41163,6814,959,26613,
                      -15121,
                      -17355,28424,
                      -11305,33175,
                      -8585,23649,
                      -18428,16770,14095,38766,
                      -22425,
                      -45139,
                      -5836,
                      -28668,
                      -15123,
                      -35450,41353,11103,
                      -29233,
                      -51990,
                      -14958,45944,20841,
                      -34149,34720,
                      -51760,23519,
                      -46257,40985,
                      -32615,
                      -43378,14243,
                      -24731,1311,
                      -4236,
                      -24885,41713,
                      -45195,
                      -14683,47765,26904,
                      -51741,38051,13429,38189,
                      -45812,
                      -52474,14936,6582,
                      -26313,4692,12313,
                      -37502,
                      -40673,5799,23264,33617,
                      -50938,26268,
                      -25548,
                      -22353,
                      -15175,
                      -21568,18656,19208,20674,41228,
                      -42538,
                      -45085,
                      -32356,
                      -39901,
                      -39585,
                      -50690,2859,
                      -4079,29823,28849,
                      -2142,
                      -16613,23378,36363,31780,
                      -40379,7489,
                      -13324,
                      -22377,35661,
                      -27141,
                      -42727,10122,
                      -40385,
                      -19765,33913,
                      -10504,
                      -4715,
                      -18190,41430,
                      -19134,32646,25839,783,32941,
                      -25142]
                Expected Output: 7097995"
            );
        }
    }
}
