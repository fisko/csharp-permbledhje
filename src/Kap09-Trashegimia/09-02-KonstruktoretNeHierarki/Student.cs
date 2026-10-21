namespace Libri.Kap09;

public class Student : Njeri
{
    public string Fakulteti;

    public Student(string emri, int mosha, string fakulteti)
        : base(emri, mosha)
    {
        Fakulteti = fakulteti;
    }
}
