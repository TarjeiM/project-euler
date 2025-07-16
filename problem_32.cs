// Pandigital Products

HashSet<int> seen = new();
int res = 0;

for (int multiplicand = 1; multiplicand < 100; multiplicand++)
{
    for (int multiplier = 1; multiplier < 10000; multiplier++)
    {
        int product = multiplicand * multiplier;

        if (seen.Contains(product)) { continue; }

        string sequence = product.ToString() + multiplicand.ToString() + multiplier.ToString();

        if (sequence.Length != 9) { continue; }

        char[] arr = sequence.ToCharArray();
        Array.Sort(arr);
        sequence = new string(arr);

        if (sequence != "123456789") { continue; }

        seen.Add(product);
        res += product;
    }
}

Console.WriteLine(res);