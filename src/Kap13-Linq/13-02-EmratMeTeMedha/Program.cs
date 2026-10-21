using Libri.Kap13;

List<Student> studentet = new List<Student>
{
    new Student { Emri = "Arben", Nota = 8.5 },
    new Student { Emri = "Besa",  Nota = 4.0 },
    new Student { Emri = "Drin",  Nota = 6.8 },
};

var emrat = from s in studentet
            select s.Emri.ToUpper();

foreach (string e in emrat)
    Console.WriteLine(e);
