using NUnit.Framework;
using System;
using task2;
namespace task2Tests
{
    [TestFixture()]
    public class Test
    {
        [Test()]
        public void TestBranch1()
        {
            var m = new task2.services.MathClass();
            m.Calc(1);
            Assert.AreEqual(2, m.numOfBranch);
        }

        [Test()]
        public void TestBranch2()
        {
            var m = new task2.services.MathClass();
            m.Calc(0);
            Assert.AreEqual(1, m.numOfBranch);
        }
    }
}
