// Z 8.5 — Metodë statike Maksimumi mbi varg.
int[] numrat = { 14, 3, 27, 8, 19 };
Console.WriteLine($"Maksimumi: {Njehsime.Maksimumi(numrat)}");

public static class Njehsime
{
    public static int Maksimumi(int[] numra)
    {
        int max = numra[0];
        foreach (int n in numra)
        {
            if (n > max)
                max = n;
        }
        return max;
    }
}
