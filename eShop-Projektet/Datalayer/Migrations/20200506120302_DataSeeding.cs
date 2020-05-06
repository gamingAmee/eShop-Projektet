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
                table: "Kunder",
                columns: new[] { "KundeId", "Adresse", "Email", "Kodeord", "Navn" },
                values: new object[,]
                {
                    { 1, "HAHA", "niel862b@elevcampus.dk", "Qwerty123", "Niels Schultz" },
                    { 2, "FakeHAHA", "Fakeniel862b@elevcampus.dk", "Qwerty123", "FakeNiels FakeSchultz" }
                });

            migrationBuilder.InsertData(
                table: "Producenter",
                columns: new[] { "ProducentId", "Navn" },
                values: new object[,]
                {
                    { 11, "Steelseries" },
                    { 10, "Razer" },
                    { 9, "LG" },
                    { 7, "MSI" },
                    { 6, "HP" },
                    { 8, "Samsung" },
                    { 4, "Lenovo" },
                    { 3, "Apple" },
                    { 2, "Acer" },
                    { 1, "ASUS" },
                    { 5, "DELL" }
                });

            migrationBuilder.InsertData(
                table: "kategorier",
                columns: new[] { "kategoriId", "Navn" },
                values: new object[,]
                {
                    { 5, "Tastatur" },
                    { 1, "Grafikkort" },
                    { 2, "Bærbar" },
                    { 3, "Mobil" },
                    { 4, "TV" },
                    { 6, "Mus" }
                });

            migrationBuilder.InsertData(
                table: "Produkter",
                columns: new[] { "ProduktId", "KategoriId", "Navn", "Pris", "ProducentId" },
                values: new object[,]
                {
                    { 1, 1, "ASUS GeForce RTX 2080 SUPER ROG Strix Advanced", 7319m, 1 },
                    { 27, 6, "Razer Basilisk Ultimate Trådløs Gaming Mus", 1349m, 10 },
                    { 26, 5, "SteelSeries Apex Pro Gaming Tastatur", 1599m, 11 },
                    { 25, 5, "ASUS ROG Strix Scope Gaming Tastatur", 1099m, 1 },
                    { 24, 5, "Razer BlackWidow Elite Gaming Tastatur", 1399m, 10 },
                    { 23, 4, "LG 48 OLED TV OLED48CX6", 11999m, 9 },
                    { 22, 4, "LG 55 UHD OLED Smart TV OLED55C9", 9990m, 9 },
                    { 21, 4, "Samsung 75 QLED Smart TV QE75Q90R", 39990m, 8 },
                    { 20, 4, "Samsung 75 QLED Smart TV QE75Q60R", 16990m, 8 },
                    { 19, 3, "Apple iPhone SE 64GB Sort", 3699m, 3 },
                    { 18, 3, "iPhone 11 Pro Max 64 GB Grå", 9649m, 3 },
                    { 17, 3, "Samsung Galaxy A51 128GB Sort", 2789m, 8 },
                    { 16, 3, "Samsung Galaxy S20 Ultra 5G 128GB Grå", 10499m, 8 },
                    { 28, 6, "ASUS ROG Chakram Trådløs Gaming Mus", 1079m, 1 },
                    { 15, 2, "Razer Blade Pro 17,3 UHD / 4K touch 120 Hz", 33495m, 10 },
                    { 13, 2, "Dell XPS 13 7390 13,3 UHD / 4K Touch", 13690m, 5 },
                    { 12, 2, "Dell Vostro 3590 15,6 Full HD", 5290m, 5 },
                    { 11, 2, "Lenovo ThinkPad P53 15,6 Workstation Pro Full HD", 27990m, 4 },
                    { 10, 2, "Apple MacBook Pro laptop 16 1TB MVV med touch bar", 21999m, 3 },
                    { 9, 2, "Acer Chromebook R13 CB5-312T 13.3 FHD", 2495m, 2 },
                    { 8, 2, "ASUS ZenBook Pro Duo 15,6 UHD / 4K OLED Touch", 21490m, 1 },
                    { 7, 2, "MSI Prestige 15 15,6 Full HD", 11995m, 7 },
                    { 6, 2, "Acer Nitro 5 15,6 FHD 120 Hz", 5290m, 2 },
                    { 5, 2, "MSI GE75 Raider 17,3 FHD 240 Hz", 19990m, 7 },
                    { 4, 1, "ASUS GeForce GTX 1660 SUPER ROG Strix OC", 2229m, 1 },
                    { 3, 1, "ASUS Radeon RX 5500 XT ROG Strix OC 8GB", 1999m, 1 },
                    { 2, 1, "MSI GeForce RTX 2080 SUPER SEA HAWK EK X", 6999m, 7 },
                    { 14, 2, "HP Spectre x360 15-df1012no 15,6 UHD OLED touch", 17495m, 6 },
                    { 29, 6, "Steelseries Rival 710 Gaming Mus", 799m, 11 }
                });

            migrationBuilder.InsertData(
                table: "ProduktBillede",
                columns: new[] { "ProduktBilledeId", "Billede", "ProduktId" },
                values: new object[,]
                {
                    { 4, "https://www.komplett.dk/img/p/1200/1135677.jpg", 1 },
                    { 30, "https://www.komplett.dk/img/p/1200/1146944.jpg", 27 },
                    { 29, "https://www.komplett.dk/img/p/1200/1127733.jpg", 26 },
                    { 28, "https://www.komplett.dk/img/p/1200/1144808.jpg", 25 },
                    { 27, "https://www.elgiganten.dk/image/dv_web_D18000100296972/12851/razer-blackwidow-elite-gaming-tastatur.jpg?$fullsize$", 24 },
                    { 26, "https://www.elgiganten.dk/image/dv_web_D180001002410624/153758/lg-48-cx-4k-oled-tv-oled48cx.jpg?$fullsize$", 23 },
                    { 3, "https://www.elgiganten.dk/image/dv_web_D180001002410669/153758/lg-48-cx-4k-oled-tv-oled48cx.jpg?$prod_all4one$", 23 },
                    { 2, "https://www.elgiganten.dk/image/dv_web_D180001002410670/153758/lg-48-cx-4k-oled-tv-oled48cx.jpg?$fullsize$", 23 },
                    { 1, "https://www.elgiganten.dk/image/dv_web_D180001002410624/153758/lg-48-cx-4k-oled-tv-oled48cx.jpg?$fullsize$", 23 },
                    { 25, "https://www.komplett.dk/img/p/1200/1130516.jpg", 22 },
                    { 24, "https://www.komplett.dk/img/p/1080/1124646.jpg", 21 },
                    { 23, "https://www.komplett.dk/img/p/1080/1124639.jpg", 20 },
                    { 22, "https://www.komplett.dk/img/p/1200/1157749.jpg", 19 },
                    { 21, "https://www.komplett.dk/img/p/1200/1138869.jpg", 18 },
                    { 20, "https://www.komplett.dk/img/p/1200/1149587.jpg", 17 },
                    { 19, "https://www.komplett.dk/img/p/1200/1151019.jpg", 16 },
                    { 18, "https://www.komplett.dk/img/p/1200/1153777.jpg", 15 },
                    { 17, "https://www.komplett.dk/img/p/1200/1132707.jpg", 14 },
                    { 16, "https://www.komplett.dk/img/p/1200/1146637.jpg", 13 },
                    { 15, "https://www.komplett.dk/img/p/1200/1150472.jpg", 12 },
                    { 14, "https://www.komplett.dk/img/p/1000/1137677.jpg", 11 },
                    { 13, "https://sg-next.imgix.net/medias/sys_master/root/hbd/h3a/13735092912158/MacBook-Pro-16-in-Pure-Front-Space-Gray-SCREEN-result.jpg?w=350&h=350&auto=format&fm=jpg", 10 },
                    { 12, "https://www.komplett.dk/img/p/1200/898464.jpg", 9 },
                    { 11, "https://www.komplett.dk/img/p/1200/1132405.jpg", 8 },
                    { 10, "https://www.komplett.dk/img/p/1200/1135667.jpg", 7 },
                    { 9, "https://www.komplett.dk/img/p/1200/1156443.jpg", 6 },
                    { 8, "https://www.komplett.dk/img/p/1200/1153467.jpg", 5 },
                    { 7, "https://www.komplett.dk/img/p/1200/1148757.jpg", 4 },
                    { 6, "https://www.komplett.dk/img/p/1200/1149212.jpg", 3 },
                    { 5, "https://www.komplett.dk/img/p/1200/1139034.jpg", 2 },
                    { 31, "https://www.komplett.dk/img/p/1200/1150475.jpg", 28 },
                    { 32, "https://www.komplett.dk/img/p/1200/1041072.jpg", 29 }
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
                table: "Kunder",
                keyColumn: "KundeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Kunder",
                keyColumn: "KundeId",
                keyValue: 2);

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
                table: "ProduktBillede",
                keyColumn: "ProduktBilledeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProduktBillede",
                keyColumn: "ProduktBilledeId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProduktBillede",
                keyColumn: "ProduktBilledeId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProduktBillede",
                keyColumn: "ProduktBilledeId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProduktBillede",
                keyColumn: "ProduktBilledeId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProduktBillede",
                keyColumn: "ProduktBilledeId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ProduktBillede",
                keyColumn: "ProduktBilledeId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ProduktBillede",
                keyColumn: "ProduktBilledeId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ProduktBillede",
                keyColumn: "ProduktBilledeId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ProduktBillede",
                keyColumn: "ProduktBilledeId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ProduktBillede",
                keyColumn: "ProduktBilledeId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ProduktBillede",
                keyColumn: "ProduktBilledeId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ProduktBillede",
                keyColumn: "ProduktBilledeId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ProduktBillede",
                keyColumn: "ProduktBilledeId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ProduktBillede",
                keyColumn: "ProduktBilledeId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ProduktBillede",
                keyColumn: "ProduktBilledeId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ProduktBillede",
                keyColumn: "ProduktBilledeId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ProduktBillede",
                keyColumn: "ProduktBilledeId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ProduktBillede",
                keyColumn: "ProduktBilledeId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ProduktBillede",
                keyColumn: "ProduktBilledeId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ProduktBillede",
                keyColumn: "ProduktBilledeId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ProduktBillede",
                keyColumn: "ProduktBilledeId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ProduktBillede",
                keyColumn: "ProduktBilledeId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ProduktBillede",
                keyColumn: "ProduktBilledeId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ProduktBillede",
                keyColumn: "ProduktBilledeId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ProduktBillede",
                keyColumn: "ProduktBilledeId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ProduktBillede",
                keyColumn: "ProduktBilledeId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ProduktBillede",
                keyColumn: "ProduktBilledeId",
                keyValue: 32);

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
                table: "Produkter",
                keyColumn: "ProduktId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Produkter",
                keyColumn: "ProduktId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Produkter",
                keyColumn: "ProduktId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Produkter",
                keyColumn: "ProduktId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Produkter",
                keyColumn: "ProduktId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Produkter",
                keyColumn: "ProduktId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Produkter",
                keyColumn: "ProduktId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Produkter",
                keyColumn: "ProduktId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Produkter",
                keyColumn: "ProduktId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Produkter",
                keyColumn: "ProduktId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Produkter",
                keyColumn: "ProduktId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Produkter",
                keyColumn: "ProduktId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Produkter",
                keyColumn: "ProduktId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Produkter",
                keyColumn: "ProduktId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Produkter",
                keyColumn: "ProduktId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Produkter",
                keyColumn: "ProduktId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Produkter",
                keyColumn: "ProduktId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Produkter",
                keyColumn: "ProduktId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Produkter",
                keyColumn: "ProduktId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Produkter",
                keyColumn: "ProduktId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Produkter",
                keyColumn: "ProduktId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Produkter",
                keyColumn: "ProduktId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Produkter",
                keyColumn: "ProduktId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Produkter",
                keyColumn: "ProduktId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Produkter",
                keyColumn: "ProduktId",
                keyValue: 29);

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
                table: "Producenter",
                keyColumn: "ProducentId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Producenter",
                keyColumn: "ProducentId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Producenter",
                keyColumn: "ProducentId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Producenter",
                keyColumn: "ProducentId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Producenter",
                keyColumn: "ProducentId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Producenter",
                keyColumn: "ProducentId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Producenter",
                keyColumn: "ProducentId",
                keyValue: 11);

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

            migrationBuilder.DeleteData(
                table: "kategorier",
                keyColumn: "kategoriId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "kategorier",
                keyColumn: "kategoriId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "kategorier",
                keyColumn: "kategoriId",
                keyValue: 6);

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
