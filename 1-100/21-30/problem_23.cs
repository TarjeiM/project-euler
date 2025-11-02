// Non-Abundant Sums

List<int> abundantNumbers = new List<int>();
HashSet<int> abundantSums = new HashSet<int>();
int res = 0;

for (int i = 1; i <= 28123; i++)
{
    if (IsAbundant(i))
    {
        abundantNumbers.Add(i);
    }
}

for (int i = 0; i < abundantNumbers.Count; i++)
{
    for (int j = 0; j < abundantNumbers.Count; j++)
    {
        if (abundantNumbers[i] + abundantNumbers[j] <= 28123)
        {
            abundantSums.Add(abundantNumbers[i] + abundantNumbers[j]);
        }
    }
}

for (int i = 1; i <= 28123; i++)
{
    if (!abundantSums.Contains(i))
    {
        res += i;
    }
}

bool IsAbundant(int n)
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
    return factorSum > n;
}

Console.WriteLine(res);