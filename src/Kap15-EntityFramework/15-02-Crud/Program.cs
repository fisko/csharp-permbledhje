using Libri.Kap15;

using var db = new ShkollaContext();

// Krijim
db.Studentet.Add(new Student { Emri = "Besa", Nota = 9.2 });
db.Studentet.Add(new Student { Emri = "Drin", Nota = 4.0 });
db.SaveChanges();

// Lexim
var kaluesit = db.Studentet
    .Where(s => s.Nota > 5)
    .OrderByDescending(s => s.Nota)
    .ToList();

Console.WriteLine("Kaluesit:");
foreach (Student s in kaluesit)
    Console.WriteLine($"  {s.Emri} ({s.Nota})");

// Përditësim
Student drin = db.Studentet.First(s => s.Emri == "Drin");
drin.Nota = 6.0;
db.SaveChanges();

// Fshirje
db.Studentet.Remove(drin);
db.SaveChanges();
