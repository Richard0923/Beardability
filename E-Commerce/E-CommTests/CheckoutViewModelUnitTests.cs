using E_Commerce.Models.ViewModels;
using System;
using Xunit;

namespace E_CommTests
{
    public class CheckoutViewModelUnitTests
    {
        [Fact]
        public void CanGetFirstName()
        {
            CheckoutViewModel checkoutView = new CheckoutViewModel()
            {
                FirstName = "Hermoine"
            };

            Assert.Equal("Hermoine", checkoutView.FirstName);
        }

        [Fact]
        public void CanSetFirstName()
        {
            CheckoutViewModel checkoutView = new CheckoutViewModel()
            {
                FirstName = "Hermoine"
            };

            checkoutView.FirstName = "Minerva";

            Assert.Equal("Minerva", checkoutView.FirstName);
        }

        [Fact]
        public void CanGetLastName()
        {
            CheckoutViewModel checkoutView = new CheckoutViewModel()
            {
                LastName = "Granger"
            };

            Assert.Equal("Granger", checkoutView.LastName);
        }

        [Fact]
        public void CanSetLastName()
        {
            CheckoutViewModel checkoutView = new CheckoutViewModel()
            {
                LastName = "Granger"
            };

            checkoutView.LastName = "Weasley";

            Assert.Equal("Weasley", checkoutView.LastName);
        }

        [Fact]
        public void CanGetStreetAddress()
        {
            CheckoutViewModel checkoutView = new CheckoutViewModel()
            {
                StreetAddress = "12 Grimmauld Place"
            };

            Assert.Equal("12 Grimmauld Place", checkoutView.StreetAddress);
        }

        [Fact]
        public void CanSetStreetAddress()
        {
            CheckoutViewModel checkoutView = new CheckoutViewModel()
            {
                StreetAddress = "12 Grimmauld Place"
            };

            checkoutView.StreetAddress = "3 Godric Hollow";

            Assert.Equal("3 Godric Hollow", checkoutView.StreetAddress);
        }

        [Fact]
        public void CanGetCity()
        {
            CheckoutViewModel checkoutView = new CheckoutViewModel()
            {
                City = "London"
            };

            Assert.Equal("London", checkoutView.City);
        }

        [Fact]
        public void CanSetCity()
        {
            CheckoutViewModel checkoutView = new CheckoutViewModel()
            {
                City = "London"
            };

            checkoutView.City = "West Country";

            Assert.Equal("West Country", checkoutView.City);
        }

        [Fact]
        public void CanGetState()
        {
            CheckoutViewModel checkoutView = new CheckoutViewModel()
            {
                State = "Britain"
            };

            Assert.Equal("Britain", checkoutView.State);
        }

        [Fact]
        public void CanSetState()
        {
            CheckoutViewModel checkoutView = new CheckoutViewModel()
            {
                State = "Britain"
            };

            checkoutView.State = "UK";

            Assert.Equal("UK", checkoutView.State);
        }

        [Fact]
        public void CanGetZipCode()
        {
            CheckoutViewModel checkoutView = new CheckoutViewModel()
            {
                ZipCode = "62442"
            };

            Assert.Equal("62442", checkoutView.ZipCode);
        }

        [Fact]
        public void CanSetZipCode()
        {
            CheckoutViewModel checkoutView = new CheckoutViewModel()
            {
                ZipCode = "62442"
            };

            checkoutView.ZipCode = "62441";

            Assert.Equal("62441", checkoutView.ZipCode);
        }

    }
}
