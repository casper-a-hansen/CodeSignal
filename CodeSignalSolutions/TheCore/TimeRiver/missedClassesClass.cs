/*
    Status:   Solved
    Imported: 2020-05-02 13:11
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/time-river/WBjidxs6TBgJqp2RG

    Description:
        Your Math teacher takes education very seriously, and hates it when a class is
        missed or canceled for any reason. He even made up the following rule: if a
        class is missed because of a holiday, the teacher will compensate for it with a
        makeup class after school.
        You're given an array, daysOfTheWeek, with the weekdays on which your teacher's
        classes are scheduled, and holidays, representing the dates of the holidays
        throughout the academic year (from 1st of September in year to 31st of May in
        year + 1). How many times will you be forced to stay after school for a makeup
        class because of holiday conflicts in the current academic year?
        For your convenience, here is the list of month lengths (from January to
        December, respectively):
        Month lengths: 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31.
        Please note that in leap years February has 29 days.
        Example
        For year = 2015, daysOfTheWeek = [2, 3], and
        holidays = ["11-04", "02-22", "02-23", "03-07", "03-08", "05-09"],
        the output should be
        missedClasses(year, daysOfTheWeek, holidays) = 3.
        November 4th of 2015 is a Wednesday, February 23th of 2016 and March 8th of 2016
        are Tuesdays, and the other holidays fall on Mondays. Classes are scheduled on
        Wednesdays and Tuesdays, so there will be only 3 missed classes.
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] integer year
        An integer representing the correct year. The current academic year started on
        September 1st and will finish on May 31st of year + 1.
        Guaranteed constraints:
        1900 ≤ year ≤ 2100.
        [input] array.integer daysOfTheWeek
        A sorted array of integers from 1 to 7 representing the days of the week
        (1-based, i.e. 1 for Monday, 2 for Tuesday and so on) on which classes are
        scheduled.
        Guaranteed constraints:
        0 ≤ daysOfTheWeek.length ≤ 7,
        1 ≤ daysOfTheWeek[i] ≤ 7.
        [input] array.string holidays
        An array of strings representing the correct dates of holidays in this academic
        year in the format "mm-dd", where "mm" stands for the month (1-based, i.e. "01"
        for January, "02" for February and so on) and "dd" stands for the day.
        Guaranteed constraints:
        0 ≤ holidays.length ≤ 30,
        1 ≤ int(mm) ≤ 12, except 6, 7 and 8,
        1 ≤ int(dd) ≤ 31.
        [output] integer
        The number of classes that will be missed.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.TimeRiver
{
    class missedClassesClass
    {
        int missedClasses(int year, int[] daysOfTheWeek, string[] holidays) {
            return holidays
                .Select(h => h.Split('-')
                    .Select(s => int.Parse(s))
                    .ToArray())
                .Select(a => new DateTime(a[0] <= 5 ? year + 1 : year, a[0], a[1]))
                .Count(d => daysOfTheWeek.Contains(d.DayOfWeek == DayOfWeek.Sunday ? 7 : (int)d.DayOfWeek));
        }
    }
}
