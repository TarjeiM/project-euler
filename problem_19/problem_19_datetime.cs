using System;

void Main()
{
    int res = 0;
    int day = 1;

    for (int year = 1901; year < 2001; year++)
    {
        for (int month = 1; month < 13; month++)
        {
            DateTime dateTime = new DateTime(year,month,day);
            if ((int)dateTime.DayOfWeek == 0)
            {
                Console.WriteLine($"{year},{month},{day}");
                res++;
            }
        }
    }

    Console.WriteLine(res);
}

Main();

