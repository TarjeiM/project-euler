// Distinct Prime Factors

int limit = 1000000;

int[] Primes(int limit)
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

HashSet<int> primes = new(Primes(limit));

bool hasFourDistinctPrimeFactors(int number)
{
    List<int> factors = new();

    int orig = number;

    while (number % 2 == 0)
    {
        factors.Add(2);
        number /= 2;
    }

    for (int factor = 3; factor <= number / 2; factor += 2)
    {
        if (number % factor == 0)
        {
            if (primes.Contains(factor))
            {
                factors.Add(factor);
                number /= factor;
            }
        }
    }
    
    if (primes.Contains(number))
    {
        factors.Add(number);
    }

    HashSet<int> distinct = new(factors);

    return distinct.Count == 4;
}

for (int i = 1; i < limit; i++)
{
    if (hasFourDistinctPrimeFactors(i))
    {
        if (hasFourDistinctPrimeFactors(i+1))
        {
            if (hasFourDistinctPrimeFactors(i+2))
            {
                if (hasFourDistinctPrimeFactors(i+3))
                {
                    Console.WriteLine($"The first four consecutive integers to have four distinct prime factors each are {i}, {i + 1}, {i + 2} and {i + 3}.");
                    break;
                } else { i += 3; }
            } else { i += 2; }
        } else { i += 1; }
    }
}