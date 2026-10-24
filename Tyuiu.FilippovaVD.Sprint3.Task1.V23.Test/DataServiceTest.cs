using Tyuiu.FilippovaVD.Sprint3.Task1.V23.Lib;

namespace Tyuiu.FilippovaVD.Sprint3.Task1.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            int value = 5;
            int startValue = 1;
            int stopValue = 5;

            double wait = 0.071;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            Assert.AreNotEqual(0, res);

            Assert.IsTrue(res > 0);
        }
    }
}
