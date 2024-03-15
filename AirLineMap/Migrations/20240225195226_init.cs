using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirLineMap.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "airCrafts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Capactiy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pash_Pilot = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Assistant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Host1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Host2 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_airCrafts", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "airCrafts");
        }
    }
}
