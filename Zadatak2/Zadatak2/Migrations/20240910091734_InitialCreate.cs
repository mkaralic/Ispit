using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zadatak2.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ljubimci",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vrsta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cena = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NivoSrece = table.Column<int>(type: "int", nullable: false),
                    NivoHrane = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ljubimci", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Ljubimci",
                columns: new[] { "Id", "Cena", "Ime", "NivoHrane", "NivoSrece", "Vrsta" },
                values: new object[] { 1, 0m, "Maca 1", 0, 0, "macka" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ljubimci");
        }
    }
}
