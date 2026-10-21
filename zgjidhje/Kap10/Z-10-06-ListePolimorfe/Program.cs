// Z 10.6 — Objekte të llojeve të ndryshme nën një interface, një cikël.
List<IRaportueshem> raportet = new List<IRaportueshem>
{
    new Student("Arben", 8.5),
    new Lenda("Programim në C#", 6),
    new Provimi("Kolokviumi 1"),
};

foreach (IRaportueshem r in raportet)
    Console.WriteLine(r.Raporto());

public interface IRaportueshem
{
    string Raporto();
}

public class Student : IRaportueshem
{
    public string Emri; public double Nota;
    public Student(string emri, double nota) { Emri = emri; Nota = nota; }
    public string Raporto() => $"Studenti {Emri}, nota {Nota}";
}

public class Lenda : IRaportueshem
{
    public string Emri; public int EKTS;
    public Lenda(string emri, int ekts) { Emri = emri; EKTS = ekts; }
    public string Raporto() => $"Lënda {Emri}, {EKTS} EKTS";
}

public class Provimi : IRaportueshem
{
    public string Titulli;
    public Provimi(string titulli) { Titulli = titulli; }
    public string Raporto() => $"Provimi: {Titulli}";
}
