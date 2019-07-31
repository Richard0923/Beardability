using Microsoft.AspNetCore.Mvc;
using E_Commerce.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Components
{
    /// <summary>
    /// This is a basket class to be used as a View Component.
    /// </summary>
    public class Basket : ViewComponent
    {
        private IBasket _basket;

        public Basket(IBasket basket)
        {
            _basket = basket;
        }

        /// <summary>
        /// Grabs all the basket items and orders them by ID to send to the View.
        /// </summary>
        /// <param name="number"></param>
        /// <returns>Returns an async task of IViewComponetResult </returns>
        public async Task<IViewComponentResult> InvokeAsync(int number)
        {
            var items = await _basket.GetAllBasketItems();
            var results = items.OrderByDescending(x => x.BasketID)
                                .Take(number);
            return View(results);
        }
    }
}
