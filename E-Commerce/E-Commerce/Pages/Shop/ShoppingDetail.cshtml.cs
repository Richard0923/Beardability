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
    /// <summary>
    /// Adds functionallity to the ShoppingDetail page 
    /// </summary>
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

        /// <summary>
        /// When the page gets render it grabs the Product deatils by id .
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task OnGet(int id)
        {
            Beard = await _context.GetItemByIDAsync(id);
        }

        /// <summary>
        /// It creates a new basket item and adds it to the BasketItems DB 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IActionResult> OnPost(int id )
        {
            Beard = await _context.GetItemByIDAsync(id);

            var user = User.Identity.Name;
            
            Basket userBasket = await _basket.FindBasketID(user);
            
            if (ModelState.IsValid)
            {
                BasketItem newBasketItem = new BasketItem
                {
                    ProductID = Beard.ID,
                    Quanity = BasketItem.Quanity,
                    BasketID = userBasket.ID,
                    Name = Beard.Name,
                    Sku = Beard.Sku,
                    Price = Beard.Price,
                    Image = Beard.Image
                };
               await _basket.CreateBasketItem(newBasketItem);
               
            }
            return RedirectToPage("Shopping");
        }
    }
}