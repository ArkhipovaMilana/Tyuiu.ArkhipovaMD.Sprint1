using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.ArkhipovaMD.Sprint1.Task3.V19.Lib
{
    public class DataService : ISprint1Task3V19
    {
        public bool ElephCanMove(double x1, double x2, double y1, double y2)
        {
            var xdif = x2 - x1;
            var ydif = y2 - y1;
            if (xdif==ydif) { return true; }
            else { return false; }
        }
    }
}
