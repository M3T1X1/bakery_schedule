using Bakery_Schedule.modele;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery_Schedule
{
    public class BakeryContext : DbContext
    {
        public BakeryContext(DbContextOptions<BakeryContext> options) : base(options)
        {
        }

        public DbSet<Adres> Adres { get; set; }
        public DbSet<Pracownik> Pracownik { get; set; }
        public DbSet<Stanowisko> Stanowisko { get; set; }
        public DbSet<Produkt> Produkt { get; set; }
        public DbSet<Zmiana> Zmiana { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Adres>().ToTable("Adres");
            modelBuilder.Entity<Pracownik>().ToTable("Pracownik");
            modelBuilder.Entity<Stanowisko>().ToTable("Stanowisko");
            modelBuilder.Entity<Produkt>().ToTable("Produkt");
            modelBuilder.Entity<Zmiana>().ToTable("Zmiana");

            base.OnModelCreating(modelBuilder);
        }
    }
}