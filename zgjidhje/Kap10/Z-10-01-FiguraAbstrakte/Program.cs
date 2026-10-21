// Z 10.1 — Figura abstrakte: Syprina() e detyrueshme te fëmijët.
Figura[] figurat = { new Rrethi(3), new Katrori(4) };

foreach (Figura f in figurat)
    Console.WriteLine($"{f.GetType().Name}: {f.Syprina():F2}");

public abstract class Figura
{
    public abstract double Syprina();
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
