using Microsoft.EntityFrameworkCore.Migrations;

namespace DuzceUniTez.Migrations
{
    public partial class addMeslekYuksekOkulTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MeslekYuksekOkullar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MeslekYuksekOkulAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MeslekYuksekOkulAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MeslekYuksekOkulAdres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MeslekYuksekOkulTel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MeslekYuksekOkulMail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeslekYuksekOkullar", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MeslekYuksekOkullar");
        }
    }
}
