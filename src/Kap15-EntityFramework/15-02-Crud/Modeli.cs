using Microsoft.EntityFrameworkCore;

namespace Libri.Kap15;

public class Student
{
    public int Id { get; set; }        // çelësi primar
    public string Emri { get; set; } = "";
    public double Nota { get; set; }
}

public class ShkollaContext : DbContext
{
    public DbSet<Student> Studentet { get; set; }

    protected override void OnConfiguring(
        DbContextOptionsBuilder options)
    {
        options.UseSqlite("Data Source=shkolla.db");
    }
}
