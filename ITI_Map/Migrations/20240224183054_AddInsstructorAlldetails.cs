using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ITI_Map.Migrations
{
    public partial class AddInsstructorAlldetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "instructorID",
                table: "departments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "instructors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bonus = table.Column<int>(type: "int", nullable: false),
                    Salary = table.Column<int>(type: "int", nullable: false),
                    Hour_rate = table.Column<int>(type: "int", nullable: false),
                    departmentsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_instructors", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_departments_instructorID",
                table: "departments",
                column: "instructorID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_departments_instructors_instructorID",
                table: "departments",
                column: "instructorID",
                principalTable: "instructors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_departments_instructors_instructorID",
                table: "departments");

            migrationBuilder.DropTable(
                name: "instructors");

            migrationBuilder.DropIndex(
                name: "IX_departments_instructorID",
                table: "departments");

            migrationBuilder.DropColumn(
                name: "instructorID",
                table: "departments");
        }
    }
}
