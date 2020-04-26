/*
    Imported:   2020-04-26 13:11
    Created By: Casper
    Url:        https://app.codesignal.com/arcade/intro
*/
using NUnit.Framework;
using CodeSignalSolutions;
using CodeSignalSolutions.Intro.DivingDeeper;

namespace Intro
{
    public class DivingDeeper
    {
    /*
        Imported: 2020-04-26 13:11
        By:       Casper
        Url:      https://app.codesignal.com/arcade/intro/level-8/3AgqcKrxbwFhd3Z3R
    */
    [Test]
    public void extractEachKth()
    {
        Test.Execute(typeof(extractEachKthClass),
            @"inputArray: [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
            k: 3
            Expected Output: [1, 2, 4, 5, 7, 8, 10]",
            @"inputArray: [1, 1, 1, 1, 1]
            k: 1
            Expected Output: []",
            @"inputArray: [1, 2, 1, 2, 1, 2, 1, 2]
            k: 2
            Expected Output: [1, 1, 1, 1]",
            @"inputArray: [1, 2, 1, 2, 1, 2, 1, 2]
            k: 10
            Expected Output: [1, 2, 1, 2, 1, 2, 1, 2]",
            @"inputArray: [2, 4, 6, 8, 10]
            k: 2
            Expected Output: [2, 6, 10]"
        );
    }
    /*
        Imported: 2020-04-26 13:11
        By:       Casper
        Url:      https://app.codesignal.com/arcade/intro/level-8/rRGGbTtwZe2mA8Wov
    */
    [Test]
    public void firstDigit()
    {
        Test.Execute(typeof(firstDigitClass),
            @"inputString: ""var_1__Int""
            Expected Output: ""1""",
            @"inputString: ""q2q-q""
            Expected Output: ""2""",
            @"inputString: ""0ss""
            Expected Output: ""0""",
            @"inputString: ""_Aas_23""
            Expected Output: ""2""",
            @"inputString: ""a a_933""
            Expected Output: ""9""",
            @"inputString: ""ok0""
            Expected Output: ""0"""
        );
    }
    /*
        Imported: 2020-04-26 13:11
        By:       Casper
        Url:      https://app.codesignal.com/arcade/intro/level-8/8N7p3MqzGQg5vFJfZ
    */
    [Test]
    public void differentSymbolsNaive()
    {
        Test.Execute(typeof(differentSymbolsNaiveClass),
            @"s: ""cabca""
            Expected Output: 3",
            @"s: ""aba""
            Expected Output: 2",
            @"s: ""ccccccccccc""
            Expected Output: 1",
            @"s: ""bcaba""
            Expected Output: 3",
            @"s: ""codesignal""
            Expected Output: 10"
        );
    }
    /*
        Imported: 2020-04-26 13:11
        By:       Casper
        Url:      https://app.codesignal.com/arcade/intro/level-8/Rqvw3daffNE7sT7d5
    */
    [Test]
    public void arrayMaxConsecutiveSum()
    {
        Test.Execute(typeof(arrayMaxConsecutiveSumClass),
            @"inputArray: [2, 3, 5, 1, 6]
            k: 2
            Expected Output: 8",
            @"inputArray: [2, 4, 10, 1]
            k: 2
            Expected Output: 14",
            @"inputArray: [1, 3, 2, 4]
            k: 3
            Expected Output: 9",
            @"inputArray: [3, 2, 1, 1]
            k: 1
            Expected Output: 3",
            @"inputArray: [1, 3, 4, 2, 4, 2, 4]
            k: 4
            Expected Output: 13",
            @"The test case is too large and is shown truncated
            inputArray: [768, 77, 755, 960, 747, 25, 107, 520, 995, 404, 43, 714, 632, 642, 493, 352, 450, 625, 262, 217, 254, 55, 661, 822, 562, 187, 603, 216, 275, 76, 75, 417, 350, 942, 1000, 232, 887, 173, 858, 116, 75, 170, 529, 26, 62, 378, 667, 444, 240, 325, 444, 391, 698, 282, 870, 611, 974, 388, 586, 616, 845, 591, 525, 976, 938, 673, 413, 862, 396, 856, 764, 415, 309, 27, 583, 630, 741, 988, 456, 807, 242, 624, 149, 524, 962, 960, 900, 199, 645, 36, 343, 943, 232, 781, 445, 670, 177, 889, 57, 519]
            k: 250
            Expected Output: 135845",
            @"inputArray: [963, 741, 22, 851, 399, 382, 190, 247, 494, 452, 891, 532, 795, 920, 465, 831, 344, 391, 582, 897, 763, 951, 735, 806, 320, 702, 200, 59, 870, 345, 695, 321, 817, 83, 416, 36, 914, 335, 117, 985, 690, 303, 875, 556, 292, 309, 496, 791, 509, 360, 235, 784, 607, 341]
            k: 23
            Expected Output: 14232",
            @"The test case is too large and is shown truncated
            inputArray: [186, 923, 553, 569, 686, 316, 282, 709, 781, 93, 635, 789, 540, 569, 532, 882, 541, 549, 977, 44, 211, 737, 253, 436, 919, 521, 126, 346, 113, 716, 560, 690, 671, 673, 242, 662, 962, 935, 612, 691, 111, 809, 570, 551, 209, 732, 408, 181, 773, 306, 800, 688, 674, 957, 16, 513, 566, 954, 521, 248, 280, 670, 630, 106, 887, 789, 58, 990, 776, 256, 727, 588, 48, 926, 763, 820, 245, 261, 588, 786, 650, 634, 418, 41, 885, 673, 251, 827, 524, 678, 961, 877, 455, 441, 649, 294, 941, 733, 818, 789]
            k: 785
            Expected Output: 400098",
            @"The test case is too large and is shown truncated
            inputArray: [152, 503, 151, 221, 768, 954, 236, 707, 927, 107, 648, 556, 979, 833, 754, 210, 911, 801, 673, 73, 696, 700, 188, 335, 581, 805, 197, 506, 622, 335, 854, 544, 727, 166, 941, 205, 44, 536, 544, 579, 611, 725, 630, 725, 462, 591, 809, 487, 921, 821, 270, 997, 514, 4, 821, 799, 609, 185, 342, 883, 519, 449, 98, 296, 965, 557, 406, 382, 672, 347, 844, 977, 851, 847, 668, 342, 652, 660, 494, 509, 508, 705, 855, 340, 119, 326, 692, 891, 871, 284, 111, 698, 625, 484, 124, 245, 163, 226, 707, 801]
            k: 776
            Expected Output: 377666",
            @"The test case is too large and is shown truncated
            inputArray: [18, 872, 747, 579, 38, 773, 592, 53, 14, 93, 446, 276, 476, 547, 62, 911, 444, 134, 106, 914, 229, 528, 986, 370, 723, 374, 242, 666, 740, 976, 748, 259, 252, 947, 927, 247, 405, 289, 357, 761, 949, 894, 835, 664, 996, 956, 897, 710, 66, 409, 571, 336, 188, 848, 802, 298, 486, 513, 538, 425, 367, 328, 942, 664, 951, 162, 530, 990, 337, 510, 876, 169, 548, 884, 447, 171, 187, 618, 174, 45, 753, 980, 905, 927, 133, 841, 583, 569, 998, 354, 382, 189, 105, 551, 330, 151, 29, 488, 392, 100]
            k: 671
            Expected Output: 345095"
        );
    }
    }
}
