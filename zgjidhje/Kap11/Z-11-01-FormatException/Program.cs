// Z 11.1 — Kap FormatException kur hyrja s'është numër.
Console.Write("Shkruaj një numër: ");
try
{
    int numri = int.Parse(Console.ReadLine() ?? "");
    Console.WriteLine($"Dyfishi: {numri * 2}");
}
catch (FormatException)
{
    Console.WriteLine("Kjo nuk ishte numër i vlefshëm.");
}
