namespace Libri.Kap08;

public class Student
{
    public static int Numri = 0;
    public string Emri;

    public Student(string emri)
    {
        Emri = emri;
        Numri++;
    }
}
