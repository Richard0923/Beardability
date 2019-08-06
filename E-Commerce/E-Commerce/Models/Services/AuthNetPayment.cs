using AuthorizeNet.Api.Contracts.V1;
using AuthorizeNet.Api.Controllers;
using AuthorizeNet.Api.Controllers.Bases;
using E_Commerce.Models.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Commerce.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Models.Services
{
    public class AuthNetPayment : IPayment
    {
        
        public CheckoutViewModel ShippingAddress { get; }

        public IConfiguration Configuration { get; }

        public AuthNetPayment(IConfiguration configuration)
        {
            Configuration = configuration;

        }

        public string Run(CheckoutViewModel sa)
        {
            ApiOperationBase<ANetApiRequest, ANetApiResponse>.RunEnvironment = AuthorizeNet.Environment.SANDBOX;

            ApiOperationBase<ANetApiRequest, ANetApiResponse>.MerchantAuthentication = new merchantAuthenticationType()
            {
                name = Configuration["AUTHNET_LOGIN_ID"],
                ItemElementName = ItemChoiceType.transactionKey,
                Item = Configuration["AUTH_TRANSACTION_KEY"]
            };

            creditCardType creditCard = new creditCardType
            {
                cardNumber = Configuration["CreditCardNumber"],
                expirationDate = Configuration["ExpirationDate"]
            };

            customerAddressType billingAddress = GetAddress(sa);

            paymentType payment = new paymentType { Item = creditCard };

            transactionRequestType transRequestType = new transactionRequestType
            {
                transactionType = transactionTypeEnum.authCaptureTransaction.ToString(),
                amount = 123.45m,
                payment = payment,
                billTo = billingAddress
            };

            createTransactionRequest request = new createTransactionRequest
            {
                transactionRequest = transRequestType
            };

            var contoller = new createTransactionController(request);
            contoller.Execute();
            var response = contoller.GetApiResponse();

            if (response == null)
            {
                if (response.messages.resultCode == messageTypeEnum.Ok)
                {
                    return "Groomed to Perfection ;{";
                }
            }
            else
            {
                return "Not Groomed :[";
            }

            return "Not Groomed :[";
        }

        public customerAddressType GetAddress(CheckoutViewModel sa)
        {
            customerAddressType address = new customerAddressType()
            {
                firstName = sa.FirstName,
                lastName = sa.LastName,
                address = sa.StreetAddress,
                city = sa.City,
                state = sa.State,
                zip = sa.ZipCode
            };

            return address;
        }
    }
}
