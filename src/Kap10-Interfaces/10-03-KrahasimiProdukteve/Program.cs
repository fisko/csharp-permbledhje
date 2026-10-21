using Libri.Kap10;

List<Produkt> produktet = new()
{
    new Produkt("Laptop", 75000m, 3),
    new Produkt("Maus", 1250m, 40),
    new Produkt("Monitor", 21000m, 8),
    new Produkt("Tastierë", 3590m, 15)
};

produktet.Sort();
Console.WriteLine("Sipas çmimit (IComparable):");
foreach (Produkt p in produktet)
    Console.WriteLine("  " + p);

produktet.Sort(new KrahasuesSipasEmrit());
Console.WriteLine("Sipas emrit (IComparer):");
foreach (Produkt p in produktet)
    Console.WriteLine("  " + p);
