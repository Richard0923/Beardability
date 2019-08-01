using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Commerce.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace E_Commerce.Pages.Checkout
{
    public class BillingDetailModel : PageModel
    {
        public CheckoutViewModel Input { get; set; }

        public void OnGet()
        {

        }

       
    }
}