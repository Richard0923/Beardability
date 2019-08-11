using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace E_Commerce.Migrations
{
    public partial class AddingOrdersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Baskets",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Baskets", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CustomerName = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    TotalPrice = table.Column<int>(nullable: false),
                    ShipppingAddress = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Sku = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "BasketItems",
                columns: table => new
                {
                    BasketID = table.Column<int>(nullable: false),
                    ProductID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Sku = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Image = table.Column<string>(nullable: true),
                    Quanity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasketItems", x => new { x.BasketID, x.ProductID });
                    table.ForeignKey(
                        name: "FK_BasketItems_Baskets_BasketID",
                        column: x => x.BasketID,
                        principalTable: "Baskets",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasketItems_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    ProductID = table.Column<int>(nullable: false),
                    OrderID = table.Column<int>(nullable: false),
                    Quanity = table.Column<int>(nullable: false),
                    TotalItemPrice = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => new { x.ProductID, x.OrderID });
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "Description", "Image", "Name", "Price", "Sku" },
                values: new object[,]
                {
                    { 1, "Stick on full beard. Glue not included", "http://placebeard.it/g/100/125", "The Baron", 10.00m, "Bear001" },
                    { 3, "Stick on soul patch. Glue not included", "http://placebeard.it/g/100/125", "Soul Patch", 2.00m, "003Soul" },
                    { 4, "Full beard with hooks to hang off of ears.", "http://placebeard.it/g/100/125", "Old School Hook Beard", 10.00m, "004Hook" },
                    { 5, "Long Fu-Man-Chu stick on mustache. Glue not included.", "http://placebeard.it/g/100/125", "Long Fu-Man-Chu Mustache", 8.00m, "005Fu" },
                    { 6, "Short Fu-Man-Chu stick on mustache. Glue not included", "http://placebeard.it/g/100/125", "Short Fu-Man-Chu Mustache", 5.00m, "006FuS" },
                    { 7, "Spray that allows for realistic looking 5'oclock shadow. Alcohol soluble.", "http://placebeard.it/g/100/125", "5'oclock Shadow Spray", 15.00m, "007Shadow" },
                    { 8, "Glue for all stick on facial hair. Alcohol soluble.", "http://placebeard.it/g/100/125", "Facial Glue", 5.00m, "008Glue" },
                    { 9, "Specially designed comb for facial hair.", "http://placebeard.it/g/100/125", "Facial Hair Comb", 5.00m, "009Comb" },
                    { 10, "Stick on mutton chops. Glue not included", "http://placebeard.it/g/100/125", "Mutton Chops", 7.00m, "010Chops" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BasketItems_ProductID",
                table: "BasketItems",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderID",
                table: "OrderItems",
                column: "OrderID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BasketItems");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Baskets");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
