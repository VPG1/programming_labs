using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using task1;

namespace TestTask1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestUser()
        {
            var user = new User("Name");
            var tariff = new Tariff("tariff1", 2);
            user.Call(tariff);
            user.Call(tariff);
            user.Call(new Tariff("tariff2", 5));
            
            Assert.AreEqual(9, user.CallsCoast());
        }
        
        [TestMethod]
        public void TestAte()
        {
            var ate = new Ate(new List<Tariff>{new Tariff("tariff1", 2), new Tariff("tariff2", 32)});
            
            ate.LogIn("name");
            ate.Call("tariff1");
            ate.Call("tariff1");
            ate.Call("tariff2");
            
            Assert.AreEqual(36, ate.CallsCoast());
        }
    }
}