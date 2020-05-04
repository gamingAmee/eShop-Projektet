﻿// <auto-generated />
using System;
using Datalayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Datalayer.Migrations
{
    [DbContext(typeof(EshopContext))]
    partial class EshopContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Datalayer.Entities.Kunde", b =>
                {
                    b.Property<int>("KundeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kodeord")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Navn")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KundeId");

                    b.ToTable("Kunder");
                });

            modelBuilder.Entity("Datalayer.Entities.Ordre", b =>
                {
                    b.Property<int>("OrdreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("KoebsDato")
                        .HasColumnType("datetime2");

                    b.Property<int>("KundeId")
                        .HasColumnType("int");

                    b.HasKey("OrdreId");

                    b.HasIndex("KundeId");

                    b.ToTable("Ordre");
                });

            modelBuilder.Entity("Datalayer.Entities.OrdreProdukt", b =>
                {
                    b.Property<int>("OrdreId")
                        .HasColumnType("int");

                    b.Property<int>("ProduktId")
                        .HasColumnType("int");

                    b.Property<int>("Styk")
                        .HasColumnType("int");

                    b.HasKey("OrdreId", "ProduktId");

                    b.HasIndex("ProduktId");

                    b.ToTable("OrdreProdukt");
                });

            modelBuilder.Entity("Datalayer.Entities.Producent", b =>
                {
                    b.Property<int>("ProducentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Navn")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProducentId");

                    b.ToTable("Producenter");

                    b.HasData(
                        new
                        {
                            ProducentId = 1,
                            Navn = "Asus"
                        },
                        new
                        {
                            ProducentId = 2,
                            Navn = "Nintendo"
                        },
                        new
                        {
                            ProducentId = 3,
                            Navn = "Apple"
                        },
                        new
                        {
                            ProducentId = 4,
                            Navn = "MSI"
                        });
                });

            modelBuilder.Entity("Datalayer.Entities.Produkt", b =>
                {
                    b.Property<int>("ProduktId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("KategoriId")
                        .HasColumnType("int");

                    b.Property<string>("Navn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Pris")
                        .HasColumnType("decimal(8, 2)");

                    b.Property<int?>("ProducentId")
                        .HasColumnType("int");

                    b.HasKey("ProduktId");

                    b.HasIndex("KategoriId");

                    b.HasIndex("ProducentId");

                    b.ToTable("Produkter");

                    b.HasData(
                        new
                        {
                            ProduktId = 1,
                            KategoriId = 1,
                            Navn = "ASUS ZenBook Pro Duo",
                            Pris = 21490m,
                            ProducentId = 1
                        },
                        new
                        {
                            ProduktId = 2,
                            KategoriId = 2,
                            Navn = "Nintendo Switch 2019",
                            Pris = 2999m,
                            ProducentId = 2
                        },
                        new
                        {
                            ProduktId = 3,
                            KategoriId = 3,
                            Navn = "iPhone 11 Pro Max",
                            Pris = 9649m,
                            ProducentId = 3
                        },
                        new
                        {
                            ProduktId = 4,
                            KategoriId = 1,
                            Navn = "MSI Infinite A",
                            Pris = 13490m,
                            ProducentId = 4
                        });
                });

            modelBuilder.Entity("Datalayer.Entities.ProduktBillede", b =>
                {
                    b.Property<int>("ProduktBilledeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Billede")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProduktId")
                        .HasColumnType("int");

                    b.HasKey("ProduktBilledeId");

                    b.HasIndex("ProduktId");

                    b.ToTable("ProduktBillede");

                    b.HasData(
                        new
                        {
                            ProduktBilledeId = 1,
                            Billede = "https://dlcdnimgs.asus.com/websites/DK/PDCustomizedKVSection/video/2172.jpg",
                            ProduktId = 1
                        },
                        new
                        {
                            ProduktBilledeId = 2,
                            Billede = "https://www.elgiganten.dk/image/dv_web_D18000100283778/SWI32GBNEON/nintendo-switch-konsol-neonblaa-og-neonroed-joy-con.jpg?$fullsize$",
                            ProduktId = 2
                        },
                        new
                        {
                            ProduktBilledeId = 3,
                            Billede = "https://www.pricerunner.dk/product/200x200/1906996069/Apple-iPhone-11-Pro-Max-64GB.jpg",
                            ProduktId = 3
                        },
                        new
                        {
                            ProduktBilledeId = 4,
                            Billede = "https://storage.tweak.dk/images/uploads/2017_10/New-MSI-INFINITE-X-High-End-Gaming-Desktop-580.jpg",
                            ProduktId = 4
                        });
                });

            modelBuilder.Entity("Datalayer.Entities.kategori", b =>
                {
                    b.Property<int>("kategoriId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Navn")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("kategoriId");

                    b.ToTable("kategorier");

                    b.HasData(
                        new
                        {
                            kategoriId = 1,
                            Navn = "Computer"
                        },
                        new
                        {
                            kategoriId = 2,
                            Navn = "konsoller"
                        },
                        new
                        {
                            kategoriId = 3,
                            Navn = "Mobil"
                        });
                });

            modelBuilder.Entity("Datalayer.Entities.Ordre", b =>
                {
                    b.HasOne("Datalayer.Entities.Kunde", "Kunde")
                        .WithMany("Ordrer")
                        .HasForeignKey("KundeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Datalayer.Entities.OrdreProdukt", b =>
                {
                    b.HasOne("Datalayer.Entities.Ordre", "Ordre")
                        .WithMany("Produkter")
                        .HasForeignKey("OrdreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Datalayer.Entities.Produkt", "Produkt")
                        .WithMany("Ordrer")
                        .HasForeignKey("ProduktId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Datalayer.Entities.Produkt", b =>
                {
                    b.HasOne("Datalayer.Entities.kategori", "Kategori")
                        .WithMany("Produkts")
                        .HasForeignKey("KategoriId");

                    b.HasOne("Datalayer.Entities.Producent", "Producent")
                        .WithMany("Produkter")
                        .HasForeignKey("ProducentId");
                });

            modelBuilder.Entity("Datalayer.Entities.ProduktBillede", b =>
                {
                    b.HasOne("Datalayer.Entities.Produkt", "Produkt")
                        .WithMany("ProduktBilleder")
                        .HasForeignKey("ProduktId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
