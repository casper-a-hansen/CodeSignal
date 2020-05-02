/*
    Imported:   2020-05-02 13:10
    Created By: Casper
    Url:        https://app.codesignal.com/arcade/code-arcade
*/
using NUnit.Framework;
using CodeSignalSolutions;
using CodeSignalSolutions.TheCore.TimeRiver;

namespace TheCore
{
    public class TimeRiver
    {
        /*
            Imported: 2020-05-02 13:10
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/time-river/ywMyCTspqGXPWRZx5
        */
        [Test]
        public void validTime()
        {
            Test.Execute(typeof(validTimeClass),
                @"time: ""13:58""
                Expected Output: true",
                @"time: ""25:51""
                Expected Output: false",
                @"time: ""02:76""
                Expected Output: false",
                @"time: ""24:00""
                Expected Output: false",
                @"time: ""02:61""
                Expected Output: false",
                @"time: ""27:00""
                Expected Output: false",
                @"time: ""19:66""
                Expected Output: false",
                @"time: ""12:31""
                Expected Output: true",
                @"time: ""25:73""
                Expected Output: false",
                @"time: ""09:56""
                Expected Output: true",
                @"time: ""03:29""
                Expected Output: true"
            );
        }
        /*
            Imported: 2020-05-02 13:10
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/time-river/DKjM5qLz5ccK2ukhH
        */
        [Test]
        public void videoPart()
        {
            Test.Execute(typeof(videoPartClass),
                @"part: ""02:20:00""
                total: ""07:00:00""
                Expected Output: [1, 3]",
                @"part: ""25:26:20""
                total: ""25:26:20""
                Expected Output: [1, 1]",
                @"part: ""00:02:20""
                total: ""00:10:00""
                Expected Output: [7, 30]",
                @"part: ""08:08:08""
                total: ""20:20:20""
                Expected Output: [2, 5]",
                @"part: ""00:00:07""
                total: ""01:10:00""
                Expected Output: [1, 600]",
                @"part: ""07:32:29""
                total: ""10:12:51""
                Expected Output: [1597, 2163]",
                @"part: ""01:41:59""
                total: ""02:00:00""
                Expected Output: [6119, 7200]"
            );
        }
        /*
            Imported: 2020-05-02 13:10
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/time-river/Xg8AXfc4hHeebq4se
        */
        [Test]
        public void dayOfWeek()
        {
            Test.Execute(typeof(dayOfWeekClass),
                @"birthdayDate: ""02-01-2016""
                Expected Output: 5",
                @"birthdayDate: ""01-01-1900""
                Expected Output: 6",
                @"birthdayDate: ""02-29-2016""
                Expected Output: 28",
                @"birthdayDate: ""01-16-2027""
                Expected Output: 11",
                @"birthdayDate: ""10-12-2000""
                Expected Output: 6",
                @"birthdayDate: ""02-29-2072""
                Expected Output: 40"
            );
        }
        /*
            Imported: 2020-05-02 13:10
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/time-river/ekhR5y6QuHjxWk36W
        */
        [Test]
        public void curiousClock()
        {
            Test.Execute(typeof(curiousClockClass),
                @"someTime: ""2016-08-26 22:40""
                leavingTime: ""2016-08-29 10:00""
                Expected Output: ""2016-08-24 11:20""",
                @"someTime: ""2016-08-26 22:40""
                leavingTime: ""2016-08-26 22:41""
                Expected Output: ""2016-08-26 22:39""",
                @"someTime: ""2015-01-14 09:12""
                leavingTime: ""2015-11-04 17:36""
                Expected Output: ""2014-03-26 00:48""",
                @"someTime: ""2016-02-28 12:21""
                leavingTime: ""2016-03-01 22:21""
                Expected Output: ""2016-02-26 02:21""",
                @"someTime: ""1995-05-30 13:48""
                leavingTime: ""2016-04-22 05:32""
                Expected Output: ""1974-07-06 22:04""",
                @"someTime: ""1992-09-29 00:00""
                leavingTime: ""1998-12-04 23:59""
                Expected Output: ""1986-07-25 00:01"""
            );
        }
        /*
            Imported: 2020-05-02 13:10
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/time-river/EaPEmzu6CYRuc4X2C
        */
        [Test]
        public void newYearCelebrations()
        {
            Test.Execute(typeof(newYearCelebrationsClass),
                @"takeOffTime: ""23:35""
                minutes: [60, 90, 140]
                Expected Output: 3",
                @"takeOffTime: ""00:00""
                minutes: [60, 120, 180, 250]
                Expected Output: 4",
                @"takeOffTime: ""13:36""
                minutes: [23, 33, 45, 56, 66, 88]
                Expected Output: 1",
                @"takeOffTime: ""22:50""
                minutes: []
                Expected Output: 1",
                @"takeOffTime: ""20:18""
                minutes: [222, 342]
                Expected Output: 3",
                @"takeOffTime: ""12:05""
                minutes: [1, 109, 113, 344, 345, 478, 545, 565, 809, 814, 838, 883, 971, 1007, 1029, 1053, 1133, 1271, 1314, 1500]
                Expected Output: 1",
                @"takeOffTime: ""17:10""
                minutes: [150, 160, 293, 589, 614, 716, 760, 776, 781, 911, 1040, 1438]
                Expected Output: 3",
                @"takeOffTime: ""18:15""
                minutes: [117, 241, 364, 375, 545, 1317]
                Expected Output: 1",
                @"takeOffTime: ""19:44""
                minutes: [545, 1320]
                Expected Output: 1",
                @"takeOffTime: ""21:13""
                minutes: [52, 257, 323, 515, 579, 600, 703, 707, 1127, 1298]
                Expected Output: 3"
            );
        }
        /*
            Imported: 2020-05-02 13:11
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/time-river/36z952jJdatJnFXGC
        */
        [Test]
        public void regularMonths()
        {
            Test.Execute(typeof(regularMonthsClass),
                @"currMonth: ""02-2016""
                Expected Output: ""08-2016""",
                @"currMonth: ""05-2027""
                Expected Output: ""11-2027""",
                @"currMonth: ""09-2099""
                Expected Output: ""02-2100""",
                @"currMonth: ""01-1970""
                Expected Output: ""06-1970""",
                @"currMonth: ""07-2024""
                Expected Output: ""09-2025"""
            );
        }
        /*
            Imported: 2020-05-02 13:11
            By:       Casper
            Url:      https://app.codesignal.com/arcade/code-arcade/time-river/WBjidxs6TBgJqp2RG
        */
        [Test]
        public void missedClasses()
        {
            Test.Execute(typeof(missedClassesClass),
                @"year: 2015
                daysOfTheWeek: [2, 3]
                holidays:
                [""11-04"",
                 ""02-22"",
                 ""02-23"",
                 ""03-07"",
                 ""03-08"",
                 ""05-09""]
                Expected Output: 3",
                @"year: 1900
                daysOfTheWeek: []
                holidays: []
                Expected Output: 0",
                @"year: 2100
                daysOfTheWeek: [1, 4, 7]
                holidays:
                [""10-28"",
                 ""05-03"",
                 ""10-02"",
                 ""05-07"",
                 ""05-25"",
                 ""09-04"",
                 ""10-30"",
                 ""03-03"",
                 ""09-02"",
                 ""11-08""]
                Expected Output: 4",
                @"year: 1956
                daysOfTheWeek: [1, 4, 6, 7]
                holidays:
                [""03-17"",
                 ""04-03"",
                 ""03-08"",
                 ""09-18"",
                 ""05-28"",
                 ""02-14"",
                 ""10-20"",
                 ""01-02"",
                 ""01-22"",
                 ""10-04"",
                 ""02-02"",
                 ""10-07"",
                 ""09-30"",
                 ""05-20"",
                 ""05-23"",
                 ""09-22"",
                 ""01-12"",
                 ""05-02"",
                 ""10-21"",
                 ""03-20""]
                Expected Output: 13",
                @"year: 2067
                daysOfTheWeek: [1, 2, 3, 4, 5, 6, 7]
                holidays:
                [""01-20"",
                 ""02-09"",
                 ""01-25"",
                 ""09-01"",
                 ""05-30"",
                 ""12-24"",
                 ""09-05"",
                 ""10-15"",
                 ""09-25"",
                 ""10-23"",
                 ""10-10"",
                 ""05-29"",
                 ""02-05"",
                 ""11-19"",
                 ""04-28"",
                 ""02-17"",
                 ""05-04"",
                 ""01-26"",
                 ""05-31"",
                 ""03-19"",
                 ""12-31"",
                 ""09-26"",
                 ""05-19"",
                 ""05-14"",
                 ""09-03"",
                 ""05-21"",
                 ""02-08"",
                 ""11-09"",
                 ""09-09"",
                 ""04-21""]
                Expected Output: 30",
                @"year: 2000
                daysOfTheWeek: []
                holidays: []
                Expected Output: 0",
                @"year: 1995
                daysOfTheWeek: [1, 2, 3]
                holidays:
                [""10-28"",
                 ""05-26"",
                 ""09-24"",
                 ""11-28"",
                 ""09-17"",
                 ""03-29"",
                 ""09-08"",
                 ""05-13"",
                 ""10-23"",
                 ""11-29"",
                 ""04-26"",
                 ""10-27"",
                 ""09-26"",
                 ""09-09"",
                 ""12-07""]
                Expected Output: 5",
                @"year: 2045
                daysOfTheWeek: [1, 2, 3, 5]
                holidays:
                [""11-12"",
                 ""09-10"",
                 ""11-10"",
                 ""05-12"",
                 ""05-03"",
                 ""03-04"",
                 ""02-14"",
                 ""12-25"",
                 ""09-24"",
                 ""11-17"",
                 ""09-22"",
                 ""09-14"",
                 ""12-04"",
                 ""01-24"",
                 ""03-24"",
                 ""05-26"",
                 ""09-01"",
                 ""11-20"",
                 ""04-30"",
                 ""03-20"",
                 ""10-04"",
                 ""11-21"",
                 ""01-14"",
                 ""05-11"",
                 ""12-03"",
                 ""11-01""]
                Expected Output: 15",
                @"year: 2014
                daysOfTheWeek: [2, 3]
                holidays:
                [""11-04"",
                 ""02-22"",
                 ""02-23"",
                 ""03-07"",
                 ""03-08"",
                 ""05-09""]
                Expected Output: 1",
                @"year: 2100
                daysOfTheWeek: []
                holidays: []
                Expected Output: 0"
            );
        }
    }
}
