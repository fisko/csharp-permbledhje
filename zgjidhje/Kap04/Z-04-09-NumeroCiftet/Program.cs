// Z 4.9 — Sa elemente janë çift.
int[] numrat = { 14, 3, 27, 8, 4, 19 };

int cifte = 0;
foreach (int n in numrat)
{
    if (n % 2 == 0)
        cifte++;
}
Console.WriteLine($"Elemente çift: {cifte}");
