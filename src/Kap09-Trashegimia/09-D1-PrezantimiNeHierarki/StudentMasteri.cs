namespace Libri.Kap09;

public class StudentMasteri : Student
{
    public StudentMasteri(string emri) : base(emri) { }

    public override void Prezanto()
    {
        base.Prezanto();
        Console.WriteLine("Në nivelin master.");
    }
}
