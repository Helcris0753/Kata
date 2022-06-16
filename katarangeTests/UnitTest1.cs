using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace katarangeTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void containsTest()
        {
            bool result = katarange.Program.Kata.contains("[2,6]", "[2,4]");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void overlapsTest()
        {
            bool result = katarange.Program.Kata.overlaps("[2,10)", "[3,5)");
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void equalsTest()
        {
            bool result = katarange.Program.Kata.equals("[3,2)", "[3,2)");
            Assert.AreEqual(true, result);
        }
    }
}
