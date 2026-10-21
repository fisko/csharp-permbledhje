// Zgjidhjet e detyrave 15.1 - 15.7 në një projekt të vetëm me meny.
// Para nisjes së parë: dotnet ef migrations add Fillimi
using Microsoft.EntityFrameworkCore;

using var db = new UniversitetiContext();
db.Database.Migrate();
MbushNeseBosh(db);

while (true)
{
    Console.WriteLine("\n1) Shto lëndë (Z 15.1)");
    Console.WriteLine("2) Studentët sipas notës (Z 15.2)");
    Console.WriteLine("3) Numëro kaluesit (Z 15.3)");
    Console.WriteLine("4) Përditëso notë sipas emrit (Z 15.4)");
    Console.WriteLine("5) Fshi studentët me notë nën 5 (Z 15.5)");
    Console.WriteLine("6) Profesori me studentët e tij (Z 15.6)");
    Console.WriteLine("7) Nota mesatare nga baza (Z 15.7)");
    Console.WriteLine("0) Dalje");
    Console.Write("Zgjedhja: ");
    string z = Console.ReadLine() ?? "";
    if (z == "0") break;

    switch (z)
    {
        case "1": Z1_ShtoLende(db); break;
        case "2": Z2_SipasNotes(db); break;
        case "3": Z3_NumeroKaluesit(db); break;
        case "4": Z4_PerditesoNoten(db); break;
        case "5": Z5_FshiNgelesit(db); break;
        case "6": Z6_ProfesoriMeStudentet(db); break;
        case "7": Z7_NotaMesatare(db); break;
    }
}

// Z 15.1 — Shto entitetin Lenda dhe ruaj disa lëndë.
static void Z1_ShtoLende(UniversitetiContext db)
{
    db.Lendet.Add(new Lenda { Emri = "Programim në C#", EKTS = 6 });
    db.Lendet.Add(new Lenda { Emri = "Bazat e të dhënave", EKTS = 6 });
    db.SaveChanges();
    foreach (Lenda l in db.Lendet)
        Console.WriteLine($"[{l.Id}] {l.Emri} ({l.EKTS} EKTS)");
}

// Z 15.2 — Të gjithë studentët të renditur sipas notës.
static void Z2_SipasNotes(UniversitetiContext db)
{
    var teRenditur = db.Studentet.OrderByDescending(s => s.Nota);
    foreach (Studenti s in teRenditur)
        Console.WriteLine($"{s.Emri}: {s.Nota}");
}

// Z 15.3 — Sa kanë kaluar, me Count me kusht.
static void Z3_NumeroKaluesit(UniversitetiContext db)
{
    int kalues = db.Studentet.Count(s => s.Nota > 5);
    Console.WriteLine($"Kanë kaluar: {kalues}");
}

// Z 15.4 — Përditëso notën e një studenti sipas emrit.
static void Z4_PerditesoNoten(UniversitetiContext db)
{
    Console.Write("Emri i studentit: ");
    string emri = Console.ReadLine() ?? "";

    Studenti? s = db.Studentet.FirstOrDefault(x => x.Emri == emri);
    if (s == null)
    {
        Console.WriteLine("Nuk u gjet.");
        return;
    }
    Console.Write("Nota e re: ");
    s.Nota = double.Parse(Console.ReadLine() ?? "0");
    db.SaveChanges();
    Console.WriteLine($"U përditësua: {s.Emri} -> {s.Nota}");
}

// Z 15.5 — Fshi studentët me notë nën 5.
static void Z5_FshiNgelesit(UniversitetiContext db)
{
    var ngelesit = db.Studentet.Where(s => s.Nota < 5).ToList();
    db.Studentet.RemoveRange(ngelesit);
    db.SaveChanges();
    Console.WriteLine($"U fshinë {ngelesit.Count} studentë.");
}

// Z 15.6 — Një profesor ka shumë studentë (lidhja 1:N me Include).
static void Z6_ProfesoriMeStudentet(UniversitetiContext db)
{
    var profesoret = db.Profesoret.Include(p => p.Studentet);
    foreach (Profesor p in profesoret)
    {
        Console.WriteLine($"{p.Emri}:");
        foreach (Studenti s in p.Studentet)
            Console.WriteLine($"  - {s.Emri} ({s.Nota})");
    }
}

// Z 15.7 — Nota mesatare direkt nga baza me Average.
static void Z7_NotaMesatare(UniversitetiContext db)
{
    if (!db.Studentet.Any())
    {
        Console.WriteLine("S'ka studentë në bazë.");
        return;
    }
    double mesatarja = db.Studentet.Average(s => s.Nota);
    Console.WriteLine($"Nota mesatare: {mesatarja:F2}");
}

static void MbushNeseBosh(UniversitetiContext db)
{
    if (db.Studentet.Any()) return;
    Profesor prof = new Profesor { Emri = "doc. dr. Vlora" };
    db.Profesoret.Add(prof);
    db.Studentet.AddRange(
        new Studenti { Emri = "Arben", Nota = 8.5, Profesori = prof },
        new Studenti { Emri = "Besa",  Nota = 4.0, Profesori = prof },
        new Studenti { Emri = "Drin",  Nota = 6.8, Profesori = prof });
    db.SaveChanges();
}

public class Studenti
{
    public int Id { get; set; }
    public string Emri { get; set; } = "";
    public double Nota { get; set; }

    public int? ProfesoriId { get; set; }        // çelësi i huaj (Z 15.6)
    public Profesor? Profesori { get; set; }
}

public class Lenda
{
    public int Id { get; set; }
    public string Emri { get; set; } = "";
    public int EKTS { get; set; }
}

public class Profesor
{
    public int Id { get; set; }
    public string Emri { get; set; } = "";
    public List<Studenti> Studentet { get; set; } = new();
}

public class UniversitetiContext : DbContext
{
    public DbSet<Studenti> Studentet { get; set; }
    public DbSet<Lenda> Lendet { get; set; }
    public DbSet<Profesor> Profesoret { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlite("Data Source=universiteti.db");
    }
}
