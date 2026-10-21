namespace Libri.Kap09;

public class Profesor : Njeri
{
    public Profesor(string emri) : base(emri) { }

    public override void Prezanto()
    {
        Console.WriteLine($"Jam {Emri}, profesor.");
    }
}
