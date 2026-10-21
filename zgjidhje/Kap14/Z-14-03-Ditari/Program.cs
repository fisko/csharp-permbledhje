// Z 14.3 — Ditar (log): çdo nisje shton datën dhe orën.
File.AppendAllText("ditari.log",
    $"Programi u nis më {DateTime.Now:dd.MM.yyyy HH:mm:ss}\n");

Console.WriteLine("Përmbajtja e ditarit:");
Console.WriteLine(File.ReadAllText("ditari.log"));
