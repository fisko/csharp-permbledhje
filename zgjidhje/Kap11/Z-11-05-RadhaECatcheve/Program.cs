// Z 11.5 — Disa catch me radhë: nga specifiku te i përgjithshmi.
Console.Write("Indeksi (0-2): ");
int[] vlerat = { 10, 20, 30 };

try
{
    string hyrja = Console.ReadLine() ?? "";
    int indeksi = int.Parse(hyrja);
    Console.WriteLine($"Vlera: {vlerat[indeksi]}");
}
catch (FormatException)
{
    Console.WriteLine("Duhet numër i plotë.");
}
catch (IndexOutOfRangeException)
{
    Console.WriteLine("Indeksi jashtë kufijve të vargut.");
}
catch (Exception ex)          // rrjeta e fundit, gjithmonë e fundit
{
    Console.WriteLine($"Gabim i papritur: {ex.Message}");
}
