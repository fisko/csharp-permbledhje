namespace Libri.Kap10;

public abstract class Njeri
{
    public string Emri;

    public Njeri(string emri) { Emri = emri; }

    public abstract void Lexo();

    public virtual void Fol()
    {
        Console.WriteLine($"{Emri} flet.");
    }
}
