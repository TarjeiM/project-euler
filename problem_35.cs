// Circular Primes

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

bool isCircular(HashSet<int> primes, int number)
{
    if (number < 10) { return true; }
    string numberString = number.ToString();
    int n = numberString.Length;
    numberString += numberString;
    for (int i = 0; i < n; i++)
    {
        string rotation = numberString.Substring(i, n);
        int rotationNumber = int.Parse(rotation);
        if (!primes.Contains(rotationNumber))
        {
            return false;
        }
    }
    return true;
}

HashSet<int> primes = new HashSet<int>(Primes(1000000));

int res = 0;

foreach (int prime in primes)
{
    if (isCircular(primes, prime))
    {
        res++;
    }
}

Console.WriteLine($"There are {res} circular primes below one million");