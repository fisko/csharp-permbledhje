// Z 12.6 — Studenti me notën më të lartë, me cikël.
List<Student> studentet = new List<Student>
{
    new Student("Arben", 8.5),
    new Student("Besa", 9.2),
    new Student("Drin", 6.8),
};

Student meIMiri = studentet[0];
foreach (Student s in studentet)
{
    if (s.Nota > meIMiri.Nota)
        meIMiri = s;
}
Console.WriteLine($"Më i miri: {meIMiri.Emri} ({meIMiri.Nota})");

public class Student
{
    public string Emri;
    public double Nota;
    public Student(string emri, double nota) { Emri = emri; Nota = nota; }
}
