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
    public class BasketDetailModel : PageModel
    {

        public IBasket _context;

        public BasketDetailModel(IBasket context)
        {
            _context = context;
        }

        public ICollection<BasketItem> BasketItems { get; }

        public BasketItem BasketItem { get; set; }

        /// <summary>
        /// Retrieves all BasketItems in user's Basket
        /// </summary>
        /// <returns>List of BasketItems</returns>
        public async Task OnGet()
        {
            List<BasketItem> basketItems = await _context.GetAllBasketItems();
        }

        public async Task OnPut(BasketItem basketItem)
        {
            await _context.UpdateBasketItems(basketItem);
        }

        public async Task OnDelete()
        {
            await _context.DeleteBasketItem(BasketItem.ID);
        }

    }
}