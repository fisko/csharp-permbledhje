namespace Libri.Kap09;

public class Njeri
{
    public string Emri;
    public Njeri(string emri) { Emri = emri; }

    public virtual void Prezanto()
        => Console.WriteLine($"Jam {Emri}.");
}
