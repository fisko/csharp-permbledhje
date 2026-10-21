namespace Libri.Kap07;

public class Student
{
    public string Emri { get; set; }
    public string Fakulteti { get; set; }

    private double nota;
    public double Nota
    {
        get { return nota; }
        set
        {
            if (value >= 0 && value <= 10)
                nota = value;
        }
    }

    public override string ToString()
    {
        return $"{Emri}, {Fakulteti}, notë: {nota}";
    }
}
