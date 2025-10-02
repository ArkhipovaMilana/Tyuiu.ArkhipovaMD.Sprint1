using Tyuiu.ArkhipovaMD.Sprint1.Task5.V2.Lib;
namespace Tyuiu.ArkhipovaMD.Sprint1.Task5.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = ds.FahrenheitToСelsius(32);
            Assert.AreEqual(0, x);
        }
    }
}
