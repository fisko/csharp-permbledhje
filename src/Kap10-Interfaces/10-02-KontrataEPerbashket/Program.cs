using Libri.Kap10;

List<IIdentifikim> objektet = new List<IIdentifikim>
{
    new NjeriId { NumriId = 101, Emri = "Arben" },
    new Vetura  { NumriId = 202, Marka = "VW" },
};

foreach (IIdentifikim o in objektet)
    Console.WriteLine(o.NumriId);
