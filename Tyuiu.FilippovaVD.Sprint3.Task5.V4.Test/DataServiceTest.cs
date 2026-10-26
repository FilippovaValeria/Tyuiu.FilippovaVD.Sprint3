using Tyuiu.FilippovaVD.Sprint3.Task5.V4.Lib;

namespace Tyuiu.FilippovaVD.Sprint3.Task5.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();

            int x = 5;
            int startValue1 = 1;
            int stopValue1 = 1;
            int startValue2 = 3;
            int stopValue2 = 13;

            double wait = 3328.185;

            double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

            Assert.AreEqual(wait, res);
        }
    }
}
