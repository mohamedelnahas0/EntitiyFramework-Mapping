using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Musican_Map.Migrations
{
    public partial class MusicInstrumentTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "music_Instruments",
                columns: table => new
                {
                    MusicanId = table.Column<int>(type: "int", nullable: false),
                    InstrumentName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    InstrumentName1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_music_Instruments", x => new { x.MusicanId, x.InstrumentName });
                    table.ForeignKey(
                        name: "FK_music_Instruments_instruments_InstrumentName1",
                        column: x => x.InstrumentName1,
                        principalTable: "instruments",
                        principalColumn: "Name");
                    table.ForeignKey(
                        name: "FK_music_Instruments_musicans_MusicanId",
                        column: x => x.MusicanId,
                        principalTable: "musicans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_music_Instruments_InstrumentName1",
                table: "music_Instruments",
                column: "InstrumentName1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "music_Instruments");
        }
    }
}
