using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class addedUserRestaurant : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Restaurant_User_UserID",
                table: "Restaurant");

            migrationBuilder.DropIndex(
                name: "IX_Restaurant_UserID",
                table: "Restaurant");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Restaurant");

            migrationBuilder.AddColumn<int>(
                name: "Categories",
                table: "MenuItem",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "UserRestaurant",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    RestaurantId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRestaurant", x => new { x.RestaurantId, x.UserId });
                    table.ForeignKey(
                        name: "FK_UserRestaurant_Restaurant_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurant",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRestaurant_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "UserRestaurant",
                columns: new[] { "RestaurantId", "UserId" },
                values: new object[] { 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_UserRestaurant_UserId",
                table: "UserRestaurant",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserRestaurant");

            migrationBuilder.DropColumn(
                name: "Categories",
                table: "MenuItem");

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Restaurant",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Restaurant_UserID",
                table: "Restaurant",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Restaurant_User_UserID",
                table: "Restaurant",
                column: "UserID",
                principalTable: "User",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
