
namespace csharp.utilities
{
    public static class Utilities
{
    public static int[] Primes(int limit)
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
        return [.. primes];
    }
}
}
