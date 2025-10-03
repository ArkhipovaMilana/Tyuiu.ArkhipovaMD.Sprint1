using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.ArkhipovaMD.Sprint1.Task7.V11.Lib
{
    public class DataService : ISprint1Task7V11
    {
        public double Calculate(double x, double y)
        {
            var z = Math.Pow(Math.Log(Math.Sin(x)), x);
            z = z / (Math.Log(1 + x * x));
            z = z + (y - Math.Sqrt(Math.Abs(x)));
            return Math.Round(z,3);
        }
    }
}
