using E_Commerce.Models.ViewModels;
using System;
using Xunit;

namespace E_CommTests
{
    public class BasketViewModelUnitTests
    {
        [Fact]
        public void CanGetID()
        {
            BasketDetailViewModel basketDetailView = new BasketDetailViewModel()
            {
                ID = 1
            };

            Assert.Equal(1, basketDetailView.ID);
        }

        [Fact]
        public void CanSetID()
        {
            BasketDetailViewModel basketDetailView = new BasketDetailViewModel()
            {
                ID = 1
            };

            basketDetailView.ID = 4;

            Assert.Equal(4, basketDetailView.ID);
        }

        [Fact]
        public void CanGetBasketID()
        {
            BasketDetailViewModel basketDetailView = new BasketDetailViewModel()
            {
                BasketID = 1
            };

            Assert.Equal(1, basketDetailView.BasketID);
        }

        [Fact]
        public void CanSetBasketID()
        {
            BasketDetailViewModel basketDetailView = new BasketDetailViewModel()
            {
                BasketID = 1
            };

            basketDetailView.BasketID = 42;

            Assert.Equal(42, basketDetailView.BasketID);
        }

        [Fact]
        public void CanGetProductID()
        {
            BasketDetailViewModel basketDetailView = new BasketDetailViewModel()
            {
                ProductID = 1
            };

            Assert.Equal(1, basketDetailView.ProductID);
        }

        [Fact]
        public void CanSetProductID()
        {
            BasketDetailViewModel basketDetailView = new BasketDetailViewModel()
            {
                ProductID = 1
            };

            basketDetailView.ProductID = 42;

            Assert.Equal(42, basketDetailView.ProductID);
        }

        [Fact]
        public void CanGetName()
        {
            BasketDetailViewModel basketDetailView = new BasketDetailViewModel()
            {
                Name = "Dumbledore Beard"
            };

            Assert.Equal("Dumbledore Beard", basketDetailView.Name);
        }

        [Fact]
        public void CanGetSku()
        {
            BasketDetailViewModel basketDetailView = new BasketDetailViewModel()
            {
                Sku = "MAGIC001"
            };

            Assert.Equal("MAGIC001", basketDetailView.Sku);
        }

        [Fact]
        public void CanGetPrice()
        {
            BasketDetailViewModel basketDetailView = new BasketDetailViewModel()
            {
                Price = 20.00m
            };

            Assert.Equal(20.00m, basketDetailView.Price);
        }

        [Fact]
        public void CanGetImage()
        {
            BasketDetailViewModel basketDetailView = new BasketDetailViewModel()
            {
                Image = "Magic.png"
            };

            Assert.Equal("Magic.png", basketDetailView.Image);
        }

        [Fact]
        public void CanGetQuanity()
        {
            BasketDetailViewModel basketDetailView = new BasketDetailViewModel()
            {
                Quanity = 24
            };

            Assert.Equal(24, basketDetailView.Quanity);
        }

        [Fact]
        public void CanSetQuanity()
        {
            BasketDetailViewModel basketDetailView = new BasketDetailViewModel()
            {
                Quanity = 24
            };

            basketDetailView.Quanity = 42;

            Assert.Equal(42, basketDetailView.Quanity);
        }

    }
}
