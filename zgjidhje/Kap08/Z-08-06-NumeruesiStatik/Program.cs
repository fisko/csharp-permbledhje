// Z 8.6 — Numërues statik i studentëve me property vetëm-për-lexim.
Student s1 = new Student("Arben");
Student s2 = new Student("Besa");
Student s3 = new Student("Drin");

Console.WriteLine($"Gjithsej studentë: {Student.Gjithsej}");

public class Student
{
    public string Emri;

    private static int gjithsej;
    public static int Gjithsej
    {
        get { return gjithsej; }
    }

    public Student(string emri)
    {
        Emri = emri;
        gjithsej++;
    }
}
