using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesMap.Migrations
{
    public partial class AddEmpidToSalesOffice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmpId",
                table: "sales_Offices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_sales_Offices_EmpId",
                table: "sales_Offices",
                column: "EmpId");

            migrationBuilder.AddForeignKey(
                name: "FK_sales_Offices_Employees_EmpId",
                table: "sales_Offices",
                column: "EmpId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_sales_Offices_Employees_EmpId",
                table: "sales_Offices");

            migrationBuilder.DropIndex(
                name: "IX_sales_Offices_EmpId",
                table: "sales_Offices");

            migrationBuilder.DropColumn(
                name: "EmpId",
                table: "sales_Offices");
        }
    }
}
