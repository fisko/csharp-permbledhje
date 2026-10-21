// Z 6.1 — Klasa Lenda me konstruktor dhe ToString.
Lenda l1 = new Lenda("Programim në C#", "CS101", 6);
Lenda l2 = new Lenda("Matematikë", "MA110", 8);
Lenda l3 = new Lenda("Bazat e të dhënave", "DB201", 6);

Console.WriteLine(l1);
Console.WriteLine(l2);
Console.WriteLine(l3);

public class Lenda
{
    public string Emri;
    public string Kodi;
    public int EKTS;

    public Lenda(string emri, string kodi, int ekts)
    {
        Emri = emri;
        Kodi = kodi;
        EKTS = ekts;
    }

    public override string ToString()
        => $"{Kodi}: {Emri} ({EKTS} EKTS)";
}
