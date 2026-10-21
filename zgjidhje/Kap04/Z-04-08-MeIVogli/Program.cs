// Z 4.8 — Elementi më i vogël i vargut.
int[] numrat = { 14, 3, 27, 8, 3, 19 };

int min = numrat[0];
foreach (int n in numrat)
{
    if (n < min)
        min = n;
}
Console.WriteLine($"Më i vogli: {min}");
