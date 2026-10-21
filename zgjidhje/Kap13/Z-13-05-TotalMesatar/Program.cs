// Z 13.5 — Çmimi total dhe mesatar i produkteve.
List<Produkt> produktet = new List<Produkt>
{
    new Produkt("Bukë", 45), new Produkt("Qumësht", 75),
    new Produkt("Vezë", 120),
};

double totali = produktet.Sum(p => p.Cmimi);
double mesatari = produktet.Average(p => p.Cmimi);

Console.WriteLine($"Totali: {totali} den., mesatari: {mesatari:F2} den.");

public class Produkt
{
    public string Emri; public double Cmimi;
    public Produkt(string emri, double cmimi) { Emri = emri; Cmimi = cmimi; }
}
