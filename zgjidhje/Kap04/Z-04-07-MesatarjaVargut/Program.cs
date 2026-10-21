// Z 4.7 — Mesatarja e një vargu notash.
int[] notat = { 7, 8, 5, 9, 6 };

int shuma = 0;
foreach (int nota in notat)
    shuma += nota;

double mesatarja = (double)shuma / notat.Length;
Console.WriteLine($"Mesatarja: {mesatarja:F2}");
