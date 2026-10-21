StatusPagese status = StatusPagese.Vonuar;
Console.WriteLine(Pershkrimi(status));

static string Pershkrimi(StatusPagese status)
{
    return status switch
    {
        StatusPagese.PaPaguar => "Pagesa ende nuk është kryer.",
        StatusPagese.Paguar => "Pagesa është kryer me sukses.",
        StatusPagese.Vonuar => "Pagesa është vonuar.",
        StatusPagese.Anuluar => "Pagesa është anuluar.",
        _ => "Status i panjohur."
    };
}

enum StatusPagese
{
    PaPaguar,
    Paguar,
    Vonuar,
    Anuluar
}
