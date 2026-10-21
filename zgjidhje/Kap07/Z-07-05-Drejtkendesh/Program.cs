// Z 7.5 — Përmasat jo negative, Syprina vetëm-për-lexim.
Drejtkendesh d = new Drejtkendesh();
d.Gjatesia = 4;
d.Gjeresia = -2;                 // refuzohet
d.Gjeresia = 3;
Console.WriteLine($"Syprina: {d.Syprina}");

public class Drejtkendesh
{
    private double gjatesia;
    public double Gjatesia
    {
        get { return gjatesia; }
        set { if (value >= 0) gjatesia = value; }
    }

    private double gjeresia;
    public double Gjeresia
    {
        get { return gjeresia; }
        set { if (value >= 0) gjeresia = value; }
    }

    public double Syprina
    {
        get { return Gjatesia * Gjeresia; }
    }
}
