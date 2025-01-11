// Number Spiral Diagonals

int GetDiagonal(int diameter)
{
    int radius = ((int)diameter / 2) + 1;
    int res = 0;

    res += ComputeDiagonal(radius, 8, 9); // top right
    res += ComputeDiagonal(radius, 6, 7); // top left
    res += ComputeDiagonal(radius, 2, 3); // bottom left
    res += ComputeDiagonal(radius, 4, 5); // bottom left

    return res;
}

int ComputeDiagonal(int radius, int addon, int num)
{
    int res = 0;

    for (int i = 2; i <= radius; i++)
    {
        res += num;
        addon += 8;
        num += addon;
    }

    return res;
}

Console.WriteLine(GetDiagonal(1001) + 1);