namespace Libri.Kap06;

public class Student
{
    public string Emri;
    public int Mosha;
    public string Fakulteti;
    public int Indeksi;

    public Student(string emri, int mosha,
                   string fakulteti, int indeksi)
    {
        Emri = emri;
        Mosha = mosha;
        Fakulteti = fakulteti;
        Indeksi = indeksi;
    }
}
