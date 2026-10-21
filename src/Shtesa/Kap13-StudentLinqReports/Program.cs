var studentet = new List<Student>
{
    new("Ana", "Informatikë", 9.4),
    new("Blerim", "Informatikë", 8.1),
    new("Drita", "Ekonomi", 9.0),
    new("Arben", "Ekonomi", 7.2)
};

var meTeMiret = studentet
    .Where(s => s.Mesatarja >= 8.5)
    .OrderByDescending(s => s.Mesatarja)
    .Select(s => $"{s.Emri} - {s.Mesatarja:F2}");

foreach (var r in meTeMiret)
    Console.WriteLine(r);

var sipasFakultetit = studentet
    .GroupBy(s => s.Fakulteti)
    .Select(g => new { Fakulteti = g.Key, Mesatarja = g.Average(s => s.Mesatarja) });

foreach (var g in sipasFakultetit)
    Console.WriteLine($"{g.Fakulteti}: {g.Mesatarja:F2}");

record Student(string Emri, string Fakulteti, double Mesatarja);
