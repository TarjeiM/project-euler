// Coin Sums

int res = 0;
int[] coins = new[] {200, 100, 50, 20, 10, 5, 2, 1};

void Greedy(int curr, int i)
{
    if (curr == 200) {
        res++;
        return;
    }

    if (curr > 200 || i >= coins.Length) {
        return;
    }

    while (curr < 200) {
        Greedy(curr, i+1);
        curr = curr + coins[i];
        if (curr == 200) {
            res++;
            break;
        }
    }
}

Greedy(0, 0);

Console.WriteLine(res);