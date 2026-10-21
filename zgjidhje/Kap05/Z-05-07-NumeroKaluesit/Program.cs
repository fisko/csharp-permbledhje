// Z 5.7 — Sa nota janë mbi 5.
int[] notat = { 7, 4, 9, 5, 10, 6 };
Console.WriteLine($"Kalues: {NumeroKaluesit(notat)}");

static int NumeroKaluesit(int[] notat)
{
    int kalues = 0;
    foreach (int nota in notat)
    {
        if (nota > 5)
            kalues++;
    }
    return kalues;
}
