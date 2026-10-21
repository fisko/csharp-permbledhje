Console.WriteLine(Faktorieli(5));   // 120

static long Faktorieli(int n)
{
    if (n <= 1)
        return 1;                    // rasti bazë ndalon rekursionin
    return n * Faktorieli(n - 1);    // thirrja rekursive
}
