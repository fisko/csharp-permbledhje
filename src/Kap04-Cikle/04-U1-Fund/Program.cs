int shuma = 0;

while (true)
{
    Console.Write("Shkruaj një numër (ose FUND): ");
    string hyrja = Console.ReadLine();

    if (hyrja == "FUND")
        break;                    // dalja nga cikli

    shuma += int.Parse(hyrja);
}

Console.WriteLine($"Shuma e numrave: {shuma}");
