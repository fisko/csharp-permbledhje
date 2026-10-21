// Z 9.6 — Figura -> Rrethi, Katrori me Syprina() të mbishkruar.
List<Figura> figurat = new List<Figura>
{
    new Rrethi(3),
    new Katrori(4),
};

foreach (Figura f in figurat)
    Console.WriteLine($"{f.GetType().Name}: {f.Syprina():F2}");

public class Figura
{
    public virtual double Syprina() => 0;
}

public class Rrethi : Figura
{
    public double Rrezja;
    public Rrethi(double rrezja) { Rrezja = rrezja; }

    public override double Syprina() => Math.PI * Rrezja * Rrezja;
}

public class Katrori : Figura
{
    public double Brinja;
    public Katrori(double brinja) { Brinja = brinja; }

    public override double Syprina() => Brinja * Brinja;
}
