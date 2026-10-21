namespace Libri.Kap10;

public class Katrori : Figura
{
    public double Brinja;
    public Katrori(double brinja) { Brinja = brinja; }

    public override double Syprina() => Brinja * Brinja;
}
