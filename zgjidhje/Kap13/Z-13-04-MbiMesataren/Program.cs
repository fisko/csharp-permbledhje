// Z 13.4 — Sa studentë kanë notë mbi mesataren e grupit.
List<Student> studentet = new List<Student>
{
    new Student("Arben", 8.5), new Student("Besa", 9.2),
    new Student("Drin", 6.8),  new Student("Elta", 7.4),
};

double mesatarja = studentet.Average(s => s.Nota);
int mbiMesataren = studentet.Count(s => s.Nota > mesatarja);

Console.WriteLine($"Mesatarja: {mesatarja:F2}");
Console.WriteLine($"Mbi mesataren: {mbiMesataren} studentë");

public class Student
{
    public string Emri; public double Nota;
    public Student(string emri, double nota) { Emri = emri; Nota = nota; }
}
