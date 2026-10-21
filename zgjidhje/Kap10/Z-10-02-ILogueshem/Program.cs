// Z 10.2 — Një interface, dy klasa krejt të ndryshme.
ILogueshem[] burimet = { new Vetura(), new Porosia() };

foreach (ILogueshem b in burimet)
    b.Logo();

public interface ILogueshem
{
    void Logo();
}

public class Vetura : ILogueshem
{
    public void Logo()
        => Console.WriteLine("[LOG] Vetura u regjistrua.");
}

public class Porosia : ILogueshem
{
    public void Logo()
        => Console.WriteLine("[LOG] Porosia u pranua.");
}
