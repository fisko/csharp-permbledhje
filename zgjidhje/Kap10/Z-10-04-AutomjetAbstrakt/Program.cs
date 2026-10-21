// Z 10.4 — Automjet abstrakt me Levize() te Makine e Barke.
Automjet[] automjetet = { new Makine(), new Barke() };

foreach (Automjet a in automjetet)
    a.Levize();

public abstract class Automjet
{
    public abstract void Levize();
}

public class Makine : Automjet
{
    public override void Levize()
        => Console.WriteLine("Makina lëviz në rrugë.");
}

public class Barke : Automjet
{
    public override void Levize()
        => Console.WriteLine("Barka lundron në ujë.");
}
