int[] notat = { 7, 8, 5, 9, 6 };

int meLarta = notat[0];
foreach (int nota in notat)
{
    if (nota > meLarta)
        meLarta = nota;
}

Console.WriteLine($"Nota më e lartë: {meLarta}");
