using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesMap.Migrations
{
    public partial class AddEsalesoffnumtoProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "salesOfficeNumber",
                table: "properties",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "salesOfficeNumbers",
                table: "properties",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_properties_salesOfficeNumbers",
                table: "properties",
                column: "salesOfficeNumbers");

            migrationBuilder.AddForeignKey(
                name: "FK_properties_sales_Offices_salesOfficeNumbers",
                table: "properties",
                column: "salesOfficeNumbers",
                principalTable: "sales_Offices",
                principalColumn: "Numbers",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_properties_sales_Offices_salesOfficeNumbers",
                table: "properties");

            migrationBuilder.DropIndex(
                name: "IX_properties_salesOfficeNumbers",
                table: "properties");

            migrationBuilder.DropColumn(
                name: "salesOfficeNumber",
                table: "properties");

            migrationBuilder.DropColumn(
                name: "salesOfficeNumbers",
                table: "properties");
        }
    }
}
