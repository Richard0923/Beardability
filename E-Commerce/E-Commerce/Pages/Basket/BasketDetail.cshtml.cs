using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Commerce.Models;
using E_Commerce.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace E_Commerce.Pages.Basket
{
    /// <summary>
    /// Adds functionallity to the basket detail page
    /// </summary>
    public class BasketDetailModel : PageModel
    {

        private readonly IInventory _context;
        public IBasket _basketList;

        public BasketDetailModel(IInventory context, IBasket basketList)
        {
            _context = context;
            _basketList = basketList;
        }

        public ICollection<BasketItem> BasketItems { get; }

        [BindProperty]
        public List<BasketItem> BasketItem { get; set; }

        /// <summary>
        /// When the page gets render it grabs a list of all the basket items.
        /// </summary>
        /// <returns></returns>
        public async Task OnGet()
        {
            List<BasketItem> basketItems = await _basketList.GetAllBasketItems();
        }

        //public async Task OnPut(BasketItem basketItem)
        //{
            
        //}

    }
}