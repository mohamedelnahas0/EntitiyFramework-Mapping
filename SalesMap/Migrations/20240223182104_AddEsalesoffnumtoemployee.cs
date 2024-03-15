using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesMap.Migrations
{
    public partial class AddEsalesoffnumtoemployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_sales_Offices_EmpId",
                table: "sales_Offices");

            migrationBuilder.AddColumn<int>(
                name: "salesOfficeNumber",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_sales_Offices_EmpId",
                table: "sales_Offices",
                column: "EmpId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_sales_Offices_EmpId",
                table: "sales_Offices");

            migrationBuilder.DropColumn(
                name: "salesOfficeNumber",
                table: "Employees");

            migrationBuilder.CreateIndex(
                name: "IX_sales_Offices_EmpId",
                table: "sales_Offices",
                column: "EmpId");
        }
    }
}
