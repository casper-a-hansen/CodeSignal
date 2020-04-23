using NUnit.Framework;

namespace CodeSignalSolutions
{
    public class TestNUnit
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test(TestOf = typeof(Test))]
        public void ParseValue()
        {
            var test = @"
intValue: 23
stringValue: ""string""
charValue: ""C""
intArray: [1,2,3,4,5]
stringArray: [""apple"", ""orange"", ""banana""]
charArray: [""A"", 
""B"",  
""C"",  
""D""] 
intDArray: [ [1,2 ,3],
[4,5,6]]
stringDArray: [[""apple"", ""orange"", ""banana""],
[""boat"", ""car"", ""plane""] ]
charDArray: [[""A"", ""B"", ""C""], [""D"", ""E"", ""F""]]

Expected Output: 1
";

            Assert.AreEqual(23, Test.ParseValue("intValue", typeof(int), test));
            Assert.IsTrue(Test.Same(23, Test.ParseValue("intValue", typeof(int), test)), "int is incorrect");
            Assert.AreEqual("string", Test.ParseValue("stringValue", typeof(string), test));
            Assert.IsTrue(Test.Same("string", Test.ParseValue("stringValue", typeof(string), test)), "string is incorrect");
            Assert.AreEqual('C', Test.ParseValue("charValue", typeof(char), test));
            Assert.IsTrue(Test.Same('C', Test.ParseValue("charValue", typeof(char), test)), "char is incorrect");
            Assert.IsTrue(Test.Same(new[] { 1, 2, 3, 4, 5 }, Test.ParseValue("intArray", typeof(int[]), test)), "intArray is incorrect");
            Assert.IsTrue(Test.Same(new[] { "apple", "orange", "banana" }, Test.ParseValue("stringArray", typeof(string[]), test)), "stringArray is incorrect");
            Assert.IsTrue(Test.Same(new[] { 'A', 'B', 'C', 'D' }, Test.ParseValue("charArray", typeof(char[]), test)), "charArray is incorrect");
            Assert.IsTrue(Test.Same(new[] { new[] { 1, 2, 3 },new[] { 4, 5, 6 } }, Test.ParseValue("intDArray", typeof(int[][]), test)), "intDArray is incorrect");
            Assert.IsTrue(Test.Same(new[] { new[] { "apple", "orange", "banana" },  new[] { "boat", "car", "plane" } }, Test.ParseValue("stringDArray", typeof(string[][]), test)), "stringDArray is incorrect");
            Assert.IsTrue(Test.Same(new[] { new[] { 'A', 'B', 'C' }, new[] { 'D', 'E', 'F' } }, Test.ParseValue("charDArray", typeof(char[][]), test)), "charDArray is incorrect");
            Assert.IsTrue(Test.Same(1, Test.ParseExpectedOutput(typeof(int), test)), "Expected Result is incorrect");

            Test.AssertSuccess = false;
            Assert.AreEqual(1, Test.Execute(typeof(CodeSignalSolutions.firstClass), test));
            Assert.AreEqual(0, Test.Execute(typeof(CodeSignalSolutions.secondClass), @"
Expected Output:
[""A"", ""B"", ""C""]
" + test));
            Assert.AreEqual(0, Test.Execute(typeof(CodeSignalSolutions.thirdClass), test));

        }
    }

    public class firstClass
    {
        int first(char[][] charDArray, int intValue) => 1;
    }
    public class secondClass
    {
        char[] second(string stringValue, char charValue, int[] intArray) => new[] { 'A', 'B', 'C', 'D' };
    }
    public class thirdClass
    {
        int third(string[] stringArray, char[] charArray, string stringValue) => 0;
    }
}
