using Tyuiu.FilippovaVD.Sprint3.Task2.V5.Lib;

namespace Tyuiu.FilippovaVD.Sprint3.Task2.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            double value = 0.75;
            int startValue = 1;
            int stopValue = 20;

            double wait = 0.333;

            double res = ds.GetSumSeries(value, startValue, stopValue);

            Assert.AreEqual(wait, res, 0.001);
        }
    }
}
