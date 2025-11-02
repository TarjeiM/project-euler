// Prime Permutations

using csharp.utilities;

HashSet<int> primes = [.. Utilities.Primes(10000)];

foreach (int prime in primes)
{
    if (prime < 1000 || prime == 1487) // ignore irrelevant primes and known case
    {
        continue;
    }

    int seq2 = prime + 3330;
    int seq3 = seq2 + 3330;

    if (seq3 >= 10000) { continue; }

    if (primes.Contains(seq2) && primes.Contains(seq3))
    {
        if (isPermutation(prime, seq2) && isPermutation(prime, seq3))
        {
            Console.WriteLine($"{prime}{seq2}{seq3}");
            break;
        }
    }
}

bool isPermutation(int n1, int n2)
{
    string n1s = n1.ToString();
    string n2s = n2.ToString();
    foreach (char c in n1s)
    {
        if (!n2s.Contains(c))
        {
            return false;
        }
    }
    return true;
}