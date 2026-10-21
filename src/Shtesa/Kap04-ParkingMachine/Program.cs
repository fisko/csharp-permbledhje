decimal total = 0m;
int automjete = 0;
bool vazhdo = true;

while (vazhdo)
{
    Console.WriteLine("1. Llogarit pagesë");
    Console.WriteLine("2. Raport");
    Console.WriteLine("0. Dalje");
    Console.Write("Zgjedhja: ");
    string zgjedhja = Console.ReadLine() ?? "";

    switch (zgjedhja)
    {
        case "1":
            Console.Write("Orë qëndrimi: ");
            int ore = int.Parse(Console.ReadLine() ?? "0");
            decimal pagesa = ore <= 1 ? 50m : 50m + (ore - 1) * 30m;
            total += pagesa;
            automjete++;
            Console.WriteLine($"Pagesa: {pagesa:F2} den");
            break;
        case "2":
            Console.WriteLine($"Automjete: {automjete}, Total: {total:F2} den");
            break;
        case "0":
            vazhdo = false;
            break;
        default:
            Console.WriteLine("Opsion i panjohur.");
            break;
    }
}
