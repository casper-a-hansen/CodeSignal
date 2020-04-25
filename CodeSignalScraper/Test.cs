using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignalScraper
{
    public class Test
    {
        [Test]
        public void SourceIndent()
        {
            var content = @"{
    <source>
}";
            var source = @"var a = 1;
var b = 2;
var c = 3;";
            var regex = new Regex("<source>");
            var result = regex.Replace(content, match => Source.Indent(Source.GetIndent(content, match.Index), source));

            var expected = @"{
    var a = 1;
    var b = 2;
    var c = 3;
}";
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void SourceTests()
        {
            var task = new TaskInfo("https://area.com", "Area", "Topic", "https://task.com", "Task", true);

            task.Tests = new List<string>() { @"param1: [[0, 1],
[2, 3]]
Expected Output: [[2, 0],
[3, 1]]",@"param1: [[4, 5],
[6, 7]]
Expected Output: [[6, 4],
[7, 5]]" };
            var result = Source.ReplaceText("Test.Execute(typeof(<task>Class)<tests>);", task);
            var expected = @"Test.Execute(typeof(TaskClass), @""param1: [[0, 1],
                                [2, 3]]
                                Expected Output: [[2, 0],
                                [3, 1]]"", @""param1: [[4, 5],
                                [6, 7]]
                                Expected Output: [[6, 4],
                                [7, 5]]""
);";
            Assert.AreEqual(expected, result);
        }
    }
}
