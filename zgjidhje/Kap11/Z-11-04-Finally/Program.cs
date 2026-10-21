// Z 11.4 — finally ekzekutohet gjithmonë.
Console.Write("Shkruaj një numër: ");
try
{
    int numri = int.Parse(Console.ReadLine() ?? "");
    Console.WriteLine($"Katrori: {numri * numri}");
}
catch (FormatException)
{
    Console.WriteLine("Hyrje e pavlefshme.");
}
finally
{
    Console.WriteLine("Programi po mbyllet. (finally)");
}
