// Amicable Numbers

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
    int factorSum = 0;
    for (int factor = 1; factor * factor <= n; factor++)
    {
        if (n % factor == 0)
        {
            factorSum += factor;
            if (factor * factor != n && factor != 1)
            {
                factorSum += (n / factor);
            }
        }
    }
    return factorSum;
}

Console.WriteLine(res);
