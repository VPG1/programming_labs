using Microsoft.VisualStudio.TestTools.UnitTesting;
using task1;

namespace TestTask1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var ate = new Ate();
            ate.AddAbsDiscountTariff("fwjeoif", 2000, 200);
            Assert.AreEqual(1800, ate.GetAveragePrice());
        }
        [TestMethod]
        public void TestMethod2()
        {
            var ate = new Ate();
            ate.AddNoDiscountTariff("fwjeoif", 2000);
            Assert.AreEqual(2000, ate.GetAveragePrice());
        }
        [TestMethod]
        public void TestMethod3()
        {
            var ate = new Ate();
            ate.AddAbsDiscountTariff("fwjeoif", 2000, 200);
            ate.AddNoDiscountTariff("fwjeoif", 2000);
            Assert.AreEqual(1900, ate.GetAveragePrice());
        }
    }
}