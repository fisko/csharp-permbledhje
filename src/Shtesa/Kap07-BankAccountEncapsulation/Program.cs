var l = new LlogariBankare("Arben", 1000m);
l.Depozito(500m);
Console.WriteLine(l.Terhiq(1200m));
Console.WriteLine($"Saldo: {l.Saldo:F2}");

class LlogariBankare
{
    public string Pronari { get; }
    public decimal Saldo { get; private set; }

    public LlogariBankare(string pronari, decimal saldoFillestare)
    {
        if (saldoFillestare < 0) throw new ArgumentException("Saldo negative.");
        Pronari = pronari;
        Saldo = saldoFillestare;
    }

    public void Depozito(decimal shuma)
    {
        if (shuma <= 0) throw new ArgumentException("Shuma duhet të jetë pozitive.");
        Saldo += shuma;
    }

    public bool Terhiq(decimal shuma)
    {
        if (shuma <= 0) return false;
        if (shuma > Saldo) return false;
        Saldo -= shuma;
        return true;
    }
}
