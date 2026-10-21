namespace Libri.Kap09;

public class Student : Njeri
{
    public Student(string emri) : base(emri) { }

    public override void Prezanto()
    {
        base.Prezanto();           // versioni i prindit
        Console.WriteLine("Jam student.");
    }
}
