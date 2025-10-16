using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.AymurzinaJV.Sprint2.Task6.V3.Lib
{
    public class DataService : ISprint2Task6V3
    {
        public string FindDayName(int value)
        {
            string res = value switch
            {
                1 => "Понедельник",
                2 => "Вторник",
                3 => "Среда",
                4 => "Четверг",
                5 => "Пятница",
                6 => "Суббота",
                7 => "Воскресенье",
                _ => "Неверный порядковый номер дня недели."
            };

            return res;

        }
    }
}
