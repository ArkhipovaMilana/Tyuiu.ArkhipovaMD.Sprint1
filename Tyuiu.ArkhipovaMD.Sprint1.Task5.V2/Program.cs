using Tyuiu.ArkhipovaMD.Sprint1.Task5.V2.Lib;
DataService ds = new DataService();
Console.Title = "Спринт #1 | Выполнила: Архипова М.Д. | АСОиУб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
Console.WriteLine("* Задание #5                                                              *");
Console.WriteLine("* Вариант #2                                                              *");
Console.WriteLine("* Выполнила: Архипова М.Д. | АСОиУб-25-1                                  *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дано значение температуры в градусах Фаренгейта. Определить значение этой же температуры в градусах Цельсия. Ответ привести к целому с помощью класса Convert.            *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

double x;
Console.WriteLine("Введите значение X");
x = Convert.ToDouble(Console.ReadLine());



Console.WriteLine("***************************************************************************");
Console.WriteLine("РЕЗУЛЬТАТ:                                                                *");
Console.WriteLine("***************************************************************************");

Console.WriteLine(ds.FahrenheitToСelsius(x));