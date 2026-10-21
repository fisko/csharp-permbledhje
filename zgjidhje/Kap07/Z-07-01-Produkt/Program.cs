// Z 7.1 — Produkt: çmimi nuk pranon vlera negative.
Produkt p = new Produkt { Emri = "Laptop", Cmimi = 45000 };
p.Cmimi = -100;                  // refuzohet
Console.WriteLine($"{p.Emri}: {p.Cmimi} den.");

public class Produkt
{
    public string Emri { get; set; } = "";

    private double cmimi;
    public double Cmimi
    {
        get { return cmimi; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Çmimi s'mund të jetë negativ!");
                return;
            }
            cmimi = value;
        }
    }
}
