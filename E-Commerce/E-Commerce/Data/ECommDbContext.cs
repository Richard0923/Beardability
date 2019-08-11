using E_Commerce.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Data
{
    /// <summary>
    /// Product's DB that has all our seeded data for E-Comm site
    /// </summary>
    public class ECommDbContext : DbContext
    {
        public ECommDbContext(DbContextOptions<ECommDbContext> options) : base(options)
        {

        }

        /// <summary>
        /// Creates the seeded data for our database.
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Composite Key Binding 

            modelBuilder.Entity<BasketItem>().HasKey(bi =>
            new { bi.BasketID, bi.ProductID });
            

            modelBuilder.Entity<OrderItem>().HasKey(oi =>
            new { oi.ProductID, oi.OrderID });

            //Product seeded data 
            modelBuilder.Entity<Product>().HasData(

                new Product
                {
                    ID = 1,

                    Name = "The Baron",

                    Sku = "BEAR001",

                    Price = 10.00M,

                    Description = "Stick on beard and mustache. Glue not included",

                    Image = "https://beardibilityblob.blob.core.windows.net/productimages/baron.png"
                },

                new Product
                {
                    ID = 2,

                    Name = "The Butcher",

                    Sku = "MUTT001",

                    Price = 8.00M,

                    Description = "Stick on mustache and mutton-chops. Glue not included",

                    Image = "https://beardibilityblob.blob.core.windows.net/productimages/butcher.png"
                },

                new Product
                {
                    ID = 3,

                    Name = "The Czar",

                    Sku = "BEAR002",

                    Price = 10.00M,

                    Description = "Stick on beard and mustache. Glue not included",

                    Image = "https://beardibilityblob.blob.core.windows.net/productimages/czar.png"
                },

                new Product
                {
                    ID = 4,

                    Name = "The Dandy",

                    Sku = "BEAR003",

                    Price = 10.00M,

                    Description = "Stick on beard and mustache. Glue not included",

                    Image = "https://beardibilityblob.blob.core.windows.net/productimages/dandy.png"
                },

                new Product
                {
                    ID = 5,

                    Name = "The Barrister",

                    Sku = "BEAR005",

                    Price = 10.00M,

                    Description = "Stick on beard and mustache. Glue not included",

                    Image = "https://beardibilityblob.blob.core.windows.net/productimages/barrister.png"
                },

                new Product
                {
                    ID = 6,

                    Name = "The Duke",

                    Sku = "MUST001",

                    Price = 5.00M,

                    Description = "Stick on mustache and sideburns. Glue not included",

                    Image = "https://beardibilityblob.blob.core.windows.net/productimages/duke.png"
                },

                new Product
                {
                    ID = 7,

                    Name = "The Empereur",

                    Sku = "GOAT001",

                    Price = 7.00M,

                    Description = "Stick on goatee and mustache. Glue not included",

                    Image = "https://beardibilityblob.blob.core.windows.net/productimages/empereur.png"
                },

                new Product
                {
                    ID = 8,

                    Name = "The Farmer",

                    Sku = "BEAR006",

                    Price = 8.00M,

                    Description = "Stick on beard. Glue not included",

                    Image = "https://beardibilityblob.blob.core.windows.net/productimages/farmer.png"
                },

                new Product
                {
                    ID = 9,

                    Name = "The Kaiser",

                    Sku = "MUTT002",

                    Price = 8.00M,

                    Description = "Stick on mutton-chops and mustache. Glue not included",

                    Image = "https://beardibilityblob.blob.core.windows.net/productimages/kaiser.png"
                },

                new Product
                {
                    ID = 10,

                    Name = "The Magician",

                    Sku = "GOAT002",

                    Price = 7.00M,

                    Description = "Stick on goatee and mustache. Glue not included",

                    Image = "https://beardibilityblob.blob.core.windows.net/productimages/magician.png"
                },

                new Product
                {
                    ID = 11,

                    Name = "The Mariner",

                    Sku = "BEAR007",

                    Price = 10.00M,

                    Description = "Stick on beard and mustache. Glue not included",

                    Image = "https://beardibilityblob.blob.core.windows.net/productimages/mariner.png"
                },

                new Product
                {
                    ID = 12,

                    Name = "Facial Glue",

                    Sku = "ACCE001",

                    Price = 5.00M,

                    Description = "Glue for all stick on facial hair. Alcohol soluble.",

                    Image = "https://beardibilityblob.blob.core.windows.net/productimages/facial_glue.jpg"
                },

                new Product
                {
                    ID = 13,

                    Name = "Gentlemen's Beard Oil",

                    Sku = "GROO001",

                    Price = 5.00M,

                    Description = "Beard oil for every gentleman.",

                    Image = "https://beardibilityblob.blob.core.windows.net/productimages/beard_oil.jpg"
                },

                new Product
                {
                    ID = 14,

                    Name = "Comb and Brush Set",

                    Sku = "GROO002",

                    Price = 8.00M,

                    Description = "Specially designed comb and brush for facial hair.",

                    Image = "https://beardibilityblob.blob.core.windows.net/productimages/brush_set.jpg"
                });

        }

        //Tables for our DBd
        public DbSet<Product> Products { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<BasketItem> BasketItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

    }
}
