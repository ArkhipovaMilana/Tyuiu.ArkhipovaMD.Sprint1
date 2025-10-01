using Tyuiu.ArkhipovaMD.Sprint1.Task4.V2.Lib;
DataService ds = new DataService();
Console.Title = "Спринт #1 | Выполнила: Архипова М.Д. | АСОиУб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
Console.WriteLine("* Задание #4                                                              *");
Console.WriteLine("* Вариант #2                                                              *");
Console.WriteLine("* Выполнила: Архипова М.Д. | АСОиУб-25-1                                  *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, вычисляет результат по формуле и печатает его на экране. Ответ округлите до 3 знаков после запятой.            *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

double x;
Console.WriteLine("Введите значение X");
x = Convert.ToInt32(Console.ReadLine());
double y;
Console.WriteLine("Введите значение Y");
y = Convert.ToInt32(Console.ReadLine());



Console.WriteLine("***************************************************************************");
Console.WriteLine("РЕЗУЛЬТАТ:                                                                *");
Console.WriteLine("***************************************************************************");

Console.WriteLine(ds.Calculate(x,y));