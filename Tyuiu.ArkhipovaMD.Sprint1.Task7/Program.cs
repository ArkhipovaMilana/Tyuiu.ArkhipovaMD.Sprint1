int a, b, c;

Console.WriteLine("Enter data");

a = Convert.ToInt32(Console.ReadLine());

b = Convert.ToInt32(Console.ReadLine());

c = Convert.ToInt32(Console.ReadLine());

int d = a + b;

c -= a + b;

Console.WriteLine("Result = {0}", d + c);