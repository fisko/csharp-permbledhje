int[] numrat = { 4, 8, 15, 16, 23, 42 };
int kerko = 16;
int indeksi = -1;

for (int i = 0; i < numrat.Length; i++)
{
    if (numrat[i] == kerko)
    {
        indeksi = i;
        break;
    }
}

Console.WriteLine(indeksi == -1
    ? "Nuk u gjet" : $"U gjet në indeksin {indeksi}");
