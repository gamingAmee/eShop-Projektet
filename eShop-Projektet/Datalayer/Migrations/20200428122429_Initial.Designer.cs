﻿// <auto-generated />
using System;
using Datalayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Datalayer.Migrations
{
    [DbContext(typeof(EshopContext))]
    [Migration("20200428122429_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.ToTable("Ordrer");
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

            modelBuilder.Entity("Datalayer.Entities.Produkt", b =>
                {
                    b.Property<int>("ProduktId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("KategoriId")
                        .HasColumnType("int");

                    b.Property<string>("Navn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Pris")
                        .HasColumnType("decimal(8, 2)");

                    b.HasKey("ProduktId");

                    b.HasIndex("KategoriId");

                    b.ToTable("Produkter");
                });

            modelBuilder.Entity("Datalayer.Entities.ProduktBillede", b =>
                {
                    b.Property<int>("ProduktBilledeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte>("Billede")
                        .HasColumnType("tinyint");

                    b.Property<int>("ProduktId")
                        .HasColumnType("int");

                    b.HasKey("ProduktBilledeId");

                    b.HasIndex("ProduktId");

                    b.ToTable("ProduktBillede");
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

                    b.ToTable("kategori");
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
                        .HasForeignKey("KategoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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
