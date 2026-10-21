// Z 13.2 — Emrat e studentëve nën 21 vjeç.
List<Student> studentet = new List<Student>
{
    new Student("Arben", 20), new Student("Besa", 23),
    new Student("Drin", 19),  new Student("Elta", 21),
};

var teRinjte = studentet
    .Where(s => s.Mosha < 21)
    .Select(s => s.Emri);

Console.WriteLine(string.Join(", ", teRinjte));

public class Student
{
    public string Emri; public int Mosha;
    public Student(string emri, int mosha) { Emri = emri; Mosha = mosha; }
}
