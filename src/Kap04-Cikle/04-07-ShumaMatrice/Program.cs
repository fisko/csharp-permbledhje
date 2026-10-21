int[,] a =
{
    { 2, 4, 6 },
    { 1, 3, 5 },
    { 7, 8, 9 }
};

int shuma = 0;

for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        shuma += a[i, j];
    }
}

Console.WriteLine($"Shuma është: {shuma}");
