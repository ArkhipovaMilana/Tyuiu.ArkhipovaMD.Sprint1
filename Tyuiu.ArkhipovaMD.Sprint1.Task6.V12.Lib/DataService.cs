using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.ArkhipovaMD.Sprint1.Task6.V12.Lib
{
    public class DataService : ISprint1Task6V12
    {
        public bool CheckLastWordRepetiton(string value)
        {

            int i = 0;
            
            string[] words = value.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var l = words.Last();
            foreach (var word in words)
            {
                if (word == l) { i++; } else {; }
            }
            return i>1;

        }
    }
}
