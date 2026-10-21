const decimal TVSH = 0.18m;
const decimal ZBRITJA = 0.10m;

string produkti = "Monitor 27 inch";
int sasia = 2;
decimal cmimiNjesi = 12500m;

decimal nentotali = sasia * cmimiNjesi;
decimal vleraZbritjes = nentotali * ZBRITJA;
decimal bazaPasZbritjes = nentotali - vleraZbritjes;
decimal vleraTvsh = bazaPasZbritjes * TVSH;
decimal totali = bazaPasZbritjes + vleraTvsh;

Console.WriteLine($"Produkti: {produkti}");
Console.WriteLine($"Nëntotali: {nentotali:F2} den");
Console.WriteLine($"Zbritja:   {vleraZbritjes:F2} den");
Console.WriteLine($"TVSH:      {vleraTvsh:F2} den");
Console.WriteLine($"TOTALI:    {totali:F2} den");
