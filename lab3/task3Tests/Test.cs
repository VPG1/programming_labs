using NUnit.Framework;
using System;
using task3;

namespace task3Tests
{
    [TestFixture()]
    public class Test
    {
        [Test()]
        public void TestDayOfWeek1()
        {
            Assert.AreEqual("Thursday", DataService.GetDay("05.12.2022"));
        }

        [Test()]
        public void TestDayOfWeek2()
        {
            Assert.AreEqual("Wednesday", DataService.GetDay("04.20.2022"));
        }

        [Test()]
        public void TestSpan1()
        {
            var tempDate = new DateTime(2022, 5, 12);
            Assert.AreEqual(Math.Abs((tempDate - DateTime.Today).Days), DataService.GetDaySpan(12, 5, 2022));
        }

        [Test()]
        public void TestSpan2()
        {
            var tempDate = new DateTime(2022, 4, 20);
            Assert.AreEqual(Math.Abs((tempDate - DateTime.Today).Days), DataService.GetDaySpan(20, 4, 2022));
        }
    }
}
