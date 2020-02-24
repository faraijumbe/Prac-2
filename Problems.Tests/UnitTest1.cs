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

            string b = Program.Prefix("");
            Assert.AreEqual("0,0:", b);

             string c = Program.Prefix("what ... did you say??     ");
            Assert.AreEqual("27,5:what ... did you say??     ", c);

            string d = Program.Prefix("   hello   ");
            Assert.AreEqual("11,1:", d);

            string e = Program.Prefix("what happened   here");
            Assert.AreEqual("20,3:", b);

            string f = Program.Prefix(... ...);
            Assert.AreEqual("7,2:", b);
        }
        
    }
}