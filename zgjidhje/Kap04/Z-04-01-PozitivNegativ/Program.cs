// Z 4.1 — Pozitiv, negativ apo zero.
Console.Write("Shkruaj një numër: ");
int numri = int.Parse(Console.ReadLine() ?? "0");

if (numri > 0)
    Console.WriteLine("Pozitiv");
else if (numri < 0)
    Console.WriteLine("Negativ");
else
    Console.WriteLine("Zero");
