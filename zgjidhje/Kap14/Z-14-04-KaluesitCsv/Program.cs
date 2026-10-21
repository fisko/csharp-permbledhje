// Z 14.4 — Nga studentet.csv te kaluesit.csv (nota të paktën 6).
File.WriteAllLines("studentet.csv", new[]
{
    "Arben;1024;8", "Besa;1025;4", "Drin;1026;6", "Elta;1027;10"
});

List<string> kaluesit = new List<string>();
foreach (string rreshti in File.ReadAllLines("studentet.csv"))
{
    string[] pjeset = rreshti.Split(';');
    if (pjeset.Length == 3 &&
        int.TryParse(pjeset[2], out int nota) && nota >= 6)
    {
        kaluesit.Add(rreshti);
    }
}

File.WriteAllLines("kaluesit.csv", kaluesit);
Console.WriteLine($"U ruajtën {kaluesit.Count} kalues në kaluesit.csv");
