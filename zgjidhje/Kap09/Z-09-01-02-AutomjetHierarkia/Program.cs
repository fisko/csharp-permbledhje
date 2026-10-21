// Z 9.1 + 9.2 — Hierarkia Automjet me konstruktorë base(...).
Vetura v = new Vetura("Škoda", 2021, 5);
Autobus a = new Autobus("Mercedes", 2019, 52);

Console.WriteLine($"{v.Marka} ({v.Viti}), {v.NumriDyerve} dyer");
Console.WriteLine($"{a.Marka} ({a.Viti}), {a.NumriUleseve} ulëse");

public class Automjet
{
    public string Marka;
    public int Viti;

    public Automjet(string marka, int viti)
    {
        Marka = marka;
        Viti = viti;
    }
}

public class Vetura : Automjet
{
    public int NumriDyerve;

    public Vetura(string marka, int viti, int numriDyerve)
        : base(marka, viti)
    {
        NumriDyerve = numriDyerve;
    }
}

public class Autobus : Automjet
{
    public int NumriUleseve;

    public Autobus(string marka, int viti, int numriUleseve)
        : base(marka, viti)
    {
        NumriUleseve = numriUleseve;
    }
}
