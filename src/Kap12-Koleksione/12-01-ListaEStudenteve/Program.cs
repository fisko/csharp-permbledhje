using Libri.Kap12;

List<Student> studentet = new List<Student>();
studentet.Add(new Student { Emri = "Arben", Nota = 8.5 });
studentet.Add(new Student { Emri = "Besa",  Nota = 9.2 });
studentet.Add(new Student { Emri = "Drin",  Nota = 6.8 });

Console.WriteLine($"Gjithsej: {studentet.Count}");
foreach (Student s in studentet)
    Console.WriteLine(s);
