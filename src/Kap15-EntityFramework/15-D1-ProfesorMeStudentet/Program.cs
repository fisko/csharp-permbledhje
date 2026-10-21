using Libri.Kap15;
using Microsoft.EntityFrameworkCore;

using var db = new ShkollaContext();

var prof = new Profesor { Emri = "Dr. Leka" };
prof.Studentet.Add(new Student { Emri = "Arben" });
prof.Studentet.Add(new Student { Emri = "Besa" });
db.Profesoret.Add(prof);
db.SaveChanges();

// Lexo profesorin bashkë me studentët e tij
var p = db.Profesoret
    .Include(x => x.Studentet)
    .First();

Console.WriteLine($"{p.Emri}: {p.Studentet.Count} studentë");
