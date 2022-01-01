using Microsoft.EntityFrameworkCore.Migrations;

namespace DuzceUniTez.Migrations
{
    public partial class addEnstituTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Enstituler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnsitutuAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnsitutuAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnsitutuAdres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnsitutuTel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnsitutuMail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enstituler", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Enstituler");
        }
    }
}
