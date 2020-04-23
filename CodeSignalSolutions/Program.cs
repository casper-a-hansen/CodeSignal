using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Reflection;
using NUnit.Framework;
using System.Linq;
using System.Diagnostics.Contracts;

namespace CodeSignalSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            var classes = Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => t.IsClass && t.IsPublic && t.GetMethods().Where(m => m.GetCustomAttributes(typeof(TestAttribute)).Any()).Any())
                .ToArray();
            int count = classes.Sum(c => c.GetMethods().Where(m => m.GetCustomAttributes(typeof(TestAttribute)).Any()).Count());
            int success = 0;
            List<string> failed = new List<string>();
            Console.WriteLine($"There are {classes.Length} classes with {count} tests in the application");
            Console.WriteLine();
            foreach(var c in classes)
            {
                var instance = Activator.CreateInstance(c);
                var tests = c.GetMethods().Where(m => m.GetCustomAttributes(typeof(TestAttribute)).Any() && m.IsPublic).ToArray();
                var setup = c.GetMethods().Where(m => m.GetCustomAttributes(typeof(SetUpAttribute)).Any() && m.IsPublic).FirstOrDefault();
                if (setup != null)
                {
                    Console.WriteLine($"Calling {c.Name}.{setup.Name} to initialize tests");
                    setup.Invoke(instance, null);
                }
                Console.WriteLine($"The class {c.Name} contains {tests.Length} tests.");
                foreach(var t in tests)
                {
                    try
                    {
                        t.Invoke(instance, null);
                        success++;
                    }
                    catch
                    {
                        failed.Add($"{c.Name}.{t.Name}");
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Status: {success} tests was successful out of {count} tests");

            if (failed.Count > 0)
            {
                Console.WriteLine($"Failed tests: {string.Join(", ", failed)}");
            }
        }
    }
}
