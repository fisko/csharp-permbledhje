int[,] a =
{
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 }
};

int n = a.GetLength(0);
int kryesore = 0;
int sekondare = 0;

for (int i = 0; i < n; i++)
{
    kryesore += a[i, i];
    sekondare += a[i, n - 1 - i];
}

Console.WriteLine($"Diagonalja kryesore: {kryesore}");
Console.WriteLine($"Diagonalja sekondare: {sekondare}");
