// Z 4.4 — Vetëm emrat që fillojnë me "A".
string[] emrat = { "Arben", "Besa", "Agron", "Drin", "Arta" };

foreach (string emri in emrat)
{
    if (emri.StartsWith("A"))
        Console.WriteLine(emri);
}
