using Tyuiu.ArkhipovaMD.Sprint1.Task6.V12.Lib;
namespace Tyuiu.ArkhipovaMD.Sprint1.Task6.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var res = ds.CheckLastWordRepetiton("as df ds as as");
            Assert.AreEqual(true, res);
        }
    }
}
