using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace E_Commerce.Migrations
{
    public partial class Initial : Migration
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
                    { 1, "Stick on beard and mustache. Glue not included", "https://beardibilityblob.blob.core.windows.net/productimages/baron.png", "The Baron", 10.00m, "BEAR001" },
                    { 2, "Stick on mustache and mutton-chops. Glue not included", "https://beardibilityblob.blob.core.windows.net/productimages/butcher.png", "The Butcher", 8.00m, "MUTT001" },
                    { 3, "Stick on beard and mustache. Glue not included", "https://beardibilityblob.blob.core.windows.net/productimages/czar.png", "The Czar", 10.00m, "BEAR002" },
                    { 4, "Stick on beard and mustache. Glue not included", "https://beardibilityblob.blob.core.windows.net/productimages/dandy.png", "The Dandy", 10.00m, "BEAR003" },
                    { 5, "Stick on beard and mustache. Glue not included", "https://beardibilityblob.blob.core.windows.net/productimages/barrister.png", "The Barrister", 10.00m, "BEAR005" },
                    { 6, "Stick on mustache and sideburns. Glue not included", "https://beardibilityblob.blob.core.windows.net/productimages/duke.png", "The Duke", 5.00m, "MUST001" },
                    { 7, "Stick on goatee and mustache. Glue not included", "https://beardibilityblob.blob.core.windows.net/productimages/empereur.png", "The Empereur", 7.00m, "GOAT001" },
                    { 8, "Stick on beard. Glue not included", "https://beardibilityblob.blob.core.windows.net/productimages/farmer.png", "The Farmer", 8.00m, "BEAR006" },
                    { 9, "Stick on mutton-chops and mustache. Glue not included", "https://beardibilityblob.blob.core.windows.net/productimages/kaiser.png", "The Kaiser", 8.00m, "MUTT002" },
                    { 10, "Stick on goatee and mustache. Glue not included", "https://beardibilityblob.blob.core.windows.net/productimages/magician.png", "The Magician", 7.00m, "GOAT002" },
                    { 11, "Stick on beard and mustache. Glue not included", "https://beardibilityblob.blob.core.windows.net/productimages/mariner.png", "The Mariner", 10.00m, "BEAR007" },
                    { 12, "Glue for all stick on facial hair. Alcohol soluble.", "https://beardibilityblob.blob.core.windows.net/productimages/facial_glue.jpg", "Facial Glue", 5.00m, "ACCE001" },
                    { 13, "Beard oil for every gentleman.", "https://beardibilityblob.blob.core.windows.net/productimages/beard_oil.jpg", "Gentlemen's Beard Oil", 5.00m, "GROO001" },
                    { 14, "Specially designed comb and brush for facial hair.", "https://beardibilityblob.blob.core.windows.net/productimages/brush_set.jpg", "Comb and Brush Set", 8.00m, "GROO002" }
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
