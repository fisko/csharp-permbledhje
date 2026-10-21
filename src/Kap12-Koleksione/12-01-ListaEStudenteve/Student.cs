namespace Libri.Kap12;

public class Student
{
    public string Emri { get; set; }
    public double Nota { get; set; }

    public override string ToString() => $"{Emri} ({Nota})";
}
