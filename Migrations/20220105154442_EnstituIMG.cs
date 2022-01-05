using Microsoft.EntityFrameworkCore.Migrations;

namespace DuzceUniTez.Migrations
{
    public partial class EnstituIMG : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EnsitutuResim",
                table: "Enstituler",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EnsitutuResim",
                table: "Enstituler");
        }
    }
}
