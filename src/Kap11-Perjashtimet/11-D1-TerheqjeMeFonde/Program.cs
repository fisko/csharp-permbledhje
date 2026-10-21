using Libri.Kap11;

Llogari l = new Llogari();
double[] kerkesat = { 40, 80, 20 };

foreach (double k in kerkesat)
{
    try
    {
        l.Terhiq(k);
        Console.WriteLine($"U tërhoq {k}. Mbetje: {l.Gjendja}");
    }
    catch (FondePamjaftueshmeException ex)
    {
        Console.WriteLine("Gabim: " + ex.Message);
    }
}
