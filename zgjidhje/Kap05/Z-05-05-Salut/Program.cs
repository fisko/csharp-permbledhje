// Z 5.5 — Parametër me vlerë të parazgjedhur.
Salut("Arben");                    // përdor parazgjedhjen
Salut("Besa", "Mirëmëngjesi");     // e zëvendëson

static void Salut(string emri, string pershendetje = "Përshëndetje")
{
    Console.WriteLine($"{pershendetje}, {emri}!");
}
