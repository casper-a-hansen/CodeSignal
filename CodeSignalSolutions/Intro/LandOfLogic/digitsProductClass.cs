/*
    Status:   Solved
    Imported: 2020-04-26 13:14
    By:       Casper
    Url:      https://app.codesignal.com/arcade/intro/level-12/NJJhENpgheFRQbPRA

    Description:
        Given an integer product, find the smallest positive (i.e. greater than 0)
        integer the product of whose digits is equal to product. If there is no such
        integer, return -1 instead.
        
        Example
        
        For product = 12, the output should be
        digitsProduct(product) = 26;
        For product = 19, the output should be
        digitsProduct(product) = -1.
        
        Input/Output
        
        [execution time limit] 3 seconds
        (cs)
        
        [input] integer product
        
        Guaranteed constraints:
        0 ≤ product ≤ 600.
        [output] integer

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.Intro.LandOfLogic
{
    class digitsProductClass
    {
        int digitsProduct(int product) {
                // This is the brute force version of the solution, but it works
                for(int i = 1; i < 99999; i++) {
                    string digits = i.ToString();
                    int result = digits.Aggregate(1, (acc, val) => acc * (int)(val - '0'));
                    if(result == product)
                        return int.Parse(digits);
                }
                
                return -1;
            }
         
        /* This is my version but it fails at one hidden test.
        int digitsProduct(int product) {
            if (product == 0) return 10;
            if (product == 1) return 1;
            var results = new List<string[]>();
            var numbers = new string[100];
            var minDigits = int.MaxValue;
         
            void Products(int index, int value)
            {
                // Only one digit numbers are generated -> integer the product of whose digits is equal to product
                var max = Math.Min(9, value);
                for(var d = 2; d <= max; d++)
                {
                    if (value % d == 0)
                    {
                        if (index + 1 > minDigits) continue;
                        numbers[index] = d.ToString();
                        Products(index + 1, value / d);
                    }
                }
                if (index != 0 && value < 10)
                {
                    numbers[index] = value.ToString();
                    var result = new string[index + 1];
                    Array.Copy(numbers, result, index + 1);
                    results.Add(result);
                    minDigits = result.Length;
                }
            }
         
            Products(0, product);
         
            if (results.Count == 0) return -1;
         
            var minValue = int.MaxValue;
            foreach(var result in results)
            {
                Array.Sort(result);
                var value = int.Parse(string.Join("", result));
                if (value < minValue)
                {
                    Console.WriteLine($"-> {value} <- {string.Join(",", result)}");
                    minValue = value;
                }
            }
            return minValue;
        }
        */
    }
}
