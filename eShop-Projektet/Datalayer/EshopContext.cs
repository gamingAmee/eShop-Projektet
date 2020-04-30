using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Datalayer.Entities;

namespace Datalayer
{
    public class EshopContext : DbContext
    {
        public EshopContext()
            
        { }
        public EshopContext(DbContextOptions<EshopContext> options)
            : base(options)
        { }
        public DbSet<Kunde> Kunder { get; set; }
        public DbSet<Produkt> Produkter { get; set; }
        public DbSet<kategori> kategorier { get; set; }
        public DbSet<Producent> Producenter { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = EshopDb; Trusted_Connection = True; ")
                .EnableSensitiveDataLogging(true)
                .UseLoggerFactory(new ServiceCollection()
                .AddLogging(builder => builder.AddConsole()
                    .AddFilter(DbLoggerCategory.Database.Command.Name, LogLevel.Information))
                    .BuildServiceProvider().GetService<ILoggerFactory>());
            }
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //ManyToMany
            modelBuilder.Entity<OrdreProdukt>()
            .HasKey(b => new { b.OrdreId, b.ProduktId });

            modelBuilder.Entity<kategori>().HasData(
               new kategori { kategoriId = 1, Navn = "Computer" },
               new kategori { kategoriId = 2, Navn = "konsoller" },
               new kategori { kategoriId = 3, Navn = "Mobil" }
               );

            modelBuilder.Entity<Producent>().HasData(
               new Producent { ProducentId = 1, Navn = "Asus" },
               new Producent { ProducentId = 2, Navn = "Nintendo" },
               new Producent { ProducentId = 3, Navn = "Apple" }
               );

            modelBuilder.Entity<Produkt>().HasData(
               new Produkt { ProduktId = 1, Navn = "ASUS ZenBook Pro Duo", Pris = 21490, KategoriId = 1, ProducentId = 1 },
               new Produkt { ProduktId = 2, Navn = "Nintendo Switch 2019", Pris = 2999, KategoriId = 2, ProducentId = 2 },
               new Produkt { ProduktId = 3, Navn = "iPhone 11 Pro Max", Pris = 9649, KategoriId = 3, ProducentId = 3 }
               );

        }
    }
}
