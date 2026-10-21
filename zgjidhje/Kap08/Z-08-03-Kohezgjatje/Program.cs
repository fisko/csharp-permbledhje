// Z 8.3 — Mbingarkimi i + për Kohezgjatje.
Kohezgjatje ligjerata = new Kohezgjatje(90);
Kohezgjatje ushtrime = new Kohezgjatje(45);

Kohezgjatje gjithsej = ligjerata + ushtrime;
Console.WriteLine(gjithsej);

public class Kohezgjatje
{
    public int Minuta;

    public Kohezgjatje(int minuta) { Minuta = minuta; }

    public static Kohezgjatje operator +(Kohezgjatje a, Kohezgjatje b)
        => new Kohezgjatje(a.Minuta + b.Minuta);

    public override string ToString()
        => $"{Minuta / 60} orë e {Minuta % 60} minuta";
}
