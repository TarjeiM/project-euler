// Goldbach's Other Conjecture

int limit = 100000;

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

List<int> oddComposites = new();

for (int i = 3; i < limit; i += 2)
{
    if (!primes.Contains(i))
    {
        oddComposites.Add(i);
    }
}

bool fitsConjecture(int number)
{
    for (int i = 1; i <= (int)Math.Sqrt(number/2); i++)
    {
        int difference = number - 2 * (int)Math.Pow(i, 2);
        if (primes.Contains(difference))
        {
            return true;
        }
    }
    return false;
}

foreach (int oddComposite in oddComposites)
{
    if (!fitsConjecture(oddComposite))
    {
        Console.WriteLine($"The smallest odd composite that does not fit the conjecture is {oddComposite}");
        break;
    }
}

