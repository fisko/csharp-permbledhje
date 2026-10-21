public abstract class Ora
{
    public int NumriOreve { get; set; }
    public string Titulli { get; set; } = "";

    public Ora(int numriOreve, string titulli)
    {
        NumriOreve = numriOreve;
        Titulli = titulli;
    }

    public abstract void Fol();

    public override string ToString()
        => $"{Titulli} ({NumriOreve} orë)";
}

public interface INotueshme          // interface-i i bonusit
{
    void Vlereso(int nota);
}

public class Ligjerata : Ora, INotueshme
{
    public string Profesori { get; set; } = "";

    public Ligjerata(int numriOreve, string titulli,
                     string profesori)
        : base(numriOreve, titulli)
    {
        Profesori = profesori;
    }

    public override void Fol()
        => Console.WriteLine(
            $"Ligjërata \"{Titulli}\" mbahet nga {Profesori}.");

    public void Vlereso(int nota)
        => Console.WriteLine($"Ligjërata u vlerësua me {nota}.");
}

public class Ushtrime : Ora
{
    public Ushtrime(int numriOreve, string titulli)
        : base(numriOreve, titulli)
    {
    }

    public override void Fol()
        => Console.WriteLine($"Ushtrime praktike: {Titulli}.");
}

public class Provimi : INotueshme    // klasa shtesë e bonusit
{
    public void Vlereso(int nota)
        => Console.WriteLine($"Provimi u vlerësua me {nota}.");
}
