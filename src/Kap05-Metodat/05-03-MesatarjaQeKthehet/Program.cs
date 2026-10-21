double m = Mesatarja(8, 4, 6);
Console.WriteLine($"Mesatarja: {m}");
Console.WriteLine(m > 5 ? "Kaluar" : "Mbetur");

static double Mesatarja(int a, int b, int c)
{
    return (double)(a + b + c) / 3;
}
