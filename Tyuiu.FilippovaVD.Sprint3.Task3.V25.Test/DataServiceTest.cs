using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.FilippovaVD.Sprint3.Task3.V25.Lib;

namespace Tyuiu.FilippovaVD.Sprint3.Task3.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMinCharCount()
        {
            DataService ds = new DataService();

            string value = "kjhgfuu gujut dtuu";
            char item = 'u';

            int wait = 2;

            int res = ds.GetMinCharCount(value, item);

            Assert.AreEqual(wait, res);
        }
    }
}
