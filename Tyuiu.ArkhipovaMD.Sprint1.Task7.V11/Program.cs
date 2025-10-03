using Tyuiu.ArkhipovaMD.Sprint1.Task7.V11.Lib;

DataService ds = new DataService();
var x=Convert.ToDouble(Console.ReadLine());
var y = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(ds.Calculate(x,y));