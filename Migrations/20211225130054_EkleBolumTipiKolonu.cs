using Microsoft.EntityFrameworkCore.Migrations;

namespace DuzceUniTez.Migrations
{
    public partial class EkleBolumTipiKolonu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BolumTipi",
                table: "Bolumler",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BolumTipi",
                table: "Bolumler");
        }
    }
}
