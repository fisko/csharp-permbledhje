using Libri.Kap15;

using (var db = new ShkollaContext())
{
    Student s = new Student { Emri = "Arben", Nota = 8.5 };
    db.Studentet.Add(s);
    db.SaveChanges();

    Console.WriteLine($"U ruajt studenti me Id = {s.Id}");
}
