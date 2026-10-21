Console.WriteLine(Prodhimi(2, 3));
Console.WriteLine(Prodhimi(2, 3, 6));
Console.WriteLine(Prodhimi(2, 3, 4, 4));

static int Prodhimi(int a, int b, int c = 1, int d = 1)
{
    return a * b * c * d;
}
