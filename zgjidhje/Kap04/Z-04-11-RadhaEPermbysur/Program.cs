// Z 4.11 — Elementet në radhë të përmbysur, pa varg të ri.
int[] numrat = { 1, 2, 3, 4, 5 };

for (int i = numrat.Length - 1; i >= 0; i--)
    Console.Write(numrat[i] + " ");
Console.WriteLine();
