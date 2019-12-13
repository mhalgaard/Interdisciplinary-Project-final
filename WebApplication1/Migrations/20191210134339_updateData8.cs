using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class updateData8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MenuId",
                table: "Restaurant");

            migrationBuilder.DropColumn(
                name: "RestaurantName",
                table: "Menu");

            migrationBuilder.AddColumn<int>(
                name: "RestaurantId",
                table: "Menu",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "ID",
                keyValue: 1,
                column: "RestaurantId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "ID",
                keyValue: 2,
                column: "RestaurantId",
                value: 2);

            migrationBuilder.CreateIndex(
                name: "IX_Menu_RestaurantId",
                table: "Menu",
                column: "RestaurantId");

            migrationBuilder.AddForeignKey(
                name: "FK_Menu_Restaurant_RestaurantId",
                table: "Menu",
                column: "RestaurantId",
                principalTable: "Restaurant",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Menu_Restaurant_RestaurantId",
                table: "Menu");

            migrationBuilder.DropIndex(
                name: "IX_Menu_RestaurantId",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "RestaurantId",
                table: "Menu");

            migrationBuilder.AddColumn<int>(
                name: "MenuId",
                table: "Restaurant",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "RestaurantName",
                table: "Menu",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "ID",
                keyValue: 1,
                column: "RestaurantName",
                value: "Café Smagløs");

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "ID",
                keyValue: 2,
                column: "RestaurantName",
                value: "Restaurant Frederikshøj");

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "ID",
                keyValue: 1,
                column: "MenuId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "ID",
                keyValue: 2,
                column: "MenuId",
                value: 2);
        }
    }
}
