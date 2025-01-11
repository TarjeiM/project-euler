// Amicable Numbers

using System.Collections.Generic;

int res = 0;

for (int a = 2; a < 10000; a++)
{
    int b = d(a);
    if (a != b && d(b) == a)
    {
        res += a;
    }
}

int d(int n)
{
    List<int> factors = new();
    for (int factor = 1; factor * factor <= n; factor++)
    {
        if (n % factor == 0)
        {
            factors.Add(factor);
            if (factor * factor != n && factor != 1)
            {
                factors.Add(n / factor);
            }
        }
    }
    return factors.Sum();
}

Console.WriteLine(res);
