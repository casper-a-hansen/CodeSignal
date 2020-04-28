using NUnit.Framework;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalScraper
{
    public static class Source
    {
        public static readonly string SourcePath = @"..\..\..\..\CodeSignalSolutions";

        public static readonly string ClassFileName = @"<area>\<topic>\<task>Class.cs";
        public static readonly string ClassContent = @"/*
    Status:   <solved>
    Imported: <date>
    By:       <username>
    Url:      <taskUrl>

    Description:
        <description>
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalSolutions.<area>.<topic>
{
    class <task>Class
    {
        <source>
    }
}
";
        public static readonly string TestFileName = @"<area>\<topic>\<topic>.cs";
        public static readonly string TestContent = @"/*
    Imported:   <date>
    Created By: <username>
    Url:        <areaUrl>
*/
using NUnit.Framework;
using CodeSignalSolutions;
using CodeSignalSolutions.<area>.<topic>;

namespace <area>
{
    public class <topic>
    {
    }
}
";
        public static readonly string TestFunction = @"        /*
            Imported: <date>
            By:       <username>
            Url:      <taskUrl>
        */
        [Test]
        public void <task>()
        {
            Test.Execute(typeof(<task>Class),
                <tests>
            );
        }
";

        public static IEnumerable<TaskInfo> FilterTasks(IEnumerable<TaskInfo> tasks)
        {
            foreach(var task in tasks)
            {
                if (!IsSourceFinal(task)) yield return task;
            }
        }

        private static Regex regexStatus = new Regex(@"^\s*Status\s*:\s*((?:Uns|S)olved)\s*$", RegexOptions.Compiled | RegexOptions.Multiline);
        private static bool IsSourceFinal(TaskInfo task)
        {
            var sourcePath = Path.Combine(SourcePath, ReplaceText(ClassFileName, task));
            if (File.Exists(sourcePath))
            {
                // The task is not solved yet so no need to update source file.
                if (!task.Solved) return false;

                // Check if source contains the Solved source.
                var source = File.ReadAllText(sourcePath);
                var match = regexStatus.Match(source);
                return match.Success && match.Groups[1].Value == "Solved";
            }
            return false;
        }

        private static Regex regexParameter = new Regex(@"<(\w+)>", RegexOptions.Compiled);
        public static string ReplaceText(string source, TaskInfo task)
        {
            return regexParameter.Replace(source, match => match.Groups[1].Value.ToLower() switch { 
                "date" => DateTime.Now.ToString("yyyy-MM-dd HH:mm"),
                "username" => Environment.UserName,
                "taskurl" => task.TaskUrl,
                "task" => Fix(task.Task, true),
                "area" => Fix(task.Area),
                "areaurl" => task.AreaUrl,
                "topic" => Fix(task.Topic),
                "solved" => task.Solved ? "Solved" : "Unsolved",
                "description" => Indent(GetIndent(source, match.Index), WordWrap(task.Description.Trim(), 80)),
                "source" => Indent(GetIndent(source, match.Index), task.Source.Replace((char)160, ' ').Trim()),
                "tests" => Tests(GetIndent(source, match.Index), task.Tests),
                _ => $"{match.Groups[1].Value} was not found",
            } );
        }

        private static Regex regexCase = new Regex(@"\b[a-z]", RegexOptions.Compiled);
        private static Regex regexCamel = new Regex(@"^[A-Z]", RegexOptions.Compiled);
        private static Regex regexFix = new Regex(@"[^a-z0-9]", RegexOptions.IgnoreCase | RegexOptions.Compiled);
        public static string Fix(string name, bool camelCase = false)
        {
            name = regexCase.Replace(name, match => match.Value.ToUpper());
            if (camelCase)
            {
                name = regexCamel.Replace(name, match => match.Value.ToLower());
            }
            return regexFix.Replace(name, match => "");
        }
        public static string WordWrap(string text, int maxLength)
        {
            int First(string line, int pos)
            {
                while (pos < line.Length && char.IsWhiteSpace(line[pos]))
                    pos++;
                return pos;
            }
            int Last(string line, int pos)
            {
                while (pos >= 0 && char.IsWhiteSpace(line[pos]))
                    pos--;
                return pos;
            }
            int LastSpace(string line, int start, int length)
            {
                var pos = start + length;
                while (pos >= start)
                {
                    if (char.IsWhiteSpace(line[pos])) return Last(line, pos);
                    pos--;
                }
                return start + length - 1;
            }

            StringBuilder result = new StringBuilder(text.Length + 2 * (text.Length / maxLength));
            foreach (var line in text.Split('\n'))
            {
                var start = First(line, 0);
                var textEnd = Last(line, line.Length - 1);
                while (start + maxLength - 1 < textEnd)
                {
                    var end = LastSpace(line, start, maxLength);
                    if (end > start)
                    {
                        result.Append(line, start, end - start + 1);
                        result.AppendLine();
                    }
                    start = First(line, end + 1);
                }

                result.Append(line, start, textEnd - start + 1);
                result.AppendLine();
            }
            return result.ToString();
        }
        public static int GetIndent(string source, int index)
        {
            for(var i = index - 1; i >= 0; i--)
            {
                if (source[i] == '\n') return index - i - 1;
            }
            return index;
        }
        public static string Indent(int indent, string text, bool firstLine = false)
        {
            StringBuilder result = new StringBuilder();
            var indentStr = firstLine ? new string(' ', indent) : "";
            int start = 0;
            bool newLine = false;
            while(start < text.Length)
            {
                var end = text.IndexOf('\n', start);
                if (end == -1) end = text.Length - 1;
                var lineEnd = end;
                while (lineEnd > start && char.IsWhiteSpace(text[lineEnd])) lineEnd--;
                if (lineEnd > start || !char.IsWhiteSpace(text[lineEnd]))
                {
                    if (newLine) result.AppendLine();
                    newLine = true;
                    result.Append(indentStr);
                    if (indentStr.Length == 0) indentStr = new string(' ', indent);
                    result.Append(text, start, lineEnd - start + 1);
                }
                start = end + 1;
            }
            return result.ToString();
        }
        public static string Tests(int indent, List<string> tests)
        {
            if (tests == null || tests.Count == 0) return "";
            bool comma = false;
            StringBuilder result = new StringBuilder();
            foreach (var test in tests)
            {
                if (comma)
                {
                    result.AppendLine(",");
                }
                result.Append(Indent(indent, "@\"", comma));
                result.Append(Indent(indent, test.Replace("\"", "\"\"").Trim()));
                result.Append("\"");
                comma = true;
            }
            return result.ToString();
        }

        public static void WriteTask(TaskInfo task)
        {
            Console.WriteLine($"Writing {task.Task} of {task.Topic}.");
            {
                // Check that we get the Task Name right.
                var name = Fix(task.Task, true);
                var pattern = name.Replace("to", "(?:to|2)", StringComparison.OrdinalIgnoreCase);
                Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
                var match = regex.Match(task.Source);
                if (match.Success && !name.Equals(match.Value))
                {
                    Console.WriteLine($"Changed task name from {task.Task}to {match.Value}");
                    task.UpdateTaskName(match.Value);
                    if (IsSourceFinal(task))
                    {
                        Console.WriteLine($"Skipped the task since it is named {task.Task}");
                        return;
                    }
                }
            }

            // Writing source file
            var sourcePath = Path.Combine(SourcePath, ReplaceText(ClassFileName, task));
            Directory.CreateDirectory(Path.GetDirectoryName(sourcePath));
            var content = ReplaceText(ClassContent, task);
            File.WriteAllText(sourcePath, content);

            // Writing test file.
            var testPath = Path.Combine(SourcePath, ReplaceText(TestFileName, task));
            string source = null;
            if (File.Exists(testPath))
            {
                source = File.ReadAllText(testPath);

                if (source.Contains(task.Task)) return;
            }
            else
            {
                // Create new file.
                source = ReplaceText(TestContent, task);
            }
            var function = ReplaceText(TestFunction, task);

            var index = source.LastIndexOf("    }");
            if (index == -1) return;

            source = source.Substring(0, index) + function + source.Substring(index);
            File.WriteAllText(testPath, source);
        }
    }
}
