// Z 9.5 — Profesor e mbishkruan Fol(), Student e trashëgon të pandryshuar.
Njeri n = new Njeri("Agim");
Student s = new Student("Arben");
Profesor p = new Profesor("Vlora");

n.Fol();   // varianti i bazës
s.Fol();   // i pandryshuar -> varianti i bazës
p.Fol();   // i mbishkruar

public class Njeri
{
    public string Emri;
    public Njeri(string emri) { Emri = emri; }

    public virtual void Fol()
        => Console.WriteLine($"{Emri}: Përshëndetje!");
}

public class Student : Njeri
{
    public Student(string emri) : base(emri) { }
    // nuk e mbishkruan Fol() -> përdor atë të Njeriut
}

public class Profesor : Njeri
{
    public Profesor(string emri) : base(emri) { }

    public override void Fol()
        => Console.WriteLine($"Prof. {Emri}: Mirë se erdhët në ligjëratë!");
}
