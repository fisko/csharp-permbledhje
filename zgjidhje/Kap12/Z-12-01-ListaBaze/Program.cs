// Z 12.1 — List<int>: shto, hiq, numëro.
List<int> numrat = new List<int> { 5, 10, 15 };

numrat.Add(20);
numrat.Add(25);
numrat.Remove(10);

Console.WriteLine($"Elemente: {numrat.Count}");
foreach (int n in numrat)
    Console.Write(n + " ");
Console.WriteLine();
