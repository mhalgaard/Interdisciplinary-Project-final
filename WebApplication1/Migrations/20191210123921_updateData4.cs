using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class updateData4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 1,
                column: "URL",
                value: "../img/cafe-smaglos.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 1,
                column: "URL",
                value: "#");
        }
    }
}
