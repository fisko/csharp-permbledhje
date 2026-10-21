// Z 10.5 — Interface-i ynë IKrahasueshem te Student.
Student s1 = new Student("Arben", 8.5);
Student s2 = new Student("Besa", 9.2);

int rezultati = s1.KrahasoMe(s2);
Console.WriteLine(rezultati < 0 ? "Besa më e mirë" :
                  rezultati > 0 ? "Arben më i mirë" : "Barabar");

public interface IKrahasueshem
{
    int KrahasoMe(Student tjetri);
}

public class Student : IKrahasueshem
{
    public string Emri;
    public double Nota;

    public Student(string emri, double nota)
    {
        Emri = emri; Nota = nota;
    }

    public int KrahasoMe(Student tjetri)
        => Nota.CompareTo(tjetri.Nota);
}
