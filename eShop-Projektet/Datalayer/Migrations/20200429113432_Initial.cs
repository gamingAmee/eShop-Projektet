﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Datalayer.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "kategorier",
                columns: table => new
                {
                    kategoriId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Navn = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kategorier", x => x.kategoriId);
                });

            migrationBuilder.CreateTable(
                name: "Kunder",
                columns: table => new
                {
                    KundeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Navn = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Kodeord = table.Column<string>(nullable: true),
                    Adresse = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kunder", x => x.KundeId);
                });

            migrationBuilder.CreateTable(
                name: "Producenter",
                columns: table => new
                {
                    ProducentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Navn = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producenter", x => x.ProducentId);
                });

            migrationBuilder.CreateTable(
                name: "Ordre",
                columns: table => new
                {
                    OrdreId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KundeId = table.Column<int>(nullable: false),
                    KoebsDato = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ordre", x => x.OrdreId);
                    table.ForeignKey(
                        name: "FK_Ordre_Kunder_KundeId",
                        column: x => x.KundeId,
                        principalTable: "Kunder",
                        principalColumn: "KundeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Produkter",
                columns: table => new
                {
                    ProduktId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Navn = table.Column<string>(nullable: true),
                    Pris = table.Column<decimal>(type: "decimal(8, 2)", nullable: false),
                    KategoriId = table.Column<int>(nullable: false),
                    ProducentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produkter", x => x.ProduktId);
                    table.ForeignKey(
                        name: "FK_Produkter_kategorier_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "kategorier",
                        principalColumn: "kategoriId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Produkter_Producenter_ProducentId",
                        column: x => x.ProducentId,
                        principalTable: "Producenter",
                        principalColumn: "ProducentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrdreProdukt",
                columns: table => new
                {
                    OrdreId = table.Column<int>(nullable: false),
                    ProduktId = table.Column<int>(nullable: false),
                    Styk = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdreProdukt", x => new { x.OrdreId, x.ProduktId });
                    table.ForeignKey(
                        name: "FK_OrdreProdukt_Ordre_OrdreId",
                        column: x => x.OrdreId,
                        principalTable: "Ordre",
                        principalColumn: "OrdreId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrdreProdukt_Produkter_ProduktId",
                        column: x => x.ProduktId,
                        principalTable: "Produkter",
                        principalColumn: "ProduktId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProduktBillede",
                columns: table => new
                {
                    ProduktBilledeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Billede = table.Column<string>(nullable: true),
                    ProduktId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProduktBillede", x => x.ProduktBilledeId);
                    table.ForeignKey(
                        name: "FK_ProduktBillede_Produkter_ProduktId",
                        column: x => x.ProduktId,
                        principalTable: "Produkter",
                        principalColumn: "ProduktId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ordre_KundeId",
                table: "Ordre",
                column: "KundeId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdreProdukt_ProduktId",
                table: "OrdreProdukt",
                column: "ProduktId");

            migrationBuilder.CreateIndex(
                name: "IX_ProduktBillede_ProduktId",
                table: "ProduktBillede",
                column: "ProduktId");

            migrationBuilder.CreateIndex(
                name: "IX_Produkter_KategoriId",
                table: "Produkter",
                column: "KategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_Produkter_ProducentId",
                table: "Produkter",
                column: "ProducentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrdreProdukt");

            migrationBuilder.DropTable(
                name: "ProduktBillede");

            migrationBuilder.DropTable(
                name: "Ordre");

            migrationBuilder.DropTable(
                name: "Produkter");

            migrationBuilder.DropTable(
                name: "Kunder");

            migrationBuilder.DropTable(
                name: "kategorier");

            migrationBuilder.DropTable(
                name: "Producenter");
        }
    }
}
