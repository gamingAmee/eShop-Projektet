using Microsoft.EntityFrameworkCore.Migrations;

namespace Datalayer.Migrations
{
    public partial class DataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produkter_kategorier_KategoriId",
                table: "Produkter");

            migrationBuilder.DropForeignKey(
                name: "FK_Produkter_Producenter_ProducentId",
                table: "Produkter");

            migrationBuilder.AlterColumn<int>(
                name: "ProducentId",
                table: "Produkter",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "KategoriId",
                table: "Produkter",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Producenter",
                columns: new[] { "ProducentId", "Navn" },
                values: new object[,]
                {
                    { 1, "Asus" },
                    { 2, "Nintendo" },
                    { 3, "Apple" },
                    { 4, "MSI" }
                });

            migrationBuilder.InsertData(
                table: "kategorier",
                columns: new[] { "kategoriId", "Navn" },
                values: new object[,]
                {
                    { 1, "Computer" },
                    { 2, "konsoller" },
                    { 3, "Mobil" }
                });

            migrationBuilder.InsertData(
                table: "Produkter",
                columns: new[] { "ProduktId", "KategoriId", "Navn", "Pris", "ProducentId" },
                values: new object[,]
                {
                    { 1, 1, "ASUS ZenBook Pro Duo", 21490m, 1 },
                    { 4, 1, "MSI Infinite A", 13490m, 4 },
                    { 2, 2, "Nintendo Switch 2019", 2999m, 2 },
                    { 3, 3, "iPhone 11 Pro Max", 9649m, 3 }
                });

            migrationBuilder.InsertData(
                table: "ProduktBillede",
                columns: new[] { "ProduktBilledeId", "Billede", "ProduktId" },
                values: new object[,]
                {
                    { 1, "https://dlcdnimgs.asus.com/websites/DK/PDCustomizedKVSection/video/2172.jpg", 1 },
                    { 4, "https://storage.tweak.dk/images/uploads/2017_10/New-MSI-INFINITE-X-High-End-Gaming-Desktop-580.jpg", 4 },
                    { 2, "https://www.elgiganten.dk/image/dv_web_D18000100283778/SWI32GBNEON/nintendo-switch-konsol-neonblaa-og-neonroed-joy-con.jpg?$fullsize$", 2 },
                    { 3, "https://www.pricerunner.dk/product/200x200/1906996069/Apple-iPhone-11-Pro-Max-64GB.jpg", 3 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Produkter_kategorier_KategoriId",
                table: "Produkter",
                column: "KategoriId",
                principalTable: "kategorier",
                principalColumn: "kategoriId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Produkter_Producenter_ProducentId",
                table: "Produkter",
                column: "ProducentId",
                principalTable: "Producenter",
                principalColumn: "ProducentId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produkter_kategorier_KategoriId",
                table: "Produkter");

            migrationBuilder.DropForeignKey(
                name: "FK_Produkter_Producenter_ProducentId",
                table: "Produkter");

            migrationBuilder.DeleteData(
                table: "ProduktBillede",
                keyColumn: "ProduktBilledeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProduktBillede",
                keyColumn: "ProduktBilledeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProduktBillede",
                keyColumn: "ProduktBilledeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProduktBillede",
                keyColumn: "ProduktBilledeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Produkter",
                keyColumn: "ProduktId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Produkter",
                keyColumn: "ProduktId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Produkter",
                keyColumn: "ProduktId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Produkter",
                keyColumn: "ProduktId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Producenter",
                keyColumn: "ProducentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Producenter",
                keyColumn: "ProducentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Producenter",
                keyColumn: "ProducentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Producenter",
                keyColumn: "ProducentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "kategorier",
                keyColumn: "kategoriId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "kategorier",
                keyColumn: "kategoriId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "kategorier",
                keyColumn: "kategoriId",
                keyValue: 3);

            migrationBuilder.AlterColumn<int>(
                name: "ProducentId",
                table: "Produkter",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "KategoriId",
                table: "Produkter",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Produkter_kategorier_KategoriId",
                table: "Produkter",
                column: "KategoriId",
                principalTable: "kategorier",
                principalColumn: "kategoriId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Produkter_Producenter_ProducentId",
                table: "Produkter",
                column: "ProducentId",
                principalTable: "Producenter",
                principalColumn: "ProducentId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
