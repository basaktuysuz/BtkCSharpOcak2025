using System;
using Microsoft.EntityFrameworkCore;
using Web_App.Models;
namespace Web_App.Database;


public class Db : DbContext // inheritance
{
    public DbSet<Kisi> Kisiler { get; set; } //kisiler tablosu

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=D:\\rehber.db");
    }
}
