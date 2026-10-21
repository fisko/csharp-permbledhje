namespace Libri.Kap10;

public class Student : Njeri
{
    public Student(string emri) : base(emri) { }

    public override void Lexo()
    {
        Console.WriteLine($"{Emri} lexon libra.");
    }
}
