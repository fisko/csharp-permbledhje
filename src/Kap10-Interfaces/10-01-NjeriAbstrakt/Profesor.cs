namespace Libri.Kap10;

public class Profesor : Njeri
{
    public Profesor(string emri) : base(emri) { }

    public override void Lexo()
    {
        Console.WriteLine($"{Emri} lexon punime shkencore.");
    }

    public override void Fol()
    {
        Console.WriteLine($"{Emri} ligjëron.");
    }
}
