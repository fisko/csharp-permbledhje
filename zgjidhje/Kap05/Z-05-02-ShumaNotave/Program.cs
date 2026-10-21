// Z 5.2 — Metoda që kthen shumën e një vargu notash.
int[] notat = { 7, 8, 5, 9 };
Console.WriteLine($"Shuma: {Shuma(notat)}");

static int Shuma(int[] notat)
{
    int shuma = 0;
    foreach (int nota in notat)
        shuma += nota;
    return shuma;
}
