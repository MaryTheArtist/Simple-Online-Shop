using Microsoft.EntityFrameworkCore.Migrations;

namespace CraftShop1.Migrations
{
    public partial class NotesAddedToItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Items",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Items");
        }
    }
}
