// Coded Triangle Numbers

int res = 0;

string[] words = File.ReadAllText("C:\\Users\\Tarjei\\Desktop\\Project Euler\\problem_42\\0042_words.txt").Split(',');

HashSet<int> triangleNumbers = new(TriangleNumbers(30));

foreach (string word in words)
{
    string trimmedWord = word.Trim('"');
    int wordValue = 0;

    foreach (char c in trimmedWord)
    {
        wordValue += (int)c - 64;
    }

    if (triangleNumbers.Contains(wordValue))
    {
        res++;
    }
}

int[] TriangleNumbers(int limit)
{
    int[] triangleNumbers = new int[limit];
    for (int i = 0; i < limit; i++)
    {
        triangleNumbers[i] = (int)(0.5 * (i + 1) * (i + 2));
    }
    return triangleNumbers;
}

Console.WriteLine($"The text file contains {res} triangle words");