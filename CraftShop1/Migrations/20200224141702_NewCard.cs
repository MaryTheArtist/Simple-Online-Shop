using Microsoft.EntityFrameworkCore.Migrations;

namespace CraftShop1.Migrations
{
    public partial class NewCard : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemId", "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "InStock", "Name", "Notes", "Price" },
                values: new object[] { 11, 3, "Greeting card", "/images/card.jpg", "/images/card.jpg", false, "Card", null, 15.95m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 11);
        }
    }
}
