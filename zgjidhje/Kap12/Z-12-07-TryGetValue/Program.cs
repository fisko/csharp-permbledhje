// Z 12.7 — TryGetValue: leximi i sigurt i çelësit.
Dictionary<string, int> indekset = new Dictionary<string, int>
{
    ["Arben"] = 1024,
    ["Besa"] = 1025,
};

Console.Write("Emri i studentit: ");
string emri = Console.ReadLine() ?? "";

if (indekset.TryGetValue(emri, out int indeksi))
    Console.WriteLine($"Indeksi i {emri}: {indeksi}");
else
    Console.WriteLine($"{emri} nuk u gjet.");
