using Libri.Kap12;

List<Student> studentet = new List<Student>
{
    new Student { Emri="Arben", Fakulteti="Informatikë" },
    new Student { Emri="Besa",  Fakulteti="Ekonomik" },
    new Student { Emri="Drin",  Fakulteti="Informatikë" },
};

var sipasFakultetit =
    new Dictionary<string, List<Student>>();

foreach (Student s in studentet)
{
    if (!sipasFakultetit.ContainsKey(s.Fakulteti))
        sipasFakultetit[s.Fakulteti] = new List<Student>();
    sipasFakultetit[s.Fakulteti].Add(s);
}

foreach (var cift in sipasFakultetit)
    Console.WriteLine($"{cift.Key}: {cift.Value.Count} student");
