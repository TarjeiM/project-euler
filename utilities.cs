
namespace csharp.utilities
{
    public static class Utilities
    {
        // Sieve of Eratosthenes for generating prime numbers up to a limit (inclusive)
        public static int[] GetPrimes(int limit)
        {
            List<int> primes = [];
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

        // Boolean combination generation based on binary number set bits
        public static bool[][] GetBooleanCombinations(int digits)
        {
            List<bool[]> booleanCombinations = [];
            int end = 1 << digits;
            for (int i = 1; i < end; i++)
            {
                int binary = i;
                bool[] booleanCombination = new bool[digits];
                for (int j = 1; j <= digits; j++)
                {
                    booleanCombination[^j] = binary % 2 != 0;
                    binary >>= 1;
                }
                booleanCombinations.Add(booleanCombination);
            }
            return [.. booleanCombinations];
        }
    }
}
