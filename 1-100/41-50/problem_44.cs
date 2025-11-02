// Pentagon Numbers

int limit = 10000;

int Pentagonal(int n)
{
    return n * (3 * n - 1) / 2;
}

List<int> pentagonList = new();

for (int i = 1; i < limit; i++)
{
    pentagonList.Add(Pentagonal(i));
}

HashSet<int> pentagonSet = new(pentagonList);

int res = int.MaxValue;

for (int k = 1; k < limit; k++)
{
    int P_k = pentagonList[k-1];

    for (int n = 1; n < limit; n++)
    {
        int P_n = pentagonList[n-1]; // difference

        int P_j = P_k + P_n; // generate P_j that meets difference condition

        int sum = P_k + P_j;

        if (pentagonSet.Contains(P_j) && pentagonSet.Contains(sum))
        {
            res = Math.Min(res, Math.Abs(P_k - P_j));
        }
    }
}

Console.WriteLine(res);