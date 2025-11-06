// Prime Digit Replacements

using csharp.utilities;

// set digit ranges of search space
int start = 5, end = 7;

HashSet<int> primeSet = [.. Utilities.GetPrimes((int)Math.Pow(10, end - 1))];

for (int numberOfDigits = start; numberOfDigits <= end; numberOfDigits++)
{
    List<int[]> relevantCombinations = [];
    int[][] indexCombinations = Utilities.GetIndexCombinations(numberOfDigits);

    foreach (int[] indexCombination in indexCombinations)
    {
        // swapping a number of digits not divisible by 3 cannot yield 8 primes due to 
        // digit sum intervals overlapping too frequently with numbers divisible by 3
        if (indexCombination.Length % 3 != 0) { continue; }

        // swapping the last digit cannot yield 8 primes due to half the permutations being even.
        if (indexCombination.Contains(numberOfDigits)) { continue; }

        relevantCombinations.Add(indexCombination);
    }

    int firstNumber = (int)Math.Pow(10, numberOfDigits - 1);
    int lastNumber = firstNumber * 10;

    for (int origin = firstNumber; origin < lastNumber; origin++)
    {
        foreach (int[] combination in relevantCombinations)
        {
            if (hasEightPrimePermutations(origin, combination, firstNumber))
            {
                Console.WriteLine($"The unaltered answer is {origin}, swapping indeces {string.Join('-', combination)}");
                return;
            }
        }
    }
}

bool hasEightPrimePermutations(int n, int[] indeces, int check)
{
    int compositePermutations = 0;

    char[] charDigits = [.. n.ToString()];

    for (int digit = 0; digit <= 9; digit++)
    {
        foreach (int index in indeces)
        {
            charDigits[index] = (char)(digit + '0');
        }

        int permutation = int.Parse(new string(charDigits));

        if (!primeSet.Contains(permutation) || permutation < check) 
        {
            compositePermutations++; 
        }

        if (compositePermutations > 2) { return false; }
    }
    return true;
}


