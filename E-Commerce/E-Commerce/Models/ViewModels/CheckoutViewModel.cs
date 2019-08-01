using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Models.ViewModels
{
    public class CheckoutViewModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string StreetAddress { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }

        public CreditCardtype CreditCard { get; set; }
    }

    public enum CreditCardtype
    {
        [Display (Name= "Visa")]
        Visa,//Set equal to number from user secrets

        [Display (Name ="Mastercard")]
        Mastercard//Set equal to number from user secrets
    }
}
