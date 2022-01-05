using Microsoft.EntityFrameworkCore.Migrations;

namespace DuzceUniTez.Migrations
{
    public partial class EtkinlikIMG : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EtkinlikResim",
                table: "Etkinlikler",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EtkinlikResim",
                table: "Etkinlikler");
        }
    }
}
