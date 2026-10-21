const double TVSH = 0.18;

string produkti = "Tastierë";
int sasia = 3;
decimal cmimiNjesi = 1200m;

decimal nentotali = sasia * cmimiNjesi;
decimal vleraTVSH = nentotali * (decimal)TVSH;
decimal totali = nentotali + vleraTVSH;

Console.WriteLine($"Produkti:   {produkti}");
Console.WriteLine($"Sasia:      {sasia}");
Console.WriteLine($"Nëntotali:  {nentotali:F2}");
Console.WriteLine($"TVSH (18%): {vleraTVSH:F2}");
Console.WriteLine($"TOTALI:     {totali:F2}");
