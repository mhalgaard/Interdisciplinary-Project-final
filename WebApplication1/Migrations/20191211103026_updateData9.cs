using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class updateData9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "MenuItem",
                type: "decimal(5,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(4,2)");

            migrationBuilder.InsertData(
                table: "KitchenType",
                columns: new[] { "ID", "Name" },
                values: new object[] { 5, "Amerikansk" });

            migrationBuilder.InsertData(
                table: "Restaurant",
                columns: new[] { "ID", "Address", "Description", "Name", "Phonenumber", "Priceclass", "Zipcode" },
                values: new object[] { 3, "Christiansgade 32", "“It doesn’t have to be fancy to be damm good!” That’s our humble creed here at Memphis Roadhouse.Using only the freshest local ingredients – prepared to the highest standard – we offer all the hospitality and soul of an authentic Southern barbeque joint.", "Memphis Roadhouse", "+45 87 300 400", "$$", 8000 });

            migrationBuilder.InsertData(
                table: "Restaurant",
                columns: new[] { "ID", "Address", "Description", "Name", "Phonenumber", "Priceclass", "Zipcode" },
                values: new object[] { 4, "Vesterport 10", "På Møf laver vi mad med en omhyggelighed, bevidsthed og respekt for de enkelte råvarer, der alle kommer til orde i vores tre forretter, tre hovedretter og tre desserter. Vores kærlighed til mad omfatter en konstant udvikling og en lyst til at eksperimentere. Derfor skifter vi menu hver måned, og vi er ikke blege for at få inspiration og plukke smage fra internationale køkkener, så længe det er i harmoni med den danske sæson.", "Restaurant Møf", "+45 6173 3333", "$$$", 8000 });

            migrationBuilder.InsertData(
                table: "Image",
                columns: new[] { "ID", "RestaurantId", "URL" },
                values: new object[,]
                {
                    { 3, 3, "..img/memphisroadhouse.jpg" },
                    { 4, 4, "..img/restaurantmof.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "ID", "RestaurantId" },
                values: new object[,]
                {
                    { 3, 3 },
                    { 4, 4 }
                });

            migrationBuilder.InsertData(
                table: "RestaurantBadges",
                columns: new[] { "RestaurantId", "BadgeId" },
                values: new object[,]
                {
                    { 3, 3 },
                    { 4, 3 }
                });

            migrationBuilder.InsertData(
                table: "RestaurantKitchenType",
                columns: new[] { "RestaurantId", "KitchenTypeId" },
                values: new object[,]
                {
                    { 3, 5 },
                    { 4, 4 },
                    { 4, 3 }
                });

            migrationBuilder.InsertData(
                table: "MenuItem",
                columns: new[] { "ID", "Categories", "MenuId", "Price", "Title" },
                values: new object[,]
                {
                    { 4, 1, 3, 149.00m, "Kansas City Big Rigs" },
                    { 5, 1, 3, 139.00m, "Beef Brisket" },
                    { 6, 2, 3, 60.00m, "Cookie Skillet" },
                    { 7, 1, 4, 109.00m, "Let grillet fisk med hummer creme, silderogn, syltet græskar og havtorn" },
                    { 8, 2, 4, 99.00m, "3 franske råmælkeost med kompot og knækbrød" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "RestaurantBadges",
                keyColumns: new[] { "RestaurantId", "BadgeId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "RestaurantBadges",
                keyColumns: new[] { "RestaurantId", "BadgeId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "RestaurantKitchenType",
                keyColumns: new[] { "RestaurantId", "KitchenTypeId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "RestaurantKitchenType",
                keyColumns: new[] { "RestaurantId", "KitchenTypeId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "RestaurantKitchenType",
                keyColumns: new[] { "RestaurantId", "KitchenTypeId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "KitchenType",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "MenuItem",
                type: "decimal(4,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)");
        }
    }
}
