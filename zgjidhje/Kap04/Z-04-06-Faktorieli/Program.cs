// Z 4.6 — Faktorieli me for. Vlera fillestare 1, jo 0!
int n = 5;

long faktorieli = 1;
for (int i = 2; i <= n; i++)
    faktorieli *= i;

Console.WriteLine($"{n}! = {faktorieli}");
