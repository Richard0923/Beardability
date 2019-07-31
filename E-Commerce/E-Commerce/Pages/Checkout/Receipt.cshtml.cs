using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Commerce.Models;
using E_Commerce.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace E_Commerce.Pages.Checkout.Receipt
{
    /// <summary>
    /// Adds functionallity to the Receipt page 
    /// </summary>
    public class ReceiptModel : PageModel
    {
        private readonly IBasket _basket;

        public ReceiptModel(IBasket basket)
        {
            _basket = basket;
        }

        public List<BasketItem> PurchaseItems { get; set; }

        /// <summary>
        /// When the page gets render it grabs a list of all the basket items.
        /// </summary>
        /// <returns></returns>
        public async Task OnGet()
        {
            PurchaseItems = await _basket.GetAllBasketItems();
        }
    }
}