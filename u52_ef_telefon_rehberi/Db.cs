using Microsoft.EntityFrameworkCore;

namespace u52_ef_telefon_rehberi;

public class Db : DbContext // inheritance
{
    public DbSet<Kisi> Kisiler { get; set; } //kisiler tablosu

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=D:\\rehber.db");
    }
}
