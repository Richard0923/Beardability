using E_Commerce.Models.ViewModels;
using System;
using Xunit;


namespace E_CommTests
{
    public class RegisterViewModelUnitTests
    {
        [Fact]
        public void CanGetEmail()
        {
            RegisterViewModel registerView = new RegisterViewModel()
            {
                Email = "testemail@test.com"
            };

            Assert.Equal("testemail@test.com", registerView.Email);
        }

        [Fact]
        public void CanSetEmail()
        {
            RegisterViewModel registerView = new RegisterViewModel()
            {
                Email = "testemail@test.com"
            };

            registerView.Email = "newtestemail@test.com";

            Assert.Equal("newtestemail@test.com", registerView.Email);
        }

        [Fact]
        public void CanGetFirstName()
        {
            RegisterViewModel registerView = new RegisterViewModel()
            {
                FirstName = "Harry"
            };

            Assert.Equal("Harry", registerView.FirstName);
        }

        [Fact]
        public void CanSetFirstName()
        {
            RegisterViewModel registerView = new RegisterViewModel()
            {
                FirstName = "Harry"
            };

            registerView.FirstName = "James";

            Assert.Equal("James", registerView.FirstName);
        }
    }
}
