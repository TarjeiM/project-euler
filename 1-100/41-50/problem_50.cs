// Consecutive Prime Sum

using csharp.utilities;

(int, int) res = (0, 0);

int[] primes = Utilities.Primes(10000);

for (int start = 0; start < primes.Length; start++)
{
    for (int end = primes.Length - 1; end >= start; end--)
    {
        if (end - start < res.Item1)
        {
            continue;
        }
        int testSum = 0;
        for (int i = start; i < end; i++)
        {
            testSum += primes[i];
        }
        if (isPrime(testSum) && res.Item1 < end - start && testSum < 1000000)
        {
            res = (end - start, testSum);
        }
    }
}

bool isPrime(int n)
{
    if (n % 2 == 0 || n % 3 == 0)
    {
        return false;
    }
    int limit = (int)Math.Sqrt(n);
    for (int i = 5; i <= limit; i+=2)
    {
        if (n % i == 0)
        {
            return false;
        }
    }
    return true;
}

Console.WriteLine(res.Item2);
