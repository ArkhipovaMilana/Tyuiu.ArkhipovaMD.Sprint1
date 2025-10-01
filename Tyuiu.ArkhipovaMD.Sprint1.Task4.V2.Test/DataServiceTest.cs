using Tyuiu.ArkhipovaMD.Sprint1.Task4.V2.Lib;
namespace Tyuiu.ArkhipovaMD.Sprint1.Task4.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            var res = ds.Calculate(0, 2);
            Assert.AreEqual(0.5, res);
        }
    }
}
