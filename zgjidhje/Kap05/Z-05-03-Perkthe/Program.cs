// Z 5.3 — Metoda Perkthe: nota në vlerësim me fjalë.
Console.WriteLine(Perkthe(10));
Console.WriteLine(Perkthe(6));
Console.WriteLine(Perkthe(4));

static string Perkthe(int nota)
{
    return nota switch
    {
        10 => "Shkëlqyeshëm",
        9  => "Shumë mirë",
        8 or 7 => "Mirë",
        6  => "Mjaftueshëm",
        _  => "Pamjaftueshëm"
    };
}
