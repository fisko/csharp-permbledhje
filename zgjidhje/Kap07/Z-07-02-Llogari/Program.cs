// Z 7.2 — Gjendja lexohet nga jashtë, ndryshohet vetëm me Depozito/Terhiq.
Llogari ll = new Llogari();
ll.Depozito(5000);
ll.Terhiq(1200);
ll.Terhiq(9999);                 // refuzohet
Console.WriteLine($"Gjendja: {ll.Gjendja} den.");

public class Llogari
{
    private double gjendja;
    public double Gjendja
    {
        get { return gjendja; }   // vetëm lexim nga jashtë
    }

    public void Depozito(double shuma)
    {
        if (shuma > 0)
            gjendja += shuma;
    }

    public void Terhiq(double shuma)
    {
        if (shuma <= 0 || shuma > gjendja)
        {
            Console.WriteLine("Tërheqje e palejuar.");
            return;
        }
        gjendja -= shuma;
    }
}
