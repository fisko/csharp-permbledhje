int[] notat = { 7, 8, 5, 9, 6 };

int shuma = 0;
for (int i = 0; i < notat.Length; i++)
    shuma += notat[i];

double mesatarja = (double)shuma / notat.Length;

Console.WriteLine($"Shuma: {shuma}");
Console.WriteLine($"Mesatarja: {mesatarja:F2}");
