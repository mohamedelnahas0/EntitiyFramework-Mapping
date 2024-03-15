using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ITI_Map.Migrations
{
    public partial class Addtud_Course : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stud_Courses",
                columns: table => new
                {
                    StudId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    Course_Id = table.Column<int>(type: "int", nullable: true),
                    StudentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stud_Courses", x => new { x.StudId, x.CourseId });
                    table.ForeignKey(
                        name: "FK_Stud_Courses_courses_Course_Id",
                        column: x => x.Course_Id,
                        principalTable: "courses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Stud_Courses_students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "students",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Stud_Courses_Course_Id",
                table: "Stud_Courses",
                column: "Course_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Stud_Courses_StudentId",
                table: "Stud_Courses",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stud_Courses");
        }
    }
}
