﻿// <auto-generated />
using System;
using E_Commerce.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace E_Commerce.Migrations
{
    [DbContext(typeof(ECommDbContext))]
    partial class ECommDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("E_Commerce.Models.Basket", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.HasKey("ID");

                    b.ToTable("Baskets");
                });

            modelBuilder.Entity("E_Commerce.Models.BasketItem", b =>
                {
                    b.Property<int>("BasketID");

                    b.Property<int>("ProductID");

                    b.Property<string>("Image");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.Property<int>("Quanity");

                    b.Property<string>("Sku");

                    b.HasKey("BasketID", "ProductID");

                    b.HasIndex("ProductID");

                    b.ToTable("BasketItems");
                });

            modelBuilder.Entity("E_Commerce.Models.Order", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustomerName");

                    b.Property<DateTime>("Date");

                    b.Property<string>("ShipppingAddress");

                    b.Property<int>("TotalPrice");

                    b.HasKey("ID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("E_Commerce.Models.OrderItem", b =>
                {
                    b.Property<int>("ProductID");

                    b.Property<int>("OrderID");

                    b.Property<int>("Quanity");

                    b.Property<int>("TotalItemPrice");

                    b.HasKey("ProductID", "OrderID");

                    b.HasIndex("OrderID");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("E_Commerce.Models.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Image");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.Property<string>("Sku");

                    b.HasKey("ID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Description = "Stick on beard and mustache. Glue not included",
                            Image = "https://beardibilityblob.blob.core.windows.net/productimages/baron.png",
                            Name = "The Baron",
                            Price = 10.00m,
                            Sku = "BEAR001"
                        },
                        new
                        {
                            ID = 2,
                            Description = "Stick on mustache and mutton-chops. Glue not included",
                            Image = "https://beardibilityblob.blob.core.windows.net/productimages/butcher.png",
                            Name = "The Butcher",
                            Price = 8.00m,
                            Sku = "MUTT001"
                        },
                        new
                        {
                            ID = 3,
                            Description = "Stick on beard and mustache. Glue not included",
                            Image = "https://beardibilityblob.blob.core.windows.net/productimages/czar.png",
                            Name = "The Czar",
                            Price = 10.00m,
                            Sku = "BEAR002"
                        },
                        new
                        {
                            ID = 4,
                            Description = "Stick on beard and mustache. Glue not included",
                            Image = "https://beardibilityblob.blob.core.windows.net/productimages/dandy.png",
                            Name = "The Dandy",
                            Price = 10.00m,
                            Sku = "BEAR003"
                        },
                        new
                        {
                            ID = 5,
                            Description = "Stick on beard and mustache. Glue not included",
                            Image = "https://beardibilityblob.blob.core.windows.net/productimages/barrister.png",
                            Name = "The Barrister",
                            Price = 10.00m,
                            Sku = "BEAR005"
                        },
                        new
                        {
                            ID = 6,
                            Description = "Stick on mustache and sideburns. Glue not included",
                            Image = "https://beardibilityblob.blob.core.windows.net/productimages/duke.png",
                            Name = "The Duke",
                            Price = 5.00m,
                            Sku = "MUST001"
                        },
                        new
                        {
                            ID = 7,
                            Description = "Stick on goatee and mustache. Glue not included",
                            Image = "https://beardibilityblob.blob.core.windows.net/productimages/empereur.png",
                            Name = "The Empereur",
                            Price = 7.00m,
                            Sku = "GOAT001"
                        },
                        new
                        {
                            ID = 8,
                            Description = "Stick on beard. Glue not included",
                            Image = "https://beardibilityblob.blob.core.windows.net/productimages/farmer.png",
                            Name = "The Farmer",
                            Price = 8.00m,
                            Sku = "BEAR006"
                        },
                        new
                        {
                            ID = 9,
                            Description = "Stick on mutton-chops and mustache. Glue not included",
                            Image = "https://beardibilityblob.blob.core.windows.net/productimages/kaiser.png",
                            Name = "The Kaiser",
                            Price = 8.00m,
                            Sku = "MUTT002"
                        },
                        new
                        {
                            ID = 10,
                            Description = "Stick on goatee and mustache. Glue not included",
                            Image = "https://beardibilityblob.blob.core.windows.net/productimages/magician.png",
                            Name = "The Magician",
                            Price = 7.00m,
                            Sku = "GOAT002"
                        },
                        new
                        {
                            ID = 11,
                            Description = "Stick on beard and mustache. Glue not included",
                            Image = "https://beardibilityblob.blob.core.windows.net/productimages/mariner.png",
                            Name = "The Mariner",
                            Price = 10.00m,
                            Sku = "BEAR007"
                        },
                        new
                        {
                            ID = 12,
                            Description = "Glue for all stick on facial hair. Alcohol soluble.",
                            Image = "https://beardibilityblob.blob.core.windows.net/productimages/facial_glue.jpg",
                            Name = "Facial Glue",
                            Price = 5.00m,
                            Sku = "ACCE001"
                        },
                        new
                        {
                            ID = 13,
                            Description = "Beard oil for every gentleman.",
                            Image = "https://beardibilityblob.blob.core.windows.net/productimages/beard_oil.jpg",
                            Name = "Gentlemen's Beard Oil",
                            Price = 5.00m,
                            Sku = "GROO001"
                        },
                        new
                        {
                            ID = 14,
                            Description = "Specially designed comb and brush for facial hair.",
                            Image = "https://beardibilityblob.blob.core.windows.net/productimages/brush_set.jpg",
                            Name = "Comb and Brush Set",
                            Price = 8.00m,
                            Sku = "GROO002"
                        });
                });

            modelBuilder.Entity("E_Commerce.Models.BasketItem", b =>
                {
                    b.HasOne("E_Commerce.Models.Basket", "Basket")
                        .WithMany("BasketItems")
                        .HasForeignKey("BasketID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("E_Commerce.Models.Product", "Product")
                        .WithMany("BasketItem")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("E_Commerce.Models.OrderItem", b =>
                {
                    b.HasOne("E_Commerce.Models.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("E_Commerce.Models.Product", "Product")
                        .WithMany("OrderItem")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
