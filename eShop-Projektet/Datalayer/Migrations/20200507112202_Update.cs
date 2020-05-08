using Microsoft.EntityFrameworkCore.Migrations;

namespace Datalayer.Migrations
{
    public partial class Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Navn",
                table: "Kunder");

            migrationBuilder.AlterColumn<string>(
                name: "Navn",
                table: "Produkter",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Billede",
                table: "ProduktBillede",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Navn",
                table: "Producenter",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Kodeord",
                table: "Kunder",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Kunder",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Adresse",
                table: "Kunder",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Efternavn",
                table: "Kunder",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Fornavn",
                table: "Kunder",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Navn",
                table: "kategorier",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Kunder",
                keyColumn: "KundeId",
                keyValue: 1,
                columns: new[] { "Efternavn", "Fornavn" },
                values: new object[] { "Schultz", "Niels" });

            migrationBuilder.UpdateData(
                table: "Kunder",
                keyColumn: "KundeId",
                keyValue: 2,
                columns: new[] { "Efternavn", "Fornavn" },
                values: new object[] { "FakeSchultz", "FakeNiels" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Efternavn",
                table: "Kunder");

            migrationBuilder.DropColumn(
                name: "Fornavn",
                table: "Kunder");

            migrationBuilder.AlterColumn<string>(
                name: "Navn",
                table: "Produkter",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Billede",
                table: "ProduktBillede",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Navn",
                table: "Producenter",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Kodeord",
                table: "Kunder",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Kunder",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "Adresse",
                table: "Kunder",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AddColumn<string>(
                name: "Navn",
                table: "Kunder",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Navn",
                table: "kategorier",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.UpdateData(
                table: "Kunder",
                keyColumn: "KundeId",
                keyValue: 1,
                column: "Navn",
                value: "Niels Schultz");

            migrationBuilder.UpdateData(
                table: "Kunder",
                keyColumn: "KundeId",
                keyValue: 2,
                column: "Navn",
                value: "FakeNiels FakeSchultz");
        }
    }
}
