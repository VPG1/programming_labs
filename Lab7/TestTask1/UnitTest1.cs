using System.Numerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestTask1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestComplex1()
        {
            var a = new Complex(3, 5);
            var b = new Complex(10, 12);
            Assert.AreEqual(new Complex(13, 17), (a + b));
        }   
        
        [TestMethod]
        public void TestComplex2()
        {
            Assert.AreEqual(new Complex(12, 13), new Complex(24, 13) - 12);
        }
    }
}