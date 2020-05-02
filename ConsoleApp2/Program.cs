using System;
using System.IO;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var jsonText = File.ReadAllText(@"C:\Users\Casper\Downloads\test-6.json");
            var json = JsonSerializer.Deserialize(jsonText, typeof(object)) as JsonElement?;
            StringBuilder result = new StringBuilder();
            json.Value.TryGetProperty("input", out var input);
            foreach (var value in input.EnumerateObject())
            {
                Write(result, value.Name, value.Value);
            }
            json.Value.TryGetProperty("output", out var output);
            Write(result, "Expected Output", output);

            Console.WriteLine(result.ToString());

        }

        static void Write(StringBuilder result, string name, JsonElement element)
        {
            var value = element.ToString();
            result.Append(name);
            result.Append(": ");
            result.Append(value.Replace("\"", "\"\""));
            result.AppendLine();
        }
        static string Write(string json)
        {
            json = Regex.Replace(json, @"(?<=""[^""]*""|\w+)\s*,\s*(?=""[^""]*""|\w+)", ",");
            json = Regex.Replace(json, @"(?<=\[|\w+)\s*(?=""[^""]*""|\w+)", "");
            json = Regex.Replace(json, @"(?<=""[^""]*""|\w+)\s*(?=\])", "");
            json = Regex.Replace(json, @"(?<=\])\s*,\s*(?=\[)", "," + Environment.NewLine);
            json = Regex.Replace(json, @"(?<=\[)\s+(?=\[)", "");
            json = Regex.Replace(json, @"(?<=\])\s+(?=\])", "");

            return json;
        }
    }
}
