namespace Libri.Kap11;

public class Llogari
{
    public double Gjendja = 100;

    public void Terhiq(double shuma)
    {
        if (shuma > Gjendja)
            throw new FondePamjaftueshmeException(
                $"S'ka fonde për {shuma}.");
        Gjendja -= shuma;
    }
}
