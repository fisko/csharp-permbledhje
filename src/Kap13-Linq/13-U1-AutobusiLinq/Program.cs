List<Autobusi> autobuset = new List<Autobusi>
{
    new Autobusi("Mercedes", "Tourismo", 2019, 428),
    new Autobusi("Setra",    "S 516 HD", 2021, 476),
    new Autobusi("Mercedes", "Intouro",  2016, 299),
    new Autobusi("MAN",      "Lion's Coach", 2022, 470),
};

Console.WriteLine("1. Autobusët sipas brendit");
Console.WriteLine("2. Autobusët me KF mbi një vlerë");
Console.WriteLine("3. Viti mesatar i prodhimit");
Console.Write("Zgjedhja: ");
string zgjedhja = Console.ReadLine();

switch (zgjedhja)
{
    case "1":
        Console.Write("Shkruaj brendin: ");
        string brendi = Console.ReadLine();
        var sipasBrendit = autobuset
            .Where(a => a.Brendi == brendi);
        foreach (Autobusi a in sipasBrendit)
            Console.WriteLine(a);
        break;

    case "2":
        Console.Write("Shkruaj kufirin e KF: ");
        int kufiri = int.Parse(Console.ReadLine());
        var meTeFuqishem = autobuset
            .Where(a => a.KF > kufiri)
            .OrderByDescending(a => a.KF);
        foreach (Autobusi a in meTeFuqishem)
            Console.WriteLine(a);
        break;

    case "3":
        double vitiMesatar = autobuset
            .Average(a => a.Viti);
        Console.WriteLine(
            $"Viti mesatar: {vitiMesatar:F1}");
        break;
}

public class Autobusi
{
    public string Brendi { get; set; }
    public string Modeli { get; set; }
    public int Viti { get; set; }
    public int KF { get; set; }

    public Autobusi(string brendi, string modeli,
                    int viti, int kf)
    {
        Brendi = brendi; Modeli = modeli;
        Viti = viti; KF = kf;
    }

    public override string ToString()
        => $"{Brendi} {Modeli}, {Viti}, {KF} KF";
}
