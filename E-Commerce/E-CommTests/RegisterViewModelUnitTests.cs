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
    }
}
