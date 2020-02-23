using NUnit.Framework;
using Problems;
namespace Problems.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            string a = Program.Prefix("hello");
            Assert.AreEqual("5,1:hello", a);
        }
        [Test]
        public void Test2()
        {
            string a = Program.Prefix("");
            Assert.AreEqual("0,0:", a);
        }
        [Test]
        public void Test3()
        {
            string a = Program.Prefix("what ... did you say??     ");
            Assert.AreEqual("27,5:what ... did you say??     ", a);
        }
    }
}