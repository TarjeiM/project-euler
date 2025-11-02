// Pandigital Multiples

using System.Text;

int res = 0;

int n = 5;

StringBuilder sb = new();

for (int start = 9; start <= 9999; start++)
{
    sb.Clear();

    for (int i = 1; i <= n; i++)
    {
        string part = (start * i).ToString();
        sb.Append(part);
    }

    string number = sb.ToString();

    if (number.Length > 9)
    {
        n--;
    }

    if (isPandigital(number)) {
        res = Math.Max(res, int.Parse(number));
    }
}

bool isPandigital(string s)
{
    HashSet<char> chars = new(s.ToCharArray());
    return chars.Count == 9 && !chars.Contains('0');
}

Console.WriteLine(res);