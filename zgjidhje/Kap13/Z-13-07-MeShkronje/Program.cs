// Z 13.7 — Emrat me shkronjën e dhënë, të renditur alfabetikisht.
List<string> emrat = new List<string>
{
    "Arben", "Besa", "Agron", "Drin", "Arta", "Blerta"
};

Console.Write("Shkronja: ");
string shkronja = Console.ReadLine() ?? "A";

var rezultati = emrat
    .Where(e => e.StartsWith(shkronja))
    .OrderBy(e => e);

Console.WriteLine(string.Join(", ", rezultati));
