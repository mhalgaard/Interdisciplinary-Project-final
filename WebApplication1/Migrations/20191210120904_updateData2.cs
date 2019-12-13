using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class updateData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RestaurantBadge_Badge_BadgeId",
                table: "RestaurantBadge");

            migrationBuilder.DropForeignKey(
                name: "FK_RestaurantBadge_Restaurant_RestaurantId",
                table: "RestaurantBadge");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RestaurantBadge",
                table: "RestaurantBadge");

            migrationBuilder.RenameTable(
                name: "RestaurantBadge",
                newName: "RestaurantBadges");

            migrationBuilder.RenameIndex(
                name: "IX_RestaurantBadge_BadgeId",
                table: "RestaurantBadges",
                newName: "IX_RestaurantBadges_BadgeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RestaurantBadges",
                table: "RestaurantBadges",
                columns: new[] { "RestaurantId", "BadgeId" });

            migrationBuilder.InsertData(
                table: "RestaurantBadges",
                columns: new[] { "RestaurantId", "BadgeId" },
                values: new object[] { 2, 3 });

            migrationBuilder.AddForeignKey(
                name: "FK_RestaurantBadges_Badge_BadgeId",
                table: "RestaurantBadges",
                column: "BadgeId",
                principalTable: "Badge",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RestaurantBadges_Restaurant_RestaurantId",
                table: "RestaurantBadges",
                column: "RestaurantId",
                principalTable: "Restaurant",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RestaurantBadges_Badge_BadgeId",
                table: "RestaurantBadges");

            migrationBuilder.DropForeignKey(
                name: "FK_RestaurantBadges_Restaurant_RestaurantId",
                table: "RestaurantBadges");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RestaurantBadges",
                table: "RestaurantBadges");

            migrationBuilder.DeleteData(
                table: "RestaurantBadges",
                keyColumns: new[] { "RestaurantId", "BadgeId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.RenameTable(
                name: "RestaurantBadges",
                newName: "RestaurantBadge");

            migrationBuilder.RenameIndex(
                name: "IX_RestaurantBadges_BadgeId",
                table: "RestaurantBadge",
                newName: "IX_RestaurantBadge_BadgeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RestaurantBadge",
                table: "RestaurantBadge",
                columns: new[] { "RestaurantId", "BadgeId" });

            migrationBuilder.AddForeignKey(
                name: "FK_RestaurantBadge_Badge_BadgeId",
                table: "RestaurantBadge",
                column: "BadgeId",
                principalTable: "Badge",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RestaurantBadge_Restaurant_RestaurantId",
                table: "RestaurantBadge",
                column: "RestaurantId",
                principalTable: "Restaurant",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
