Console.Write("Emri: ");
string emri = Console.ReadLine() ?? "";
Console.Write("Mbiemri: ");
string mbiemri = Console.ReadLine() ?? "";
Console.Write("Numri i indeksit: ");
string indeks = Console.ReadLine() ?? "";
Console.Write("Qyteti: ");
string qyteti = Console.ReadLine() ?? "";

Console.WriteLine("+-----------------------------+");
Console.WriteLine("| KARTELA E STUDENTIT         |");
Console.WriteLine("+-----------------------------+");
Console.WriteLine($"| {emri} {mbiemri}");
Console.WriteLine($"| Indeksi: {indeks}");
Console.WriteLine($"| Qyteti:  {qyteti}");
Console.WriteLine("+-----------------------------+");
