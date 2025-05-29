using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

using Bakery_Schedule.modele;

public class AppDbContext : DbContext
{
    public DbSet<Produkt> Produkt { get; set; }
    public DbSet<Stanowisko> Stanowisko{ get; set; }
    public DbSet<Adres> Adres { get; set; }
    public DbSet<Pracownik> Pracownik { get; set; }
    public DbSet<Zmiana> Zmiana { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //var basePath = AppContext.BaseDirectory;
        //var dbPath = Path.Combine(basePath, "baza", "baza.db"); 
        //optionsBuilder.UseSqlite($"Data Source={dbPath}");

        optionsBuilder.UseSqlite("Data Source=C:\\Users\\dusza\\Desktop\\bakery_schedule\\baza\\baza.db");
        //optionsBuilder.UseSqlite("Data Source=Desktop\\bakery_schedule\\baza\\baza.db");

        //MessageBox.Show(($"DB PATH: {dbPath}"));
        //MessageBox.Show(($"Plik istnieje: {File.Exists(dbPath)}"));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Adres>().ToTable("Adres");
        modelBuilder.Entity<Pracownik>().ToTable("Pracownik");
        modelBuilder.Entity<Stanowisko>().ToTable("Stanowisko");
        modelBuilder.Entity<Produkt>().ToTable("Produkt");
        modelBuilder.Entity<Zmiana>().ToTable("Zmiana");

        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Zmiana>()
        .HasOne(z => z.Pracownik)
        .WithMany(p => p.Zmiany)    // zak³adam, ¿e masz kolekcjê Zmiany w Pracownik
        .HasForeignKey(z => z.PracownikID_pracownika)
        .OnDelete(DeleteBehavior.Restrict);

        base.OnModelCreating(modelBuilder);
    }
}
