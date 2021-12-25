using Microsoft.EntityFrameworkCore.Migrations;

namespace DuzceUniTez.Migrations
{
    public partial class BolumFakultesiKolon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Fakultesi",
                table: "Bolumler",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fakultesi",
                table: "Bolumler");
        }
    }
}
