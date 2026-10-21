try
{
    Console.Write("Numëruesi: ");
    int a = int.Parse(Console.ReadLine());

    Console.Write("Emëruesi: ");
    int b = int.Parse(Console.ReadLine());

    Console.WriteLine($"Rezultati: {a / b}");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Nuk mund të pjesëtosh me zero.");
}
catch (FormatException)
{
    Console.WriteLine("Të lutem shkruaj numra.");
}
finally
{
    Console.WriteLine("Faleminderit që përdore programin.");
}
