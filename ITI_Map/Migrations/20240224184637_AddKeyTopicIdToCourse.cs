using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ITI_Map.Migrations
{
    public partial class AddKeyTopicIdToCourse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "topicId",
                table: "courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_courses_topicId",
                table: "courses",
                column: "topicId");

            migrationBuilder.AddForeignKey(
                name: "FK_courses_topics_topicId",
                table: "courses",
                column: "topicId",
                principalTable: "topics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_courses_topics_topicId",
                table: "courses");

            migrationBuilder.DropIndex(
                name: "IX_courses_topicId",
                table: "courses");

            migrationBuilder.DropColumn(
                name: "topicId",
                table: "courses");
        }
    }
}
