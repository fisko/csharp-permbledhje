using Microsoft.EntityFrameworkCore;

namespace Libri.Kap15;

public class ShkollaContext : DbContext
{
    public DbSet<Profesor> Profesoret { get; set; }
    public DbSet<Student> Studentet { get; set; }

    protected override void OnConfiguring(
        DbContextOptionsBuilder o)
        => o.UseSqlite("Data Source=shkolla.db");
}
