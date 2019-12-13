using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class updateData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Badge",
                keyColumn: "ID",
                keyValue: 1,
                column: "ImageURL",
                value: "../img/vegetar.png");

            migrationBuilder.InsertData(
                table: "Badge",
                columns: new[] { "ID", "ImageURL", "Name" },
                values: new object[,]
                {
                    { 2, "../img/oekologi.png", "90-100% Økologimærket" },
                    { 3, "../img/elite.png", "Elitesmiley" }
                });

            migrationBuilder.UpdateData(
                table: "KitchenType",
                keyColumn: "ID",
                keyValue: 2,
                column: "Name",
                value: "Cafémad");

            migrationBuilder.InsertData(
                table: "KitchenType",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 3, "Gourmet" },
                    { 4, "Lokalt" }
                });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "ID", "RestaurantName" },
                values: new object[] { 2, "Restaurant Frederikshøj" });

            migrationBuilder.InsertData(
                table: "Priceclass",
                columns: new[] { "ID", "PriceclassValue" },
                values: new object[,]
                {
                    { 2, "$$" },
                    { 3, "$$$" }
                });

            migrationBuilder.InsertData(
                table: "Restaurant",
                columns: new[] { "ID", "Address", "Description", "MenuId", "Name", "Phonenumber", "Priceclass", "Zipcode" },
                values: new object[] { 2, "Oddervej 19-21", "The cuisine of Frederikshøj is classic and modern, emancipated and unpredictable. A sophisticated union of the pure style of the nouvelle cuisine and the dizzying and complex deconstructions of the postmodern cuisine – with digressions to the detailed, slight minimalism and raw primordial forces of the new Nordic cuisine and the very advanced techniques and surprising compositions.", 2, "Restaurant Frederikshoj", "+45 234 567 89", "$$$", 8000 });

            migrationBuilder.UpdateData(
                table: "Setting",
                keyColumn: "ID",
                keyValue: 1,
                column: "Distance",
                value: 20);

            migrationBuilder.InsertData(
                table: "MenuItem",
                columns: new[] { "ID", "Categories", "MenuId", "Price", "Title" },
                values: new object[,]
                {
                    { 2, 4, 2, 0m, "7 retters måltid" },
                    { 3, 4, 2, 0m, "10 retters måltid" }
                });

            migrationBuilder.InsertData(
                table: "RestaurantBadge",
                columns: new[] { "RestaurantId", "BadgeId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 1, 3 }
                });

            migrationBuilder.InsertData(
                table: "RestaurantKitchenType",
                columns: new[] { "RestaurantId", "KitchenTypeId" },
                values: new object[,]
                {
                    { 2, 3 },
                    { 2, 4 },
                    { 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "UserRestaurant",
                columns: new[] { "RestaurantId", "UserId" },
                values: new object[] { 2, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Priceclass",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Priceclass",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RestaurantBadge",
                keyColumns: new[] { "RestaurantId", "BadgeId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "RestaurantBadge",
                keyColumns: new[] { "RestaurantId", "BadgeId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "RestaurantKitchenType",
                keyColumns: new[] { "RestaurantId", "KitchenTypeId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "RestaurantKitchenType",
                keyColumns: new[] { "RestaurantId", "KitchenTypeId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "RestaurantKitchenType",
                keyColumns: new[] { "RestaurantId", "KitchenTypeId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "UserRestaurant",
                keyColumns: new[] { "RestaurantId", "UserId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "Badge",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Badge",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "KitchenType",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "KitchenType",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Badge",
                keyColumn: "ID",
                keyValue: 1,
                column: "ImageURL",
                value: "#");

            migrationBuilder.UpdateData(
                table: "KitchenType",
                keyColumn: "ID",
                keyValue: 2,
                column: "Name",
                value: "Spansk");

            migrationBuilder.UpdateData(
                table: "Setting",
                keyColumn: "ID",
                keyValue: 1,
                column: "Distance",
                value: 5);
        }
    }
}
