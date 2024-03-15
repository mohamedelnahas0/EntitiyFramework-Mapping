using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ITI_Map.Migrations
{
    public partial class AddRealtionBetDepandandStu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "departmentsId",
                table: "students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_students_departmentsId",
                table: "students",
                column: "departmentsId");

            migrationBuilder.AddForeignKey(
                name: "FK_students_departments_departmentsId",
                table: "students",
                column: "departmentsId",
                principalTable: "departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_students_departments_departmentsId",
                table: "students");

            migrationBuilder.DropIndex(
                name: "IX_students_departmentsId",
                table: "students");

            migrationBuilder.DropColumn(
                name: "departmentsId",
                table: "students");
        }
    }
}
