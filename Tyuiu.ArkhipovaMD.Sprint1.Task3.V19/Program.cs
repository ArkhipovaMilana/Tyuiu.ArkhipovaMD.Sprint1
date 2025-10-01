using Tyuiu.ArkhipovaMD.Sprint1.Task3.V19.Lib;
DataService ds = new DataService();
Console.Title = "Спринт #1 | Выполнила: Архипова М.Д. | АСОиУб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
Console.WriteLine("* Задание #3                                                              *");
Console.WriteLine("* Вариант #19                                                              *");
Console.WriteLine("* Выполнила: Архипова М.Д. | АСОиУб-25-1                                  *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая печатает true или false в зависимости от того, может ли шахматная фигура «Слон» с одного заданного поля шахматной доски перейти за один ход на другое. Пользователь задаёт координаты двух ячеек шахматной доски (x1 и y1, x2 и y2, каждое в диапазоне от 1 до 8).            *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

double x1;
Console.WriteLine("Введите значение X1");
x1 = Convert.ToInt32(Console.ReadLine());
double x2;
Console.WriteLine("Введите значение X2");
x2 = Convert.ToInt32(Console.ReadLine());
double y1;
Console.WriteLine("Введите значение Y1");
y1 = Convert.ToInt32(Console.ReadLine());
double y2;
Console.WriteLine("Введите значение Y2");
y2 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("***************************************************************************");
Console.WriteLine("РЕЗУЛЬТАТ:                                                                *");
Console.WriteLine("***************************************************************************");

Console.WriteLine(ds.ElephCanMove(x1,x2,y1,y2));