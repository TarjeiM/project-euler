// Permuted Multiples

using csharp.utilities;

int[] multipliers = [2, 3, 4, 5, 6];

for (int numberOfDigits = 6; numberOfDigits <= 8; numberOfDigits++)
{
    int firstNumber = (int)Math.Pow(10, numberOfDigits - 1);
    int lastNumber = (int)Math.Pow(10, numberOfDigits) / 6;

    for (int origin = firstNumber; origin < lastNumber; origin++)
    {
        if (fitsCriteria(origin, lastNumber * 6))
        {
            Console.WriteLine($"The answer is {origin}");
            return;
        }
    }
}

bool fitsCriteria(int n, int end)
{
    foreach (int multiplier in multipliers)
    {
        int product = n * multiplier;

        if (product > end || !Utilities.isPermutation(n, product))
        {
            return false;
        }
    }
    return true;
}