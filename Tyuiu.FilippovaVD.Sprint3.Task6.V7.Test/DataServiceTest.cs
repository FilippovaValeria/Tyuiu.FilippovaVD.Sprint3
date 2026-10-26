using Tyuiu.FilippovaVD.Sprint3.Task6.V7.Lib;

namespace Tyuiu.FilippovaVD.Sprint3.Task6.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();

            int startValue = 17;
            int stopValue = 26;

            int wait = 344;

            int res = ds.GetSumTheDivisors(startValue, stopValue);

            Assert.AreEqual(wait, res);
        }
    }
}
