// Z 14.6 — FileNotFoundException dhe IOException veç e veç.
try
{
    string permbajtja = File.ReadAllText("nuk-ekziston.txt");
    Console.WriteLine(permbajtja);
}
catch (FileNotFoundException)
{
    Console.WriteLine("Skedari nuk u gjet — kontrollo emrin dhe rrugën.");
}
catch (IOException ex)
{
    Console.WriteLine($"Gabim gjatë leximit: {ex.Message}");
}
