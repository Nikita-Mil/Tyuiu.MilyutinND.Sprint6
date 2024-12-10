using Tyuiu.MilyutinND.Sprint6.Task2.V1.Lib;

namespace Tyuiu.MilyutinND.Sprint6.Task2.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double[] result = ds.GetMassFunction(-5, 5);


            Assert.AreEqual(11, result.Length);
            foreach (double value in result)
            {
                Assert.AreNotEqual(0, value);
            }
        }
    }
}