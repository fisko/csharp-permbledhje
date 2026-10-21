// Z 11.2 — Pjesëtimi me kapje të DivideByZeroException.
Console.WriteLine(Pjeseto(10, 2));
Console.WriteLine(Pjeseto(10, 0));

static string Pjeseto(int a, int b)
{
    try
    {
        return $"{a} / {b} = {a / b}";
    }
    catch (DivideByZeroException)
    {
        return "Pjesëtimi me zero nuk lejohet!";
    }
}
