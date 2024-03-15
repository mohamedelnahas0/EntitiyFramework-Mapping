using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Musican_Map.Migrations
{
    public partial class Album_songTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "album_Songs",
                columns: table => new
                {
                    AlbumId = table.Column<int>(type: "int", nullable: false),
                    SongTitle = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_album_Songs", x => new { x.AlbumId, x.SongTitle });
                    table.ForeignKey(
                        name: "FK_album_Songs_albums_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "albums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_album_Songs_songs_SongTitle",
                        column: x => x.SongTitle,
                        principalTable: "songs",
                        principalColumn: "Title",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_album_Songs_SongTitle",
                table: "album_Songs",
                column: "SongTitle");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "album_Songs");
        }
    }
}
