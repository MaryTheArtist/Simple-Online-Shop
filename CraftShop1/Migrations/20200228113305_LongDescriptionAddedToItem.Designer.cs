﻿// <auto-generated />
using CraftShop1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CraftShop1.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200228113305_LongDescriptionAddedToItem")]
    partial class LongDescriptionAddedToItem
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CraftShop1.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName");

                    b.Property<string>("Description");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new { CategoryId = 1, CategoryName = "Paintings" },
                        new { CategoryId = 2, CategoryName = "Decoupage" },
                        new { CategoryId = 3, CategoryName = "Cards" }
                    );
                });

            modelBuilder.Entity("CraftShop1.Models.Item", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<string>("Description");

                    b.Property<string>("ImageThumbnailUrl");

                    b.Property<string>("ImageUrl");

                    b.Property<bool>("InStock");

                    b.Property<string>("LongDescription");

                    b.Property<string>("Name");

                    b.Property<string>("Notes");

                    b.Property<decimal>("Price");

                    b.HasKey("ItemId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Items");

                    b.HasData(
                        new { ItemId = 1, CategoryId = 3, Description = "Greeting card!", ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg", ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg", InStock = true, Name = "Card", Price = 12.95m },
                        new { ItemId = 2, CategoryId = 2, Description = "You'll love it!", ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecakesmall.jpg", ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecake.jpg", InStock = true, Name = "Bottle", Price = 28.95m },
                        new { ItemId = 3, CategoryId = 1, Description = "Acrylic painting", ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg", ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg", InStock = true, Name = "Morning cat", Price = 108.95m },
                        new { ItemId = 4, CategoryId = 1, Description = "A summer classic!", ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypiesmall.jpg", ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypie.jpg", InStock = true, Name = "Sunset", Price = 215.95m },
                        new { ItemId = 5, CategoryId = 3, Description = "Happy holidays with this card!", ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepiesmall.jpg", ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepie.jpg", InStock = true, Name = "Christmas Card", Price = 13.95m },
                        new { ItemId = 6, CategoryId = 2, Description = "A Christmas favorite", ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberrypiesmall.jpg", ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberrypie.jpg", InStock = true, Name = "Christmas decoration", Price = 27.95m },
                        new { ItemId = 7, CategoryId = 3, Description = "Greeting card", ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpiesmall.jpg", ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpie.jpg", InStock = false, Name = "Card", Price = 15.95m },
                        new { ItemId = 11, CategoryId = 3, Description = "Greeting card", ImageThumbnailUrl = "/images/card.jpg", ImageUrl = "/images/card.jpg", InStock = false, Name = "Card", Price = 15.95m }
                    );
                });

            modelBuilder.Entity("CraftShop1.Models.Item", b =>
                {
                    b.HasOne("CraftShop1.Models.Category", "Category")
                        .WithMany("Items")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
