namespace Libri.Kap08;

public class Para
{
    public double Shuma;

    public Para(double shuma)
    {
        Shuma = shuma;
    }

    public static Para operator +(Para a, Para b)
    {
        return new Para(a.Shuma + b.Shuma);
    }

    public override string ToString()
    {
        return $"{Shuma} lekë";
    }
}
