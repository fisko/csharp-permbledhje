Console.Write("Shkruaj moshën: ");
string? input = Console.ReadLine();
if (int.TryParse(input, out int mosha))
    Console.WriteLine($"Mosha është {mosha}");
else
    Console.WriteLine("Vlera nuk është numër i vlefshëm.");
