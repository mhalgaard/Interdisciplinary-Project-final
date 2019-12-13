using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class newEntries : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "KitchenType",
                columns: new[] { "ID", "Name" },
                values: new object[] { 2, "Spansk" });

            migrationBuilder.InsertData(
                table: "RestaurantKitchenType",
                columns: new[] { "RestaurantId", "KitchenTypeId" },
                values: new object[] { 1, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RestaurantKitchenType",
                keyColumns: new[] { "RestaurantId", "KitchenTypeId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "KitchenType",
                keyColumn: "ID",
                keyValue: 2);
        }
    }
}
