// Z 6.3 — Klasa Grup me varg studentësh.
Grup grupi = new Grup(new[]
{
    new Student("Arben"),
    new Student("Besa"),
    new Student("Drin"),
});

grupi.ShtypAnetaret();

public class Student
{
    public string Emri;
    public Student(string emri) { Emri = emri; }
}

public class Grup
{
    public Student[] Studentet;

    public Grup(Student[] studentet)
    {
        Studentet = studentet;
    }

    public void ShtypAnetaret()
    {
        foreach (Student s in Studentet)
            Console.WriteLine(s.Emri);
    }
}
