// Z 13.1 — Numrat çift, të renditur në rritje.
List<int> numrat = new List<int> { 7, 2, 9, 4, 12, 3, 8 };

var ciftet = numrat
    .Where(n => n % 2 == 0)
    .OrderBy(n => n);

Console.WriteLine(string.Join(", ", ciftet));
