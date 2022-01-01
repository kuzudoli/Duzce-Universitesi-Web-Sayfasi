using Microsoft.EntityFrameworkCore.Migrations;

namespace DuzceUniTez.Migrations
{
    public partial class addYuksekOkulTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "YuksekOkullar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YuksekOkulAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YuksekOkulAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YuksekOkulAdres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YuksekOkulTel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YuksekOkulMail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YuksekOkullar", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "YuksekOkullar");
        }
    }
}
