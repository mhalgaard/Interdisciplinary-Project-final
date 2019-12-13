using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class changeImageLinks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 3,
                column: "URL",
                value: "..img/memphisroadhouse.png");

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 4,
                column: "URL",
                value: "..img/restaurantmof.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 3,
                column: "URL",
                value: "..img/memphisroadhouse.jpg");

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 4,
                column: "URL",
                value: "..img/restaurantmof.jpg");
        }
    }
}
