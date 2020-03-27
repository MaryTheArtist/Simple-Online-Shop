using Microsoft.EntityFrameworkCore.Migrations;

namespace CraftShop1.Migrations
{
    public partial class SeedNeweightItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemId", "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "InStock", "LongDescription", "Name", "Notes", "Price" },
                values: new object[,]
                {
                    { 12, 2, "Bayern Munchen Fans", "https://scontent-sof1-1.xx.fbcdn.net/v/t1.0-9/74905581_2550946021847348_7754944008505262080_n.jpg?_nc_cat=107&_nc_sid=a61e81&_nc_ohc=z6RMxoZX4WgAX_W1YZU&_nc_ht=scontent-sof1-1.xx&oh=94c9e11be567ac286a5d3de10cecec46&oe=5F029B03", "https://scontent-sof1-1.xx.fbcdn.net/v/t1.0-9/74905581_2550946021847348_7754944008505262080_n.jpg?_nc_cat=107&_nc_sid=a61e81&_nc_ohc=z6RMxoZX4WgAX_W1YZU&_nc_ht=scontent-sof1-1.xx&oh=94c9e11be567ac286a5d3de10cecec46&oe=5F029B03", true, "Handmade bottle with technique decoupage for Bayern Munchen Fans.", "Bottle BM", null, 19.95m },
                    { 13, 2, "Manchester United Fans", "https://scontent-sof1-1.xx.fbcdn.net/v/t1.0-9/74228921_2550057448602872_8694976358050168832_n.jpg?_nc_cat=103&_nc_sid=a61e81&_nc_ohc=oDfL4KEymYEAX-6kSLo&_nc_ht=scontent-sof1-1.xx&oh=bfaa03be4c07b2b5bb97208e3d5b6227&oe=5EF23675", "https://scontent-sof1-1.xx.fbcdn.net/v/t1.0-9/74228921_2550057448602872_8694976358050168832_n.jpg?_nc_cat=103&_nc_sid=a61e81&_nc_ohc=oDfL4KEymYEAX-6kSLo&_nc_ht=scontent-sof1-1.xx&oh=bfaa03be4c07b2b5bb97208e3d5b6227&oe=5EF23675", true, "Handmade bottle with technique decoupage for Manchester United Fans.", "Bottle MU", null, 18.95m },
                    { 18, 2, "Ludogoretz Fans", "https://scontent-sof1-1.xx.fbcdn.net/v/t1.0-9/s960x960/73128524_2546586282283322_8173801618781765632_o.jpg?_nc_cat=110&_nc_sid=a61e81&_nc_ohc=mNg6jo7FSzYAX90Sb6l&_nc_ht=scontent-sof1-1.xx&_nc_tp=7&oh=b0226573c0738250119a0961fa62b1cd&oe=5EF58707", "https://scontent-sof1-1.xx.fbcdn.net/v/t1.0-9/s960x960/73128524_2546586282283322_8173801618781765632_o.jpg?_nc_cat=110&_nc_sid=a61e81&_nc_ohc=mNg6jo7FSzYAX90Sb6l&_nc_ht=scontent-sof1-1.xx&_nc_tp=7&oh=b0226573c0738250119a0961fa62b1cd&oe=5EF58707", false, "Handmade bottle with technique decoupage for Ludogoretz Fans.", "Bottle L", null, 29.95m },
                    { 14, 2, "Milan Fans", "https://scontent-sof1-1.xx.fbcdn.net/v/t1.0-9/72632769_2524096181198999_1359356955910471680_n.jpg?_nc_cat=108&_nc_sid=a61e81&_nc_ohc=4dhfxZZ_vxUAX-g5I1p&_nc_ht=scontent-sof1-1.xx&oh=d4917d783fbad6bf56aa15580bfe2a9c&oe=5EF0F38E", "https://scontent-sof1-1.xx.fbcdn.net/v/t1.0-9/72632769_2524096181198999_1359356955910471680_n.jpg?_nc_cat=108&_nc_sid=a61e81&_nc_ohc=4dhfxZZ_vxUAX-g5I1p&_nc_ht=scontent-sof1-1.xx&oh=d4917d783fbad6bf56aa15580bfe2a9c&oe=5EF0F38E", false, "Handmade bottle with technique decoupage for Milan Fans.", "Bottle M", null, 29.95m },
                    { 15, 4, "Handmade Recipes Book", "https://scontent-sof1-1.xx.fbcdn.net/v/t1.0-9/75442937_2572659076342709_3677204540450406400_n.jpg?_nc_cat=104&_nc_sid=a61e81&_nc_ohc=NFLmVZC8YYoAX9S87X1&_nc_ht=scontent-sof1-1.xx&oh=f910228e2d002515bdb81e1b22ef0a40&oe=5EB95E54", "https://scontent-sof1-1.xx.fbcdn.net/v/t1.0-9/75442937_2572659076342709_3677204540450406400_n.jpg?_nc_cat=104&_nc_sid=a61e81&_nc_ohc=NFLmVZC8YYoAX9S87X1&_nc_ht=scontent-sof1-1.xx&oh=f910228e2d002515bdb81e1b22ef0a40&oe=5EB95E54", true, "Full handmade recipe book, contains: 60 sheet and 5 sections.", "Recipes Book", null, 39.95m },
                    { 16, 3, "Handmade Eastern card", "https://scontent-sof1-1.xx.fbcdn.net/v/t1.0-9/57267650_2380844435524175_5872320986375782400_n.jpg?_nc_cat=108&_nc_sid=a61e81&_nc_ohc=45WrhpeYExgAX-eAGCn&_nc_ht=scontent-sof1-1.xx&oh=11cad9d008b531aa033c55d2210c3895&oe=5EC0F56D", "https://scontent-sof1-1.xx.fbcdn.net/v/t1.0-9/57267650_2380844435524175_5872320986375782400_n.jpg?_nc_cat=108&_nc_sid=a61e81&_nc_ohc=45WrhpeYExgAX-eAGCn&_nc_ht=scontent-sof1-1.xx&oh=11cad9d008b531aa033c55d2210c3895&oe=5EC0F56D", true, "Handmade Eastern greeting card, size: 15x15 cm, contains 3D elements", "Card Bunny E1", null, 5.95m },
                    { 17, 3, "Handmade Eastern card", "https://scontent-sof1-1.xx.fbcdn.net/v/t1.0-9/56721519_2380844385524180_8057501429188788224_n.jpg?_nc_cat=103&_nc_sid=a61e81&_nc_ohc=JS64FEj1wV0AX89uMwv&_nc_ht=scontent-sof1-1.xx&oh=a04bc5128bf1b1d4ee9b99397b7ae116&oe=5EEFCECE", "https://scontent-sof1-1.xx.fbcdn.net/v/t1.0-9/56721519_2380844385524180_8057501429188788224_n.jpg?_nc_cat=103&_nc_sid=a61e81&_nc_ohc=JS64FEj1wV0AX89uMwv&_nc_ht=scontent-sof1-1.xx&oh=a04bc5128bf1b1d4ee9b99397b7ae116&oe=5EEFCECE", true, "Handmade Eastern greeting card, size: 15x15 cm, contains 3D elements", "Card Bunny E2", null, 5.95m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 18);
        }
    }
}
