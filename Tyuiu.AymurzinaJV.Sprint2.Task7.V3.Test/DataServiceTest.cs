using Tyuiu.AymurzinaJV.Sprint2.Task7.V3.Lib;
namespace Tyuiu.AymurzinaJV.Sprint2.Task7.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(false, res);
        }
    }
}
