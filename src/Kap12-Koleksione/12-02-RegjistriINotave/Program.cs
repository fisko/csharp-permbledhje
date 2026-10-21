Dictionary<string, double> notat = new Dictionary<string, double>();
notat["Arben"] = 8.5;
notat["Besa"] = 9.2;
notat["Drin"] = 6.8;

Console.Write("Kërko studentin: ");
string emri = Console.ReadLine();

if (notat.ContainsKey(emri))
    Console.WriteLine($"Nota e {emri}: {notat[emri]}");
else
    Console.WriteLine("Ky student nuk u gjet.");
