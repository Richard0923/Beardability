using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace E_Commerce.Migrations
{
    public partial class seed_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "Description", "Image", "Name", "Price", "Sku" },
                values: new object[,]
                {
                    { 1, "Stick on full beard. Glue not included", "http://placebeard.it/g/100/125", "Full Beard", 10.00m, "001Bear" },
                    { 3, "Stick on soul patch. Glue not included", "http://placebeard.it/g/100/125", "Soul Patch", 2.00m, "003Soul" },
                    { 4, "Full beard with hooks to hang off of ears.", "http://placebeard.it/g/100/125", "Old School Hook Beard", 10.00m, "004Hook" },
                    { 5, "Long Fu-Man-Chu stick on mustache. Glue not included.", "http://placebeard.it/g/100/125", "Long Fu-Man-Chu Mustache", 8.00m, "005Fu" },
                    { 6, "Short Fu-Man-Chu stick on mustache. Glue not included", "http://placebeard.it/g/100/125", "Short Fu-Man-Chu Mustache", 5.00m, "006FuS" },
                    { 7, "Spray that allows for realistic looking 5'oclock shadow. Alcohol soluble.", "http://placebeard.it/g/100/125", "5'oclock Shadow Spray", 15.00m, "007Shadow" },
                    { 8, "Glue for all stick on facial hair. Alcohol soluble.", "http://placebeard.it/g/100/125", "Facial Glue", 5.00m, "008Glue" },
                    { 9, "Specially designed comb for facial hair.", "http://placebeard.it/g/100/125", "Facial Hair Comb", 5.00m, "009Comb" },
                    { 10, "Stick on mutton chops. Glue not included", "http://placebeard.it/g/100/125", "Mutton Chops", 7.00m, "010Chops" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
