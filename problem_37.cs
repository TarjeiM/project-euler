// Truncatable Primes

int res = 0, limit = 1000000;


static int[] Primes(int limit)
{
    List<int> primes = new();
    int[] numbers = new int[limit + 1];
    for (int i = 2; i < limit + 1; i++)
    {
        if (numbers[i] == 0) { primes.Add(i); }
        for (int j = i * 2; j < limit + 1; j += i)
        {
            numbers[j] = 1;
        }
    }
    return primes.ToArray();
}

HashSet<int> primes = new HashSet<int>(Primes(limit));

bool isTruncatable(HashSet<int> primes, int prime)
{
    string numString = prime.ToString();
    int start = 0, len = 1, n = numString.Length;

    // truncation from the right
    while (len < n)
    {
        string truncation = numString.Substring(start, len);
        if (!primes.Contains(int.Parse(truncation)))
        {
            return false;
        }
        len++;
    }

    // truncation from the left
    while (start <= n - 1)
    {
        string truncation = numString.Substring(start);
        if (!primes.Contains(int.Parse(truncation)))
        {
            return false;
        }
        start++;
    }
    return true;
}


foreach (int prime in primes)
{
    if (prime >= 11 && isTruncatable(primes, prime))
    {
        res += prime;
    }
}

Console.WriteLine($"The sum of every prime number that is truncaable in both directions while remaining prime is {res}");