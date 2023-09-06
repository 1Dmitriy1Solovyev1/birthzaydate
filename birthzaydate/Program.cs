using System;
using System.Globalization;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Создаем список дней рождения
        List<DateTime> birthdays = new List<DateTime>
        {
            new DateTime(2004, 2, 24),
            // Добавьте другие дни рождения по вашему выбору
        };

        // Задаем начальную и конечную даты для промежутка
        DateTime startDate = new DateTime(2004, 2, 24);
        DateTime endDate = new DateTime(2023, 12, 31);

        int count = CountSundaysInBirthdays(birthdays, startDate, endDate);

        Console.WriteLine($"Количество дней рождения, выпадающих на воскресенье: {count}");
    }

    static int CountSundaysInBirthdays(List<DateTime> birthdays, DateTime startDate, DateTime endDate)
    {
        int count = 0;

        // Перебираем все дни в заданном диапазоне
        for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
        {
            // Проверяем, выпадает ли текущая дата на воскресенье (0 - воскресенье, 1 - понедельник и т. д.)
            if (date.DayOfWeek == DayOfWeek.Sunday)
            {
                // Проверяем, есть ли день рождения в списке на эту дату
                foreach (DateTime birthday in birthdays)
                {
                    if (date.Month == birthday.Month && date.Day == birthday.Day)
                    {
                        count++;
                        break;
                    }
                }
            }
        }

        return count;
    }
}