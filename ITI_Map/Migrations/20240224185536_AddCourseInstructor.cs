using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ITI_Map.Migrations
{
    public partial class AddCourseInstructor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "course_Instructots",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    Instructorid = table.Column<int>(type: "int", nullable: false),
                    Evaluation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Course_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_course_Instructots", x => new { x.CourseId, x.Instructorid });
                    table.ForeignKey(
                        name: "FK_course_Instructots_courses_Course_Id",
                        column: x => x.Course_Id,
                        principalTable: "courses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_course_Instructots_instructors_Instructorid",
                        column: x => x.Instructorid,
                        principalTable: "instructors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_course_Instructots_Course_Id",
                table: "course_Instructots",
                column: "Course_Id");

            migrationBuilder.CreateIndex(
                name: "IX_course_Instructots_Instructorid",
                table: "course_Instructots",
                column: "Instructorid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "course_Instructots");
        }
    }
}
