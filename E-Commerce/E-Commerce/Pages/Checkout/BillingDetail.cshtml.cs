using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Commerce.Models.Interfaces;
using E_Commerce.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace E_Commerce.Pages.Checkout
{
    public class BillingDetailModel : PageModel
    {
        private IPayment _payment;

        [BindProperty]
        public CheckoutViewModel ShippingAddress { get; set; }

        public BillingDetailModel(IPayment payment)
        {
            _payment = payment;
        }

        public void OnGet()
        {

        }


        public IActionResult OnPost()
        {
            string answer = _payment.Run(ShippingAddress); //need something to check if payment was processed maybe have an if statement for the return string 
            //NEED TO EMPTY BASKET TABLE ON POST AND SAVE THEM TO A ORDERS  TABLE 
            return RedirectToPage("Receipt");
        }

       
    }
}