int[,] a =
{
    { 2, 4, 6 },
    { 1, 3, 5 },
    { 7, 8, 9 }
};

for (int i = 0; i < a.GetLength(0); i++)
{
    int shumaRreshtit = 0;
    for (int j = 0; j < a.GetLength(1); j++)
    {
        shumaRreshtit += a[i, j];
    }
    Console.WriteLine($"Rreshti {i}: {shumaRreshtit}");
}

for (int j = 0; j < a.GetLength(1); j++)
{
    int shumaKolones = 0;
    for (int i = 0; i < a.GetLength(0); i++)
    {
        shumaKolones += a[i, j];
    }
    Console.WriteLine($"Kolona {j}: {shumaKolones}");
}
