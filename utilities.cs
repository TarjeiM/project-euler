
using Microsoft.VisualBasic;

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

        // Index combination generation based on binary number set bits
        public static int[][] GetIndexCombinations(int digits)
        {
            List<int[]> indexCombinations = [];
            int end = 1 << digits;
            for (int i = 1; i < end; i++)
            {
                int binary = i;
                List<int> indexCombination = [];
                for (int j = 0; j < digits; j++)
                {
                    if (binary % 2 != 0)
                    {
                        indexCombination.Add(j);
                    }
                    binary >>= 1;
                }
                indexCombinations.Add([.. indexCombination]);
            }
            return [.. indexCombinations];
        }
        
        public static bool isPrime(int n, int[] primes)
        {
            if (n == 2 || n == 3 || n == 5)
            {
                return true;
            }
            int limit = (int)Math.Sqrt(n) + 1;
            foreach (int prime in primes)
            {
                if (n % prime == 0)
                {
                    return false;
                }

                if (prime > limit)
                {
                    break;
                }
            }

            return true;
        }

        public static int GetDigitSum(int n)
        {
            int digitSum = 0;
            while (n > 0)
            {
                digitSum += n % 10;
                n /= 10;
            }
            return digitSum;
        }
    }
}
