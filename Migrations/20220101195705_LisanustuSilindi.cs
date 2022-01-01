using Microsoft.EntityFrameworkCore.Migrations;

namespace DuzceUniTez.Migrations
{
    public partial class LisanustuSilindi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LisansustuBolumler");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LisansustuBolumler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FakulteId = table.Column<int>(type: "int", nullable: false),
                    Fakultesi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LisansustuBolumAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LisansustuBolumTipi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LisansustuBolumler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LisansustuBolumler_Fakulteler_FakulteId",
                        column: x => x.FakulteId,
                        principalTable: "Fakulteler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LisansustuBolumler_FakulteId",
                table: "LisansustuBolumler",
                column: "FakulteId");
        }
    }
}
