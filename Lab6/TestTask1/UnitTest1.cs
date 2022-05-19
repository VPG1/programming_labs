 using Microsoft.VisualStudio.TestTools.UnitTesting;

 using Task1;
 using Task1.Properties;

 namespace TestTask1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestTriangle()
        {
            var triangle = new Triangle(new Point(20, 30), new Point(0, 0), new Point(30, 0));
            triangle.Move(10, 10);
            Assert.AreEqual(30, triangle.A.x);
        }
        
        [TestMethod]
        public void TestPoint()
        {
            var point = new Point(12, 14);
            point.Move(-10, -10);
            Assert.AreEqual(2, point.x);
        }
    }
}
