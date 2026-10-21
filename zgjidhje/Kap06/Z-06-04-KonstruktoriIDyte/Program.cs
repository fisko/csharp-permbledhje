// Z 6.4 — Konstruktor i dytë me vlera të parazgjedhura, i deleguar me this.
Student s1 = new Student("Arben", 1024, 20, "Informatikë");
Student s2 = new Student("Besa", 1025);   // konstruktori i dytë

Console.WriteLine(s1);
Console.WriteLine(s2);

public class Student
{
    public string Emri;
    public int Indeksi;
    public int Mosha;
    public string Fakulteti;

    public Student(string emri, int indeksi, int mosha, string fakulteti)
    {
        Emri = emri;
        Indeksi = indeksi;
        Mosha = mosha;
        Fakulteti = fakulteti;
    }

    public Student(string emri, int indeksi)
        : this(emri, indeksi, 18, "I papërcaktuar")
    {
    }

    public override string ToString()
        => $"{Emri} ({Indeksi}), {Mosha} vjeç, {Fakulteti}";
}
