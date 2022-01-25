using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodDeliveryApp.Server.Data.Migrations
{
    public partial class Added_ApplicationTables_Seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeliveryAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MenuItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Staffs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Staffs_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    StaffId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Staffs_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staffs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Deliveries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeliveryDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeliveryAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    StaffId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deliveries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Deliveries_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Deliveries_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Deliveries_Staffs_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staffs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    MenuItemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_MenuItems_MenuItemId",
                        column: x => x.MenuItemId,
                        principalTable: "MenuItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payments_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "Id", "Address", "ContactNumber", "Name" },
                values: new object[,]
                {
                    { 1, "311 New Upper Changi Road, #B2-K1, Bedok Mall", "85699938", "Pezzo SG | Bedok Mall" },
                    { 2, "53 Ang Mo Kio Ave 3, #B2-38, AMK Hub", "94673609", "Pezzo SG | AMK" },
                    { 3, "50 Jurong Gateway Road, #B1-K07, Jem", "86085498", "Pezzo SG | Jem" },
                    { 4, "23 Serangoon Central, #B2-67, NEX", "95560839", "Pezzo SG | NEX" },
                    { 5, "1 Harbourfront Walk, #B2-K15, VivoCity", "80985858", "Pezzo SG | VivoCity" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "ContactNumber", "DateOfBirth", "DeliveryAddress", "EmailAddress", "FirstName", "Gender", "LastName" },
                values: new object[,]
                {
                    { 4, "98767777", new DateTime(1977, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hougang Avenue 7, #07-7777", "cheryltann@mailhot.com", "Cheryl", "Female", "Tan" },
                    { 3, "88880962", new DateTime(1984, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "815 Tampines Avenue 4, #05-6077", "carrielim@hooya.com", "Carrie", "Female", "Lim" },
                    { 5, "99990962", new DateTime(1996, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "266 Serangoon Central Drive, #03-1111", "thomastan@inlook.com", "Thomas", "Male", "Tan" },
                    { 1, "98760962", new DateTime(1980, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "509 Tampines Central 1, #20-2011", "thedesmondwong@geemail.com", "Desmond", "Male", "Wong" },
                    { 2, "99761562", new DateTime(1970, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "510 Tampines Central 1, #15-7099", "panglawrence@geemail.com", "Lawrence", "Male", "Pang" }
                });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Cost", "ImageUrl", "Name", "Type" },
                values: new object[,]
                {
                    { 9, 9.90m, "images/chocLavaCake.jpg", "Hot Chocolate Lava Cake", "Dessert" },
                    { 1, 9.90m, "images/aloha.jpg", "Aloha", "Pizza" },
                    { 2, 9.90m, "images/pepperoni.jpg", "Pepperoni", "Pizza" },
                    { 3, 9.90m, "images/sanRemo.jpg", "San Remo", "Pizza" },
                    { 4, 9.90m, "images/teriyakiChicken.jpg", "Teriyaki Chicken", "Pizza" },
                    { 5, 2.90m, "images/cocaCola.png", "Coca-Cola", "Beverage" },
                    { 6, 2.90m, "images/greenTea.jpg", "Green Tea", "Beverage" },
                    { 7, 2.90m, "images/tea.jpg", "Hot Tea", "Beverage" },
                    { 8, 2.90m, "images/coffee.jpg", "Hot Coffee", "Beverage" },
                    { 10, 8.90m, "images/tiramisu.jpg", "Tiramisu", "Dessert" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "BranchId", "CustomerId", "OrderDateTime", "StaffId" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, 1, 2, new DateTime(2022, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, 1, 3, new DateTime(2022, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4, 1, 4, new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5, 1, 5, new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "BranchId", "ContactNumber", "EmailAddress", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, 1, "98765432", "lisalim@geemail.com", "Lisa", "Lim" },
                    { 2, 2, "99765433", "tanjacob@geemail.com", "Jacob", "Tan" },
                    { 3, 3, "98744434", "jonaslim@geemail.com", "Jonas", "Lim" },
                    { 4, 4, "98762222", "phuamatthew@geemail.com", "Matthew", "Phua" },
                    { 5, 5, "98768882", "kwokowen@geemail.com", "Owen", "Kwok" }
                });

            migrationBuilder.InsertData(
                table: "Deliveries",
                columns: new[] { "Id", "CustomerId", "DeliveryAddress", "DeliveryDateTime", "OrderId", "StaffId" },
                values: new object[,]
                {
                    { 1, null, "509 Tampines Central 1, #20-2011", new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null },
                    { 5, null, "266 Serangoon Central Drive, #03-1111", new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, null },
                    { 4, null, "Hougang Avenue 7, #07-7777", new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, null },
                    { 2, null, "510 Tampines Central 1, #15-7099", new DateTime(2022, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null },
                    { 3, null, "815 Tampines Avenue 4, #05-6077", new DateTime(2022, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "MenuItemId", "OrderId", "Quantity" },
                values: new object[,]
                {
                    { 3, 1, 2, 1 },
                    { 4, 10, 2, 1 },
                    { 7, 3, 5, 5 },
                    { 5, 3, 3, 5 },
                    { 2, 5, 1, 1 },
                    { 6, 3, 4, 5 },
                    { 1, 1, 1, 2 }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "Id", "Amount", "OrderId", "PaymentDateTime", "PaymentMethod" },
                values: new object[,]
                {
                    { 2, 18.80m, 2, new DateTime(2022, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Debit Card" },
                    { 3, 49.50m, 3, new DateTime(2022, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Debit Card" },
                    { 4, 49.50m, 4, new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Credit Card" },
                    { 1, 22.70m, 1, new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Credit Card" },
                    { 5, 49.50m, 5, new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Credit Card" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Deliveries_CustomerId",
                table: "Deliveries",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Deliveries_OrderId",
                table: "Deliveries",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Deliveries_StaffId",
                table: "Deliveries",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_MenuItemId",
                table: "OrderItems",
                column: "MenuItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_BranchId",
                table: "Orders",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_StaffId",
                table: "Orders",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_OrderId",
                table: "Payments",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_BranchId",
                table: "Staffs",
                column: "BranchId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Deliveries");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "MenuItems");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Staffs");

            migrationBuilder.DropTable(
                name: "Branches");
        }
    }
}
