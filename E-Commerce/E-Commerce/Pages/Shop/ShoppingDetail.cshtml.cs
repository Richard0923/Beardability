using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Commerce.Models;
using E_Commerce.Models.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace E_Commerce.Pages.Shop
{
    public class ShoppingDetailModel : PageModel
    {

        private readonly IInventory _context;
        private readonly IBasket _basket;

        public ShoppingDetailModel(IInventory context, IBasket basketitems)
        {
            _context = context;
            _basket = basketitems;
        }
        [BindProperty]
        public Product Beard { get; set; }
        [BindProperty]
        public BasketItem BasketItem { get; set; }
        public async Task OnGet(int id)
        {
            Beard = await _context.GetItemByIDAsync(id);
        }

        public async Task OnPost()
        {
            var user = User.Identity.Name;
            
            var userBasket = _basket.FindBasketID(user);
            
            if (ModelState.IsValid)
            {
                var basketItem = new BasketItem
                {
                    ProductID = Beard.ID,
                    Quanity = BasketItem.Quanity,
                    BasketID = userBasket.ID
                };
               await _basket.CreateBasketItem(basketItem);
            }
            RedirectToPage("Shopping");
        }
    }
}