using Microsoft.EntityFrameworkCore;

using var db = new KamionetContext();
db.Database.Migrate();               // zbaton migrimet

while (true)
{
    Console.WriteLine("\n1.Krijo 2.Paraqit 3.Ndrysho " +
                      "4.Pyetjet 0.Dalje");
    Console.Write("Zgjedhja: ");
    string z = Console.ReadLine();
    if (z == "0") break;

    if (z == "1") Krijo(db);
    else if (z == "2") Paraqit(db);
    else if (z == "3") Ndrysho(db);
    else if (z == "4") Pyetjet(db);
}

static void Krijo(KamionetContext db)
{
    Console.Write("Brendi: ");
    string brendi = Console.ReadLine();
    Console.Write("Modeli: ");
    string modeli = Console.ReadLine();
    Console.Write("Viti: ");
    int viti = int.Parse(Console.ReadLine());
    Console.Write("KF: ");
    int kf = int.Parse(Console.ReadLine());

    db.Kamionet.Add(new Kamioni { Brendi = brendi,
        Modeli = modeli, Viti = viti, KF = kf });
    db.SaveChanges();                // ruajtja në bazë
    Console.WriteLine("U ruajt.");
}

static void Paraqit(KamionetContext db)
{
    foreach (Kamioni k in db.Kamionet)
        Console.WriteLine(k);
}

static void Ndrysho(KamionetContext db)
{
    Console.Write("Id i kamionit: ");
    int id = int.Parse(Console.ReadLine());

    Kamioni k = db.Kamionet.Find(id);
    if (k == null)
    {
        Console.WriteLine("Nuk u gjet.");
        return;
    }
    Console.Write("KF i ri: ");
    k.KF = int.Parse(Console.ReadLine());
    db.SaveChanges();                // përditësimi
    Console.WriteLine("U ndryshua: " + k);
}

static void Pyetjet(KamionetContext db)
{
    Console.Write("a) brendi  b) KF mbi  c) viti mesatar: ");
    string p = Console.ReadLine();

    if (p == "a")
    {
        Console.Write("Brendi: ");
        string brendi = Console.ReadLine();
        var rez = db.Kamionet
            .Where(k => k.Brendi == brendi);
        foreach (Kamioni k in rez)
            Console.WriteLine(k);
    }
    else if (p == "b")
    {
        Console.Write("Kufiri KF: ");
        int kufiri = int.Parse(Console.ReadLine());
        var rez = db.Kamionet
            .Where(k => k.KF > kufiri)
            .OrderByDescending(k => k.KF);
        foreach (Kamioni k in rez)
            Console.WriteLine(k);
    }
    else if (p == "c")
    {
        double mes = db.Kamionet.Average(k => k.Viti);
        Console.WriteLine($"Viti mesatar: {mes:F1}");
    }
}
