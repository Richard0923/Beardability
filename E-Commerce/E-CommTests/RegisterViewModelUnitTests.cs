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

        [Fact]
        public void CanGetLastName()
        {
            RegisterViewModel registerView = new RegisterViewModel()
            {
                LastName = "Potter"
            };

            Assert.Equal("Potter", registerView.LastName);
        }

        [Fact]
        public void CanSetLastName()
        {
            RegisterViewModel registerView = new RegisterViewModel()
            {
                LastName = "Potter"
            };

            registerView.LastName = "Weasley";

            Assert.Equal("Weasley", registerView.LastName);
        }

        [Fact]
        public void CanGetDOB()
        {
            RegisterViewModel registerView = new RegisterViewModel()
            {
                DOB = new DateTime(07/31/1980)
            };

            Assert.Equal(new DateTime(07/31/1980), registerView.DOB);
        }

        [Fact]
        public void CanSetDOB()
        {
            RegisterViewModel registerView = new RegisterViewModel()
            {
                DOB = new DateTime(07 / 31 / 1980)
            };

            registerView.DOB = new DateTime(07 / 24 / 1991);

            Assert.Equal(new DateTime(07/24/1991), registerView.DOB);
        }

        [Fact]
        public void CanGetPhoneNumber()
        {
            RegisterViewModel registerView = new RegisterViewModel()
            {
                PhoneNumber = "1234567890"
            };

            Assert.Equal("1234567890", registerView.PhoneNumber);
        }

        [Fact]
        public void CanSetPhoneNumber()
        {
            RegisterViewModel registerView = new RegisterViewModel()
            {
                PhoneNumber = "1234567890"
            };
            registerView.PhoneNumber = "9876543210";

            Assert.Equal("9876543210", registerView.PhoneNumber);
        }

        [Fact]
        public void CanGetPassword()
        {
            RegisterViewModel registerView = new RegisterViewModel()
            {
                Password = "Test123$"
            };

            Assert.Equal("Test123$", registerView.Password);
        }

        [Fact]
        public void CanSetPassword()
        {
            RegisterViewModel registerView = new RegisterViewModel()
            {
                Password = "Test123$"
            };

            registerView.Password = "newTest123$";

            Assert.Equal("newTest123$", registerView.Password);
        }

        [Fact]
        public void CanGetPasswordConfirmation()
        {
            RegisterViewModel registerView = new RegisterViewModel()
            {
                PasswordConfirmation = "Test123$"
            };

            Assert.Equal("Test123$", registerView.PasswordConfirmation);
        }

        [Fact]
        public void CanSetPasswordConfirmation()
        {
            RegisterViewModel registerView = new RegisterViewModel()
            {
                PasswordConfirmation = "Test123$"
            };

            registerView.PasswordConfirmation = "newTest123$";

            Assert.Equal("newTest123$", registerView.PasswordConfirmation);
        }
    }
}
