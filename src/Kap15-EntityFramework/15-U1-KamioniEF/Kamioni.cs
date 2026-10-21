using Microsoft.EntityFrameworkCore;

public class Kamioni
{
    public int Id { get; set; }        // çelësi primar
    public string Brendi { get; set; } = "";
    public string Modeli { get; set; } = "";
    public int Viti { get; set; }
    public int KF { get; set; }

    public override string ToString()
        => $"[{Id}] {Brendi} {Modeli}, {Viti}, {KF} KF";
}

public class KamionetContext : DbContext
{
    public DbSet<Kamioni> Kamionet { get; set; }

    protected override void OnConfiguring(
        DbContextOptionsBuilder options)
    {
        options.UseSqlite("Data Source=kamionet.db");
    }
}
