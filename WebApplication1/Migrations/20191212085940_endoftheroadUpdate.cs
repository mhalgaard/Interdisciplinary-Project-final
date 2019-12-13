using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class endoftheroadUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Restaurant",
                columns: new[] { "ID", "Address", "Description", "Name", "Phonenumber", "Priceclass", "Zipcode" },
                values: new object[] { 5, null, null, "Du er nået til vejs ende...", null, "Der er desværre ikke flere restauranter i dette område, udvid evt. distancen der søges indenfor på filtersiden.", 0 });

            migrationBuilder.InsertData(
                table: "Image",
                columns: new[] { "ID", "RestaurantId", "URL" },
                values: new object[] { 5, 5, "../img/End_of_the_road.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "ID",
                keyValue: 5);
        }
    }
}
