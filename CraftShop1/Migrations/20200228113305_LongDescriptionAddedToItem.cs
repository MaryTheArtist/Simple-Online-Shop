using Microsoft.EntityFrameworkCore.Migrations;

namespace CraftShop1.Migrations
{
    public partial class LongDescriptionAddedToItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LongDescription",
                table: "Items",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LongDescription",
                table: "Items");
        }
    }
}
