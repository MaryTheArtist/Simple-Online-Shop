using Microsoft.EntityFrameworkCore.Migrations;

namespace CraftShop1.Migrations
{
    public partial class SeedNewItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 4, "Other crafts", null });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 1,
                columns: new[] { "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "LongDescription", "Name", "Price" },
                values: new object[] { 2, "Bayern Munchen Fans", "https://scontent-sof1-1.xx.fbcdn.net/v/t1.0-9/74905581_2550946021847348_7754944008505262080_n.jpg?_nc_cat=107&_nc_sid=a61e81&_nc_ohc=z6RMxoZX4WgAX_W1YZU&_nc_ht=scontent-sof1-1.xx&oh=94c9e11be567ac286a5d3de10cecec46&oe=5F029B03", "https://scontent-sof1-1.xx.fbcdn.net/v/t1.0-9/74905581_2550946021847348_7754944008505262080_n.jpg?_nc_cat=107&_nc_sid=a61e81&_nc_ohc=z6RMxoZX4WgAX_W1YZU&_nc_ht=scontent-sof1-1.xx&oh=94c9e11be567ac286a5d3de10cecec46&oe=5F029B03", "Handmade bottle with technique decoupage for Bayern Munchen Fans.", "Bottle BM", 19.95m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 2,
                columns: new[] { "Description", "ImageThumbnailUrl", "ImageUrl", "LongDescription", "Name", "Price" },
                values: new object[] { "Manchester United Fans", "https://scontent-sof1-1.xx.fbcdn.net/v/t1.0-9/74228921_2550057448602872_8694976358050168832_n.jpg?_nc_cat=103&_nc_sid=a61e81&_nc_ohc=oDfL4KEymYEAX-6kSLo&_nc_ht=scontent-sof1-1.xx&oh=bfaa03be4c07b2b5bb97208e3d5b6227&oe=5EF23675", "https://scontent-sof1-1.xx.fbcdn.net/v/t1.0-9/74228921_2550057448602872_8694976358050168832_n.jpg?_nc_cat=103&_nc_sid=a61e81&_nc_ohc=oDfL4KEymYEAX-6kSLo&_nc_ht=scontent-sof1-1.xx&oh=bfaa03be4c07b2b5bb97208e3d5b6227&oe=5EF23675", "Handmade bottle with technique decoupage for Manchester United Fans.", "Bottle MU", 18.95m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 3,
                columns: new[] { "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "InStock", "LongDescription", "Name", "Price" },
                values: new object[] { 2, "Ludogoretz Fans", "https://scontent-sof1-1.xx.fbcdn.net/v/t1.0-9/s960x960/73128524_2546586282283322_8173801618781765632_o.jpg?_nc_cat=110&_nc_sid=a61e81&_nc_ohc=mNg6jo7FSzYAX90Sb6l&_nc_ht=scontent-sof1-1.xx&_nc_tp=7&oh=b0226573c0738250119a0961fa62b1cd&oe=5EF58707", "https://scontent-sof1-1.xx.fbcdn.net/v/t1.0-9/s960x960/73128524_2546586282283322_8173801618781765632_o.jpg?_nc_cat=110&_nc_sid=a61e81&_nc_ohc=mNg6jo7FSzYAX90Sb6l&_nc_ht=scontent-sof1-1.xx&_nc_tp=7&oh=b0226573c0738250119a0961fa62b1cd&oe=5EF58707", false, "Handmade bottle with technique decoupage for Ludogoretz Fans.", "Bottle L", 29.95m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 4,
                columns: new[] { "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "InStock", "LongDescription", "Name", "Price" },
                values: new object[] { 2, "Milan Fans", "https://scontent-sof1-1.xx.fbcdn.net/v/t1.0-9/72632769_2524096181198999_1359356955910471680_n.jpg?_nc_cat=108&_nc_sid=a61e81&_nc_ohc=4dhfxZZ_vxUAX-g5I1p&_nc_ht=scontent-sof1-1.xx&oh=d4917d783fbad6bf56aa15580bfe2a9c&oe=5EF0F38E", "https://scontent-sof1-1.xx.fbcdn.net/v/t1.0-9/72632769_2524096181198999_1359356955910471680_n.jpg?_nc_cat=108&_nc_sid=a61e81&_nc_ohc=4dhfxZZ_vxUAX-g5I1p&_nc_ht=scontent-sof1-1.xx&oh=d4917d783fbad6bf56aa15580bfe2a9c&oe=5EF0F38E", false, "Handmade bottle with technique decoupage for Milan Fans.", "Bottle M", 29.95m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 6,
                columns: new[] { "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "LongDescription", "Name", "Price" },
                values: new object[] { 3, "Handmade Eastern card", "https://scontent-sof1-1.xx.fbcdn.net/v/t1.0-9/57267650_2380844435524175_5872320986375782400_n.jpg?_nc_cat=108&_nc_sid=a61e81&_nc_ohc=45WrhpeYExgAX-eAGCn&_nc_ht=scontent-sof1-1.xx&oh=11cad9d008b531aa033c55d2210c3895&oe=5EC0F56D", "https://scontent-sof1-1.xx.fbcdn.net/v/t1.0-9/57267650_2380844435524175_5872320986375782400_n.jpg?_nc_cat=108&_nc_sid=a61e81&_nc_ohc=45WrhpeYExgAX-eAGCn&_nc_ht=scontent-sof1-1.xx&oh=11cad9d008b531aa033c55d2210c3895&oe=5EC0F56D", "Handmade Eastern greeting card, size: 15x15 cm, contains 3D elements", "Card Bunny E1", 5.95m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 7,
                columns: new[] { "Description", "ImageThumbnailUrl", "ImageUrl", "InStock", "LongDescription", "Name", "Price" },
                values: new object[] { "Handmade Eastern card", "https://scontent-sof1-1.xx.fbcdn.net/v/t1.0-9/56721519_2380844385524180_8057501429188788224_n.jpg?_nc_cat=103&_nc_sid=a61e81&_nc_ohc=JS64FEj1wV0AX89uMwv&_nc_ht=scontent-sof1-1.xx&oh=a04bc5128bf1b1d4ee9b99397b7ae116&oe=5EEFCECE", "https://scontent-sof1-1.xx.fbcdn.net/v/t1.0-9/56721519_2380844385524180_8057501429188788224_n.jpg?_nc_cat=103&_nc_sid=a61e81&_nc_ohc=JS64FEj1wV0AX89uMwv&_nc_ht=scontent-sof1-1.xx&oh=a04bc5128bf1b1d4ee9b99397b7ae116&oe=5EEFCECE", true, "Handmade Eastern greeting card, size: 15x15 cm, contains 3D elements", "Card Bunny E2", 5.95m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 11,
                columns: new[] { "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "InStock", "LongDescription", "Name", "Price" },
                values: new object[] { 1, "Morning cat", "https://scontent-sof1-1.xx.fbcdn.net/v/t1.0-9/26055665_2059839840957971_3050193840913806679_n.jpg?_nc_cat=103&_nc_sid=a61e81&_nc_ohc=5_xtKuzgg00AX_UoVEV&_nc_ht=scontent-sof1-1.xx&oh=3e78dfc4fc72c8c9a8343ecf58e90107&oe=5EF3F85E", "https://scontent-sof1-1.xx.fbcdn.net/v/t1.0-9/26055665_2059839840957971_3050193840913806679_n.jpg?_nc_cat=103&_nc_sid=a61e81&_nc_ohc=5_xtKuzgg00AX_UoVEV&_nc_ht=scontent-sof1-1.xx&oh=3e78dfc4fc72c8c9a8343ecf58e90107&oe=5EF3F85E", true, "Acrylic painting, size: 30x40 cm", "Painting M", 119.95m });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemId", "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "InStock", "LongDescription", "Name", "Notes", "Price" },
                values: new object[,]
                {
                    { 8, 3, "Mother's Day Greeting Card", "https://scontent-sof1-1.xx.fbcdn.net/v/t1.0-9/52884248_2356970907911528_2812184095377850368_n.jpg?_nc_cat=111&_nc_sid=a61e81&_nc_ohc=4pNlqWJg6U8AX_jPpGO&_nc_ht=scontent-sof1-1.xx&oh=82ed66576af82e21a133bc13cae42ce8&oe=5EF9CD37", "https://scontent-sof1-1.xx.fbcdn.net/v/t1.0-9/52884248_2356970907911528_2812184095377850368_n.jpg?_nc_cat=111&_nc_sid=a61e81&_nc_ohc=4pNlqWJg6U8AX_jPpGO&_nc_ht=scontent-sof1-1.xx&oh=82ed66576af82e21a133bc13cae42ce8&oe=5EF9CD37", false, "Handmade Mother's Day Greeting Card, size: 15x10 cm, contains 3D elements and Label", "Card Roses MD1", null, 9.95m },
                    { 9, 3, "Mother's Day Greeting Card", "https://scontent-sof1-1.xx.fbcdn.net/v/t1.0-9/52809966_2355037058104913_4377321438474928128_n.jpg?_nc_cat=102&_nc_sid=a61e81&_nc_ohc=ukh1AQK2ufsAX-NMeeB&_nc_ht=scontent-sof1-1.xx&oh=0281f263cd286aa40214cb9c76d91a1f&oe=5EF106E8", "https://scontent-sof1-1.xx.fbcdn.net/v/t1.0-9/52809966_2355037058104913_4377321438474928128_n.jpg?_nc_cat=102&_nc_sid=a61e81&_nc_ohc=ukh1AQK2ufsAX-NMeeB&_nc_ht=scontent-sof1-1.xx&oh=0281f263cd286aa40214cb9c76d91a1f&oe=5EF106E8", true, "Handmade Mother's Day Greeting Card, size: 15x10 cm, contains 3D elements and Label", "Card Roses MD2", null, 9.95m },
                    { 10, 1, "Traveling...", "https://scontent-sof1-1.xx.fbcdn.net/v/t1.0-9/82889874_2627637417511541_9053982563969794048_n.jpg?_nc_cat=110&_nc_sid=a61e81&_nc_ohc=6KAO0pQIk6wAX9ifyyk&_nc_ht=scontent-sof1-1.xx&oh=0ac02401cfc769d11ffc10a6198f2491&oe=5F028754", "https://scontent-sof1-1.xx.fbcdn.net/v/t1.0-9/82889874_2627637417511541_9053982563969794048_n.jpg?_nc_cat=110&_nc_sid=a61e81&_nc_ohc=6KAO0pQIk6wAX9ifyyk&_nc_ht=scontent-sof1-1.xx&oh=0ac02401cfc769d11ffc10a6198f2491&oe=5F028754", false, "Acrylic painting, size: 30x40 cm", "Painting T", null, 219.95m }
                });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 5,
                columns: new[] { "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "LongDescription", "Name", "Price" },
                values: new object[] { 4, "Handmade Recipes Book", "https://scontent-sof1-1.xx.fbcdn.net/v/t1.0-9/75442937_2572659076342709_3677204540450406400_n.jpg?_nc_cat=104&_nc_sid=a61e81&_nc_ohc=NFLmVZC8YYoAX9S87X1&_nc_ht=scontent-sof1-1.xx&oh=f910228e2d002515bdb81e1b22ef0a40&oe=5EB95E54", "https://scontent-sof1-1.xx.fbcdn.net/v/t1.0-9/75442937_2572659076342709_3677204540450406400_n.jpg?_nc_cat=104&_nc_sid=a61e81&_nc_ohc=NFLmVZC8YYoAX9S87X1&_nc_ht=scontent-sof1-1.xx&oh=f910228e2d002515bdb81e1b22ef0a40&oe=5EB95E54", "Full handmade recipe book, contains: 60 sheet and 5 sections.", "Recipes Book", 39.95m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 1,
                columns: new[] { "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "LongDescription", "Name", "Price" },
                values: new object[] { 3, "Greeting card!", "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg", null, "Card", 12.95m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 2,
                columns: new[] { "Description", "ImageThumbnailUrl", "ImageUrl", "LongDescription", "Name", "Price" },
                values: new object[] { "You'll love it!", "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecakesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecake.jpg", null, "Bottle", 28.95m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 3,
                columns: new[] { "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "InStock", "LongDescription", "Name", "Price" },
                values: new object[] { 1, "Acrylic painting", "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg", true, null, "Morning cat", 108.95m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 4,
                columns: new[] { "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "InStock", "LongDescription", "Name", "Price" },
                values: new object[] { 1, "A summer classic!", "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypie.jpg", true, null, "Sunset", 215.95m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 5,
                columns: new[] { "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "LongDescription", "Name", "Price" },
                values: new object[] { 3, "Happy holidays with this card!", "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepie.jpg", null, "Christmas Card", 13.95m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 6,
                columns: new[] { "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "LongDescription", "Name", "Price" },
                values: new object[] { 2, "A Christmas favorite", "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberrypiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberrypie.jpg", null, "Christmas decoration", 27.95m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 7,
                columns: new[] { "Description", "ImageThumbnailUrl", "ImageUrl", "InStock", "LongDescription", "Name", "Price" },
                values: new object[] { "Greeting card", "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpie.jpg", false, null, "Card", 15.95m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 11,
                columns: new[] { "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "InStock", "LongDescription", "Name", "Price" },
                values: new object[] { 3, "Greeting card", "/images/card.jpg", "/images/card.jpg", false, null, "Card", 15.95m });
        }
    }
}
