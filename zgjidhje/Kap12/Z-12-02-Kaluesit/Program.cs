// Z 12.2 — Sa studentë kanë kaluar (nota mbi 5).
List<Student> studentet = new List<Student>
{
    new Student("Arben", 8.5),
    new Student("Besa", 4.0),
    new Student("Drin", 6.8),
    new Student("Elta", 5.0),
};

int kalues = 0;
foreach (Student s in studentet)
{
    if (s.Nota > 5)
        kalues++;
}
Console.WriteLine($"Kanë kaluar: {kalues} nga {studentet.Count}");

public class Student
{
    public string Emri;
    public double Nota;
    public Student(string emri, double nota) { Emri = emri; Nota = nota; }
}
