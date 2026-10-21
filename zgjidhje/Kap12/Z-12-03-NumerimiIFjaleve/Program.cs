// Z 12.3 — Dictionary për numërimin e fjalëve.
List<string> fjalet = new List<string>
{
    "programim", "klasa", "programim", "objekt", "klasa", "programim"
};

Dictionary<string, int> numerimi = new Dictionary<string, int>();
foreach (string fjala in fjalet)
{
    if (numerimi.ContainsKey(fjala))
        numerimi[fjala]++;
    else
        numerimi[fjala] = 1;
}

foreach (var cifti in numerimi)
    Console.WriteLine($"{cifti.Key}: {cifti.Value} herë");
