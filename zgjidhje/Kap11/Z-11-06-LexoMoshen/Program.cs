// Z 11.6 — LexoMoshen: përsërit derisa hyrja të jetë e vlefshme.
int mosha = LexoMoshen();
Console.WriteLine($"Mosha u pranua: {mosha}");

static int LexoMoshen()
{
    while (true)
    {
        Console.Write("Shkruaj moshën: ");
        try
        {
            int mosha = int.Parse(Console.ReadLine() ?? "");
            if (mosha < 0 || mosha > 120)
            {
                Console.WriteLine("Moshë jorealiste, provo sërish.");
                continue;
            }
            return mosha;
        }
        catch (FormatException)
        {
            Console.WriteLine("Kjo s'ishte numër, provo sërish.");
        }
    }
}
