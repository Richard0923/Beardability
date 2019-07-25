using Microsoft.EntityFrameworkCore.Migrations;

namespace E_Commerce.Migrations
{
    public partial class tryANew2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Baskets",
                columns: new[] { "ID", "Email" },
                values: new object[] { 1, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "BasketItems",
                columns: new[] { "ID", "BasketID", "ProductID", "Quanity" },
                values: new object[,]
                {
                    { 1, 1, 1, 4 },
                    { 2, 1, 4, 2 },
                    { 3, 1, 5, 3 },
                    { 4, 1, 7, 8 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
