using NUnit.Framework;
using System;
using task1;

namespace task1Tests
{
    [TestFixture()]
    public class Test
    {
        [Test()]
        public void TestCase1()
        {
            Assert.AreEqual(11, MathClass.min(11, 13));
        }
        [Test()]
        public void TestCase2()
        {
            Assert.AreEqual(-150, MathClass.min(235, -150));

        }
        [Test()]
        public void TestCase3()
        {
            Assert.AreEqual(-15, MathClass.min(-10, -15));

        }
    }
}
