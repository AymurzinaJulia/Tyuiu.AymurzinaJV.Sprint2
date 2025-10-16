using Tyuiu.AymurzinaJV.Sprint2.Task3.V2.Lib;
namespace Tyuiu.AymurzinaJV.Sprint2.Task3.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = ds.Calculate(x);
            double wait = -44.654;
            Assert.AreEqual(wait, y);
        }
        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = ds.Calculate(x);
            double wait = 1.5;
            Assert.AreEqual(wait, y);
        }
        [TestMethod]
        public void TestMethod3()
        {
            DataService ds = new DataService();
            double x = -2;
            double y = ds.Calculate(x);
            double wait = -53;
            Assert.AreEqual(wait, y);
        }
        [TestMethod]
        public void TestMethod4()
        {
            DataService ds = new DataService();
            double x = -10;
            double y = ds.Calculate(x);
            double wait = -110;
            Assert.AreEqual(wait, y);
        }

    }
}
