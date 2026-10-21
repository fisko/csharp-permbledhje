int[] notat = { 7, 8, 9 };

try
{
    Console.Write("Jep një indeks: ");
    int i = int.Parse(Console.ReadLine());
    Console.WriteLine($"Nota: {notat[i]}");
}
catch (FormatException)
{
    Console.WriteLine("Indeksi duhet të jetë numër.");
}
catch (IndexOutOfRangeException)
{
    Console.WriteLine("Nuk ka notë në atë pozicion.");
}
catch (Exception ex)
{
    Console.WriteLine("Gabim i papritur: " + ex.Message);
}
