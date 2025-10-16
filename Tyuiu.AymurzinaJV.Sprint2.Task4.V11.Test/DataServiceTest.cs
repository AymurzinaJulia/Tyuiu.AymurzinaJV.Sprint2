using Tyuiu.AymurzinaJV.Sprint2.Task4.V11.Lib;
namespace Tyuiu.AymurzinaJV.Sprint2.Task4.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 2;
            double wait = 25;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();
            double x = 30;
            double y = -50;
            double wait = -50;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
        
    }
}
