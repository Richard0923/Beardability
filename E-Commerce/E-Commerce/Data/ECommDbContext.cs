using E_Commerce.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Data
{
    public class ECommDbContext : DbContext
    {
        public ECommDbContext(DbContextOptions<ECommDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(

                new Product
                {
                    ID = 1,

                    Name = "Full Beard",

                    Sku = "001Bear",

                    Price = 10.00M,

                    Description = "Stick on full beard. Glue not included",

                    Image = "http://placebeard.it/g/100/125"
                },


                new Product
                {
                    ID = 3,

                    Name = "Soul Patch",

                    Sku = "003Soul",

                    Price = 2.00M,

                    Description = "Stick on soul patch. Glue not included",

                    Image = "http://placebeard.it/g/100/125"
                },

                new Product
                {
                    ID = 4,

                    Name = "Old School Hook Beard",

                    Sku = "004Hook",

                    Price = 10.00M,

                    Description = "Full beard with hooks to hang off of ears.",

                    Image = "http://placebeard.it/g/100/125"
                },

                new Product
                {
                    ID = 5,

                    Name = "Long Fu-Man-Chu Mustache",

                    Sku = "005Fu",

                    Price = 8.00M,

                    Description = "Long Fu-Man-Chu stick on mustache. Glue not included.",

                    Image = "http://placebeard.it/g/100/125"
                },

                new Product
                {
                    ID = 6,

                    Name = "Short Fu-Man-Chu Mustache",

                    Sku = "006FuS",

                    Price = 5.00M,

                    Description = "Short Fu-Man-Chu stick on mustache. Glue not included",

                    Image = "http://placebeard.it/g/100/125"
                },

                new Product
                {
                    ID = 7,

                    Name = "5'oclock Shadow Spray",

                    Sku = "007Shadow",

                    Price = 15.00M,

                    Description = "Spray that allows for realistic looking 5'oclock shadow. Alcohol soluble.",

                    Image = "http://placebeard.it/g/100/125"
                },

                new Product
                {
                    ID = 8,

                    Name = "Facial Glue",

                    Sku = "008Glue",

                    Price = 5.00M,

                    Description = "Glue for all stick on facial hair. Alcohol soluble.",

                    Image = "http://placebeard.it/g/100/125"
                },

                new Product
                {
                    ID = 9,

                    Name = "Facial Hair Comb",

                    Sku = "009Comb",

                    Price = 5.00M,

                    Description = "Specially designed comb for facial hair.",

                    Image = "http://placebeard.it/g/100/125"
                },

                new Product
                {
                    ID = 10,

                    Name = "Mutton Chops",

                    Sku = "010Chops",

                    Price = 7.00M,

                    Description = "Stick on mutton chops. Glue not included",

                    Image = "http://placebeard.it/g/100/125"
                });


            modelBuilder.Entity<Basket>().HasData(

                new Basket
                {
                    ID = 1,

                    Email = "admin@admin.com"
                });

            modelBuilder.Entity<BasketItem>().HasData(

                new BasketItem
                {
                    ID = 1,

                    BasketID = 1,
                    
                    Name = "Seed1",

                    Sku = "Seedy",

                    Image = "http://placebeard.it/g/100/125",

                    Price = 10.00M,

                    ProductID = 1,

                    Quanity = 4,
                },

                new BasketItem
                {
                    ID = 2,

                    BasketID = 1,

                    Name = "Seed2",

                    Sku = "Seedy",

                    Image = "http://placebeard.it/g/100/125",

                    Price = 20.00M,


                    ProductID = 4,

                    Quanity = 2,
                },

                new BasketItem
                {
                    ID = 3,

                    BasketID = 1,

                    Name = "Seed3",

                    Sku = "Seedy",

                    Image = "http://placebeard.it/g/100/125",

                    Price = 40.00M,

                    ProductID = 5,

                    Quanity = 3,
                },

                new BasketItem
                {
                    ID = 4,

                    BasketID = 1,

                    Name = "Seed4",

                    Sku = "Seedy",

                    Image = "http://placebeard.it/g/100/125",

                    Price = 10.00M,

                    ProductID = 7,

                    Quanity = 8,
                });
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<BasketItem> BasketItems { get; set; }

    }
}
