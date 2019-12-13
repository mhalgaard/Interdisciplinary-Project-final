using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class updateData3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Image_RestaurantId",
                table: "Image",
                column: "RestaurantId");

            migrationBuilder.AddForeignKey(
                name: "FK_Image_Restaurant_RestaurantId",
                table: "Image",
                column: "RestaurantId",
                principalTable: "Restaurant",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Image_Restaurant_RestaurantId",
                table: "Image");

            migrationBuilder.DropIndex(
                name: "IX_Image_RestaurantId",
                table: "Image");
        }
    }
}
