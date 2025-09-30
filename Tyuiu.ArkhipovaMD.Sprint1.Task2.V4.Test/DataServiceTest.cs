using Tyuiu.ArkhipovaMD.Sprint1.Task2.V4.Lib;
namespace Tyuiu.ArkhipovaMD.Sprint1.Task2.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds =new DataService();
            int x = 2;
            var res =ds.CalculateSquare(x);
            Assert.AreEqual(4,res);
        }
    }
}
