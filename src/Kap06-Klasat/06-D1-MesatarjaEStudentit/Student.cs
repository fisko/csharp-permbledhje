namespace Libri.Kap06;

public class Student
{
    public string Emri;
    public double[] Notat;

    public Student(string emri, double[] notat)
    {
        Emri = emri;
        Notat = notat;
    }

    public double Mesatarja()
    {
        double shuma = 0;
        foreach (double n in Notat)
            shuma += n;
        return shuma / Notat.Length;
    }
}
