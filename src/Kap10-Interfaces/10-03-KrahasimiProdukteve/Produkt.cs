namespace Libri.Kap10;

public class Produkt : IComparable<Produkt>
{
    public string Emri { get; set; }
    public decimal Cmimi { get; set; }
    public int Sasia { get; set; }

    public Produkt(string emri, decimal cmimi, int sasia)
    {
        Emri = emri;
        Cmimi = cmimi;
        Sasia = sasia;
    }

    // Renditja natyrore: sipas çmimit, në rritje
    public int CompareTo(Produkt? tjeter)
    {
        if (tjeter is null) return 1;
        return Cmimi.CompareTo(tjeter.Cmimi);
    }

    public override string ToString()
        => $"{Emri} - {Cmimi:F0} lekë (sasia: {Sasia})";
}

// Renditja alternative: sipas emrit, në rend alfabetik
public class KrahasuesSipasEmrit : IComparer<Produkt>
{
    public int Compare(Produkt? a, Produkt? b)
    {
        if (a is null && b is null) return 0;
        if (a is null) return -1;
        if (b is null) return 1;
        return string.Compare(a.Emri, b.Emri);
    }
}
