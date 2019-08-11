using Microsoft.EntityFrameworkCore.Migrations;

namespace E_Commerce.Migrations
{
    public partial class newdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BasketItems",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BasketItems",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BasketItems",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BasketItems",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Baskets",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Description", "Image", "Name", "Sku" },
                values: new object[] { "Stick on beard and mustache. Glue not included", "https://beardibilityblob.blob.core.windows.net/productimages/baron.png", "The Baron", "BEAR001" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Description", "Image", "Name", "Price", "Sku" },
                values: new object[] { "Stick on beard and mustache. Glue not included", "https://beardibilityblob.blob.core.windows.net/productimages/czar.png", "The Czar", 10.00m, "BEAR002" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Description", "Image", "Name", "Sku" },
                values: new object[] { "Stick on beard and mustache. Glue not included", "https://beardibilityblob.blob.core.windows.net/productimages/dandy.png", "The Dandy", "BEAR003" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Description", "Image", "Name", "Price", "Sku" },
                values: new object[] { "Stick on beard and mustache. Glue not included", "https://beardibilityblob.blob.core.windows.net/productimages/barrister.png", "The Barrister", 10.00m, "BEAR005" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Description", "Image", "Name", "Sku" },
                values: new object[] { "Stick on mustache and sideburns. Glue not included", "https://beardibilityblob.blob.core.windows.net/productimages/duke.png", "The Duke", "MUST001" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Description", "Image", "Name", "Price", "Sku" },
                values: new object[] { "Stick on goatee and mustache. Glue not included", "https://beardibilityblob.blob.core.windows.net/productimages/empereur.png", "The Empereur", 7.00m, "GOAT001" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "Description", "Image", "Name", "Price", "Sku" },
                values: new object[] { "Stick on beard. Glue not included", "https://beardibilityblob.blob.core.windows.net/productimages/farmer.png", "The Farmer", 8.00m, "BEAR006" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "Description", "Image", "Name", "Price", "Sku" },
                values: new object[] { "Stick on mutton-chops and mustache. Glue not included", "https://beardibilityblob.blob.core.windows.net/productimages/kaiser.png", "The Kaiser", 8.00m, "MUTT002" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "Description", "Image", "Name", "Sku" },
                values: new object[] { "Stick on goatee and mustache. Glue not included", "https://beardibilityblob.blob.core.windows.net/productimages/magician.png", "The Magician", "GOAT002" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "Description", "Image", "Name", "Price", "Sku" },
                values: new object[,]
                {
                    { 2, "Stick on mustache and mutton-chops. Glue not included", "https://beardibilityblob.blob.core.windows.net/productimages/butcher.png", "The Butcher", 8.00m, "MUTT001" },
                    { 11, "Stick on beard and mustache. Glue not included", "https://beardibilityblob.blob.core.windows.net/productimages/mariner.png", "The Mariner", 10.00m, "BEAR007" },
                    { 12, "Glue for all stick on facial hair. Alcohol soluble.", "https://beardibilityblob.blob.core.windows.net/productimages/facial_glue.jpg", "Facial Glue", 5.00m, "ACCE001" },
                    { 13, "Beard oil for every gentleman.", "https://beardibilityblob.blob.core.windows.net/productimages/beard_oil.jpg", "Gentlemen's Beard Oil", 5.00m, "GROO001" },
                    { 14, "Specially designed comb and brush for facial hair.", "https://beardibilityblob.blob.core.windows.net/productimages/brush_set.jpg", "Comb and Brush Set", 8.00m, "GROO002" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.InsertData(
                table: "Baskets",
                columns: new[] { "ID", "Email" },
                values: new object[] { 1, "admin@admin.com" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Description", "Image", "Name", "Sku" },
                values: new object[] { "Stick on full beard. Glue not included", "http://placebeard.it/g/100/125", "Full Beard", "001Bear" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Description", "Image", "Name", "Price", "Sku" },
                values: new object[] { "Stick on soul patch. Glue not included", "http://placebeard.it/g/100/125", "Soul Patch", 2.00m, "003Soul" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Description", "Image", "Name", "Sku" },
                values: new object[] { "Full beard with hooks to hang off of ears.", "http://placebeard.it/g/100/125", "Old School Hook Beard", "004Hook" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Description", "Image", "Name", "Price", "Sku" },
                values: new object[] { "Long Fu-Man-Chu stick on mustache. Glue not included.", "http://placebeard.it/g/100/125", "Long Fu-Man-Chu Mustache", 8.00m, "005Fu" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Description", "Image", "Name", "Sku" },
                values: new object[] { "Short Fu-Man-Chu stick on mustache. Glue not included", "http://placebeard.it/g/100/125", "Short Fu-Man-Chu Mustache", "006FuS" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Description", "Image", "Name", "Price", "Sku" },
                values: new object[] { "Spray that allows for realistic looking 5'oclock shadow. Alcohol soluble.", "http://placebeard.it/g/100/125", "5'oclock Shadow Spray", 15.00m, "007Shadow" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "Description", "Image", "Name", "Price", "Sku" },
                values: new object[] { "Glue for all stick on facial hair. Alcohol soluble.", "http://placebeard.it/g/100/125", "Facial Glue", 5.00m, "008Glue" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "Description", "Image", "Name", "Price", "Sku" },
                values: new object[] { "Specially designed comb for facial hair.", "http://placebeard.it/g/100/125", "Facial Hair Comb", 5.00m, "009Comb" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "Description", "Image", "Name", "Sku" },
                values: new object[] { "Stick on mutton chops. Glue not included", "http://placebeard.it/g/100/125", "Mutton Chops", "010Chops" });

            migrationBuilder.InsertData(
                table: "BasketItems",
                columns: new[] { "ID", "BasketID", "Image", "Name", "Price", "ProductID", "Quanity", "Sku" },
                values: new object[,]
                {
                    { 1, 1, "http://placebeard.it/g/100/125", "Seed1", 10.00m, 1, 4, "Seedy" },
                    { 2, 1, "http://placebeard.it/g/100/125", "Seed2", 20.00m, 4, 2, "Seedy" },
                    { 3, 1, "http://placebeard.it/g/100/125", "Seed3", 40.00m, 5, 3, "Seedy" },
                    { 4, 1, "http://placebeard.it/g/100/125", "Seed4", 10.00m, 7, 8, "Seedy" }
                });
        }
    }
}
