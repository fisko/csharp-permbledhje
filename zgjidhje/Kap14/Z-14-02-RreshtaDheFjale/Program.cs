// Z 14.2 — Numëro rreshtat dhe fjalët e një skedari.
File.WriteAllText("teksti.txt",
    "C# është gjuhë moderne.\nProgramimi mësohet duke shkruar kod.\n");

string[] rreshtat = File.ReadAllLines("teksti.txt");
int fjale = 0;
foreach (string rreshti in rreshtat)
    fjale += rreshti.Split(' ',
        StringSplitOptions.RemoveEmptyEntries).Length;

Console.WriteLine($"Rreshta: {rreshtat.Length}, fjalë: {fjale}");
