// Integer Right Triangles

int ans = 0;
int res = 0;

for (int p = 1; p <= 1000; p++)
{
    int solutions = 0;

    for (int a = 1; a < 500; a++)
    {
        for (int b = a + 1; b < 500; b++)
        {
            double c = Math.Pow((int)Math.Pow(a, 2) + (int)Math.Pow(b, 2), 0.5);

            if (c % 1 != 0)
            {
                continue;
            }

            if (a + b + c == p)
            {
                solutions++;
            }
        }
    }

    if (solutions > res)
    {
        ans = p;
        res = solutions;
    }
}

Console.WriteLine(ans);

