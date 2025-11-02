// Double-base Palindromes

int res = 0;

static bool isPalindrome(string s)
{
    char[] arr = s.ToCharArray();
    for (int i = 0; i < s.Length / 2; i++)
    {
        (arr[i], arr[s.Length - (1 + i)]) = (arr[s.Length - (1 + i)], arr[i]);
    }
    string reverse = new string(arr);
    return s == reverse;
}

for (int i = 1; i < 1000000; i += 2)
{
    if (isPalindrome(i.ToString()))
    {
        string binaryRepresentation = Convert.ToString(i, 2);
        if (isPalindrome(binaryRepresentation))
        {
            res += i;
        }
    }
}

Console.WriteLine($"The sum of all the numbers below one million that are palindromic in both base 10 and base 2 is {res}");