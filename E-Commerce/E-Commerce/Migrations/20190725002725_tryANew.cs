using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace E_Commerce.Migrations
{
    public partial class tryANew : Migration
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
                name: "Products",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Sku = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Quanity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "BasketItems",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BasketID = table.Column<int>(nullable: false),
                    ProductID = table.Column<int>(nullable: false),
                    Quanity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasketItems", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BasketItems_Baskets_BasketID",
                        column: x => x.BasketID,
                        principalTable: "Baskets",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "Description", "Image", "Name", "Price", "Quanity", "Sku" },
                values: new object[,]
                {
                    { 1, "Stick on full beard. Glue not included", "http://placebeard.it/g/100/125", "Full Beard", 10.00m, 0, "001Bear" },
                    { 3, "Stick on soul patch. Glue not included", "http://placebeard.it/g/100/125", "Soul Patch", 2.00m, 0, "003Soul" },
                    { 4, "Full beard with hooks to hang off of ears.", "http://placebeard.it/g/100/125", "Old School Hook Beard", 10.00m, 0, "004Hook" },
                    { 5, "Long Fu-Man-Chu stick on mustache. Glue not included.", "http://placebeard.it/g/100/125", "Long Fu-Man-Chu Mustache", 8.00m, 0, "005Fu" },
                    { 6, "Short Fu-Man-Chu stick on mustache. Glue not included", "http://placebeard.it/g/100/125", "Short Fu-Man-Chu Mustache", 5.00m, 0, "006FuS" },
                    { 7, "Spray that allows for realistic looking 5'oclock shadow. Alcohol soluble.", "http://placebeard.it/g/100/125", "5'oclock Shadow Spray", 15.00m, 0, "007Shadow" },
                    { 8, "Glue for all stick on facial hair. Alcohol soluble.", "http://placebeard.it/g/100/125", "Facial Glue", 5.00m, 0, "008Glue" },
                    { 9, "Specially designed comb for facial hair.", "http://placebeard.it/g/100/125", "Facial Hair Comb", 5.00m, 0, "009Comb" },
                    { 10, "Stick on mutton chops. Glue not included", "http://placebeard.it/g/100/125", "Mutton Chops", 7.00m, 0, "010Chops" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BasketItems_BasketID",
                table: "BasketItems",
                column: "BasketID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BasketItems");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Baskets");
        }
    }
}
