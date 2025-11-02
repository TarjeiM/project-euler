// Names Scores

int res = 0;

string[] names = File.ReadAllText("C:\\Users\\Tarjei\\Desktop\\Project Euler\\problem_22\\problem_22.txt").Split(',');

Array.Sort(names);

for (int i = 0; i < names.Length; i++)
{
    string s = names[i].Replace("\"", "");
    int name_alpha_value = 0;

    foreach (char c in s)
    {
        name_alpha_value += (int)c-64;
    }

    res += (i+1) * name_alpha_value;
}

Console.WriteLine(res);
