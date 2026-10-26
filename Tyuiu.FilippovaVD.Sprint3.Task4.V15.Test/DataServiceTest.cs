using Tyuiu.FilippovaVD.Sprint3.Task4.V15.Lib;

namespace Tyuiu.FilippovaVD.Sprint3.Task4.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double wait = 623.499;

            double res = ds.Calculate(startValue, stopValue);

            Assert.AreEqual(wait, res);
        }
    }
}
