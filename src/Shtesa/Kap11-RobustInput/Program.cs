static int LexoInt(string mesazhi)
{
    while (true)
    {
        Console.Write(mesazhi);
        string input = Console.ReadLine() ?? "";
        if (int.TryParse(input, out int vlera))
            return vlera;
        Console.WriteLine("Gabim: shkruaj numër të plotë.");
    }
}

int mosha = LexoInt("Mosha: ");
Console.WriteLine($"Mosha e lexuar: {mosha}");
