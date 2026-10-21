File.AppendAllText("notat.csv", "12345;Programim;9\n");
File.AppendAllText("notat.csv", "12346;Programim;7\n");
File.AppendAllText("notat.csv", "12347;Programim;10\n");

if (!File.Exists("notat.csv"))
{
    Console.WriteLine("Skedari nuk ekziston.");
    return;
}

string[] rreshtat = File.ReadAllLines("notat.csv");
int shuma = 0, numri = 0, maksimumi = 0;

foreach (string rreshti in rreshtat)
{
    string[] pjeset = rreshti.Split(';');
    if (pjeset.Length != 3 ||
        !int.TryParse(pjeset[2], out int nota))
    {
        Console.WriteLine($"Rresht i dëmtuar: {rreshti}");
        continue;                 // kapërce rreshtin
    }
    shuma += nota;
    numri++;
    if (nota > maksimumi) maksimumi = nota;
}

if (numri > 0)
{
    Console.WriteLine($"Nota: {numri}");
    Console.WriteLine($"Mesatarja: {(double)shuma / numri:F2}");
    Console.WriteLine($"Më e larta: {maksimumi}");
}
