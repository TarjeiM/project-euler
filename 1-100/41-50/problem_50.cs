// Consecutive Prime Sum

(int, int) res = (0, 0);

List<int> primes = new() {2,3};

for (int i = 5; i < 4100; i++)
{
    if (isPrime(i))
    {
        primes.Add(i);
    }
}

for (int start = 0; start < primes.Count; start++)
{
    for (int end = primes.Count - 1; end >= start; end--)
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

Console.WriteLine(res.Item2);

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