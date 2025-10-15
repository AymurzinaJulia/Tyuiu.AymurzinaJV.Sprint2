using Tyuiu.AymurzinaJV.Sprint2.Task1.V18.Lib;

namespace Tyuiu.AymurzinaJV.Sprint2.Task1.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int a = 155;
            int b = 696;
            int c = 242;
            int d = 541;
            bool[] wait = new bool[6] {true, true, true, false, true, false};
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);

            CollectionAssert.AreEqual(wait, res);

        }
    }
}
