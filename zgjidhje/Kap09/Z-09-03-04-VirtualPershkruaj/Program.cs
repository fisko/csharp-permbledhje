// Z 9.3 + 9.4 — Metodë virtuale e mbishkruar + listë polimorfe.
List<Automjet> automjetet = new List<Automjet>
{
    new Vetura("Škoda", 2021),
    new Autobus("Mercedes", 2019),
    new Vetura("Golf", 2018),
};

foreach (Automjet a in automjetet)
    a.Pershkruaj();               // secili variantin e vet

public class Automjet
{
    public string Marka;
    public int Viti;

    public Automjet(string marka, int viti)
    {
        Marka = marka; Viti = viti;
    }

    public virtual void Pershkruaj()
        => Console.WriteLine($"Automjet {Marka}, viti {Viti}.");
}

public class Vetura : Automjet
{
    public Vetura(string marka, int viti) : base(marka, viti) { }

    public override void Pershkruaj()
        => Console.WriteLine($"Vetura {Marka}, viti {Viti}.");
}

public class Autobus : Automjet
{
    public Autobus(string marka, int viti) : base(marka, viti) { }

    public override void Pershkruaj()
        => Console.WriteLine($"Autobusi {Marka}, viti {Viti}.");
}
