// Pandigital Prime

string digits = "123456789";

int res = 0;

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

bool isPandigital(string s)
{
    string check = digits.Substring(0, s.Length);
    HashSet<char> chars = new(s.ToCharArray());
    foreach (char c in check)
    {
        if (!chars.Contains(c))
        {
            return false;
        }
    }
    return true;
}

int[] primes = Primes(10000000);

foreach (int prime in primes)
{
    if (isPandigital(prime.ToString()))
    {
        res = Math.Max(res, prime);
    }
}

Console.WriteLine(res);

