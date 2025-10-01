using Tyuiu.ArkhipovaMD.Sprint1.Task1.V1.Lib;
namespace Tyuiu.ArkhipovaMD.Sprint1.Task1.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double k = 1;
            double i =1;
            double j = 3;
            var res = ds.Calculate(i,j,k);
            Assert.AreEqual(7, res);
        }
    }
}
