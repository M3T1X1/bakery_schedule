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
        var projectPath = Directory.GetParent(AppContext.BaseDirectory)!.Parent!.Parent!.Parent!.FullName;

        var dbPath = Path.Combine(projectPath, "baza", "baza.db");

        optionsBuilder.UseSqlite($"Data Source={dbPath}");
        MessageBox.Show($"U¿ywana baza: {dbPath}");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Pracownik>()
            .HasOne(p => p.Adres)
            .WithMany(a => a.Pracownicy)
            .HasForeignKey(p => p.ID_adresu)
            .OnDelete(DeleteBehavior.SetNull);

        modelBuilder.Entity<Pracownik>()
            .HasOne(p => p.Stanowisko)
            .WithMany(s => s.Pracownicy)
            .HasForeignKey(p => p.ID_stanowiska)
            .OnDelete(DeleteBehavior.SetNull);

        modelBuilder.Entity<Pracownik>()
            .HasOne(p => p.Produkt)
            .WithMany() 
            .HasForeignKey(p => p.ID_produktu)
            .OnDelete(DeleteBehavior.SetNull);

        modelBuilder.Entity<Stanowisko>()
            .HasOne(s => s.Produkt)
            .WithMany(p => p.Stanowiska)
            .HasForeignKey(s => s.ID_produktu)
            .OnDelete(DeleteBehavior.SetNull);

        modelBuilder.Entity<Zmiana>()
            .HasOne(z => z.Pracownik)
            .WithMany(p => p.Zmiany)
            .HasForeignKey(z => z.ID_pracownika)
            .OnDelete(DeleteBehavior.SetNull);


    }
}
