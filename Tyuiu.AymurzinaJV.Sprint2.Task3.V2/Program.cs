using Tyuiu.AymurzinaJV.Sprint2.Task3.V2.Lib;
DataService ds = new DataService();

Console.Title = "Спринт #2 | Выполнила: Аймурзина Ю. В. | РППб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема:Вложенные операторы if - else                                      *");
Console.WriteLine("* Задание #3                                                              *");
Console.WriteLine("* Вариант #2                                                              *");
Console.WriteLine("* Выполнила: Аймурзина Ю. В. | РППб-25-1                                  *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y      *");
Console.WriteLine("* с использованием вложенных оператор if-else, где пользователь вводит    *");
Console.WriteLine("* значение переменной X с клавиатуры.                                     *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");

Console.WriteLine(" Введите значение переменной X: ");
int x = Convert.ToInt32(Console.ReadLine());

double res = ds.Calculate(x);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine(res);
