using Tyuiu.AymurzinaJV.Sprint2.Task1.V18.Lib;
DataService ds = new DataService();
int a = 155;
int b = 696;
int c = 242;
int d = 541;
bool[] res = new bool[6];
res = ds.GetLogicOperations(a, b, c, d);


Console.Title = "Спринт #2 | Выполнила: Аймурзина Ю. В. | РППб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Логические операции                                               *");
Console.WriteLine("* Задание #1                                                              *");
Console.WriteLine("* Вариант #18                                                             *");
Console.WriteLine("* Выполнила: Аймурзина Ю. В. | РППб-25-1                                  *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,         *");
Console.WriteLine("* последовательность операций не должна нарушаться)                       *");
Console.WriteLine("* и арифметических выражений,которая вернет логическую последовательность *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("A = " + a);
Console.WriteLine("B = " + b);
Console.WriteLine("C = " + c);
Console.WriteLine("D = " + d);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

for (int i = 0; i < 6; i++)
{
    Console.WriteLine(res[i]);
}
Console.ReadKey();
