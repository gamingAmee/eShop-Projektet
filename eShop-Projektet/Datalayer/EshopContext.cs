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
        //public EshopContext()
            
        //{ }
        public EshopContext(DbContextOptions<EshopContext> options)
            : base(options)
        { }
        public DbSet<Kunde> Kunder { get; set; }
        public DbSet<Produkt> Produkter { get; set; }
        public DbSet<kategori> kategorier { get; set; }
        public DbSet<Producent> Producenter { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = EshopDb; Trusted_Connection = True; ")
        //        .EnableSensitiveDataLogging(true)
        //        .UseLoggerFactory(new ServiceCollection()
        //        .AddLogging(builder => builder.AddConsole()
        //            .AddFilter(DbLoggerCategory.Database.Command.Name, LogLevel.Information))
        //            .BuildServiceProvider().GetService<ILoggerFactory>());
        //    }
            
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //ManyToMany
            modelBuilder.Entity<OrdreProdukt>()
            .HasKey(b => new { b.OrdreId, b.ProduktId });

            modelBuilder.Entity<Producent>().HasData(
                 new Producent { Navn = "ASUS", ProducentId = 1 },
                 new Producent { Navn = "Acer", ProducentId = 2 },
                 new Producent { Navn = "Apple", ProducentId = 3 },
                 new Producent { Navn = "Lenovo", ProducentId = 4 },
                 new Producent { Navn = "DELL", ProducentId = 5 },
                 new Producent { Navn = "HP", ProducentId = 6 },
                 new Producent { Navn = "MSI", ProducentId = 7 },
                 new Producent { Navn = "Samsung", ProducentId = 8 },
                 new Producent { Navn = "LG", ProducentId = 9 },
                 new Producent { Navn = "Razer", ProducentId = 10 },
                 new Producent { Navn = "Steelseries", ProducentId = 11 }



                 );



            modelBuilder.Entity<kategori>().HasData(
                new kategori { Navn = "Grafikkort", kategoriId = 1 },
                new kategori { Navn = "Bærbar", kategoriId = 2 },
                new kategori { Navn = "Mobil", kategoriId = 3 },
                new kategori { Navn = "TV", kategoriId = 4 },
                new kategori { Navn = "Tastatur", kategoriId = 5 },
                new kategori { Navn = "Mus", kategoriId = 6 }
                );



            modelBuilder.Entity<Produkt>().HasData(
                new Produkt { Navn = "ASUS GeForce RTX 2080 SUPER ROG Strix Advanced", KategoriId = 1, ProducentId = 1, Pris = 7319, ProduktId = 1 },
                new Produkt { Navn = "MSI GeForce RTX 2080 SUPER SEA HAWK EK X", KategoriId = 1, ProducentId = 7, Pris = 6999, ProduktId = 2 },
                new Produkt { Navn = "ASUS Radeon RX 5500 XT ROG Strix OC 8GB", KategoriId = 1, ProducentId = 1, Pris = 1999, ProduktId = 3 },
                new Produkt { Navn = "ASUS GeForce GTX 1660 SUPER ROG Strix OC", KategoriId = 1, ProducentId = 1, Pris = 2229, ProduktId = 4 },
                new Produkt { Navn = "MSI GE75 Raider 17,3 FHD 240 Hz", KategoriId = 2, ProducentId = 7, Pris = 19990, ProduktId = 5 },
                new Produkt { Navn = "Acer Nitro 5 15,6 FHD 120 Hz", KategoriId = 2, ProducentId = 2, Pris = 5290, ProduktId = 6 },
                new Produkt { Navn = "MSI Prestige 15 15,6 Full HD", KategoriId = 2, ProducentId = 7, Pris = 11995, ProduktId = 7 },
                new Produkt { Navn = "ASUS ZenBook Pro Duo 15,6 UHD / 4K OLED Touch", KategoriId = 2, ProducentId = 1, Pris = 21490, ProduktId = 8 },
                new Produkt { Navn = "Acer Chromebook R13 CB5-312T 13.3 FHD", KategoriId = 2, ProducentId = 2, Pris = 2495, ProduktId = 9 },
                new Produkt { Navn = "Apple MacBook Pro laptop 16 1TB MVV med touch bar", KategoriId = 2, ProducentId = 3, Pris = 21999, ProduktId = 10 },
                new Produkt { Navn = "Lenovo ThinkPad P53 15,6 Workstation Pro Full HD", KategoriId = 2, ProducentId = 4, Pris = 27990, ProduktId = 11 },
                new Produkt { Navn = "Dell Vostro 3590 15,6 Full HD", KategoriId = 2, ProducentId = 5, Pris = 5290, ProduktId = 12 },
                new Produkt { Navn = "Dell XPS 13 7390 13,3 UHD / 4K Touch", KategoriId = 2, ProducentId = 5, Pris = 13690, ProduktId = 13 },
                new Produkt { Navn = "HP Spectre x360 15-df1012no 15,6 UHD OLED touch", KategoriId = 2, ProducentId = 6, Pris = 17495, ProduktId = 14 },
                new Produkt { Navn = "Razer Blade Pro 17,3 UHD / 4K touch 120 Hz", KategoriId = 2, ProducentId = 10, Pris = 33495, ProduktId = 15 },
                new Produkt { Navn = "Samsung Galaxy S20 Ultra 5G 128GB Grå", KategoriId = 3, ProducentId = 8, Pris = 10499, ProduktId = 16 },
                new Produkt { Navn = "Samsung Galaxy A51 128GB Sort", KategoriId = 3, ProducentId = 8, Pris = 2789, ProduktId = 17 },
                new Produkt { Navn = "iPhone 11 Pro Max 64 GB Grå", KategoriId = 3, ProducentId = 3, Pris = 9649, ProduktId = 18 },
                new Produkt { Navn = "Apple iPhone SE 64GB Sort", KategoriId = 3, ProducentId = 3, Pris = 3699, ProduktId = 19 },
                new Produkt { Navn = "Samsung 75 QLED Smart TV QE75Q60R", KategoriId = 4, ProducentId = 8, Pris = 16990, ProduktId = 20 },
                new Produkt { Navn = "Samsung 75 QLED Smart TV QE75Q90R", KategoriId = 4, ProducentId = 8, Pris = 39990, ProduktId = 21 },
                new Produkt { Navn = "LG 55 UHD OLED Smart TV OLED55C9", KategoriId = 4, ProducentId = 9, Pris = 9990, ProduktId = 22 },
                new Produkt { Navn = "LG 48 OLED TV OLED48CX6", KategoriId = 4, ProducentId = 9, Pris = 11999, ProduktId = 23 },
                new Produkt { Navn = "Razer BlackWidow Elite Gaming Tastatur", KategoriId = 5, ProducentId = 10, Pris = 1399, ProduktId = 24 },
                new Produkt { Navn = "ASUS ROG Strix Scope Gaming Tastatur", KategoriId = 5, ProducentId = 1, Pris = 1099, ProduktId = 25 },
                new Produkt { Navn = "SteelSeries Apex Pro Gaming Tastatur", KategoriId = 5, ProducentId = 11, Pris = 1599, ProduktId = 26 },
                new Produkt { Navn = "Razer Basilisk Ultimate Trådløs Gaming Mus", KategoriId = 6, ProducentId = 10, Pris = 1349, ProduktId = 27 },
                new Produkt { Navn = "ASUS ROG Chakram Trådløs Gaming Mus", KategoriId = 6, ProducentId = 1, Pris = 1079, ProduktId = 28 },
                new Produkt { Navn = "Steelseries Rival 710 Gaming Mus", KategoriId = 6, ProducentId = 11, Pris = 799, ProduktId = 29 }
                );



            modelBuilder.Entity<Kunde>().HasData(
                new Kunde { Navn = "Niels Schultz", Adresse = "HAHA", Email = "niel862b@elevcampus.dk", Kodeord = "Qwerty123", KundeId = 1},
                new Kunde { Navn = "FakeNiels FakeSchultz", Adresse = "FakeHAHA", Email = "Fakeniel862b@elevcampus.dk", Kodeord = "Qwerty123", KundeId = 2}
                );



            modelBuilder.Entity<ProduktBillede>().HasData(
                new ProduktBillede { ProduktId = 23, ProduktBilledeId = 1, Billede = "https://www.elgiganten.dk/image/dv_web_D180001002410624/153758/lg-48-cx-4k-oled-tv-oled48cx.jpg?$fullsize$" },
                new ProduktBillede { ProduktId = 23, ProduktBilledeId = 2, Billede = "https://www.elgiganten.dk/image/dv_web_D180001002410670/153758/lg-48-cx-4k-oled-tv-oled48cx.jpg?$fullsize$" },
                new ProduktBillede { ProduktId = 23, ProduktBilledeId = 3, Billede = "https://www.elgiganten.dk/image/dv_web_D180001002410669/153758/lg-48-cx-4k-oled-tv-oled48cx.jpg?$prod_all4one$" },
                new ProduktBillede { ProduktId = 1, ProduktBilledeId = 4, Billede = "https://www.komplett.dk/img/p/1200/1135677.jpg" },
                new ProduktBillede { ProduktId = 2, ProduktBilledeId = 5, Billede = "https://www.komplett.dk/img/p/1200/1139034.jpg" },
                new ProduktBillede { ProduktId = 3, ProduktBilledeId = 6, Billede = "https://www.komplett.dk/img/p/1200/1149212.jpg" },
                new ProduktBillede { ProduktId = 4, ProduktBilledeId = 7, Billede = "https://www.komplett.dk/img/p/1200/1148757.jpg" },
                new ProduktBillede { ProduktId = 5, ProduktBilledeId = 8, Billede = "https://www.komplett.dk/img/p/1200/1153467.jpg" },
                new ProduktBillede { ProduktId = 6, ProduktBilledeId = 9, Billede = "https://www.komplett.dk/img/p/1200/1156443.jpg" },
                new ProduktBillede { ProduktId = 7, ProduktBilledeId = 10, Billede = "https://www.komplett.dk/img/p/1200/1135667.jpg" },
                new ProduktBillede { ProduktId = 8, ProduktBilledeId = 11, Billede = "https://www.komplett.dk/img/p/1200/1132405.jpg" },
                new ProduktBillede { ProduktId = 9, ProduktBilledeId = 12, Billede = "https://www.komplett.dk/img/p/1200/898464.jpg" },
                new ProduktBillede { ProduktId = 10, ProduktBilledeId = 13, Billede = "https://sg-next.imgix.net/medias/sys_master/root/hbd/h3a/13735092912158/MacBook-Pro-16-in-Pure-Front-Space-Gray-SCREEN-result.jpg?w=350&h=350&auto=format&fm=jpg" },
                new ProduktBillede { ProduktId = 11, ProduktBilledeId = 14, Billede = "https://www.komplett.dk/img/p/1000/1137677.jpg" },
                new ProduktBillede { ProduktId = 12, ProduktBilledeId = 15, Billede = "https://www.komplett.dk/img/p/1200/1150472.jpg" },
                new ProduktBillede { ProduktId = 13, ProduktBilledeId = 16, Billede = "https://www.komplett.dk/img/p/1200/1146637.jpg" },
                new ProduktBillede { ProduktId = 14, ProduktBilledeId = 17, Billede = "https://www.komplett.dk/img/p/1200/1132707.jpg" },
                new ProduktBillede { ProduktId = 15, ProduktBilledeId = 18, Billede = "https://www.komplett.dk/img/p/1200/1153777.jpg" },
                new ProduktBillede { ProduktId = 16, ProduktBilledeId = 19, Billede = "https://www.komplett.dk/img/p/1200/1151019.jpg" },
                new ProduktBillede { ProduktId = 17, ProduktBilledeId = 20, Billede = "https://www.komplett.dk/img/p/1200/1149587.jpg" },
                new ProduktBillede { ProduktId = 18, ProduktBilledeId = 21, Billede = "https://www.komplett.dk/img/p/1200/1138869.jpg" },
                new ProduktBillede { ProduktId = 19, ProduktBilledeId = 22, Billede = "https://www.komplett.dk/img/p/1200/1157749.jpg" },
                new ProduktBillede { ProduktId = 20, ProduktBilledeId = 23, Billede = "https://www.komplett.dk/img/p/1080/1124639.jpg" },
                new ProduktBillede { ProduktId = 21, ProduktBilledeId = 24, Billede = "https://www.komplett.dk/img/p/1080/1124646.jpg" },
                new ProduktBillede { ProduktId = 22, ProduktBilledeId = 25, Billede = "https://www.komplett.dk/img/p/1200/1130516.jpg" },
                new ProduktBillede { ProduktId = 23, ProduktBilledeId = 26, Billede = "https://www.elgiganten.dk/image/dv_web_D180001002410624/153758/lg-48-cx-4k-oled-tv-oled48cx.jpg?$fullsize$" },
                new ProduktBillede { ProduktId = 24, ProduktBilledeId = 27, Billede = "https://www.elgiganten.dk/image/dv_web_D18000100296972/12851/razer-blackwidow-elite-gaming-tastatur.jpg?$fullsize$" },
                new ProduktBillede { ProduktId = 25, ProduktBilledeId = 28, Billede = "https://www.komplett.dk/img/p/1200/1144808.jpg" },
                new ProduktBillede { ProduktId = 26, ProduktBilledeId = 29, Billede = "https://www.komplett.dk/img/p/1200/1127733.jpg" },
                new ProduktBillede { ProduktId = 27, ProduktBilledeId = 30, Billede = "https://www.komplett.dk/img/p/1200/1146944.jpg" },
                new ProduktBillede { ProduktId = 28, ProduktBilledeId = 31, Billede = "https://www.komplett.dk/img/p/1200/1150475.jpg" },
                new ProduktBillede { ProduktId = 29, ProduktBilledeId = 32, Billede = "https://www.komplett.dk/img/p/1200/1041072.jpg" }
                );

        }
    }
}
