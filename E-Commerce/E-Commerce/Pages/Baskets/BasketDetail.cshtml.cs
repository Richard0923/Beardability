using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Commerce.Models;
using E_Commerce.Models.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace E_Commerce.Pages.Baskets
{
    [Authorize]
    public class BasketDetailModel : PageModel
    {

        public IInventory _context;
        public IBasket _basket;

        public BasketDetailModel(IInventory context, IBasket basket)
        {
            _context = context;
            _basket = basket;
        }

        [BindProperty]
        public List<BasketItem> BasketItems { get; set; }
        
        [BindProperty]
        public BasketItem BasketItem { get; set; }

        public Basket UserBasket { get; set; }

        /// <summary>
        /// Retrieves all BasketItems in user's Basket
        /// </summary>
        /// <returns>List of BasketItems</returns>
        public async Task OnGet()
        {
            BasketItems = await _basket.GetAllBasketItems();
            UserBasket = await _basket.FindBasketID(User.Identity.Name);
        }

        /// <summary>
        /// Updates details of given basket item in basket
        /// </summary>
        /// <param name="basketItem"></param>
        /// <returns></returns>
        public async Task<IActionResult> OnPost()
        {
            //grabs the id's for the basketitem to update
            var idBasket = Request.Form["basket"];
            var idProduct = Request.Form["product"];
            int basketid = Convert.ToInt32(idBasket);
            int productid = Convert.ToInt32(idProduct);
            //grabs the new quanity
            var formQuanity = Request.Form["quanity"];
            int quanity = Convert.ToInt32(formQuanity);
            //grabs the basket and assigns it the new quantity 
            BasketItem basketItem = await _basket.GetBasketItemById(basketid, productid);
            basketItem.Quanity = quanity;
            
            await _basket.UpdateBasketItem(basketItem);
            return RedirectToPage();
        }

        /// <summary>
        /// Removes record of given basket item in basket
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> OnPostDelete()
        {
            var idBasket = Request.Form["deletebasket"];
            var idProduct = Request.Form["deleteproduct"];
            int basketid = Convert.ToInt32(idBasket);
            int productid = Convert.ToInt32(idProduct);
            BasketItem basketItem = await _basket.GetBasketItemById(basketid, productid);
            
            if(basketItem != null)
            {
                await _basket.DeleteBasketItem(basketItem);
            }

            return RedirectToPage();
        }

    }
}
