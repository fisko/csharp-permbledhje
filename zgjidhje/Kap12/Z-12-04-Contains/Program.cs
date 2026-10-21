// Z 12.4 — Contains mbi listë qytetesh.
List<string> qytetet = new List<string>
{
    "Shkup", "Tetovë", "Gostivar", "Kumanovë"
};

Console.Write("Shkruaj një qytet: ");
string kerkuar = Console.ReadLine() ?? "";

if (qytetet.Contains(kerkuar))
    Console.WriteLine($"{kerkuar} gjendet në listë.");
else
    Console.WriteLine($"{kerkuar} nuk gjendet në listë.");
