// Z 13.3 — Objekti me notën më të lartë: OrderByDescending + First.
List<Student> studentet = new List<Student>
{
    new Student("Arben", 8.5), new Student("Besa", 9.2),
    new Student("Drin", 6.8),
};

Student meIMiri = studentet
    .OrderByDescending(s => s.Nota)
    .First();

Console.WriteLine($"Më i miri: {meIMiri.Emri} ({meIMiri.Nota})");

public class Student
{
    public string Emri; public double Nota;
    public Student(string emri, double nota) { Emri = emri; Nota = nota; }
}
