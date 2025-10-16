using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.AymurzinaJV.Sprint2.Task5.V10.Lib
{
    public class DataService : ISprint2Task5V10
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            string res = null;
            switch (m)
            {
                case 1:
                    if (n >= 1 && n <= 31)
                    {
                        if (n == 1)
                            res = $"31.12.{g - 1}";
                        else if (n > 10)
                            res = $"{n - 1}.0{m}.{g}";
                        else
                            res = $"0{n - 1}.0{m}.{g}";
                    }
                    else
                    {
                        res = "Неверно указан день.";
                    }
                    break;
                case 2:
                    if (n >= 1 && n <= 28)
                    {
                        if (n == 1) res = $"31.0{m - 1}.{g}";
                        else if (n > 10) res = $"{n - 1}.0{m}.{g}";
                        else res = $"0{n - 1}.0{m}.{g}";
                    }
                    else res = "Неверно указан день.";
                    break;
                case 3:
                    if (n >= 1 && n <= 31)
                    {
                        if (n == 1) res = $"28.0{m - 1}.{g}";
                        else if (n > 10) res = $"{n - 1}.0{m}.{g}";
                        else res = $"0{n - 1}.0{m}.{g}";
                    }
                    else res = "Неверно указан день.";
                    break;
                case 5:
                case 7:
                    if (n >= 1 && n <= 31)
                    {
                        if (n == 1) res = $"30.0{m - 1}.{g}";
                        else if (n > 10) res = $"{n - 1}.0{m}.{g}";
                        else res = $"0{n - 1}.0{m}.{g}";
                    }
                    else res = "Неверно указан день.";
                    break;
                case 10:
                    if (n >= 1 && n <= 31)
                    {
                        if (n == 1) res = $"30.0{m - 1}.{g}";
                        else if (n > 10) res = $"{n - 1}.{m}.{g}";
                        else res = $"0{n - 1}.{m}.{g}";
                    }
                    else res = "Неверно указан день.";
                    break;
                case 12:
                    if (n >= 1 && n <= 31)
                    {
                        if (n == 1) res = $"30.{m - 1}.{g}";
                        else if (n > 10) res = $"{n - 1}.{m}.{g}";
                        else res = $"0{n - 1}.{m}.{g}";
                    }
                    else res = "Неверно указан день.";
                    break;
                case 8:
                    if (n >= 1 && n <= 31)
                    {
                        if (n == 1) res = $"31.0{m - 1}.{g}";
                        else if (n > 10) res = $"{n - 1}.0{m}.{g}";
                        else res = $"0{n - 1}.0{m}.{g}";
                    }
                    else res = "Неверно указан день.";
                    break;
                case 4:
                case 6:
                case 9:
                    if (n >= 1 && n <= 30)
                    {
                        if (n == 1) res = $"31.0{m - 1}.{g}";
                        else if (n > 10) res = $"{n - 1}.0{m}.{g}";
                        else res = $"0{n - 1}.0{m}.{g}";
                    }
                    else res = "Неверно указан день.";
                    break;
                case 11:
                    if (n >= 1 && n <= 30)
                    {
                        if (n == 1) res = $"31.{m - 1}.{g}";
                        else if (n > 10) res = $"{n - 1}.{m}.{g}";
                        else res = $"0{n - 1}.{m}.{g}";
                    }
                    else res = "Неверно указан день.";
                    break;
                default:
                    res = "Неверно указан месяц.";
                    break;
            }
            return res;
        }
    }
}
