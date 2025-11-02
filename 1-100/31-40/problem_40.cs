// Champernowne's Constant

using System.Text;

StringBuilder sb = new();
sb.Append(0);

int n = 1;

while (sb.Length < 1000001)
{
    sb.Append(n);
    n++;
}

string d = sb.ToString();

int res = 1;

for (int i = 1; i <= 1000000; i *= 10)
{
    res *= int.Parse(d[i].ToString());
}

Console.WriteLine(res);