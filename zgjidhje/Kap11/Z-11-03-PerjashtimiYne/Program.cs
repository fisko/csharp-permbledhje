// Z 11.3 — Përjashtimi ynë NotePavlefshmeException (nota 0-10).
try
{
    CaktoNoten(7);
    CaktoNoten(15);      // hedh përjashtimin tonë
}
catch (NotePavlefshmeException ex)
{
    Console.WriteLine($"Gabim: {ex.Message}");
}

static void CaktoNoten(int nota)
{
    if (nota < 0 || nota > 10)
        throw new NotePavlefshmeException(
            $"Nota {nota} është jashtë intervalit 0-10.");
    Console.WriteLine($"Nota {nota} u pranua.");
}

public class NotePavlefshmeException : Exception
{
    public NotePavlefshmeException(string mesazhi) : base(mesazhi)
    {
    }
}
