namespace Libri.Kap07;

public class Llogari
{
    private double gjendja;

    public double Gjendja { get { return gjendja; } }

    public void Depozito(double shuma)
    {
        if (shuma > 0)
            gjendja += shuma;
    }

    public void Terhiq(double shuma)
    {
        if (shuma > 0 && shuma <= gjendja)
            gjendja -= shuma;
        else
            Console.WriteLine("Veprim i pavlefshëm.");
    }
}
