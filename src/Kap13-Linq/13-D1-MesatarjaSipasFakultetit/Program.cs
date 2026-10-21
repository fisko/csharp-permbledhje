using Libri.Kap13;

List<Student> studentet = new List<Student>
{
    new Student { Emri="Arben", Fakulteti="Informatikë", Nota=8 },
    new Student { Emri="Besa",  Fakulteti="Ekonomik",   Nota=9 },
    new Student { Emri="Drin",  Fakulteti="Informatikë", Nota=6 },
};

var permbledhja = studentet
    .GroupBy(s => s.Fakulteti)
    .Select(g => new {
        Fakulteti = g.Key,
        Mesatarja = g.Average(s => s.Nota) })
    .OrderByDescending(x => x.Mesatarja);

foreach (var rresht in permbledhja)
    Console.WriteLine($"{rresht.Fakulteti}: {rresht.Mesatarja:F2}");
