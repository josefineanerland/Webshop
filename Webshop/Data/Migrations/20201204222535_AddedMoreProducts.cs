using Microsoft.EntityFrameworkCore.Migrations;

namespace Webshop.Data.Migrations
{
    public partial class AddedMoreProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "..\\Webshop\\Webshop\\Images\\MinklashF100.jpg");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Price", "Quantity" },
                values: new object[] { 3, "Double pack of falsies, made of faux mink. Cruelty free.", "..\\Webshop\\Webshop\\Images\\MinklashDouble.jpg", "Double pack of long falselashes", 150.0, 20 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Price", "Quantity" },
                values: new object[] { 2, "Falselash made of faux mink, cruelty free.", "..\\Webshop\\Webshop\\Images\\LonglashF200.jpg", "Longlash F200", 70.0, 15 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: " ");
        }
    }
}
