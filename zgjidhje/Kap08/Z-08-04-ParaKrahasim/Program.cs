// Z 8.4 — Mbingarkimi i > dhe < për Para (gjithmonë në çift!).
Para pagesa1 = new Para(1500);
Para pagesa2 = new Para(900);

Console.WriteLine(pagesa1 > pagesa2);   // True

public class Para
{
    public double Shuma;

    public Para(double shuma) { Shuma = shuma; }

    public static bool operator >(Para a, Para b) => a.Shuma > b.Shuma;
    public static bool operator <(Para a, Para b) => a.Shuma < b.Shuma;
}
