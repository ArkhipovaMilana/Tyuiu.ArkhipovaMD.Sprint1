using Tyuiu.ArkhipovaMD.Sprint1.Task7.V11.Lib;
namespace Tyuiu.ArkhipovaMD.Sprint1.Task7.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var res = ds.Calculate(1, 1);
            Assert.AreEqual(-0.249, res);
        }
    }
}
