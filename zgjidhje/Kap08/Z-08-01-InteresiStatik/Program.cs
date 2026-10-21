// Z 8.1 — Interesi statik: ndryshon për të gjitha llogaritë njëherësh.
Llogari a = new Llogari(10000);
Llogari b = new Llogari(20000);

Llogari.CaktoInteresin(0.05);
Console.WriteLine($"A me interes: {a.MeInteres():F0}");
Console.WriteLine($"B me interes: {b.MeInteres():F0}");

public class Llogari
{
    public double Gjendja;
    public static double Interesi;   // e përbashkët për të gjitha

    public Llogari(double gjendja) { Gjendja = gjendja; }

    public static void CaktoInteresin(double interesi)
        => Interesi = interesi;

    public double MeInteres()
        => Gjendja * (1 + Interesi);
}
