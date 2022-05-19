using Microsoft.VisualStudio.TestTools.UnitTesting;

using task1;

namespace TestTask1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestTariff()
        {
            var tariff = new Tariff(12);
            
            tariff.Increase(10);
            
            Assert.AreEqual(22, tariff.Value);
        }

        [TestMethod]
        public void TestAte()
        {
            var ate = ATE.GetInstance("address", 12, new Tariff(2));
            
            Assert.AreEqual(24, ate.CalculatePay());
        }
        
    }
}