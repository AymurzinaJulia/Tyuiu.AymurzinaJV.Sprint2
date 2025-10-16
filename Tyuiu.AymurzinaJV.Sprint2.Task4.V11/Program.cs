using Tyuiu.AymurzinaJV.Sprint2.Task4.V11.Lib;
DataService ds = new DataService();

Console.Title = "Спринт #2 | Выполнила: Аймурзина Ю. В. | РППб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Тернарный оператор                                                *");
Console.WriteLine("* Задание #4                                                              *");
Console.WriteLine("* Вариант #11                                                             *");
Console.WriteLine("* Выполнила: Аймурзина Ю. В. | РППб-25-1                                  *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая вычисляет требуемое значение                *");
Console.WriteLine("* с использованием тернарного оператора.                                  *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");

Console.WriteLine(" Введите значение переменной X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Введите значение переменной Y: ");
int y = Convert.ToInt32(Console.ReadLine());


double res = ds.Calculate(x, y);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine(res);
