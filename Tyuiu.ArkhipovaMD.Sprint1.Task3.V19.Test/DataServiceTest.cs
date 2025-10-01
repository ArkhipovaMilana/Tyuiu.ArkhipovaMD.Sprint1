using Tyuiu.ArkhipovaMD.Sprint1.Task3.V19.Lib;
namespace Tyuiu.ArkhipovaMD.Sprint1.Task3.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            var res = ds.ElephCanMove(1,2,1,2);

            Assert.AreEqual(true, res);
        }
    }
}
