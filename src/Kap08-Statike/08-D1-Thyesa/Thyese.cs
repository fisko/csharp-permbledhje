namespace Libri.Kap08;

public class Thyese
{
    public int Numerator;
    public int Emerues;

    public Thyese(int numerator, int emerues)
    {
        Numerator = numerator;
        Emerues = emerues;
    }

    // PMP me algoritmin e Euklidit
    private static int Pmp(int a, int b)
    {
        while (b != 0) { int t = b; b = a % b; a = t; }
        return a < 0 ? -a : a;
    }

    public static Thyese operator +(Thyese x, Thyese y)
    {
        int num = x.Numerator * y.Emerues
                + y.Numerator * x.Emerues;
        int emr = x.Emerues * y.Emerues;
        int d = Pmp(num, emr);
        return new Thyese(num / d, emr / d);
    }

    public override string ToString() => $"{Numerator}/{Emerues}";
}
