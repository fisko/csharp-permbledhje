Console.Write("Shkruaj një stinë: ");
string stina = Console.ReadLine();

switch (stina)
{
    case "Pranverë":
        Console.WriteLine("Lulëzon natyra.");
        break;
    case "Verë":
        Console.WriteLine("Koha e plazhit.");
        break;
    case "Vjeshtë":
        Console.WriteLine("Bien gjethet.");
        break;
    case "Dimër":
        Console.WriteLine("Bie borë.");
        break;
    default:
        Console.WriteLine("Nuk e njoh këtë stinë.");
        break;
}
