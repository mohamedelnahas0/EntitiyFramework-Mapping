using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesMap.Migrations
{
    public partial class salesoofficeToprop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_properties_sales_Offices_salesOfficeNumbers",
                table: "properties");

            migrationBuilder.RenameColumn(
                name: "salesOfficeNumbers",
                table: "properties",
                newName: "salesOfficesNumbers");

            migrationBuilder.RenameColumn(
                name: "salesOfficeNumber",
                table: "properties",
                newName: "salesOfficesNumber");

            migrationBuilder.RenameIndex(
                name: "IX_properties_salesOfficeNumbers",
                table: "properties",
                newName: "IX_properties_salesOfficesNumbers");

            migrationBuilder.AddForeignKey(
                name: "FK_properties_sales_Offices_salesOfficesNumbers",
                table: "properties",
                column: "salesOfficesNumbers",
                principalTable: "sales_Offices",
                principalColumn: "Numbers",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_properties_sales_Offices_salesOfficesNumbers",
                table: "properties");

            migrationBuilder.RenameColumn(
                name: "salesOfficesNumbers",
                table: "properties",
                newName: "salesOfficeNumbers");

            migrationBuilder.RenameColumn(
                name: "salesOfficesNumber",
                table: "properties",
                newName: "salesOfficeNumber");

            migrationBuilder.RenameIndex(
                name: "IX_properties_salesOfficesNumbers",
                table: "properties",
                newName: "IX_properties_salesOfficeNumbers");

            migrationBuilder.AddForeignKey(
                name: "FK_properties_sales_Offices_salesOfficeNumbers",
                table: "properties",
                column: "salesOfficeNumbers",
                principalTable: "sales_Offices",
                principalColumn: "Numbers",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
