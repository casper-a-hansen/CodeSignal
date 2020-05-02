/*
    Status:   Solved
    Imported: 2020-05-02 13:11
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/time-river/4JypHBf7kQc3GjhRF

    Description:
        John Doe likes holidays very much, and he was very happy to hear that his
        country's government decided to introduce yet another one. He heard that the new
        holiday will be celebrated each year on the xth week of month, on weekDay.
        Your task is to return the day of month on which the holiday will be celebrated
        in the year yearNumber.
        For your convenience, here are the lists of months names and lengths and the
        list of days of the week names.
        Months: "January", "February", "March", "April", "May", "June", "July",
        "August", "September", "October", "November", "December".
        Months lengths: 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31.
        Days of the week: "Monday", "Tuesday", "Wednesday", "Thursday", "Friday",
        "Saturday", "Sunday".
        Please, note that in leap years February has 29 days.
        Example
        For x = 3, weekDay = "Wednesday", month = "November", and yearNumber = 2016, the
        output should be
        holiday(x, weekDay, month, yearNumber) = 16.
        The new holiday will be celebrated every November on the 3rd Wednesday of the
        month. In 2016 the 3rd Wednesday falls on the 16th of November.
        For x = 5, weekDay = "Thursday", month = "November", and yearNumber = 2016, the
        output should be
        holiday(x, weekDay, month, yearNumber) = -1.
        There are only 4 Thursdays in November 2016.
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] integer x
        A positive integer.
        Guaranteed constraints:
        1 ≤ x ≤ 5.
        [input] string weekDay
        A string representing a correct name of some day of the week.
        Guaranteed constraints:
        weekDay ∈ {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday",
        "Sunday"}.
        [input] string month
        A string representing a correct name of some month.
        Guaranteed constraints:
        month ∈ {"January", "February", "March", "April", "May", "June", "July",
        "August", "September", "October", "November", "December"}.
        [input] integer yearNumber
        Guaranteed constraints:
        2015 ≤ yearNumber ≤ 2500.
        [output] integer
        The day of month on which the holiday will be celebrated in the year yearNumber.
        If there is no answer, return -1.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.TimeRiver
{
    class holidayClass
    {
        int holiday(int x, string weekDay, string month, int yearNumber) {
            var monthNames = new string[]{"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};
            var weekDayNames = new string[]{"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"};
            var monthLengths = new int[] {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
            var m = Array.IndexOf(monthNames, month) + 1;
            var w = (DayOfWeek)Array.IndexOf(weekDayNames, weekDay);
            var d1 = new DateTime(yearNumber, m, 1);
            var w1 = d1.DayOfWeek;
            var mw = w - w1 >= 0 ? w - w1 + 1 : w + 7 - w1 + 1;
            Console.WriteLine($"first {w} is the {mw}. {month} check: {new DateTime(yearNumber, m, mw).DayOfWeek}");
            var day = mw + 7 * (x - 1);
            if (day > (DateTime.IsLeapYear(yearNumber) && m == 2 ? 29 : monthLengths[m - 1])) return -1;
            Console.WriteLine($"Check: {new DateTime(yearNumber, m, day).DayOfWeek}");
            return day;;
        }
    }
}
