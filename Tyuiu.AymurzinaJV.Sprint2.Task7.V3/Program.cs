using Tyuiu.AymurzinaJV.Sprint2.Task7.V3.Lib;
DataService ds = new DataService();

Console.Title = "Спринт #2 | Выполнила: Аймурзина Ю. В. | РППб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #3                                                              *");
Console.WriteLine("* Выполнила: Аймурзина Ю. В. | РППб-25-1                                  *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу на C#, которая запрашивает исходные данные           *");
Console.WriteLine("* и вычисляет, находится ли точка X,Y в заштрихованной области.           *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Введите значение X: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение Y: ");
int y = Convert.ToInt32(Console.ReadLine());



Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

var res = ds.CheckDotInShadedArea(x, y);
if (res) Console.WriteLine("Точка находится в заштрихованной области");
else Console.WriteLine("Точка не находится в заштрихованной области");
Console.ReadKey();