using Tyuiu.ArkhipovaMD.Sprint1.Task6.V12.Lib;
DataService ds = new DataService();
Console.Title = "Спринт #1 | Выполнила: Архипова М.Д. | АСОиУб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
Console.WriteLine("* Задание #6                                                              *");
Console.WriteLine("* Вариант #12                                                              *");
Console.WriteLine("* Выполнила: Архипова М.Д. | АСОиУб-25-1                                  *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу: пользователь вводит текст. Проверить, что последнее слово строки входит в нее еще раз.            *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

string x;
Console.WriteLine("Введите значение ");
x = Console.ReadLine();



Console.WriteLine("***************************************************************************");
Console.WriteLine("РЕЗУЛЬТАТ:                                                                *");
Console.WriteLine("***************************************************************************");

Console.WriteLine(ds.CheckLastWordRepetiton(x));