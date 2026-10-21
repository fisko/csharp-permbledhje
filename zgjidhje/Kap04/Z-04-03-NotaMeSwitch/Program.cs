// Z 4.3 — Nota 1-10 në vlerësim me switch.
Console.Write("Shkruaj notën (1-10): ");
int nota = int.Parse(Console.ReadLine() ?? "0");

switch (nota)
{
    case 10: Console.WriteLine("Shkëlqyeshëm"); break;
    case 9:  Console.WriteLine("Shumë mirë");   break;
    case 8:
    case 7:  Console.WriteLine("Mirë");         break;
    case 6:  Console.WriteLine("Mjaftueshëm");  break;
    default: Console.WriteLine("Pamjaftueshëm"); break;
}
