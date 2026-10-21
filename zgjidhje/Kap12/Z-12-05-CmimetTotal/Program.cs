// Z 12.5 — Dictionary me çmime dhe totali.
Dictionary<string, double> cmimet = new Dictionary<string, double>
{
    ["Bukë"] = 45,
    ["Qumësht"] = 75,
    ["Vezë"] = 120,
};

double totali = 0;
foreach (var produkti in cmimet)
{
    Console.WriteLine($"{produkti.Key}: {produkti.Value} den.");
    totali += produkti.Value;
}
Console.WriteLine($"Totali: {totali} den.");
