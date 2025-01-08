using System;

void Main()
{
    int res = 0;
    int day = 0;
    int[] daysInMonth = new int[12] {31,28,31,30,31,30,31,31,30,31,30,31};  

    for (int year = 1901; year < 2001; year++)
    {
        bool leap = isLeap(year);
        for (int month = 1; month < 13; month++)
        {
            int days = daysInMonth[month-1];
            if (month == 2 && leap)
            {
                days = 29;
            }
            for (int i = 0; i < days; i++)
            {
                day = day == 7 ? 1 : day + 1;
                if (i == 0 && day == 1)
                {
                    res++;
                }
            }
        }
    }
    Console.WriteLine(res);
}

bool isLeap(int year)
{
    return year % 4 == 0;
}

Main();