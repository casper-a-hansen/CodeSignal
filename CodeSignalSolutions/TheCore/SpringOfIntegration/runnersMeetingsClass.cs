/*
    Status:   Solved
    Imported: 2020-05-02 13:03
    By:       Casper
    Url:      https://app.codesignal.com/arcade/code-arcade/spring-of-integration/Hb9Cppx4pCY4d8J5P

    Description:
        Some people run along a straight line in the same direction. They start
        simultaneously at pairwise distinct positions and run with constant speed (which
        may differ from person to person).
        If two or more people are at the same point at some moment we call that a
        meeting. The number of people gathered at the same point is called meeting
        cardinality.
        For the given starting positions and speeds of runners find the maximum meeting
        cardinality assuming that people run infinitely long. If there will be no
        meetings, return -1 instead.
        Example
        For startPosition = [1, 4, 2] and speed = [27, 18, 24], the output should be
        runnersMeetings(startPosition, speed) = 3.
        In 20 seconds after the runners start running, they end up at the same point.
        Check out the gif below for better understanding:
        Input/Output
        [execution time limit] 3 seconds (cs)
        [input] array.integer startPosition
        A non-empty array of integers representing starting positions of runners (in
        meters).
        Guaranteed constraints:
        2 ≤ startPosition.length ≤ 100,
        -104 ≤ startPosition[i] ≤ 104.
        [input] array.integer speed
        Array of positive integers of the same length as startPosition representing
        speeds of the runners (in meters per minute).
        Guaranteed constraints:
        speed.length = startPosition.length,
        1 ≤ speed[i] ≤ 100.
        [output] integer
        The maximum meeting cardinality or -1 if there will be no meetings.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.TheCore.SpringOfIntegration
{
    class runnersMeetingsClass
    {
        int runnersMeetings(int[] startPosition, int[] speed) {
            if (startPosition.Length == 1) return -1;
            int cardinal = -1;
            for(var i = 0; i < startPosition.Length - 1; i++) {
                for(var j = i + 1; j < startPosition.Length; j++) {
                    // The formula is y = speed*x + startPosition.
                    // The goal is to find the cross between number i and j
                    // x is time and y is position.
                    // speed[i]x + startPosition[i] = speed[j]x + startPosition[j]
                    // speed[i]x = speed[j]x + startPosition[j] - startPosition[i]
                    // speed[i]x - speed[j]x = startPosition[j] - startPosition[i]
                    // (speed[i] - speed[j])x = startPosition[j] - startPosition[i]
                    // x = (startPosition[j] - startPosition[i]) / (speed[i] - speed[j])
                    if (speed[i] == speed[j]) continue;
                    double x = (double)(startPosition[j] - startPosition[i]) / (double)(speed[i] - speed[j]);
                    double y = speed[i]*x + startPosition[i];
                    Console.WriteLine($"{i}&{j} - time:{x*60} sec at:{y} meters");
                    var count = startPosition.Select((s, i) => speed[i] * x + s).Count(yi => yi == y);
                    if (count > cardinal) {
                        cardinal = count;
                    }
                }
            }
            return cardinal;
        }
    }
}
