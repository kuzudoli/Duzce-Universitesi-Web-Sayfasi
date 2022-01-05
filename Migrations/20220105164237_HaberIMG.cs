using Microsoft.EntityFrameworkCore.Migrations;

namespace DuzceUniTez.Migrations
{
    public partial class HaberIMG : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HaberResim",
                table: "Haberler",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HaberResim",
                table: "Haberler");
        }
    }
}
