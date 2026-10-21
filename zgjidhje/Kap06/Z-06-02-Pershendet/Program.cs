// Z 6.2 — Metoda Përshëndet te Student.
Student s1 = new Student("Arben");
Student s2 = new Student("Besa");

s1.Pershendet();
s2.Pershendet();

public class Student
{
    public string Emri;

    public Student(string emri)
    {
        Emri = emri;
    }

    public void Pershendet()
        => Console.WriteLine($"Përshëndetje, unë jam {Emri}");
}
