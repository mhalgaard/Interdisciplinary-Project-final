using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class moreData265 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MenuItem",
                columns: new[] { "ID", "Categories", "MenuId", "Price", "Title" },
                values: new object[] { 9, 5, 1, 49.99m, "Club Sandwich" });

            migrationBuilder.InsertData(
                table: "MenuItem",
                columns: new[] { "ID", "Categories", "MenuId", "Price", "Title" },
                values: new object[] { 10, 3, 2, 30.00m, "Coca Cola, 25cl" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "ID",
                keyValue: 10);
        }
    }
}
