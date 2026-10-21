// Z 5.4 — Maksimumi i tre numrave.
Console.WriteLine(Maksimumi(4, 9, 7));   // 9

static int Maksimumi(int a, int b, int c)
{
    int max = a;
    if (b > max) max = b;
    if (c > max) max = c;
    return max;
}
