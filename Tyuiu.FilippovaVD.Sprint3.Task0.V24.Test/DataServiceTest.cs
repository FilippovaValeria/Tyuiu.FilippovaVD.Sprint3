using Tyuiu.FilippovaVD.Sprint3.Task0.V24.Lib;
namespace Tyuiu.FilippovaVD.Sprint3.Task0.V24.Test
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
            int stopValue = 7;

            double wait = 0.071;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);

            Assert.AreEqual(wait, res);

        }
    }
}
