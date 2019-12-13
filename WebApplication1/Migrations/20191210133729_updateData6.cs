using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class updateData6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "ID",
                keyValue: 2,
                column: "Name",
                value: "Restaurant Frederikshøj");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "ID",
                keyValue: 2,
                column: "Name",
                value: "Restaurant Frederikshoj");
        }
    }
}
