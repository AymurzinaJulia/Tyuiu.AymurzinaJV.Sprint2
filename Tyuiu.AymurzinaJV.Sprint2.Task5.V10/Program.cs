using Tyuiu.AymurzinaJV.Sprint2.Task5.V10.Lib;
DataService ds = new DataService();

Console.Title = "Спринт #2 | Выполнила: Аймурзина Ю. В. | РППб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Оператор switch                                                   *");
Console.WriteLine("* Задание #5                                                              *");
Console.WriteLine("* Вариант #10                                                             *");
Console.WriteLine("* Выполнила: Аймурзина Ю. В. | РППб-25-1                                  *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая использует оператор switch,                 *");
Console.WriteLine("* вычисляет требуемое значение и возвращает результат.                    *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Введите день: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите месяц: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите год: ");
int g = Convert.ToInt32(Console.ReadLine());


string res = ds.FindDateOfPreviousDay(g, m, n);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine(res);
