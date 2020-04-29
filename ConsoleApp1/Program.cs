using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var path = @"C:\Users\Casper\Downloads\test-1.json";
            var jsonText = File.ReadAllText(path);

            var json = JsonSerializer.Deserialize(jsonText, typeof(object)) as JsonElement?;

            //Console.WriteLine(result);

            StringBuilder result = new StringBuilder();
            json.Value.TryGetProperty("input", out var input);
            foreach(var value in input.EnumerateObject())
            {
                Write(result, value.Name, value.Value);
            }
            json.Value.TryGetProperty("output", out var output);
            Write(result, "Expected Output", output);

            Console.Write(result);
        }
        static Regex regexArray = new Regex(@"(?<=\d|""|\[)\s*,\s*(?=\d|""|\])");
        static Regex regexBrackets = new Regex(@"(?<=\]|\[|\d|"")\s*(?=\]|\[|\d|"")");
        static Regex regexBrackets2 = new Regex(@"(?<=\])\s*,\s*(?=\[)");
        static void Write(StringBuilder result, string name, JsonElement value)
        {
            result.Append(name);
            result.Append(": ");
            var text = value.ToString();
            if (value.ValueKind == JsonValueKind.Array)
            {
                text = regexArray.Replace(text, ",");
                text = regexBrackets.Replace(text, "");
                text = regexBrackets2.Replace(text, ",\n");
            }
            result.AppendLine(text);
        }
    }
}
