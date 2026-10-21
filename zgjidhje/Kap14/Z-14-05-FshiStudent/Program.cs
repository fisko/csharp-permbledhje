// Z 14.5 — Fshi një student: rishkruaj CSV-në pa rreshtin e tij.
File.WriteAllLines("regjistri.csv", new[]
{
    "Arben;1024;8", "Besa;1025;7", "Drin;1026;6"
});

Console.Write("Indeksi i studentit për fshirje: ");
string indeksi = Console.ReadLine() ?? "";

string[] teGjithe = File.ReadAllLines("regjistri.csv");
List<string> teMbetur = new List<string>();
foreach (string rreshti in teGjithe)
{
    string[] pjeset = rreshti.Split(';');
    if (pjeset.Length >= 2 && pjeset[1] == indeksi)
        continue;                        // kapërce të fshirin
    teMbetur.Add(rreshti);
}

File.WriteAllLines("regjistri.csv", teMbetur);
Console.WriteLine($"Mbetën {teMbetur.Count} studentë në regjistër.");
