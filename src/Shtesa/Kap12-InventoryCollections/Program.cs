Dictionary<string, int> stoku = new();

void ShtoOsePerditeso(string kodi, int sasia)
{
    if (stoku.ContainsKey(kodi))
        stoku[kodi] += sasia;
    else
        stoku[kodi] = sasia;
}

ShtoOsePerditeso("P001", 10);
ShtoOsePerditeso("P002", 3);
ShtoOsePerditeso("P001", 5);

foreach (var item in stoku)
{
    if (item.Value < 5)
        Console.WriteLine($"Stok i ulët: {item.Key} = {item.Value}");
}
