using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Badge",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ImageURL = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Badge", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RestaurantId = table.Column<int>(nullable: false),
                    URL = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "KitchenType",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KitchenType", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RestaurantName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Priceclass",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PriceclassValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Priceclass", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MenuItem",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(type: "decimal(4,2)", nullable: false),
                    MenuId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItem", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MenuItem_Menu_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menu",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Restaurant",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Priceclass = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Zipcode = table.Column<int>(nullable: false),
                    Phonenumber = table.Column<string>(nullable: true),
                    MenuId = table.Column<int>(nullable: false),
                    UserID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurant", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Restaurant_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Setting",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Distance = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Setting", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Setting_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RestaurantBadge",
                columns: table => new
                {
                    RestaurantId = table.Column<int>(nullable: false),
                    BadgeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestaurantBadge", x => new { x.RestaurantId, x.BadgeId });
                    table.ForeignKey(
                        name: "FK_RestaurantBadge_Badge_BadgeId",
                        column: x => x.BadgeId,
                        principalTable: "Badge",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RestaurantBadge_Restaurant_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurant",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RestaurantKitchenType",
                columns: table => new
                {
                    RestaurantId = table.Column<int>(nullable: false),
                    KitchenTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestaurantKitchenType", x => new { x.RestaurantId, x.KitchenTypeId });
                    table.ForeignKey(
                        name: "FK_RestaurantKitchenType_KitchenType_KitchenTypeId",
                        column: x => x.KitchenTypeId,
                        principalTable: "KitchenType",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RestaurantKitchenType_Restaurant_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurant",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SettingKitchenType",
                columns: table => new
                {
                    SettingId = table.Column<int>(nullable: false),
                    KitchenTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SettingKitchenType", x => new { x.SettingId, x.KitchenTypeId });
                    table.ForeignKey(
                        name: "FK_SettingKitchenType_KitchenType_KitchenTypeId",
                        column: x => x.KitchenTypeId,
                        principalTable: "KitchenType",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SettingKitchenType_Setting_SettingId",
                        column: x => x.SettingId,
                        principalTable: "Setting",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SettingPriceclass",
                columns: table => new
                {
                    SettingId = table.Column<int>(nullable: false),
                    PriceclassId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SettingPriceclass", x => new { x.SettingId, x.PriceclassId });
                    table.ForeignKey(
                        name: "FK_SettingPriceclass_Priceclass_PriceclassId",
                        column: x => x.PriceclassId,
                        principalTable: "Priceclass",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SettingPriceclass_Setting_SettingId",
                        column: x => x.SettingId,
                        principalTable: "Setting",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Badge",
                columns: new[] { "ID", "ImageURL", "Name" },
                values: new object[] { 1, "#", "Vegetarmærket" });

            migrationBuilder.InsertData(
                table: "Image",
                columns: new[] { "ID", "RestaurantId", "URL" },
                values: new object[] { 1, 1, "#" });

            migrationBuilder.InsertData(
                table: "KitchenType",
                columns: new[] { "ID", "Name" },
                values: new object[] { 1, "Dansk" });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "ID", "RestaurantName" },
                values: new object[] { 1, "Café Smagløs" });

            migrationBuilder.InsertData(
                table: "Priceclass",
                columns: new[] { "ID", "PriceclassValue" },
                values: new object[] { 1, "$" });

            migrationBuilder.InsertData(
                table: "Restaurant",
                columns: new[] { "ID", "Address", "Description", "MenuId", "Name", "Phonenumber", "Priceclass", "UserID", "Zipcode" },
                values: new object[] { 1, "Klostertorvet 7", "Cafe Smagløs Aarhus C er en café med alt det, man forventer en cafe har. Brunch, burger, sandwich m.m. Der er tilmed en hyggelig stemning såvel ude som inde. Af og til har de bands til at komme og spille, så aftenen bliver en ekstra oplevelse. Sæt dig med en drink og nyd stemningen.", 1, "Cafe Smagløs", "+45 123 456 78", "$", null, 8000 });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "ID", "Location", "Password", "Username" },
                values: new object[] { 1, "Aarhus C", "Password", "Admin" });

            migrationBuilder.InsertData(
                table: "MenuItem",
                columns: new[] { "ID", "MenuId", "Price", "Title" },
                values: new object[] { 1, 1, 50.99m, "Stegt flæsk med persillesovs" });

            migrationBuilder.InsertData(
                table: "RestaurantBadge",
                columns: new[] { "RestaurantId", "BadgeId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "RestaurantKitchenType",
                columns: new[] { "RestaurantId", "KitchenTypeId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "Setting",
                columns: new[] { "ID", "Distance", "UserId" },
                values: new object[] { 1, 5, 1 });

            migrationBuilder.InsertData(
                table: "SettingKitchenType",
                columns: new[] { "SettingId", "KitchenTypeId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "SettingPriceclass",
                columns: new[] { "SettingId", "PriceclassId" },
                values: new object[] { 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_MenuItem_MenuId",
                table: "MenuItem",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_Restaurant_UserID",
                table: "Restaurant",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantBadge_BadgeId",
                table: "RestaurantBadge",
                column: "BadgeId");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantKitchenType_KitchenTypeId",
                table: "RestaurantKitchenType",
                column: "KitchenTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Setting_UserId",
                table: "Setting",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SettingKitchenType_KitchenTypeId",
                table: "SettingKitchenType",
                column: "KitchenTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SettingPriceclass_PriceclassId",
                table: "SettingPriceclass",
                column: "PriceclassId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Image");

            migrationBuilder.DropTable(
                name: "MenuItem");

            migrationBuilder.DropTable(
                name: "RestaurantBadge");

            migrationBuilder.DropTable(
                name: "RestaurantKitchenType");

            migrationBuilder.DropTable(
                name: "SettingKitchenType");

            migrationBuilder.DropTable(
                name: "SettingPriceclass");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "Badge");

            migrationBuilder.DropTable(
                name: "Restaurant");

            migrationBuilder.DropTable(
                name: "KitchenType");

            migrationBuilder.DropTable(
                name: "Priceclass");

            migrationBuilder.DropTable(
                name: "Setting");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
