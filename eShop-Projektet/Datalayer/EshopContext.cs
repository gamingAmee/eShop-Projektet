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
        public DbSet<Kunde> Kunder { get; set; }
        public DbSet<Produkt> Produkter { get; set; }
        public DbSet<Ordre> Ordrer { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = EshopDb; Trusted_Connection = True; ")
            .EnableSensitiveDataLogging(true)
            .UseLoggerFactory(new ServiceCollection()
            .AddLogging(builder => builder.AddConsole()
                .AddFilter(DbLoggerCategory.Database.Command.Name, LogLevel.Information))
                .BuildServiceProvider().GetService<ILoggerFactory>());
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //ManyToMany
            modelBuilder.Entity<OrdreProdukt>()
            .HasKey(b => new { b.OrdreId, b.ProduktId });

        }
    }
}
