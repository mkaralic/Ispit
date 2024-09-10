using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zadatak2.Migrations
{
    /// <inheritdoc />
    public partial class InitData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Ljubimci",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Cena", "NivoHrane", "NivoSrece" },
                values: new object[] { 50m, 100, 100 });

            migrationBuilder.InsertData(
                table: "Ljubimci",
                columns: new[] { "Id", "Cena", "Ime", "NivoHrane", "NivoSrece", "Vrsta" },
                values: new object[] { 2, 150m, "Pas 1", 100, 100, "pas" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ljubimci",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Ljubimci",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Cena", "NivoHrane", "NivoSrece" },
                values: new object[] { 0m, 0, 0 });
        }
    }
}
