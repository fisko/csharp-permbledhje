namespace Libri.Kap10;

public class Rrethi : Figura
{
    public double Rrezja;
    public Rrethi(double rrezja) { Rrezja = rrezja; }

    public override double Syprina()
        => 3.14159 * Rrezja * Rrezja;
}
