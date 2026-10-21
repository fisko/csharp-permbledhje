// Z 13.6 — Grupimi sipas fakultetit me GroupBy.
List<Student> studentet = new List<Student>
{
    new Student("Arben", "Informatikë"), new Student("Besa", "Ekonomik"),
    new Student("Drin", "Informatikë"),  new Student("Elta", "Informatikë"),
};

var grupet = studentet.GroupBy(s => s.Fakulteti);

foreach (var grupi in grupet)
    Console.WriteLine($"{grupi.Key}: {grupi.Count()} studentë");

public class Student
{
    public string Emri; public string Fakulteti;
    public Student(string emri, string fakulteti)
    { Emri = emri; Fakulteti = fakulteti; }
}
