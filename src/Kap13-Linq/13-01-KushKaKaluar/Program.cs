using Libri.Kap13;

List<Student> studentet = new List<Student>
{
    new Student { Emri = "Arben", Nota = 8.5 },
    new Student { Emri = "Besa",  Nota = 4.0 },
    new Student { Emri = "Drin",  Nota = 6.8 },
};

var kaluesit = from s in studentet
               where s.Nota > 5
               select s.Emri;

foreach (string emri in kaluesit)
    Console.WriteLine(emri);
