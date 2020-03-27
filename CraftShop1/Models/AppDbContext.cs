using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CraftShop1.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Item> Items { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
       // public DbSet<Feedback> Feedbacks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Paintings" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Decoupage" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Cards" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 4, CategoryName = "Other crafts" });

            //seed pies

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId=1,
                CategoryId=2,
                Name = "Bottle BM",
                Price = 19.95M,
                Description = "Bayern Munchen Fans",
                LongDescription = "Handmade bottle with technique decoupage for Bayern Munchen Fans.",
                InStock = true,
                ImageUrl = "https://scontent-sof1-1.xx.fbcdn.net/v/t1.0-9/74905581_2550946021847348_7754944008505262080_n.jpg?_nc_cat=107&_nc_sid=a61e81&_nc_ohc=z6RMxoZX4WgAX_W1YZU&_nc_ht=scontent-sof1-1.xx&oh=94c9e11be567ac286a5d3de10cecec46&oe=5F029B03",
                ImageThumbnailUrl = "https://scontent-sof1-1.xx.fbcdn.net/v/t1.0-9/74905581_2550946021847348_7754944008505262080_n.jpg?_nc_cat=107&_nc_sid=a61e81&_nc_ohc=z6RMxoZX4WgAX_W1YZU&_nc_ht=scontent-sof1-1.xx&oh=94c9e11be567ac286a5d3de10cecec46&oe=5F029B03"
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId=2,
                CategoryId=2,
                Name = "Bottle MU",
                Price = 18.95M,
                Description = "Manchester United Fans",
                LongDescription = "Handmade bottle with technique decoupage for Manchester United Fans.",
                InStock = true,
                ImageUrl = "https://scontent-sof1-1.xx.fbcdn.net/v/t1.0-9/74228921_2550057448602872_8694976358050168832_n.jpg?_nc_cat=103&_nc_sid=a61e81&_nc_ohc=oDfL4KEymYEAX-6kSLo&_nc_ht=scontent-sof1-1.xx&oh=bfaa03be4c07b2b5bb97208e3d5b6227&oe=5EF23675",
                ImageThumbnailUrl = "https://scontent-sof1-1.xx.fbcdn.net/v/t1.0-9/74228921_2550057448602872_8694976358050168832_n.jpg?_nc_cat=103&_nc_sid=a61e81&_nc_ohc=oDfL4KEymYEAX-6kSLo&_nc_ht=scontent-sof1-1.xx&oh=bfaa03be4c07b2b5bb97208e3d5b6227&oe=5EF23675"
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId=3,
                CategoryId=2,
                Name = "Bottle L",
                Price = 29.95M,
                Description = "Ludogoretz Fans",
                LongDescription = "Handmade bottle with technique decoupage for Ludogoretz Fans.",
                InStock = false,
                ImageUrl = "https://scontent-sof1-1.xx.fbcdn.net/v/t1.0-9/s960x960/73128524_2546586282283322_8173801618781765632_o.jpg?_nc_cat=110&_nc_sid=a61e81&_nc_ohc=mNg6jo7FSzYAX90Sb6l&_nc_ht=scontent-sof1-1.xx&_nc_tp=7&oh=b0226573c0738250119a0961fa62b1cd&oe=5EF58707",
                ImageThumbnailUrl = "https://scontent-sof1-1.xx.fbcdn.net/v/t1.0-9/s960x960/73128524_2546586282283322_8173801618781765632_o.jpg?_nc_cat=110&_nc_sid=a61e81&_nc_ohc=mNg6jo7FSzYAX90Sb6l&_nc_ht=scontent-sof1-1.xx&_nc_tp=7&oh=b0226573c0738250119a0961fa62b1cd&oe=5EF58707"
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId=4,
                CategoryId=2,
                Name = "Bottle M",
                Price = 29.95M,
                Description = "Milan Fans",
                LongDescription = "Handmade bottle with technique decoupage for Milan Fans.",
                InStock = false,
                ImageUrl = "https://scontent-sof1-1.xx.fbcdn.net/v/t1.0-9/72632769_2524096181198999_1359356955910471680_n.jpg?_nc_cat=108&_nc_sid=a61e81&_nc_ohc=4dhfxZZ_vxUAX-g5I1p&_nc_ht=scontent-sof1-1.xx&oh=d4917d783fbad6bf56aa15580bfe2a9c&oe=5EF0F38E",
                ImageThumbnailUrl = "https://scontent-sof1-1.xx.fbcdn.net/v/t1.0-9/72632769_2524096181198999_1359356955910471680_n.jpg?_nc_cat=108&_nc_sid=a61e81&_nc_ohc=4dhfxZZ_vxUAX-g5I1p&_nc_ht=scontent-sof1-1.xx&oh=d4917d783fbad6bf56aa15580bfe2a9c&oe=5EF0F38E"
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId=5,
                CategoryId=4,
                Name = "Recipes Book",
                Price = 39.95M,
                Description = "Handmade Recipes Book",
                LongDescription = "Full handmade recipe book, contains: 60 sheet and 5 sections.",
                InStock = true,
                ImageUrl = "https://scontent-sof1-1.xx.fbcdn.net/v/t1.0-9/75442937_2572659076342709_3677204540450406400_n.jpg?_nc_cat=104&_nc_sid=a61e81&_nc_ohc=NFLmVZC8YYoAX9S87X1&_nc_ht=scontent-sof1-1.xx&oh=f910228e2d002515bdb81e1b22ef0a40&oe=5EB95E54",
                ImageThumbnailUrl = "https://scontent-sof1-1.xx.fbcdn.net/v/t1.0-9/75442937_2572659076342709_3677204540450406400_n.jpg?_nc_cat=104&_nc_sid=a61e81&_nc_ohc=NFLmVZC8YYoAX9S87X1&_nc_ht=scontent-sof1-1.xx&oh=f910228e2d002515bdb81e1b22ef0a40&oe=5EB95E54"
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 6,
                CategoryId=3,
                Name = "Card Bunny E1",
                Price = 5.95M,
                Description = "Handmade Eastern card",
                LongDescription = "Handmade Eastern greeting card, size: 15x15 cm, contains 3D elements",
                InStock = true,
                ImageUrl = "https://scontent-sof1-1.xx.fbcdn.net/v/t1.0-9/57267650_2380844435524175_5872320986375782400_n.jpg?_nc_cat=108&_nc_sid=a61e81&_nc_ohc=45WrhpeYExgAX-eAGCn&_nc_ht=scontent-sof1-1.xx&oh=11cad9d008b531aa033c55d2210c3895&oe=5EC0F56D",
                ImageThumbnailUrl = "https://scontent-sof1-1.xx.fbcdn.net/v/t1.0-9/57267650_2380844435524175_5872320986375782400_n.jpg?_nc_cat=108&_nc_sid=a61e81&_nc_ohc=45WrhpeYExgAX-eAGCn&_nc_ht=scontent-sof1-1.xx&oh=11cad9d008b531aa033c55d2210c3895&oe=5EC0F56D"

            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 7,
                CategoryId=3,
                Name = "Card Bunny E2",
                Price = 5.95M,
                Description = "Handmade Eastern card",
                LongDescription = "Handmade Eastern greeting card, size: 15x15 cm, contains 3D elements",
                InStock = true,
                ImageUrl = "https://scontent-sof1-1.xx.fbcdn.net/v/t1.0-9/56721519_2380844385524180_8057501429188788224_n.jpg?_nc_cat=103&_nc_sid=a61e81&_nc_ohc=JS64FEj1wV0AX89uMwv&_nc_ht=scontent-sof1-1.xx&oh=a04bc5128bf1b1d4ee9b99397b7ae116&oe=5EEFCECE",
                ImageThumbnailUrl = "https://scontent-sof1-1.xx.fbcdn.net/v/t1.0-9/56721519_2380844385524180_8057501429188788224_n.jpg?_nc_cat=103&_nc_sid=a61e81&_nc_ohc=JS64FEj1wV0AX89uMwv&_nc_ht=scontent-sof1-1.xx&oh=a04bc5128bf1b1d4ee9b99397b7ae116&oe=5EEFCECE"
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 8,
                CategoryId=3,
                Name = "Card Roses MD1",
                Price = 9.95M,
                Description = "Mother's Day Greeting Card",
                LongDescription = "Handmade Mother's Day Greeting Card, size: 15x10 cm, contains 3D elements and Label",
                InStock = false,
                ImageUrl = "https://scontent-sof1-1.xx.fbcdn.net/v/t1.0-9/52884248_2356970907911528_2812184095377850368_n.jpg?_nc_cat=111&_nc_sid=a61e81&_nc_ohc=4pNlqWJg6U8AX_jPpGO&_nc_ht=scontent-sof1-1.xx&oh=82ed66576af82e21a133bc13cae42ce8&oe=5EF9CD37",
                ImageThumbnailUrl = "https://scontent-sof1-1.xx.fbcdn.net/v/t1.0-9/52884248_2356970907911528_2812184095377850368_n.jpg?_nc_cat=111&_nc_sid=a61e81&_nc_ohc=4pNlqWJg6U8AX_jPpGO&_nc_ht=scontent-sof1-1.xx&oh=82ed66576af82e21a133bc13cae42ce8&oe=5EF9CD37"
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 9,
                CategoryId = 3,
                Name = "Card Roses MD2",
                Price = 9.95M,
                Description = "Mother's Day Greeting Card",
                LongDescription = "Handmade Mother's Day Greeting Card, size: 15x10 cm, contains 3D elements and Label",
                InStock = true,
                ImageUrl = "https://scontent-sof1-1.xx.fbcdn.net/v/t1.0-9/52809966_2355037058104913_4377321438474928128_n.jpg?_nc_cat=102&_nc_sid=a61e81&_nc_ohc=ukh1AQK2ufsAX-NMeeB&_nc_ht=scontent-sof1-1.xx&oh=0281f263cd286aa40214cb9c76d91a1f&oe=5EF106E8",
                ImageThumbnailUrl = "https://scontent-sof1-1.xx.fbcdn.net/v/t1.0-9/52809966_2355037058104913_4377321438474928128_n.jpg?_nc_cat=102&_nc_sid=a61e81&_nc_ohc=ukh1AQK2ufsAX-NMeeB&_nc_ht=scontent-sof1-1.xx&oh=0281f263cd286aa40214cb9c76d91a1f&oe=5EF106E8"
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 10,
                CategoryId = 1,
                Name = "Painting T",
                Price = 219.95M,
                Description = "Traveling...",
                LongDescription = "Acrylic painting, size: 30x40 cm",
                InStock = false,
                ImageUrl = "https://scontent-sof1-1.xx.fbcdn.net/v/t1.0-9/82889874_2627637417511541_9053982563969794048_n.jpg?_nc_cat=110&_nc_sid=a61e81&_nc_ohc=6KAO0pQIk6wAX9ifyyk&_nc_ht=scontent-sof1-1.xx&oh=0ac02401cfc769d11ffc10a6198f2491&oe=5F028754",
                ImageThumbnailUrl = "https://scontent-sof1-1.xx.fbcdn.net/v/t1.0-9/82889874_2627637417511541_9053982563969794048_n.jpg?_nc_cat=110&_nc_sid=a61e81&_nc_ohc=6KAO0pQIk6wAX9ifyyk&_nc_ht=scontent-sof1-1.xx&oh=0ac02401cfc769d11ffc10a6198f2491&oe=5F028754"
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 11,
                CategoryId = 1,
                Name = "Painting M",
                Price = 119.95M,
                Description = "Morning cat",
                LongDescription = "Acrylic painting, size: 30x40 cm",
                InStock = true,
                ImageUrl = "https://scontent-sof1-1.xx.fbcdn.net/v/t1.0-9/26055665_2059839840957971_3050193840913806679_n.jpg?_nc_cat=103&_nc_sid=a61e81&_nc_ohc=5_xtKuzgg00AX_UoVEV&_nc_ht=scontent-sof1-1.xx&oh=3e78dfc4fc72c8c9a8343ecf58e90107&oe=5EF3F85E",
                ImageThumbnailUrl = "https://scontent-sof1-1.xx.fbcdn.net/v/t1.0-9/26055665_2059839840957971_3050193840913806679_n.jpg?_nc_cat=103&_nc_sid=a61e81&_nc_ohc=5_xtKuzgg00AX_UoVEV&_nc_ht=scontent-sof1-1.xx&oh=3e78dfc4fc72c8c9a8343ecf58e90107&oe=5EF3F85E"
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 12,
                CategoryId = 2,
                Name = "Bottle BM",
                Price = 19.95M,
                Description = "Bayern Munchen Fans",
                LongDescription = "Handmade bottle with technique decoupage for Bayern Munchen Fans.",
                InStock = true,
                ImageUrl = "https://scontent-sof1-1.xx.fbcdn.net/v/t1.0-9/74905581_2550946021847348_7754944008505262080_n.jpg?_nc_cat=107&_nc_sid=a61e81&_nc_ohc=z6RMxoZX4WgAX_W1YZU&_nc_ht=scontent-sof1-1.xx&oh=94c9e11be567ac286a5d3de10cecec46&oe=5F029B03",
                ImageThumbnailUrl = "https://scontent-sof1-1.xx.fbcdn.net/v/t1.0-9/74905581_2550946021847348_7754944008505262080_n.jpg?_nc_cat=107&_nc_sid=a61e81&_nc_ohc=z6RMxoZX4WgAX_W1YZU&_nc_ht=scontent-sof1-1.xx&oh=94c9e11be567ac286a5d3de10cecec46&oe=5F029B03"
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 13,
                CategoryId = 2,
                Name = "Bottle MU",
                Price = 18.95M,
                Description = "Manchester United Fans",
                LongDescription = "Handmade bottle with technique decoupage for Manchester United Fans.",
                InStock = true,
                ImageUrl = "https://scontent-sof1-1.xx.fbcdn.net/v/t1.0-9/74228921_2550057448602872_8694976358050168832_n.jpg?_nc_cat=103&_nc_sid=a61e81&_nc_ohc=oDfL4KEymYEAX-6kSLo&_nc_ht=scontent-sof1-1.xx&oh=bfaa03be4c07b2b5bb97208e3d5b6227&oe=5EF23675",
                ImageThumbnailUrl = "https://scontent-sof1-1.xx.fbcdn.net/v/t1.0-9/74228921_2550057448602872_8694976358050168832_n.jpg?_nc_cat=103&_nc_sid=a61e81&_nc_ohc=oDfL4KEymYEAX-6kSLo&_nc_ht=scontent-sof1-1.xx&oh=bfaa03be4c07b2b5bb97208e3d5b6227&oe=5EF23675"
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId =18 ,
                CategoryId = 2,
                Name = "Bottle L",
                Price = 29.95M,
                Description = "Ludogoretz Fans",
                LongDescription = "Handmade bottle with technique decoupage for Ludogoretz Fans.",
                InStock = false,
                ImageUrl = "https://scontent-sof1-1.xx.fbcdn.net/v/t1.0-9/s960x960/73128524_2546586282283322_8173801618781765632_o.jpg?_nc_cat=110&_nc_sid=a61e81&_nc_ohc=mNg6jo7FSzYAX90Sb6l&_nc_ht=scontent-sof1-1.xx&_nc_tp=7&oh=b0226573c0738250119a0961fa62b1cd&oe=5EF58707",
                ImageThumbnailUrl = "https://scontent-sof1-1.xx.fbcdn.net/v/t1.0-9/s960x960/73128524_2546586282283322_8173801618781765632_o.jpg?_nc_cat=110&_nc_sid=a61e81&_nc_ohc=mNg6jo7FSzYAX90Sb6l&_nc_ht=scontent-sof1-1.xx&_nc_tp=7&oh=b0226573c0738250119a0961fa62b1cd&oe=5EF58707"
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 14,
                CategoryId = 2,
                Name = "Bottle M",
                Price = 29.95M,
                Description = "Milan Fans",
                LongDescription = "Handmade bottle with technique decoupage for Milan Fans.",
                InStock = false,
                ImageUrl = "https://scontent-sof1-1.xx.fbcdn.net/v/t1.0-9/72632769_2524096181198999_1359356955910471680_n.jpg?_nc_cat=108&_nc_sid=a61e81&_nc_ohc=4dhfxZZ_vxUAX-g5I1p&_nc_ht=scontent-sof1-1.xx&oh=d4917d783fbad6bf56aa15580bfe2a9c&oe=5EF0F38E",
                ImageThumbnailUrl = "https://scontent-sof1-1.xx.fbcdn.net/v/t1.0-9/72632769_2524096181198999_1359356955910471680_n.jpg?_nc_cat=108&_nc_sid=a61e81&_nc_ohc=4dhfxZZ_vxUAX-g5I1p&_nc_ht=scontent-sof1-1.xx&oh=d4917d783fbad6bf56aa15580bfe2a9c&oe=5EF0F38E"
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 15,
                CategoryId = 4,
                Name = "Recipes Book",
                Price = 39.95M,
                Description = "Handmade Recipes Book",
                LongDescription = "Full handmade recipe book, contains: 60 sheet and 5 sections.",
                InStock = true,
                ImageUrl = "https://scontent-sof1-1.xx.fbcdn.net/v/t1.0-9/75442937_2572659076342709_3677204540450406400_n.jpg?_nc_cat=104&_nc_sid=a61e81&_nc_ohc=NFLmVZC8YYoAX9S87X1&_nc_ht=scontent-sof1-1.xx&oh=f910228e2d002515bdb81e1b22ef0a40&oe=5EB95E54",
                ImageThumbnailUrl = "https://scontent-sof1-1.xx.fbcdn.net/v/t1.0-9/75442937_2572659076342709_3677204540450406400_n.jpg?_nc_cat=104&_nc_sid=a61e81&_nc_ohc=NFLmVZC8YYoAX9S87X1&_nc_ht=scontent-sof1-1.xx&oh=f910228e2d002515bdb81e1b22ef0a40&oe=5EB95E54"
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 16,
                CategoryId = 3,
                Name = "Card Bunny E1",
                Price = 5.95M,
                Description = "Handmade Eastern card",
                LongDescription = "Handmade Eastern greeting card, size: 15x15 cm, contains 3D elements",
                InStock = true,
                ImageUrl = "https://scontent-sof1-1.xx.fbcdn.net/v/t1.0-9/57267650_2380844435524175_5872320986375782400_n.jpg?_nc_cat=108&_nc_sid=a61e81&_nc_ohc=45WrhpeYExgAX-eAGCn&_nc_ht=scontent-sof1-1.xx&oh=11cad9d008b531aa033c55d2210c3895&oe=5EC0F56D",
                ImageThumbnailUrl = "https://scontent-sof1-1.xx.fbcdn.net/v/t1.0-9/57267650_2380844435524175_5872320986375782400_n.jpg?_nc_cat=108&_nc_sid=a61e81&_nc_ohc=45WrhpeYExgAX-eAGCn&_nc_ht=scontent-sof1-1.xx&oh=11cad9d008b531aa033c55d2210c3895&oe=5EC0F56D"

            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 17,
                CategoryId = 3,
                Name = "Card Bunny E2",
                Price = 5.95M,
                Description = "Handmade Eastern card",
                LongDescription = "Handmade Eastern greeting card, size: 15x15 cm, contains 3D elements",
                InStock = true,
                ImageUrl = "https://scontent-sof1-1.xx.fbcdn.net/v/t1.0-9/56721519_2380844385524180_8057501429188788224_n.jpg?_nc_cat=103&_nc_sid=a61e81&_nc_ohc=JS64FEj1wV0AX89uMwv&_nc_ht=scontent-sof1-1.xx&oh=a04bc5128bf1b1d4ee9b99397b7ae116&oe=5EEFCECE",
                ImageThumbnailUrl = "https://scontent-sof1-1.xx.fbcdn.net/v/t1.0-9/56721519_2380844385524180_8057501429188788224_n.jpg?_nc_cat=103&_nc_sid=a61e81&_nc_ohc=JS64FEj1wV0AX89uMwv&_nc_ht=scontent-sof1-1.xx&oh=a04bc5128bf1b1d4ee9b99397b7ae116&oe=5EEFCECE"
            });

        }





    }
}
