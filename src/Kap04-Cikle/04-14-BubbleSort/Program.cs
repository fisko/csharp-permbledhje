int[] v = { 5, 1, 4, 2, 8 };

for (int i = 0; i < v.Length - 1; i++)
{
    for (int j = 0; j < v.Length - 1 - i; j++)
    {
        if (v[j] > v[j + 1])
        {
            int temp = v[j];
            v[j] = v[j + 1];
            v[j + 1] = temp;
        }
    }
}

Console.WriteLine(string.Join(", ", v));
