// Lexiographic Permutations

List<int> nums = new() {0,1,2,3,4,5,6,7,8,9};

Console.WriteLine(string.Join("", NthPermutation(nums, 10, 1000000);));

int[] NthPermutation(List<int> myList, int permSize, int permRank)
{
    permRank--;
    
    int n = myList.Count;
    int nb = (int)(Factorial(n) / Factorial(n-permSize));
    int idx = 0;

    List<int> res = new();

    while (permSize > 0)
    {
        nb = (int)(nb / n);
        idx = (int)(permRank / nb);
        permRank = permRank % nb;
        res.Add(myList[idx]);
        myList.RemoveAt(idx);
        permSize--;
        n--;
    }

    return res.ToArray();
}

int Factorial(int n)
{
    if (n == 0)
    {
        return 1;
    } 
    else
    {
        return n * Factorial(n - 1);
    }
}