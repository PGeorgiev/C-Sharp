﻿using System;
class NumberOfWorkDatesBetweenDates
{
    static bool IsHoliday(DateTime day, DateTime[] holidays)
    {
        foreach (DateTime holiday in holidays)
        {
            if (day == holiday)
            {
                return true;
            }
        }
        return false;
    }

    static void Main()
    {
        DateTime endDate = DateTime.Parse(Console.ReadLine());
        DateTime today = DateTime.Today;
        int days = 0;
        DateTime[] holidays = new DateTime[]
        {
            new DateTime(today.Year, 1, 1),
            new DateTime(today.Year, 3, 3),
            new DateTime(today.Year, 5, 1),
            new DateTime(today.Year, 5, 2),
            new DateTime(today.Year, 5, 6),
            new DateTime(today.Year, 5, 24),
            new DateTime(today.Year, 9, 22),
            new DateTime(today.Year, 12, 24),
            new DateTime(today.Year, 12, 25),
            new DateTime(today.Year, 12, 26),
            new DateTime(today.Year, 12, 31)
        };

        while (today<endDate)
        {
            if (today.DayOfWeek != DayOfWeek.Saturday && today.DayOfWeek != DayOfWeek.Sunday && !IsHoliday(today, holidays))
            {
                days++;
            }
            today = today.AddDays(1);
        }
        Console.WriteLine(days);
    }
}