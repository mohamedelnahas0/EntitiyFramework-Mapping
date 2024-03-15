using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Musican_Map.Migrations
{
    public partial class MusicSongTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Music_Songs",
                columns: table => new
                {
                    MusicanId = table.Column<int>(type: "int", nullable: false),
                    SongTitle = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Music_Songs", x => new { x.MusicanId, x.SongTitle });
                    table.ForeignKey(
                        name: "FK_Music_Songs_musicans_MusicanId",
                        column: x => x.MusicanId,
                        principalTable: "musicans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Music_Songs_songs_SongTitle",
                        column: x => x.SongTitle,
                        principalTable: "songs",
                        principalColumn: "Title",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Music_Songs_SongTitle",
                table: "Music_Songs",
                column: "SongTitle");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Music_Songs");
        }
    }
}
