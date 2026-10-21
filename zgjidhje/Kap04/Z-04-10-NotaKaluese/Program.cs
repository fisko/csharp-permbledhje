// Z 4.10 — Sa nota janë mbi 5 (kaluese).
int[] notat = { 7, 4, 9, 5, 10, 6 };

int kaluese = 0;
foreach (int nota in notat)
{
    if (nota > 5)
        kaluese++;
}
Console.WriteLine($"Nota kaluese: {kaluese}");
