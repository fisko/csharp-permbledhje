// Z 10.3 — Një klasë zbaton dy interface njëkohësisht.
Vetura v = new Vetura { Targa = "SK-1234-AB" };
Console.WriteLine(v.Identifikohu());
v.Regjistro();

public interface IIdentifikim
{
    string Identifikohu();
}

public interface IRegjistrueshem
{
    void Regjistro();
}

public class Vetura : IIdentifikim, IRegjistrueshem
{
    public string Targa { get; set; } = "";

    public string Identifikohu() => $"Vetura me targa {Targa}";

    public void Regjistro()
        => Console.WriteLine($"{Targa} u regjistrua në sistem.");
}
