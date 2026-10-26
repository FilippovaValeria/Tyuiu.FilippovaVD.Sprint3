using Tyuiu.FilippovaVD.Sprint3.Task7.V23.Lib;

namespace Tyuiu.FilippovaVD.Sprint3.Task7.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double[] res = ds.GetMassFunction(startValue, stopValue);

            double len = res.Length;

            Assert.AreEqual(11, len);

            Assert.AreEqual(13.81, res[0]);

            Assert.AreEqual(0, res[6]);

            Assert.AreEqual(-5.71, res[10]);
        }
    }
}
