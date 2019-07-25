using Microsoft.EntityFrameworkCore.Migrations;

namespace E_Commerce.Migrations
{
    public partial class addingdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quanity",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "BasketItems",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "BasketItems",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "BasketItems",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Sku",
                table: "BasketItems",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "BasketItems",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Image", "Name", "Price", "Sku" },
                values: new object[] { "http://placebeard.it/g/100/125", "Seed1", 10.00m, "Seedy" });

            migrationBuilder.UpdateData(
                table: "BasketItems",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Image", "Name", "Price", "Sku" },
                values: new object[] { "http://placebeard.it/g/100/125", "Seed2", 20.00m, "Seedy" });

            migrationBuilder.UpdateData(
                table: "BasketItems",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Image", "Name", "Price", "Sku" },
                values: new object[] { "http://placebeard.it/g/100/125", "Seed3", 40.00m, "Seedy" });

            migrationBuilder.UpdateData(
                table: "BasketItems",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Image", "Name", "Price", "Sku" },
                values: new object[] { "http://placebeard.it/g/100/125", "Seed4", 10.00m, "Seedy" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "BasketItems");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "BasketItems");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "BasketItems");

            migrationBuilder.DropColumn(
                name: "Sku",
                table: "BasketItems");

            migrationBuilder.AddColumn<int>(
                name: "Quanity",
                table: "Products",
                nullable: false,
                defaultValue: 0);
        }
    }
}
