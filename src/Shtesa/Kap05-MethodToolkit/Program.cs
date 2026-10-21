static double Mesatarja(int[] nota)
{
    int shuma = 0;
    foreach (int n in nota)
        shuma += n;
    return (double)shuma / nota.Length;
}

static string Suksesi(double mesatarja)
{
    if (mesatarja >= 9) return "Shkëlqyeshëm";
    if (mesatarja >= 7) return "Mirë";
    if (mesatarja >= 6) return "Mjaftueshëm";
    return "Nuk ka kaluar";
}

int[] notat = { 8, 9, 10, 7 };
double m = Mesatarja(notat);
Console.WriteLine($"Mesatarja: {m:F2}");
Console.WriteLine(Suksesi(m));
