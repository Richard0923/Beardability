using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Commerce.Models;
using E_Commerce.Models.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace E_Commerce.Pages.Basket
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

        /// <summary>
        /// Retrieves all BasketItems in user's Basket
        /// </summary>
        /// <returns>List of BasketItems</returns>
        public async Task OnGet()
        {
            BasketItems = await _basket.GetAllBasketItems();
        }

        /// <summary>
        /// Updates details of given basket item in basket
        /// </summary>
        /// <param name="basketItem"></param>
        /// <returns></returns>
        public async Task OnPost()
        {
            var formId = Request.Form["id"];
            int id = Convert.ToInt32(formId);
            var formQuanity = Request.Form["quanity"];
            int quanity = Convert.ToInt32(formQuanity);

            BasketItem basketItem = await _basket.GetBasketById(id);
            basketItem.Quanity = quanity;

            await _basket.UpdateBasketItem(basketItem);
        }

        /// <summary>
        /// Removes record of given basket item in basket
        /// </summary>
        /// <returns></returns>
        public async Task OnPostDelete()
        {
            var formId = Request.Form["id"];
            int id = Convert.ToInt32(formId);

            await _basket.DeleteBasketItem(id);
        }

    }
}
